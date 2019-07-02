using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Bizagi.ProjectPublish
{
    public partial class ProjectPublish : Form
    {
        public ProjectPublish()
        {
            InitializeComponent();
        }

        private void RecuperaCache()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ParametrosApp));
            StreamReader reader = new StreamReader("parametros.xml");
            reader.ReadToEnd();
            ParametrosApp param = (ParametrosApp)serializer.Deserialize(reader);
            reader.Close();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            BizagiCacheWS.Cache _cache = new BizagiCacheWS.Cache();
            string _servidor = txbServidor.Text;
            string _projeto = txbProjeto.Text;

            ParametrosApp _parametros = new ParametrosApp();
            _parametros.Servidor = _servidor;
            _parametros.Projeto = _projeto;

            XmlSerializer serializer = new XmlSerializer(typeof(ParametrosApp));
            FileStream xmlParametro = File.Create("parametros.xml");
            serializer.Serialize(xmlParametro, _parametros);
            xmlParametro.Close();

            txbOutputlog.Clear();
            txbOutputlog.AppendText(" ====================================================================== ");
            txbOutputlog.AppendText("\r\n");
            txbOutputlog.AppendText(" Data de Execução : " + DateTime.Now);
            txbOutputlog.AppendText("\r\n");
            txbOutputlog.AppendText(" ====================================================================== ");
            txbOutputlog.AppendText("\r\n");

            if (_servidor.Trim() == String.Empty)
            {
                txbOutputlog.AppendText("\r\n");
                txbOutputlog.AppendText(" >>> ERRO : O nome do SERVIDOR PRECISA SER PREENCHIDO. ");
                txbOutputlog.AppendText("\r\n");
            }
            else if (_projeto.Trim() == String.Empty)
            {
                txbOutputlog.AppendText("\r\n");
                txbOutputlog.AppendText(" >>> ERRO : O nome do PROJETO PRECISA SER PREENCHIDO. ");
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

                try
                {
                    _cache.Url = _urlCustom;

                    txbOutputlog.AppendText(" Link WebService : " + _cache.Url);
                    txbOutputlog.AppendText("\r\n");
                    txbOutputlog.AppendText(" ====================================================================== ");
                    txbOutputlog.AppendText("\r\n");
                    txbOutputlog.AppendText("\r\n");
                    txbOutputlog.AppendText(" Iniciando ...");
                    txbOutputlog.AppendText("\r\n");
                    txbOutputlog.AppendText("\r\n");
                    //
                    try
                    {
                        txbOutputlog.AppendText(" Executando 'CleanRenderCache' ... ");
                        _cache.CleanRenderCache();
                        txbOutputlog.AppendText(" >>> Status : Executado com SUCESSO");
                        txbOutputlog.AppendText("\r\n");
                        //
                        try
                        {
                            txbOutputlog.AppendText(" Executando 'CleanTracing' ... ");
                            _cache.CleanTracing();
                            txbOutputlog.AppendText(" >>> Status : Executado com SUCESSO");
                            txbOutputlog.AppendText("\r\n");
                            //
                            try
                            {
                                txbOutputlog.AppendText(" Executando 'CleanUpCache' ... ");
                                _cache.CleanUpCache("*", "*");
                                txbOutputlog.AppendText(" >>> Status : Executado com SUCESSO");
                                txbOutputlog.AppendText("\r\n");
                                //
                                try
                                {
                                    txbOutputlog.AppendText(" Executando 'CleanUpCacheEntries' ... ");
                                    BizagiCacheWS.CacheEntry[] _ce = new BizagiCacheWS.CacheEntry[0];
                                    _cache.CleanUpCacheEntries(_ce);
                                    txbOutputlog.AppendText(" >>> Status : Executado com SUCESSO");
                                    txbOutputlog.AppendText("\r\n");
                                    //
                                    try
                                    {
                                        txbOutputlog.AppendText(" Executando 'FreeLocalizationResources' ... ");
                                        _cache.FreeLocalizationResources();
                                        txbOutputlog.AppendText(" >>> Status : Executado com SUCESSO");
                                        txbOutputlog.AppendText("\r\n");
                                        //
                                        try
                                        {
                                            txbOutputlog.AppendText(" Executando 'UpdatePortal' ... ");
                                            _cache.UpdatePortal();
                                            txbOutputlog.AppendText(" >>> Status : Executado com SUCESSO");
                                            txbOutputlog.AppendText("\r\n");
                                            //
                                            try
                                            {
                                                txbOutputlog.AppendText(" Executando 'cleanParameters' ... ");
                                                _cache.cleanParameters();
                                                txbOutputlog.AppendText(" >>> Status : Executado com SUCESSO");
                                                txbOutputlog.AppendText("\r\n");
                                                //
                                                try
                                                {
                                                    txbOutputlog.AppendText(" Executando 'cleanUpRuleCache' ... ");
                                                    _cache.cleanUpRuleCache();
                                                    txbOutputlog.AppendText(" >>> Status : Executado com SUCESSO");
                                                    txbOutputlog.AppendText("\r\n");
                                                    //
                                                }
                                                catch (Exception exCleanUpRuleCache)
                                                {
                                                    txbOutputlog.AppendText("\r\n");
                                                    txbOutputlog.AppendText(" >>> Status : ERRO - " + exCleanUpRuleCache.Message);
                                                    txbOutputlog.AppendText("\r\n");
                                                }
                                            }
                                            catch (Exception exCleanParameters)
                                            {
                                                txbOutputlog.AppendText("\r\n");
                                                txbOutputlog.AppendText(" >>> Status : ERRO - " + exCleanParameters.Message);
                                                txbOutputlog.AppendText("\r\n");
                                            }
                                        }
                                        catch (Exception exUpdatePortal)
                                        {
                                            txbOutputlog.AppendText("\r\n");
                                            txbOutputlog.AppendText(" >>> Status : ERRO - " + exUpdatePortal.Message);
                                            txbOutputlog.AppendText("\r\n");
                                        }
                                    }
                                    catch (Exception exFreeLocalizationResources)
                                    {
                                        txbOutputlog.AppendText("\r\n");
                                        txbOutputlog.AppendText(" >>> Status : ERRO - " + exFreeLocalizationResources.Message);
                                        txbOutputlog.AppendText("\r\n");
                                    }
                                }
                                catch (Exception exCleanUpCacheEntries)
                                {
                                    txbOutputlog.AppendText("\r\n");
                                    txbOutputlog.AppendText(" >>> Status : ERRO - " + exCleanUpCacheEntries.Message);
                                    txbOutputlog.AppendText("\r\n");
                                }
                            }
                            catch (Exception exCleanUpCache)
                            {
                                txbOutputlog.AppendText("\r\n");
                                txbOutputlog.AppendText(" >>> Status : ERRO - " + exCleanUpCache.Message);
                                txbOutputlog.AppendText("\r\n");
                            }
                        }
                        catch (Exception exCleanTracing)
                        {
                            txbOutputlog.AppendText("\r\n");
                            txbOutputlog.AppendText(" >>> Status : ERRO - " + exCleanTracing.Message);
                            txbOutputlog.AppendText("\r\n");
                        }
                    }
                    catch (Exception exRenderCache)
                    {
                        txbOutputlog.AppendText("\r\n");
                        txbOutputlog.AppendText(" >>> Status : ERRO - " + exRenderCache.Message);
                        txbOutputlog.AppendText("\r\n");
                    }

                }
                catch (Exception ex)
                {
                    txbOutputlog.AppendText("\r\n");
                    txbOutputlog.AppendText(" >>> Status : ERRO - " + ex.Message);
                    txbOutputlog.AppendText("\r\n");
                }

            }
            Thread.Sleep(1000);
            txbOutputlog.AppendText("\r\n");
            txbOutputlog.AppendText("Execução finalizada ...");

        }

        private void btnFecharAplicacao_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            txbServidor.Clear();
            txbProjeto.Clear();
            txbOutputlog.Clear();
        }

        private void btnRecuperaCache_Click(object sender, EventArgs e)
        {
            //RecuperaCache();
        }
    }
}
