using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Security.Principal;
using System.ServiceProcess;
using System.Diagnostics;

namespace Bizagi.ProjectPublish
{

    public partial class NewProjectPublish : Form
    {
        public NewProjectPublish()
        {
            InitializeComponent();
            CarregaListaConfiguração();
            txbExplicacaoTipo.Text = "Explicação : " + Environment.NewLine + "Limpeza de cache utilizando o webservice padrão de projeto bizagi.";
        }

        private void CarregaListaConfiguração()
        {
            try
            {
                DataSet ds = new DataSet();
                if (File.Exists("configuracao.xml"))
                {
                    ds.ReadXml("configuracao.xml");
                    if (ds.Tables.Count > 0)
                    {
                        dataGridViewConfiguracao.AutoGenerateColumns = false;
                        dataGridViewConfiguracao.Columns[0].HeaderText = "Servidor";
                        dataGridViewConfiguracao.Columns[0].DataPropertyName = "Servidor";
                        dataGridViewConfiguracao.Columns[1].HeaderText = "Projeto";
                        dataGridViewConfiguracao.Columns[1].DataPropertyName = "Projeto";
                        dataGridViewConfiguracao.Columns[2].HeaderText = "Diretório Padrão";
                        dataGridViewConfiguracao.Columns[2].DataPropertyName = "DirPadrao";
                        dataGridViewConfiguracao.DataSource = ds.Tables[0];

                        var dict = new Dictionary<string, string>();
                        dict.Add("0", " < Selecione um Servidor - Projeto > ");
                        foreach (DataRow row in ds.Tables[0].Rows)
                        {
                            dict.Add(row["GUID"].ToString(), "Servidor : " + row["Servidor"] + " - Projeto : " + row["Projeto"]);
                        }
                        cbListaServidorProjeto.DataSource = new BindingSource(dict, null);
                        cbListaServidorProjeto.DisplayMember = "Value";
                        cbListaServidorProjeto.ValueMember = "Key";
                    }
                }
            }
            catch (Exception ex)
            {
                // tratar erro
                MessageBox.Show(ex.ToString());
            }
        }
        private void LimparTextbox()
        {
            txbServidor.Clear();
            txbProjeto.Clear();
            txbDirPadrao.Clear();
        }
        private void LimparBizagiCache()
        {

            BizagiCacheWS.Cache _cache = new BizagiCacheWS.Cache();
            string _servidor = String.Empty;
            string _projeto = String.Empty;

            DataSet ds = new DataSet();
            ds.ReadXml("configuracao.xml");

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                if (item["GUID"].ToString() == cbListaServidorProjeto.SelectedValue.ToString())
                {
                    _servidor = item["Servidor"].ToString();
                    _projeto = item["Projeto"].ToString();
                }
            }


            if (_servidor.Trim() == String.Empty)
            {
                txbOutputlog.AppendText("\r\n");
                txbOutputlog.AppendText(" - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - >>> ERRO : O nome do SERVIDOR PRECISA SER PREENCHIDO. ");
                txbOutputlog.AppendText("\r\n");
            }
            else if (_projeto.Trim() == String.Empty)
            {
                txbOutputlog.AppendText("\r\n");
                txbOutputlog.AppendText(" - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - >>> ERRO : O nome do PROJETO PRECISA SER PREENCHIDO. ");
                txbOutputlog.AppendText("\r\n");
            }
            else
            {
                txbOutputlog.AppendText(" Servidor : " + _servidor);
                txbOutputlog.AppendText("\r\n");
                txbOutputlog.AppendText(" Projeto : " + _projeto);
                txbOutputlog.AppendText("\r\n");
                //
                string _urlCustom = "http://" + _servidor + "/" + _projeto + "/webservices/cache.asmx";

            }
        }
        private string RecuperaTextoRadioButtonSelecionado()
        {
            if (rbLimpezaCache.Checked == true)
            {
                return rbLimpezaCache.Text;
            }
            else if (rbLimpezaTotal.Checked == true)
            {
                return rbLimpezaTotal.Text;
            }
            else if (rbPublicacaoTotal.Checked == true)
            {
                return rbPublicacaoTotal.Text;
            }
            return String.Empty;
        }
        private static bool IsAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        private void ExecutaLimpezaCacheWS(string pServidor, string pProjeto, string pUrlCustom)
        {
            if (cbListaServidorProjeto.SelectedValue.ToString() != "0")
            {
                BizagiCacheWS.Cache _cache = new BizagiCacheWS.Cache();
                _cache.Url = pUrlCustom;
                try
                {

                    txbOutputlog.AppendText("\r\n");
                    txbOutputlog.AppendText(" Iniciando execução do webservice ...");
                    txbOutputlog.AppendText("\r\n");
                    txbOutputlog.AppendText("\r\n");
                    //
                    try
                    {
                        txbOutputlog.AppendText(" Executando 'CleanRenderCache'");
                        _cache.CleanRenderCache();
                        txbOutputlog.AppendText("\t\t ---> Status : Executado com SUCESSO");
                        txbOutputlog.AppendText("\r\n");
                        //
                        try
                        {
                            txbOutputlog.AppendText(" Executando 'CleanTracing'");
                            _cache.CleanTracing();
                            txbOutputlog.AppendText("\t\t\t ---> Status : Executado com SUCESSO");
                            txbOutputlog.AppendText("\r\n");
                            //
                            try
                            {
                                txbOutputlog.AppendText(" Executando 'CleanUpCache'");
                                _cache.CleanUpCache("*", "*");
                                txbOutputlog.AppendText("\t\t\t ---> Status : Executado com SUCESSO");
                                txbOutputlog.AppendText("\r\n");
                                //
                                try
                                {
                                    txbOutputlog.AppendText(" Executando 'CleanUpCacheEntries'");
                                    BizagiCacheWS.CacheEntry[] _ce = new BizagiCacheWS.CacheEntry[0];
                                    _cache.CleanUpCacheEntries(_ce);
                                    txbOutputlog.AppendText("\t\t ---> Status : Executado com SUCESSO");
                                    txbOutputlog.AppendText("\r\n");
                                    //
                                    try
                                    {
                                        txbOutputlog.AppendText(" Executando 'FreeLocalizationResources'");
                                        _cache.FreeLocalizationResources();
                                        txbOutputlog.AppendText("\t ---> Status : Executado com SUCESSO");
                                        txbOutputlog.AppendText("\r\n");
                                        //
                                        try
                                        {
                                            txbOutputlog.AppendText(" Executando 'UpdatePortal'");
                                            _cache.UpdatePortal();
                                            txbOutputlog.AppendText("\t\t\t ---> Status : Executado com SUCESSO");
                                            txbOutputlog.AppendText("\r\n");
                                            //
                                            try
                                            {
                                                txbOutputlog.AppendText(" Executando 'cleanParameters'");
                                                _cache.cleanParameters();
                                                txbOutputlog.AppendText("\t\t ---> Status : Executado com SUCESSO");
                                                txbOutputlog.AppendText("\r\n");
                                                //
                                                try
                                                {
                                                    txbOutputlog.AppendText(" Executando 'cleanUpRuleCache'");
                                                    _cache.cleanUpRuleCache();
                                                    txbOutputlog.AppendText("\t\t ---> Status : Executado com SUCESSO");
                                                    txbOutputlog.AppendText("\r\n");
                                                    //
                                                }
                                                catch (Exception exCleanUpRuleCache)
                                                {
                                                    txbOutputlog.AppendText("\r\n");
                                                    txbOutputlog.AppendText(" ---> Status : ERRO - " + exCleanUpRuleCache.Message);
                                                    txbOutputlog.AppendText("\r\n");
                                                }
                                            }
                                            catch (Exception exCleanParameters)
                                            {
                                                txbOutputlog.AppendText("\r\n");
                                                txbOutputlog.AppendText(" ---> Status : ERRO - " + exCleanParameters.Message);
                                                txbOutputlog.AppendText("\r\n");
                                            }
                                        }
                                        catch (Exception exUpdatePortal)
                                        {
                                            txbOutputlog.AppendText("\r\n");
                                            txbOutputlog.AppendText(" ---> Status : ERRO - " + exUpdatePortal.Message);
                                            txbOutputlog.AppendText("\r\n");
                                        }
                                    }
                                    catch (Exception exFreeLocalizationResources)
                                    {
                                        txbOutputlog.AppendText("\r\n");
                                        txbOutputlog.AppendText(" ---> Status : ERRO - " + exFreeLocalizationResources.Message);
                                        txbOutputlog.AppendText("\r\n");
                                    }
                                }
                                catch (Exception exCleanUpCacheEntries)
                                {
                                    txbOutputlog.AppendText("\r\n");
                                    txbOutputlog.AppendText(" ---> Status : ERRO - " + exCleanUpCacheEntries.Message);
                                    txbOutputlog.AppendText("\r\n");
                                }
                            }
                            catch (Exception exCleanUpCache)
                            {
                                txbOutputlog.AppendText("\r\n");
                                txbOutputlog.AppendText(" ---> Status : ERRO - " + exCleanUpCache.Message);
                                txbOutputlog.AppendText("\r\n");
                            }
                        }
                        catch (Exception exCleanTracing)
                        {
                            txbOutputlog.AppendText("\r\n");
                            txbOutputlog.AppendText(" ---> Status : ERRO - " + exCleanTracing.Message);
                            txbOutputlog.AppendText("\r\n");
                        }
                    }
                    catch (Exception exRenderCache)
                    {
                        txbOutputlog.AppendText("\r\n");
                        txbOutputlog.AppendText(" ---> Status : ERRO - " + exRenderCache.Message);
                        txbOutputlog.AppendText("\r\n");
                    }

                }
                catch (Exception ex)
                {
                    txbOutputlog.AppendText("\r\n");
                    txbOutputlog.AppendText(" ---> Status : ERRO - " + ex.Message);
                    txbOutputlog.AppendText("\r\n");
                }
            }
            else
            {
                txbOutputlog.AppendText("\r\n");
                txbOutputlog.AppendText(" ---> ERRO : Selecione um SERVIDOR - PROJETO para executar esta ação. ");
                txbOutputlog.AppendText("\r\n");
            }
        }
        private bool ExecutaLimpezaPastas(string pServidor, string pProjeto, string pDirPadrao)
        {
            txbOutputlog.AppendText("\r\n");
            if (Directory.Exists(pDirPadrao))
            {

                if (IsAdministrator() == false)
                {
                    // Restart program and run as admin
                    var exeName = Process.GetCurrentProcess().MainModule.FileName;
                    ProcessStartInfo startInfo = new ProcessStartInfo(exeName);

                    startInfo.Verb = "runas";
                    startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    startInfo.FileName = @"cmd.exe";
                    startInfo.Arguments = "/C iisreset /start";
                    Process.Start(startInfo);

                }



        // PARAR SERVICO DO PROJETO
        //ServiceController[] scServices;
        //scServices = ServiceController.GetServices();

        //foreach (ServiceController scTemp in scServices)
        //{
        //    if (scTemp.ServiceName == "BizAgi" + pProjeto + "SchedulerService")
        //    {
        //        try
        //        {
        //            if ((scTemp.Status.Equals(ServiceControllerStatus.Stopped)) || (scTemp.Status.Equals(ServiceControllerStatus.StopPending)))
        //            {
        //                txbOutputlog.AppendText(" INICIANDO o serviço 'BizAgi" + pProjeto + "SchedulerService'");
        //                scTemp.Start();
        //                txbOutputlog.AppendText("\t\t ---> Status : Serviço INICIADO com SUCESSO");
        //            }
        //            else
        //            {
        //                txbOutputlog.AppendText(" PARANDO o serviço 'BizAgi" + pProjeto + "SchedulerService'");
        //                scTemp.Stop();
        //                txbOutputlog.AppendText("\t\t ---> Status : Serviço PARADO com SUCESSO");
        //            }
        //            return true;
        //        }
        //        catch (Exception exServiceSartStop)
        //        {
        //            txbOutputlog.AppendText("\r\n");
        //            txbOutputlog.AppendText(" ---> Status : ERRO - " + exServiceSartStop.InnerException + " - " + exServiceSartStop.Message);
        //            txbOutputlog.AppendText("\r\n");
        //            return false;
        //        }
        //    }
        //}

    }
            else
            {
                txbOutputlog.AppendText("\r\n");
                txbOutputlog.AppendText(" ---> Status : ERRO - O diretório padrão do projeto não existe. (" + pDirPadrao + ")");
                txbOutputlog.AppendText("\r\n");
                return false;
            }
            return false;
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            LimparTextbox();
        }
        private void btnSalvarAmbiente_Click(object sender, EventArgs e)
        {
            if (txbServidor.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Informe um nome de Servidor.\nEx.: 192.168.0.1 ou localhost", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (txbProjeto.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("Informe um nome de Projeto.\nEx.: DefaultProject", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    if (txbDirPadrao.Text.Trim() == String.Empty)
                    {
                        MessageBox.Show(@"Informe o Diretório Padrão do Projeto.\nEx.: C:\Bizagi\Enterprise\Projects\NomeProjeto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        using (DataSet dsResult = new DataSet())
                        {
                            if (!File.Exists("configuracao.xml"))
                            {
                                XDocument doc = new XDocument(new XElement("Configuracao"));
                                doc.Save("configuracao.xml");
                            }
                            dsResult.ReadXml("configuracao.xml");
                            if (dsResult.Tables.Count == 0)
                            {
                                XmlTextWriter writer = new XmlTextWriter("configuracao.xml", System.Text.Encoding.UTF8);
                                //
                                writer.WriteStartDocument(true);
                                writer.Formatting = Formatting.Indented;
                                writer.Indentation = 2;
                                writer.WriteStartElement("configuracao");
                                writer.WriteStartElement("Ambiente");
                                writer.WriteStartElement("Servidor");
                                writer.WriteString(txbServidor.Text);
                                writer.WriteEndElement();
                                writer.WriteStartElement("Projeto");
                                writer.WriteString(txbProjeto.Text);
                                writer.WriteEndElement();
                                writer.WriteStartElement("DirPadrao");
                                writer.WriteString(txbDirPadrao.Text);
                                writer.WriteEndElement();
                                writer.WriteStartElement("GUID");
                                writer.WriteString(Guid.NewGuid().ToString());
                                writer.WriteEndElement();
                                writer.WriteEndElement();
                                writer.WriteEndElement();
                                writer.WriteEndDocument();
                                writer.Close();
                                dsResult.ReadXml("configuracao.xml");
                            }
                            else
                            {
                                bool vEncontrou = false;
                                foreach (DataRow item in dsResult.Tables[0].Rows)
                                {
                                    if (item["Servidor"].ToString().Trim() == txbServidor.Text.Trim() &&
                                        item["Projeto"].ToString().Trim() == txbProjeto.Text.Trim())
                                    {
                                        MessageBox.Show("Não é possível incluir uma configuração de ambiente já existente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        vEncontrou = true;
                                    }
                                }
                                if (!vEncontrou)
                                {
                                    dsResult.Tables[0].Rows.Add(dsResult.Tables[0].NewRow());
                                    dsResult.Tables[0].Rows[dsResult.Tables[0].Rows.Count - 1]["Servidor"] = txbServidor.Text;
                                    dsResult.Tables[0].Rows[dsResult.Tables[0].Rows.Count - 1]["Projeto"] = txbProjeto.Text;
                                    dsResult.Tables[0].Rows[dsResult.Tables[0].Rows.Count - 1]["DirPadrao"] = txbDirPadrao.Text;
                                    dsResult.Tables[0].Rows[dsResult.Tables[0].Rows.Count - 1]["GUID"] = Guid.NewGuid().ToString();
                                    dsResult.AcceptChanges();
                                    //-- Write final data to XML file using write method
                                    dsResult.WriteXml("configuracao.xml", XmlWriteMode.IgnoreSchema);
                                }
                            }
                            dataGridViewConfiguracao.AutoGenerateColumns = false;
                            dataGridViewConfiguracao.Columns[0].HeaderText = "Servidor";
                            dataGridViewConfiguracao.Columns[0].DataPropertyName = "Servidor";
                            dataGridViewConfiguracao.Columns[1].HeaderText = "Projeto";
                            dataGridViewConfiguracao.Columns[1].DataPropertyName = "Projeto";
                            dataGridViewConfiguracao.Columns[2].HeaderText = "Diretório Padrão";
                            dataGridViewConfiguracao.Columns[2].DataPropertyName = "DirPadrao";
                            dataGridViewConfiguracao.DataSource = dsResult.Tables[0];

                            LimparTextbox();
                        }
                    }
                }
            }
            CarregaListaConfiguração();
        }
        private void dataGridViewConfiguracao_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.dataGridViewConfiguracao.Rows[e.RowIndex].Selected = true;
                this.dataGridViewConfiguracao.CurrentCell = this.dataGridViewConfiguracao.Rows[e.RowIndex].Cells[1];
                this.contextMenuStripDataGrid.Show(this.dataGridViewConfiguracao, e.Location);
                contextMenuStripDataGrid.Show(Cursor.Position);
            }
        }
        private void btnExecutar_Click(object sender, EventArgs e)
        {

            txbOutputlog.Clear();
            txbOutputlog.AppendText(" ============================================================================================== ");
            txbOutputlog.AppendText("\r\n");
            txbOutputlog.AppendText(" Data de Execução : " + DateTime.Now);
            txbOutputlog.AppendText("\r\n");
            txbOutputlog.AppendText(" ============================================================================================== ");
            txbOutputlog.AppendText("\r\n");
            //
            string _servidor = String.Empty;
            string _projeto = String.Empty;
            string _dirPadrao = String.Empty;

            DataSet ds = new DataSet();
            ds.ReadXml("configuracao.xml");
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                if (item["GUID"].ToString() == cbListaServidorProjeto.SelectedValue.ToString())
                {
                    _servidor = item["Servidor"].ToString();
                    _projeto = item["Projeto"].ToString();
                    _dirPadrao = item["DirPadrao"].ToString();
                }
            }
            txbOutputlog.AppendText(" Servidor : " + _servidor);
            txbOutputlog.AppendText("\r\n");
            txbOutputlog.AppendText(" Projeto : " + _projeto);
            txbOutputlog.AppendText("\r\n");
            txbOutputlog.AppendText(" Diretório padrão : " + _dirPadrao);
            txbOutputlog.AppendText("\r\n");

            string _urlCustom = "http://" + _servidor + "/" + _projeto + "/webservices/cache.asmx";

            txbOutputlog.AppendText(" Link WebService : " + _urlCustom);
            txbOutputlog.AppendText("\r\n");
            txbOutputlog.AppendText(" ============================================================================================== ");
            txbOutputlog.AppendText("\r\n");
            //
            if (rbLimpezaCache.Checked == true)
            {
                txbOutputlog.AppendText("\r\n");
                txbOutputlog.AppendText(" Tipo : " + RecuperaTextoRadioButtonSelecionado());
                txbOutputlog.AppendText("\r\n");
                ExecutaLimpezaCacheWS(_servidor, _projeto, _urlCustom);
            }
            else if (rbLimpezaTotal.Checked == true)
            {
                txbOutputlog.AppendText("\r\n");
                txbOutputlog.AppendText(" Tipo : " + RecuperaTextoRadioButtonSelecionado());
                txbOutputlog.AppendText("\r\n");
                var vReturn = ExecutaLimpezaPastas(_servidor, _projeto, _dirPadrao);
                if (vReturn)
                {
                    txbOutputlog.AppendText("\r\n");
                    txbOutputlog.AppendText("\r\n");
                    txbOutputlog.AppendText(" ============================================================================================== ");
                    ExecutaLimpezaCacheWS(_servidor, _projeto, _urlCustom);
                }
            }
            else if (rbPublicacaoTotal.Checked == true)
            {
                // Implementar se possivel
            }
            //Thread.Sleep(1000);
            txbOutputlog.AppendText("\r\n");
            txbOutputlog.AppendText("Execução finalizada ...");
        }

        private void rbTipoPublicacao_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton vRb = (RadioButton)sender;
            switch (vRb.Text)
            {
                case "Limpeza de Cache":
                    {
                        txbExplicacaoTipo.Text = "Explicação : " + Environment.NewLine + "Limpeza de cache utilizando o webservice padrão de projeto bizagi.";
                        break;
                    }
                case "Limpeza de Cache e Pastas":
                    {
                        txbExplicacaoTipo.Text = "Explicação : " + Environment.NewLine + "Limpeza de cache utilizando o webservice padrão de projeto bizagi e exclusão de pastas temporárias.";
                        break;
                    }
            }
        }
        private void txbProjeto_Leave(object sender, EventArgs e)
        {
            txbDirPadrao.Text = @"C:\Bizagi\Enterprise\Projects\" + txbProjeto.Text;
        }
        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dResult = MessageBox.Show("Deseja excluir o Ambiente?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dResult == DialogResult.Yes)
            {
                if (!this.dataGridViewConfiguracao.Rows[this.dataGridViewConfiguracao.CurrentCell.RowIndex].IsNewRow)
                {
                    this.dataGridViewConfiguracao.Rows.RemoveAt(this.dataGridViewConfiguracao.CurrentCell.RowIndex);
                    string path = "configuracao.xml";
                    DataTable ds = (DataTable)dataGridViewConfiguracao.DataSource;
                    ds.WriteXml(path);
                }
            }
        }
        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dResult = MessageBox.Show("Deseja editar o Ambiente?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dResult == DialogResult.Yes)
            {
                if (!this.dataGridViewConfiguracao.Rows[this.dataGridViewConfiguracao.CurrentCell.RowIndex].IsNewRow)
                {
                    LimparTextbox();
                    txbServidor.Text = this.dataGridViewConfiguracao.Rows[this.dataGridViewConfiguracao.CurrentCell.RowIndex].Cells["Servidor"].Value.ToString();
                    txbProjeto.Text = this.dataGridViewConfiguracao.Rows[this.dataGridViewConfiguracao.CurrentCell.RowIndex].Cells["Projeto"].Value.ToString();
                    txbDirPadrao.Text = this.dataGridViewConfiguracao.Rows[this.dataGridViewConfiguracao.CurrentCell.RowIndex].Cells["DirPadrao"].Value.ToString();
                }
            }
        }
        private void btnFecharApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}