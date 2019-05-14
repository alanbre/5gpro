using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;
using static System.Windows.Forms.Control;
using _5gpro.Entities;
using System.Drawing;

namespace _5gpro.Funcoes
{

    public class Validacao
    {

        public static IEnumerable<ValidationResult> getValidationErros(object obj)
        {
            //RECEBE UM OBJETO E TENTA VALIDAR ELE CONFORME AS REGRAS SETADAS NA ENTIDADE
            //E ADICIONA TODO O ERRO EM UMA LISTA
            var resultadoValidacao = new List<ValidationResult>();
            var contexto = new ValidationContext(obj, null, null);
            Validator.TryValidateObject(obj, contexto, resultadoValidacao, true);


            //RETORNA A LISTA DE ERROS GERADA
            return resultadoValidacao;
        }

        public bool ValidarEntidade(object obj, ControlCollection controls)
        {

            //RECEBE A ENTIDADE A SER TESTADA

            //CRIA UMA VARIÁVEL "OK" COM O VALOR 1
            bool ok = false;

            //CHAMA A FUNÇÃO getValidationErros PARA OBTER A LISTA DE ERROS
            //CASO EXISTA ALGUM
            var erros = Validacao.getValidationErros(obj);


            //CRIA UMA LISTA DE STRING PARA ARMAZENAR OS ERROS PARA QUE
            //SEJA POSSÍVEL APRESENTAR APENAS O ERRO DA POSIÇÃO [0]

            //PERCORRENDO A LISTA DE ERROS GERADOS PELA FUNÇÃO getValidationErros
            // E ARMAZENANDO ELES NA LISTA DE STRING
            List<string> listaerros = new List<string>();
            List<string> listabotoes = new List<string>();


            foreach (var error in erros)
            {
                string[] divisao = error.ErrorMessage.Split('|');
                listaerros.Add(divisao[0]);
                listabotoes.Add(divisao[1]);
            }


            //VERIFICA SE A LISTA TEM MAIS DE 0 REGISTROS E MOSTRA
            //QUANDO NÃO HOUVER MAIS ERROS, CAI NO ELSE E MUDA A VARIAVEL
            // "OK" PARA 0
            string todoserros = "CAMPOS OBRIGATÓRIOS";
            if (listaerros.Count > 0)
            {
                foreach (var erro in listaerros)
                {
                    todoserros = todoserros + "\n \n " + erro;
                }
                pintarBotoes(listabotoes, controls);
                //MessageBox.Show(todoserros);
                MessageBox.Show("Verifique os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ok = true;
            }
            return ok;
        }

        public void despintarCampos(ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {

                //USERCONTROL
                if (ctrl is UserControl)
                {
                    //ctrl.BackColor = Color.FromKnownColor(KnownColor.Control);
                    ctrl.BackColor = System.Drawing.Color.White;
                    foreach (Control ctrlcu in ctrl.Controls)
                    {
                        if (ctrlcu is TextBox && !ctrlcu.Name.Equals("tbAjuda"))
                        {
                            ctrlcu.BackColor = System.Drawing.Color.White;
                        }
                    }
                }

                //GROUPBOX
                if (ctrl is GroupBox)
                {
                    //ctrl.BackColor = Color.FromKnownColor(KnownColor.Control);
                    ctrl.BackColor = System.Drawing.Color.White;

                    foreach (Control ctrlgb in ctrl.Controls)
                    {
                        if (ctrlgb is TextBox && !ctrlgb.Name.Equals("tbAjuda"))
                        {
                            ctrlgb.BackColor = System.Drawing.Color.White;
                        }

                        if (ctrlgb is Controls.BuscaSubGrupoItem || ctrlgb is Controls.BuscaUnimedida)
                        {
                            //ctrlgb.BackColor = Color.FromKnownColor(KnownColor.Control);
                            ctrlgb.BackColor = System.Drawing.Color.White;
                        }
                        if (ctrlgb is Controls.BuscaCidade || ctrlgb is Controls.BuscaSubGrupoPessoa || ctrlgb is Controls.BuscaPessoa)
                        {
                            //ctrlgb.BackColor = Color.FromKnownColor(KnownColor.Control);
                            ctrlgb.BackColor = System.Drawing.Color.White;
                        }
                        if (ctrlgb is CheckedListBox)
                        {
                            ctrlgb.BackColor = System.Drawing.Color.White;
                        }
                    }
                }

                //PAINEL
                if (ctrl is Panel)
                {
                    foreach (Control ctrlp in ctrl.Controls)
                    {
                        if (ctrlp is TextBox && !ctrlp.Name.Equals("tbAjuda"))
                        {
                            ctrlp.BackColor = System.Drawing.Color.White;
                        }
                        if (ctrlp is Controls.BuscaSubGrupoItem || ctrlp is Controls.BuscaUnimedida)
                        {
                            //ctrlp.BackColor = Color.FromKnownColor(KnownColor.Control);
                            ctrlp.BackColor = System.Drawing.Color.White;
                        }
                        if (ctrlp is Controls.BuscaCidade || ctrlp is Controls.BuscaSubGrupoPessoa)
                        {
                            //ctrlp.BackColor = Color.FromKnownColor(KnownColor.Control);
                            ctrlp.BackColor = System.Drawing.Color.White;
                        }
                        if (ctrlp is CheckedListBox)
                        {
                            ctrlp.BackColor = System.Drawing.Color.White;
                        }
                        if (ctrlp is GroupBox)
                        {
                            foreach (Control ct in ctrlp.Controls)
                            {
                                if (ct is CheckedListBox)
                                {
                                    ct.BackColor = System.Drawing.Color.White;
                                }
                            }
                        }
                    }
                }

                //TABPAGE
                if (ctrl is TabControl)
                {
                    foreach (TabPage page in ctrl.Controls)
                    {
                        foreach (Control ctrltabpage in page.Controls)
                        {
                            if (ctrltabpage is TextBox && !ctrltabpage.Name.Equals("tbAjuda"))
                            {
                                ctrltabpage.BackColor = System.Drawing.Color.White;
                            }
                        }
                    }
                }

                //TEXTBOX
                if (ctrl is TextBox && !ctrl.Name.Equals("tbAjuda"))
                {
                    ctrl.BackColor = System.Drawing.Color.White;
                }
            }
        }

        public void pintarBotoes(List<string> botoes, ControlCollection controls)
        {
            //RECEBE A LISTA DE BOTOES QUE DEVEM SER PINTADOS E EM QUAL CONTROLCOLLECTION

            Control[] c;

            //PEGA TODOSS OS COMPONENTESS DENTRO DO controls
            //E VERFICIA O TIPO DELE, CASO SEJA PANEL FAZ UM FOREACH
            //PARA PINTAR OS COMPONENTES DENTRO DO PANEL

            despintarCampos(controls);
            //DEPOIS DE PINTAR TODOS OS CAMPOS DE BRANCO, ELE PINTA
            //OS CAMPOS COM ERRO, DE VERMELHO
            foreach (var botao in botoes)
            {
                c = controls.Find(botao, true);

                foreach (Control ct in c)
                {
                    ct.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFD2CA");

                }

            }

        }

    }
}


