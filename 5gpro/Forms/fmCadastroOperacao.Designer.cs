namespace _5gpro.Forms
{
    partial class fmCadastroOperacao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbDadosOperacao = new System.Windows.Forms.GroupBox();
            this.tbDescOperacao = new System.Windows.Forms.TextBox();
            this.tbNomeOperacao = new System.Windows.Forms.TextBox();
            this.tbCodOperacao = new System.Windows.Forms.TextBox();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.gbCondicaoOperacao = new System.Windows.Forms.GroupBox();
            this.rbAprazo = new System.Windows.Forms.RadioButton();
            this.rbAvista = new System.Windows.Forms.RadioButton();
            this.tcOpcoes = new System.Windows.Forms.TabControl();
            this.tpAvista = new System.Windows.Forms.TabPage();
            this.pnAvista = new System.Windows.Forms.Panel();
            this.gbDesconto = new System.Windows.Forms.GroupBox();
            this.dbDesconto = new _5gpro.Controls.DecimalBox();
            this.lbPorcentoDesconto = new System.Windows.Forms.Label();
            this.tpAprazo = new System.Windows.Forms.TabPage();
            this.pnAprazo = new System.Windows.Forms.Panel();
            this.gbJurosAP = new System.Windows.Forms.GroupBox();
            this.lbPorcentoJurosAP = new System.Windows.Forms.Label();
            this.dbJuros = new _5gpro.Controls.DecimalBox();
            this.gbMultaAP = new System.Windows.Forms.GroupBox();
            this.lbPorcentoMultaAP = new System.Windows.Forms.Label();
            this.dbMulta = new _5gpro.Controls.DecimalBox();
            this.gbParcelas = new System.Windows.Forms.GroupBox();
            this.tbNparcelas = new System.Windows.Forms.TextBox();
            this.btGerar = new System.Windows.Forms.Button();
            this.gbVisualizar = new System.Windows.Forms.GroupBox();
            this.tbVisualizar = new System.Windows.Forms.TextBox();
            this.btEditar = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            this.gbEntrada = new System.Windows.Forms.GroupBox();
            this.dbEntrada = new _5gpro.Controls.DecimalBox();
            this.rbNao = new System.Windows.Forms.RadioButton();
            this.lbPorcentoEntrada = new System.Windows.Forms.Label();
            this.rbSim = new System.Windows.Forms.RadioButton();
            this.tbAjuda = new System.Windows.Forms.TextBox();
            this.menuVertical = new _5gpro.Controls.MenuVertical();
            this.lbPorcentoAcrescimo = new System.Windows.Forms.Label();
            this.dbAcrescimo = new _5gpro.Controls.DecimalBox();
            this.gbAcrescimo = new System.Windows.Forms.GroupBox();
            this.gbDadosOperacao.SuspendLayout();
            this.gbCondicaoOperacao.SuspendLayout();
            this.tcOpcoes.SuspendLayout();
            this.tpAvista.SuspendLayout();
            this.pnAvista.SuspendLayout();
            this.gbDesconto.SuspendLayout();
            this.tpAprazo.SuspendLayout();
            this.pnAprazo.SuspendLayout();
            this.gbJurosAP.SuspendLayout();
            this.gbMultaAP.SuspendLayout();
            this.gbParcelas.SuspendLayout();
            this.gbVisualizar.SuspendLayout();
            this.gbEntrada.SuspendLayout();
            this.gbAcrescimo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDadosOperacao
            // 
            this.gbDadosOperacao.BackColor = System.Drawing.Color.White;
            this.gbDadosOperacao.Controls.Add(this.tbDescOperacao);
            this.gbDadosOperacao.Controls.Add(this.tbNomeOperacao);
            this.gbDadosOperacao.Controls.Add(this.tbCodOperacao);
            this.gbDadosOperacao.Controls.Add(this.lbDescricao);
            this.gbDadosOperacao.Controls.Add(this.lbNome);
            this.gbDadosOperacao.Controls.Add(this.lbCodigo);
            this.gbDadosOperacao.Location = new System.Drawing.Point(66, 13);
            this.gbDadosOperacao.Name = "gbDadosOperacao";
            this.gbDadosOperacao.Size = new System.Drawing.Size(507, 207);
            this.gbDadosOperacao.TabIndex = 1;
            this.gbDadosOperacao.TabStop = false;
            this.gbDadosOperacao.Text = "Dados da operação";
            // 
            // tbDescOperacao
            // 
            this.tbDescOperacao.Location = new System.Drawing.Point(9, 134);
            this.tbDescOperacao.Multiline = true;
            this.tbDescOperacao.Name = "tbDescOperacao";
            this.tbDescOperacao.Size = new System.Drawing.Size(338, 61);
            this.tbDescOperacao.TabIndex = 5;
            this.tbDescOperacao.TextChanged += new System.EventHandler(this.TbDescOperacao_TextChanged);
            // 
            // tbNomeOperacao
            // 
            this.tbNomeOperacao.Location = new System.Drawing.Point(9, 83);
            this.tbNomeOperacao.Name = "tbNomeOperacao";
            this.tbNomeOperacao.Size = new System.Drawing.Size(254, 20);
            this.tbNomeOperacao.TabIndex = 4;
            this.tbNomeOperacao.TextChanged += new System.EventHandler(this.TbNomeOperacao_TextChanged);
            // 
            // tbCodOperacao
            // 
            this.tbCodOperacao.Location = new System.Drawing.Point(9, 36);
            this.tbCodOperacao.Name = "tbCodOperacao";
            this.tbCodOperacao.Size = new System.Drawing.Size(65, 20);
            this.tbCodOperacao.TabIndex = 3;
            this.tbCodOperacao.Leave += new System.EventHandler(this.TbCodOperacao_Leave);
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Location = new System.Drawing.Point(6, 117);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(55, 13);
            this.lbDescricao.TabIndex = 2;
            this.lbDescricao.Text = "Descrição";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(6, 66);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "Nome";
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Location = new System.Drawing.Point(6, 20);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(40, 13);
            this.lbCodigo.TabIndex = 0;
            this.lbCodigo.Text = "Código";
            // 
            // gbCondicaoOperacao
            // 
            this.gbCondicaoOperacao.Controls.Add(this.rbAprazo);
            this.gbCondicaoOperacao.Controls.Add(this.rbAvista);
            this.gbCondicaoOperacao.Location = new System.Drawing.Point(66, 227);
            this.gbCondicaoOperacao.Name = "gbCondicaoOperacao";
            this.gbCondicaoOperacao.Size = new System.Drawing.Size(138, 49);
            this.gbCondicaoOperacao.TabIndex = 2;
            this.gbCondicaoOperacao.TabStop = false;
            this.gbCondicaoOperacao.Text = "Condição";
            // 
            // rbAprazo
            // 
            this.rbAprazo.AutoSize = true;
            this.rbAprazo.Location = new System.Drawing.Point(71, 19);
            this.rbAprazo.Name = "rbAprazo";
            this.rbAprazo.Size = new System.Drawing.Size(62, 17);
            this.rbAprazo.TabIndex = 1;
            this.rbAprazo.TabStop = true;
            this.rbAprazo.Text = "A Prazo";
            this.rbAprazo.UseVisualStyleBackColor = true;
            this.rbAprazo.CheckedChanged += new System.EventHandler(this.RbAprazo_CheckedChanged);
            // 
            // rbAvista
            // 
            this.rbAvista.AutoSize = true;
            this.rbAvista.Location = new System.Drawing.Point(7, 19);
            this.rbAvista.Name = "rbAvista";
            this.rbAvista.Size = new System.Drawing.Size(58, 17);
            this.rbAvista.TabIndex = 0;
            this.rbAvista.TabStop = true;
            this.rbAvista.Text = "A Vista";
            this.rbAvista.UseVisualStyleBackColor = true;
            this.rbAvista.CheckedChanged += new System.EventHandler(this.RbAvista_CheckedChanged);
            // 
            // tcOpcoes
            // 
            this.tcOpcoes.Controls.Add(this.tpAvista);
            this.tcOpcoes.Controls.Add(this.tpAprazo);
            this.tcOpcoes.Location = new System.Drawing.Point(66, 282);
            this.tcOpcoes.Name = "tcOpcoes";
            this.tcOpcoes.SelectedIndex = 0;
            this.tcOpcoes.Size = new System.Drawing.Size(511, 221);
            this.tcOpcoes.TabIndex = 3;
            // 
            // tpAvista
            // 
            this.tpAvista.Controls.Add(this.pnAvista);
            this.tpAvista.Location = new System.Drawing.Point(4, 22);
            this.tpAvista.Name = "tpAvista";
            this.tpAvista.Padding = new System.Windows.Forms.Padding(3);
            this.tpAvista.Size = new System.Drawing.Size(503, 195);
            this.tpAvista.TabIndex = 0;
            this.tpAvista.Text = "Opções A Vista";
            this.tpAvista.UseVisualStyleBackColor = true;
            // 
            // pnAvista
            // 
            this.pnAvista.Controls.Add(this.gbDesconto);
            this.pnAvista.Location = new System.Drawing.Point(6, 6);
            this.pnAvista.Name = "pnAvista";
            this.pnAvista.Size = new System.Drawing.Size(487, 183);
            this.pnAvista.TabIndex = 4;
            // 
            // gbDesconto
            // 
            this.gbDesconto.Controls.Add(this.dbDesconto);
            this.gbDesconto.Controls.Add(this.lbPorcentoDesconto);
            this.gbDesconto.Location = new System.Drawing.Point(3, 13);
            this.gbDesconto.Name = "gbDesconto";
            this.gbDesconto.Size = new System.Drawing.Size(113, 50);
            this.gbDesconto.TabIndex = 3;
            this.gbDesconto.TabStop = false;
            this.gbDesconto.Text = "Desconto";
            // 
            // dbDesconto
            // 
            this.dbDesconto.Location = new System.Drawing.Point(6, 19);
            this.dbDesconto.Name = "dbDesconto";
            this.dbDesconto.Size = new System.Drawing.Size(76, 20);
            this.dbDesconto.TabIndex = 4;
            this.dbDesconto.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.dbDesconto.Valor_Changed += new _5gpro.Controls.DecimalBox.valor_changedEventHandler(this.DbDesconto_Valor_Changed);
            // 
            // lbPorcentoDesconto
            // 
            this.lbPorcentoDesconto.AutoSize = true;
            this.lbPorcentoDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPorcentoDesconto.Location = new System.Drawing.Point(88, 20);
            this.lbPorcentoDesconto.Name = "lbPorcentoDesconto";
            this.lbPorcentoDesconto.Size = new System.Drawing.Size(20, 16);
            this.lbPorcentoDesconto.TabIndex = 2;
            this.lbPorcentoDesconto.Text = "%";
            // 
            // tpAprazo
            // 
            this.tpAprazo.Controls.Add(this.pnAprazo);
            this.tpAprazo.Location = new System.Drawing.Point(4, 22);
            this.tpAprazo.Name = "tpAprazo";
            this.tpAprazo.Padding = new System.Windows.Forms.Padding(3);
            this.tpAprazo.Size = new System.Drawing.Size(503, 195);
            this.tpAprazo.TabIndex = 1;
            this.tpAprazo.Text = "Opções A Prazo";
            this.tpAprazo.UseVisualStyleBackColor = true;
            // 
            // pnAprazo
            // 
            this.pnAprazo.Controls.Add(this.gbJurosAP);
            this.pnAprazo.Controls.Add(this.gbMultaAP);
            this.pnAprazo.Controls.Add(this.gbParcelas);
            this.pnAprazo.Controls.Add(this.gbVisualizar);
            this.pnAprazo.Controls.Add(this.gbEntrada);
            this.pnAprazo.Controls.Add(this.gbAcrescimo);
            this.pnAprazo.Location = new System.Drawing.Point(6, 6);
            this.pnAprazo.Name = "pnAprazo";
            this.pnAprazo.Size = new System.Drawing.Size(491, 185);
            this.pnAprazo.TabIndex = 18;
            // 
            // gbJurosAP
            // 
            this.gbJurosAP.Controls.Add(this.lbPorcentoJurosAP);
            this.gbJurosAP.Controls.Add(this.dbJuros);
            this.gbJurosAP.Location = new System.Drawing.Point(10, 65);
            this.gbJurosAP.Name = "gbJurosAP";
            this.gbJurosAP.Size = new System.Drawing.Size(118, 48);
            this.gbJurosAP.TabIndex = 19;
            this.gbJurosAP.TabStop = false;
            this.gbJurosAP.Text = "Juros";
            // 
            // lbPorcentoJurosAP
            // 
            this.lbPorcentoJurosAP.AutoSize = true;
            this.lbPorcentoJurosAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbPorcentoJurosAP.Location = new System.Drawing.Point(89, 19);
            this.lbPorcentoJurosAP.Name = "lbPorcentoJurosAP";
            this.lbPorcentoJurosAP.Size = new System.Drawing.Size(20, 16);
            this.lbPorcentoJurosAP.TabIndex = 1;
            this.lbPorcentoJurosAP.Text = "%";
            // 
            // dbJuros
            // 
            this.dbJuros.Location = new System.Drawing.Point(6, 15);
            this.dbJuros.Name = "dbJuros";
            this.dbJuros.Size = new System.Drawing.Size(76, 20);
            this.dbJuros.TabIndex = 0;
            this.dbJuros.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // gbMultaAP
            // 
            this.gbMultaAP.Controls.Add(this.lbPorcentoMultaAP);
            this.gbMultaAP.Controls.Add(this.dbMulta);
            this.gbMultaAP.Location = new System.Drawing.Point(10, 11);
            this.gbMultaAP.Name = "gbMultaAP";
            this.gbMultaAP.Size = new System.Drawing.Size(118, 48);
            this.gbMultaAP.TabIndex = 18;
            this.gbMultaAP.TabStop = false;
            this.gbMultaAP.Text = "Multa";
            // 
            // lbPorcentoMultaAP
            // 
            this.lbPorcentoMultaAP.AutoSize = true;
            this.lbPorcentoMultaAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbPorcentoMultaAP.Location = new System.Drawing.Point(89, 19);
            this.lbPorcentoMultaAP.Name = "lbPorcentoMultaAP";
            this.lbPorcentoMultaAP.Size = new System.Drawing.Size(20, 16);
            this.lbPorcentoMultaAP.TabIndex = 1;
            this.lbPorcentoMultaAP.Text = "%";
            // 
            // dbMulta
            // 
            this.dbMulta.Location = new System.Drawing.Point(6, 15);
            this.dbMulta.Name = "dbMulta";
            this.dbMulta.Size = new System.Drawing.Size(76, 20);
            this.dbMulta.TabIndex = 0;
            this.dbMulta.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // gbParcelas
            // 
            this.gbParcelas.Controls.Add(this.tbNparcelas);
            this.gbParcelas.Controls.Add(this.btGerar);
            this.gbParcelas.Location = new System.Drawing.Point(134, 11);
            this.gbParcelas.Name = "gbParcelas";
            this.gbParcelas.Size = new System.Drawing.Size(139, 80);
            this.gbParcelas.TabIndex = 15;
            this.gbParcelas.TabStop = false;
            this.gbParcelas.Text = "Parcelas";
            // 
            // tbNparcelas
            // 
            this.tbNparcelas.Location = new System.Drawing.Point(6, 21);
            this.tbNparcelas.Name = "tbNparcelas";
            this.tbNparcelas.Size = new System.Drawing.Size(114, 20);
            this.tbNparcelas.TabIndex = 1;
            this.tbNparcelas.TextChanged += new System.EventHandler(this.TbNparcelas_TextChanged);
            // 
            // btGerar
            // 
            this.btGerar.Location = new System.Drawing.Point(76, 48);
            this.btGerar.Name = "btGerar";
            this.btGerar.Size = new System.Drawing.Size(44, 23);
            this.btGerar.TabIndex = 10;
            this.btGerar.Text = "Gerar";
            this.btGerar.UseVisualStyleBackColor = true;
            this.btGerar.Click += new System.EventHandler(this.BtGerar_Click);
            // 
            // gbVisualizar
            // 
            this.gbVisualizar.Controls.Add(this.tbVisualizar);
            this.gbVisualizar.Controls.Add(this.btEditar);
            this.gbVisualizar.Controls.Add(this.btRemover);
            this.gbVisualizar.Location = new System.Drawing.Point(132, 94);
            this.gbVisualizar.Name = "gbVisualizar";
            this.gbVisualizar.Size = new System.Drawing.Size(141, 82);
            this.gbVisualizar.TabIndex = 16;
            this.gbVisualizar.TabStop = false;
            this.gbVisualizar.Text = "Visualizar";
            this.gbVisualizar.Visible = false;
            // 
            // tbVisualizar
            // 
            this.tbVisualizar.Location = new System.Drawing.Point(6, 21);
            this.tbVisualizar.Name = "tbVisualizar";
            this.tbVisualizar.ReadOnly = true;
            this.tbVisualizar.Size = new System.Drawing.Size(122, 20);
            this.tbVisualizar.TabIndex = 11;
            this.tbVisualizar.Visible = false;
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(6, 50);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(53, 23);
            this.btEditar.TabIndex = 7;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Visible = false;
            this.btEditar.Click += new System.EventHandler(this.BtEditar_Click);
            // 
            // btRemover
            // 
            this.btRemover.Location = new System.Drawing.Point(65, 50);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(63, 23);
            this.btRemover.TabIndex = 12;
            this.btRemover.Text = "Remover";
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Visible = false;
            this.btRemover.Click += new System.EventHandler(this.BtRemover_Click);
            // 
            // gbEntrada
            // 
            this.gbEntrada.Controls.Add(this.dbEntrada);
            this.gbEntrada.Controls.Add(this.rbNao);
            this.gbEntrada.Controls.Add(this.lbPorcentoEntrada);
            this.gbEntrada.Controls.Add(this.rbSim);
            this.gbEntrada.Location = new System.Drawing.Point(279, 11);
            this.gbEntrada.Name = "gbEntrada";
            this.gbEntrada.Size = new System.Drawing.Size(119, 80);
            this.gbEntrada.TabIndex = 6;
            this.gbEntrada.TabStop = false;
            this.gbEntrada.Text = "Entrada";
            // 
            // dbEntrada
            // 
            this.dbEntrada.Enabled = false;
            this.dbEntrada.Location = new System.Drawing.Point(11, 44);
            this.dbEntrada.Name = "dbEntrada";
            this.dbEntrada.Size = new System.Drawing.Size(72, 22);
            this.dbEntrada.TabIndex = 18;
            this.dbEntrada.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.dbEntrada.Valor_Changed += new _5gpro.Controls.DecimalBox.valor_changedEventHandler(this.DbEntrada_Valor_Changed);
            // 
            // rbNao
            // 
            this.rbNao.AutoSize = true;
            this.rbNao.Checked = true;
            this.rbNao.Location = new System.Drawing.Point(59, 19);
            this.rbNao.Name = "rbNao";
            this.rbNao.Size = new System.Drawing.Size(45, 17);
            this.rbNao.TabIndex = 4;
            this.rbNao.TabStop = true;
            this.rbNao.Text = "Não";
            this.rbNao.UseVisualStyleBackColor = true;
            this.rbNao.CheckedChanged += new System.EventHandler(this.RbNao_CheckedChanged);
            // 
            // lbPorcentoEntrada
            // 
            this.lbPorcentoEntrada.AutoSize = true;
            this.lbPorcentoEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPorcentoEntrada.Location = new System.Drawing.Point(89, 50);
            this.lbPorcentoEntrada.Name = "lbPorcentoEntrada";
            this.lbPorcentoEntrada.Size = new System.Drawing.Size(20, 16);
            this.lbPorcentoEntrada.TabIndex = 13;
            this.lbPorcentoEntrada.Text = "%";
            // 
            // rbSim
            // 
            this.rbSim.AutoSize = true;
            this.rbSim.Location = new System.Drawing.Point(11, 19);
            this.rbSim.Name = "rbSim";
            this.rbSim.Size = new System.Drawing.Size(42, 17);
            this.rbSim.TabIndex = 3;
            this.rbSim.Text = "Sim";
            this.rbSim.UseVisualStyleBackColor = true;
            this.rbSim.CheckedChanged += new System.EventHandler(this.RbSim_CheckedChanged);
            // 
            // tbAjuda
            // 
            this.tbAjuda.Enabled = false;
            this.tbAjuda.HideSelection = false;
            this.tbAjuda.Location = new System.Drawing.Point(70, 509);
            this.tbAjuda.Name = "tbAjuda";
            this.tbAjuda.Size = new System.Drawing.Size(507, 20);
            this.tbAjuda.TabIndex = 8;
            // 
            // menuVertical
            // 
            this.menuVertical.Location = new System.Drawing.Point(9, 9);
            this.menuVertical.Margin = new System.Windows.Forms.Padding(0);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(53, 364);
            this.menuVertical.TabIndex = 0;
            this.menuVertical.Novo_Clicked += new _5gpro.Controls.MenuVertical.novoEventHandler(this.MenuVertical1_Novo_Clicked);
            this.menuVertical.Buscar_Clicked += new _5gpro.Controls.MenuVertical.buscarEventHandler(this.MenuVertical1_Buscar_Clicked);
            this.menuVertical.Salvar_Clicked += new _5gpro.Controls.MenuVertical.salvarEventHandler(this.MenuVertical1_Salvar_Clicked);
            this.menuVertical.Recarregar_Clicked += new _5gpro.Controls.MenuVertical.recarregarEventHandler(this.MenuVertical_Recarregar_Clicked);
            this.menuVertical.Anterior_Clicked += new _5gpro.Controls.MenuVertical.anteriorEventHandler(this.MenuVertical1_Anterior_Clicked);
            this.menuVertical.Proximo_Clicked += new _5gpro.Controls.MenuVertical.proximoEventHandler(this.MenuVertical1_Proximo_Clicked);
            // 
            // lbPorcentoAcrescimo
            // 
            this.lbPorcentoAcrescimo.AutoSize = true;
            this.lbPorcentoAcrescimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPorcentoAcrescimo.Location = new System.Drawing.Point(88, 19);
            this.lbPorcentoAcrescimo.Name = "lbPorcentoAcrescimo";
            this.lbPorcentoAcrescimo.Size = new System.Drawing.Size(20, 16);
            this.lbPorcentoAcrescimo.TabIndex = 14;
            this.lbPorcentoAcrescimo.Text = "%";
            // 
            // dbAcrescimo
            // 
            this.dbAcrescimo.Location = new System.Drawing.Point(6, 15);
            this.dbAcrescimo.Name = "dbAcrescimo";
            this.dbAcrescimo.Size = new System.Drawing.Size(76, 20);
            this.dbAcrescimo.TabIndex = 18;
            this.dbAcrescimo.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.dbAcrescimo.Valor_Changed += new _5gpro.Controls.DecimalBox.valor_changedEventHandler(this.DbAcrescimo_Valor_Changed);
            // 
            // gbAcrescimo
            // 
            this.gbAcrescimo.Controls.Add(this.dbAcrescimo);
            this.gbAcrescimo.Controls.Add(this.lbPorcentoAcrescimo);
            this.gbAcrescimo.Location = new System.Drawing.Point(10, 119);
            this.gbAcrescimo.Name = "gbAcrescimo";
            this.gbAcrescimo.Size = new System.Drawing.Size(118, 48);
            this.gbAcrescimo.TabIndex = 17;
            this.gbAcrescimo.TabStop = false;
            this.gbAcrescimo.Text = "Acréscimo";
            // 
            // fmCadastroOperacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(583, 538);
            this.Controls.Add(this.tbAjuda);
            this.Controls.Add(this.tcOpcoes);
            this.Controls.Add(this.gbCondicaoOperacao);
            this.Controls.Add(this.gbDadosOperacao);
            this.Controls.Add(this.menuVertical);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(599, 577);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(599, 577);
            this.Name = "fmCadastroOperacao";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Operação";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FmCadastroOperacao_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FmCadastroOperacao_KeyDown);
            this.gbDadosOperacao.ResumeLayout(false);
            this.gbDadosOperacao.PerformLayout();
            this.gbCondicaoOperacao.ResumeLayout(false);
            this.gbCondicaoOperacao.PerformLayout();
            this.tcOpcoes.ResumeLayout(false);
            this.tpAvista.ResumeLayout(false);
            this.pnAvista.ResumeLayout(false);
            this.gbDesconto.ResumeLayout(false);
            this.gbDesconto.PerformLayout();
            this.tpAprazo.ResumeLayout(false);
            this.pnAprazo.ResumeLayout(false);
            this.gbJurosAP.ResumeLayout(false);
            this.gbJurosAP.PerformLayout();
            this.gbMultaAP.ResumeLayout(false);
            this.gbMultaAP.PerformLayout();
            this.gbParcelas.ResumeLayout(false);
            this.gbParcelas.PerformLayout();
            this.gbVisualizar.ResumeLayout(false);
            this.gbVisualizar.PerformLayout();
            this.gbEntrada.ResumeLayout(false);
            this.gbEntrada.PerformLayout();
            this.gbAcrescimo.ResumeLayout(false);
            this.gbAcrescimo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.MenuVertical menuVertical;
        private System.Windows.Forms.GroupBox gbDadosOperacao;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.TextBox tbCodOperacao;
        private System.Windows.Forms.TextBox tbNomeOperacao;
        private System.Windows.Forms.TextBox tbDescOperacao;
        private System.Windows.Forms.GroupBox gbCondicaoOperacao;
        private System.Windows.Forms.RadioButton rbAprazo;
        private System.Windows.Forms.RadioButton rbAvista;
        private System.Windows.Forms.TabControl tcOpcoes;
        private System.Windows.Forms.TabPage tpAvista;
        private System.Windows.Forms.TabPage tpAprazo;
        private System.Windows.Forms.GroupBox gbEntrada;
        private System.Windows.Forms.RadioButton rbNao;
        private System.Windows.Forms.RadioButton rbSim;
        private System.Windows.Forms.TextBox tbNparcelas;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.TextBox tbAjuda;
        private System.Windows.Forms.Button btGerar;
        private System.Windows.Forms.TextBox tbVisualizar;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.Label lbPorcentoEntrada;
        private System.Windows.Forms.Label lbPorcentoDesconto;
        private System.Windows.Forms.GroupBox gbDesconto;
        private System.Windows.Forms.GroupBox gbVisualizar;
        private System.Windows.Forms.GroupBox gbParcelas;
        private System.Windows.Forms.Panel pnAprazo;
        private System.Windows.Forms.Panel pnAvista;
        private Controls.DecimalBox dbEntrada;
        private Controls.DecimalBox dbDesconto;
        private System.Windows.Forms.GroupBox gbJurosAP;
        private System.Windows.Forms.Label lbPorcentoJurosAP;
        private Controls.DecimalBox dbJuros;
        private System.Windows.Forms.GroupBox gbMultaAP;
        private System.Windows.Forms.Label lbPorcentoMultaAP;
        private Controls.DecimalBox dbMulta;
        private System.Windows.Forms.GroupBox gbAcrescimo;
        private Controls.DecimalBox dbAcrescimo;
        private System.Windows.Forms.Label lbPorcentoAcrescimo;
    }
}