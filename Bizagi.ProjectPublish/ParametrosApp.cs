namespace Bizagi.ProjectPublish
{
    class ParametrosApp
    {
        private string _servidor;
        private string _projeto;
        public string Servidor
        {
            get
            {
                return _servidor;
            }

            set
            {
                _servidor = value;
            }
        }
        public string Projeto
        {
            get
            {
                return _projeto;
            }

            set
            {
                _projeto = value;
            }
        }

        public ParametrosApp() { }
    }
}
