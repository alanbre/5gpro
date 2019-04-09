using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace _5gpro.Controls
{
    public partial class MenuVertical : UserControl
    {
        private bool editando = false;

        public MenuVertical()
        {
            InitializeComponent();
        }

        private void AlteraBotoes(int nivel)
        {
            switch (nivel)
            {
                //NIVEL 0
                case 0:

                    if (editando)
                    {
                        btNovo.Enabled = false;
                        btSalvar.Enabled = false;
                        btBuscar.Enabled = false;
                        btExcluir.Enabled = false;
                    }
                    else
                    {
                        btNovo.Enabled = false;
                        btSalvar.Enabled = false;
                        btBuscar.Enabled = false;
                        btExcluir.Enabled = false;
                    }
                    break;

                //NIVEL 1
                case 1:

                    if (editando)
                    {
                        btNovo.Enabled = false;
                        btSalvar.Enabled = false;
                        btBuscar.Enabled = true;
                        btExcluir.Enabled = false;
                    }
                    else
                    {
                        btNovo.Enabled = false;
                        btSalvar.Enabled = false;
                        btBuscar.Enabled = true;
                        btExcluir.Enabled = false;
                    }
                    break;

                //NIVEL 2
                case 2:

                    if (editando)
                    {
                        btNovo.Enabled = false;
                        btSalvar.Enabled = true;
                        btBuscar.Enabled = false;
                        btExcluir.Enabled = false;
                    }
                    else
                    {
                        btNovo.Enabled = true;
                        btSalvar.Enabled = false;
                        btBuscar.Enabled = true;
                        btExcluir.Enabled = false;
                    }
                    break;

                //NIVEL 3
                case 3:

                    if (editando)
                    {
                        btNovo.Enabled = false;
                        btSalvar.Enabled = true;
                        btBuscar.Enabled = false;
                        btExcluir.Enabled = false;
                    }
                    else
                    {
                        btNovo.Enabled = true;
                        btSalvar.Enabled = false;
                        btBuscar.Enabled = true;
                        btExcluir.Enabled = false;
                    }
                    break;
            }

        }

        //Editando recebe o nivel de acesso da tela
        public void Editando(bool edit, int nivel)
        {
            editando = edit;
            AlteraBotoes(nivel);
        }


        
        //Eventos de click nos botões
        public delegate void novoEventHandler(object sender, EventArgs e);
        public delegate void buscarEventHandler(object sender, EventArgs e);
        public delegate void salvarEventHandler(object sender, EventArgs e);
        public delegate void recarregarEventHandler(object sender, EventArgs e);
        public delegate void anteriorEventHandler(object sender, EventArgs e);
        public delegate void proximoEventHandler(object sender, EventArgs e);
        public delegate void excluirEventHandler(object sender, EventArgs e);


        [Category("Action")]
        [Description("É acionado quando botão novo é clicado")]
        public event novoEventHandler Novo_Clicked;

        [Category("Action")]
        [Description("É acionado quando botão buscar é clicado")]
        public event buscarEventHandler Buscar_Clicked;

        [Category("Action")]
        [Description("É acionado quando botão salvar é clicado")]
        public event salvarEventHandler Salvar_Clicked;

        [Category("Action")]
        [Description("É acionado quando botão recarregar é clicado")]
        public event recarregarEventHandler Recarregar_Clicked;

        [Category("Action")]
        [Description("É acionado quando botão anterior é clicado")]
        public event anteriorEventHandler Anterior_Clicked;

        [Category("Action")]
        [Description("É acionado quando botão próximo é clicado")]
        public event proximoEventHandler Proximo_Clicked;

        [Category("Action")]
        [Description("É acionado quando botão excluir é clicado")]
        public event excluirEventHandler Excluir_Clicked;

        private void BtNovo_Click(object sender, EventArgs e)
        {
            this.Novo_Clicked?.Invoke(this, e);
        }

        private void BtBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar_Clicked?.Invoke(this, e);
        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            this.Salvar_Clicked?.Invoke(this, e);
        }

        private void BtRecarregar_Click(object sender, EventArgs e)
        {
            this.Recarregar_Clicked?.Invoke(this, e);
        }

        private void BtAnterior_Click(object sender, EventArgs e)
        {
            this.Anterior_Clicked?.Invoke(this, e);
        }

        private void BtProximo_Click(object sender, EventArgs e)
        {
            this.Proximo_Clicked?.Invoke(this, e);
        }

        private void BtExcluir_Click(object sender, EventArgs e)
        {
            this.Excluir_Clicked?.Invoke(this, e);
        }
    }
}
