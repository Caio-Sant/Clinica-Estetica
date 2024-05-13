namespace Centro_Estetica.TELAS.folha_de_pagamento
{
    partial class frmFolhaPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFolhaPagamento));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboMes = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.nudHorasTrabalhadas = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.cboFuncionario = new System.Windows.Forms.ComboBox();
            this.txtFaltasPriSemana = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtFaltaQuarSemana = new System.Windows.Forms.TextBox();
            this.chkVT = new System.Windows.Forms.CheckBox();
            this.lblPorcentagem = new System.Windows.Forms.Label();
            this.chkHoraExtra = new System.Windows.Forms.CheckBox();
            this.nudHorasExtras = new System.Windows.Forms.NumericUpDown();
            this.nudPorcentagem = new System.Windows.Forms.NumericUpDown();
            this.lblHoraExtra = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtFaltaTerSemana = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtFaltaSegSemana = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHorasTrabalhadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHorasExtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPorcentagem)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnSair);
            this.panel2.Location = new System.Drawing.Point(11, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(846, 60);
            this.panel2.TabIndex = 275;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(191, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(429, 47);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cadastrar Folha de Pagameto";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(795, 15);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(35, 35);
            this.btnSair.TabIndex = 242;
            this.btnSair.Tag = "";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(609, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 372);
            this.groupBox1.TabIndex = 274;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Centro_Estetica.Properties.Resources.High_Estetic_fina90090;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(12, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 210);
            this.panel1.TabIndex = 244;
            // 
            // btnSalvar
            // 
            this.btnSalvar.AccessibleName = "lblSalvar";
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(55, 255);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(126, 36);
            this.btnSalvar.TabIndex = 261;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.cboMes);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.btnCalcular);
            this.groupBox2.Controls.Add(this.lblSalarioLiquido);
            this.groupBox2.Controls.Add(this.nudHorasTrabalhadas);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.lblText);
            this.groupBox2.Controls.Add(this.cboFuncionario);
            this.groupBox2.Controls.Add(this.txtFaltasPriSemana);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.txtFaltaQuarSemana);
            this.groupBox2.Controls.Add(this.chkVT);
            this.groupBox2.Controls.Add(this.lblPorcentagem);
            this.groupBox2.Controls.Add(this.chkHoraExtra);
            this.groupBox2.Controls.Add(this.nudHorasExtras);
            this.groupBox2.Controls.Add(this.nudPorcentagem);
            this.groupBox2.Controls.Add(this.lblHoraExtra);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.txtFaltaTerSemana);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.txtFaltaSegSemana);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(26, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(577, 372);
            this.groupBox2.TabIndex = 273;
            this.groupBox2.TabStop = false;
            // 
            // cboMes
            // 
            this.cboMes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboMes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboMes.BackColor = System.Drawing.Color.White;
            this.cboMes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboMes.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMes.ForeColor = System.Drawing.Color.Black;
            this.cboMes.FormattingEnabled = true;
            this.cboMes.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.cboMes.Location = new System.Drawing.Point(247, 10);
            this.cboMes.Name = "cboMes";
            this.cboMes.Size = new System.Drawing.Size(188, 26);
            this.cboMes.TabIndex = 2;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(199, 18);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(40, 18);
            this.label24.TabIndex = 61;
            this.label24.Text = "Mês";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Transparent;
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcular.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcular.Image")));
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcular.Location = new System.Drawing.Point(454, 271);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(116, 36);
            this.btnCalcular.TabIndex = 13;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.AutoSize = true;
            this.lblSalarioLiquido.BackColor = System.Drawing.Color.Transparent;
            this.lblSalarioLiquido.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioLiquido.ForeColor = System.Drawing.Color.White;
            this.lblSalarioLiquido.Location = new System.Drawing.Point(467, 338);
            this.lblSalarioLiquido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(18, 25);
            this.lblSalarioLiquido.TabIndex = 59;
            this.lblSalarioLiquido.Text = "-";
            // 
            // nudHorasTrabalhadas
            // 
            this.nudHorasTrabalhadas.BackColor = System.Drawing.Color.White;
            this.nudHorasTrabalhadas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudHorasTrabalhadas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nudHorasTrabalhadas.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudHorasTrabalhadas.ForeColor = System.Drawing.Color.Black;
            this.nudHorasTrabalhadas.Location = new System.Drawing.Point(247, 77);
            this.nudHorasTrabalhadas.Margin = new System.Windows.Forms.Padding(4);
            this.nudHorasTrabalhadas.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudHorasTrabalhadas.Name = "nudHorasTrabalhadas";
            this.nudHorasTrabalhadas.Size = new System.Drawing.Size(188, 26);
            this.nudHorasTrabalhadas.TabIndex = 4;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(71, 85);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(168, 18);
            this.label21.TabIndex = 52;
            this.label21.Text = "Horas Trabalhadas";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.BackColor = System.Drawing.Color.Transparent;
            this.lblText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblText.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.ForeColor = System.Drawing.Color.White;
            this.lblText.Location = new System.Drawing.Point(322, 343);
            this.lblText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(137, 18);
            this.lblText.TabIndex = 58;
            this.lblText.Text = "Salário Líquido";
            // 
            // cboFuncionario
            // 
            this.cboFuncionario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboFuncionario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboFuncionario.BackColor = System.Drawing.Color.White;
            this.cboFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboFuncionario.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFuncionario.ForeColor = System.Drawing.Color.Black;
            this.cboFuncionario.FormattingEnabled = true;
            this.cboFuncionario.Location = new System.Drawing.Point(247, 43);
            this.cboFuncionario.Margin = new System.Windows.Forms.Padding(4);
            this.cboFuncionario.Name = "cboFuncionario";
            this.cboFuncionario.Size = new System.Drawing.Size(188, 26);
            this.cboFuncionario.TabIndex = 3;
            // 
            // txtFaltasPriSemana
            // 
            this.txtFaltasPriSemana.BackColor = System.Drawing.Color.White;
            this.txtFaltasPriSemana.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFaltasPriSemana.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFaltasPriSemana.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFaltasPriSemana.ForeColor = System.Drawing.Color.Black;
            this.txtFaltasPriSemana.Location = new System.Drawing.Point(247, 111);
            this.txtFaltasPriSemana.Margin = new System.Windows.Forms.Padding(4);
            this.txtFaltasPriSemana.Name = "txtFaltasPriSemana";
            this.txtFaltasPriSemana.Size = new System.Drawing.Size(188, 26);
            this.txtFaltasPriSemana.TabIndex = 5;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(128, 51);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(111, 18);
            this.label22.TabIndex = 50;
            this.label22.Text = "Funcionário";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(8, 119);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(231, 18);
            this.label20.TabIndex = 54;
            this.label20.Text = "Faltas na primeira semana";
            // 
            // txtFaltaQuarSemana
            // 
            this.txtFaltaQuarSemana.BackColor = System.Drawing.Color.White;
            this.txtFaltaQuarSemana.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFaltaQuarSemana.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFaltaQuarSemana.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFaltaQuarSemana.ForeColor = System.Drawing.Color.Black;
            this.txtFaltaQuarSemana.Location = new System.Drawing.Point(247, 213);
            this.txtFaltaQuarSemana.Margin = new System.Windows.Forms.Padding(4);
            this.txtFaltaQuarSemana.Name = "txtFaltaQuarSemana";
            this.txtFaltaQuarSemana.Size = new System.Drawing.Size(188, 26);
            this.txtFaltaQuarSemana.TabIndex = 8;
            // 
            // chkVT
            // 
            this.chkVT.AutoSize = true;
            this.chkVT.BackColor = System.Drawing.Color.Transparent;
            this.chkVT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkVT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkVT.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVT.ForeColor = System.Drawing.Color.White;
            this.chkVT.Location = new System.Drawing.Point(11, 341);
            this.chkVT.Margin = new System.Windows.Forms.Padding(4);
            this.chkVT.Name = "chkVT";
            this.chkVT.Size = new System.Drawing.Size(155, 22);
            this.chkVT.TabIndex = 11;
            this.chkVT.Text = "Vale transporte";
            this.chkVT.UseVisualStyleBackColor = false;
            // 
            // lblPorcentagem
            // 
            this.lblPorcentagem.AutoSize = true;
            this.lblPorcentagem.BackColor = System.Drawing.Color.Transparent;
            this.lblPorcentagem.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentagem.ForeColor = System.Drawing.Color.White;
            this.lblPorcentagem.Location = new System.Drawing.Point(122, 289);
            this.lblPorcentagem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPorcentagem.Name = "lblPorcentagem";
            this.lblPorcentagem.Size = new System.Drawing.Size(117, 18);
            this.lblPorcentagem.TabIndex = 53;
            this.lblPorcentagem.Text = "Porcentagem";
            // 
            // chkHoraExtra
            // 
            this.chkHoraExtra.AutoSize = true;
            this.chkHoraExtra.BackColor = System.Drawing.Color.Transparent;
            this.chkHoraExtra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkHoraExtra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkHoraExtra.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHoraExtra.ForeColor = System.Drawing.Color.White;
            this.chkHoraExtra.Location = new System.Drawing.Point(184, 341);
            this.chkHoraExtra.Margin = new System.Windows.Forms.Padding(4);
            this.chkHoraExtra.Name = "chkHoraExtra";
            this.chkHoraExtra.Size = new System.Drawing.Size(115, 22);
            this.chkHoraExtra.TabIndex = 12;
            this.chkHoraExtra.Text = "Hora extra";
            this.chkHoraExtra.UseVisualStyleBackColor = false;
            // 
            // nudHorasExtras
            // 
            this.nudHorasExtras.BackColor = System.Drawing.Color.White;
            this.nudHorasExtras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudHorasExtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nudHorasExtras.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudHorasExtras.ForeColor = System.Drawing.Color.Black;
            this.nudHorasExtras.Location = new System.Drawing.Point(247, 247);
            this.nudHorasExtras.Margin = new System.Windows.Forms.Padding(4);
            this.nudHorasExtras.Name = "nudHorasExtras";
            this.nudHorasExtras.Size = new System.Drawing.Size(188, 26);
            this.nudHorasExtras.TabIndex = 9;
            // 
            // nudPorcentagem
            // 
            this.nudPorcentagem.BackColor = System.Drawing.Color.White;
            this.nudPorcentagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudPorcentagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nudPorcentagem.DecimalPlaces = 2;
            this.nudPorcentagem.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPorcentagem.ForeColor = System.Drawing.Color.Black;
            this.nudPorcentagem.Location = new System.Drawing.Point(247, 281);
            this.nudPorcentagem.Margin = new System.Windows.Forms.Padding(4);
            this.nudPorcentagem.Name = "nudPorcentagem";
            this.nudPorcentagem.Size = new System.Drawing.Size(188, 26);
            this.nudPorcentagem.TabIndex = 10;
            // 
            // lblHoraExtra
            // 
            this.lblHoraExtra.AutoSize = true;
            this.lblHoraExtra.BackColor = System.Drawing.Color.Transparent;
            this.lblHoraExtra.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraExtra.ForeColor = System.Drawing.Color.White;
            this.lblHoraExtra.Location = new System.Drawing.Point(123, 255);
            this.lblHoraExtra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoraExtra.Name = "lblHoraExtra";
            this.lblHoraExtra.Size = new System.Drawing.Size(116, 18);
            this.lblHoraExtra.TabIndex = 51;
            this.lblHoraExtra.Text = "Horas Extras";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(13, 153);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(226, 18);
            this.label19.TabIndex = 55;
            this.label19.Text = "Faltas na segunda semana";
            // 
            // txtFaltaTerSemana
            // 
            this.txtFaltaTerSemana.BackColor = System.Drawing.Color.White;
            this.txtFaltaTerSemana.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFaltaTerSemana.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFaltaTerSemana.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFaltaTerSemana.ForeColor = System.Drawing.Color.Black;
            this.txtFaltaTerSemana.Location = new System.Drawing.Point(247, 179);
            this.txtFaltaTerSemana.Margin = new System.Windows.Forms.Padding(4);
            this.txtFaltaTerSemana.Name = "txtFaltaTerSemana";
            this.txtFaltaTerSemana.Size = new System.Drawing.Size(188, 26);
            this.txtFaltaTerSemana.TabIndex = 7;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(16, 187);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(223, 18);
            this.label18.TabIndex = 56;
            this.label18.Text = "Faltas na terceira semana";
            // 
            // txtFaltaSegSemana
            // 
            this.txtFaltaSegSemana.BackColor = System.Drawing.Color.White;
            this.txtFaltaSegSemana.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFaltaSegSemana.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFaltaSegSemana.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFaltaSegSemana.ForeColor = System.Drawing.Color.Black;
            this.txtFaltaSegSemana.Location = new System.Drawing.Point(247, 145);
            this.txtFaltaSegSemana.Margin = new System.Windows.Forms.Padding(4);
            this.txtFaltaSegSemana.Name = "txtFaltaSegSemana";
            this.txtFaltaSegSemana.Size = new System.Drawing.Size(188, 26);
            this.txtFaltaSegSemana.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 221);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 18);
            this.label2.TabIndex = 57;
            this.label2.Text = "Faltas na quarta semana";
            // 
            // frmFolhaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Centro_Estetica.Properties.Resources.asasa;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(868, 462);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFolhaPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFolhaPagamento";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHorasTrabalhadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHorasExtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPorcentagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboMes;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblSalarioLiquido;
        private System.Windows.Forms.NumericUpDown nudHorasTrabalhadas;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.ComboBox cboFuncionario;
        private System.Windows.Forms.TextBox txtFaltasPriSemana;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtFaltaQuarSemana;
        private System.Windows.Forms.CheckBox chkVT;
        private System.Windows.Forms.CheckBox chkHoraExtra;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtFaltaTerSemana;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtFaltaSegSemana;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPorcentagem;
        private System.Windows.Forms.NumericUpDown nudHorasExtras;
        private System.Windows.Forms.NumericUpDown nudPorcentagem;
        private System.Windows.Forms.Label lblHoraExtra;
    }
}