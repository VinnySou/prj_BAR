namespace SistemaBarbearia.View
{
    partial class frm_CadFunc
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Ocultar = new System.Windows.Forms.Button();
            this.btn_Visivel = new System.Windows.Forms.Button();
            this.txtB_Senha = new System.Windows.Forms.TextBox();
            this.txtB_Login = new System.Windows.Forms.TextBox();
            this.lbl_Senha = new System.Windows.Forms.Label();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.lbl_Cidade = new System.Windows.Forms.Label();
            this.cmB_Cidade = new System.Windows.Forms.ComboBox();
            this.cmB_Uf = new System.Windows.Forms.ComboBox();
            this.lbl_Estado = new System.Windows.Forms.Label();
            this.lbl_Endereco = new System.Windows.Forms.Label();
            this.lbl_Dados = new System.Windows.Forms.Label();
            this.txtB_CEP = new System.Windows.Forms.TextBox();
            this.txtB_Bairro = new System.Windows.Forms.TextBox();
            this.txtB_Rua = new System.Windows.Forms.TextBox();
            this.txtB_Email = new System.Windows.Forms.TextBox();
            this.txtB_Telefone = new System.Windows.Forms.TextBox();
            this.txtB_CPF = new System.Windows.Forms.TextBox();
            this.txtB_Nome = new System.Windows.Forms.TextBox();
            this.lbl_Cep = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Rua = new System.Windows.Forms.Label();
            this.lbl_Bairro = new System.Windows.Forms.Label();
            this.lbl_Telefone = new System.Windows.Forms.Label();
            this.lbl_CPF = new System.Windows.Forms.Label();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.dGV_Funcionario = new System.Windows.Forms.DataGridView();
            this.lbl_Sexo = new System.Windows.Forms.Label();
            this.cmB_Sexo = new System.Windows.Forms.ComboBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.lbl_Cod = new System.Windows.Forms.Label();
            this.txtB_Cod = new System.Windows.Forms.TextBox();
            this.lbl_AvisoGrid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Funcionario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(231, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 19);
            this.label1.TabIndex = 86;
            this.label1.Text = "LOGIN DO FUNCIONÁRIO";
            // 
            // btn_Editar
            // 
            this.btn_Editar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Editar.Location = new System.Drawing.Point(570, 160);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(75, 23);
            this.btn_Editar.TabIndex = 19;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Excluir.Location = new System.Drawing.Point(570, 189);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_Excluir.TabIndex = 20;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Novo
            // 
            this.btn_Novo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Novo.Location = new System.Drawing.Point(570, 215);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(75, 23);
            this.btn_Novo.TabIndex = 18;
            this.btn_Novo.Text = "Novo";
            this.btn_Novo.UseVisualStyleBackColor = true;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Salvar.Location = new System.Drawing.Point(570, 243);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_Salvar.TabIndex = 16;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Ocultar
            // 
            this.btn_Ocultar.Location = new System.Drawing.Point(482, 217);
            this.btn_Ocultar.Name = "btn_Ocultar";
            this.btn_Ocultar.Size = new System.Drawing.Size(67, 24);
            this.btn_Ocultar.TabIndex = 9;
            this.btn_Ocultar.Text = "Ocultar";
            this.btn_Ocultar.UseVisualStyleBackColor = true;
            this.btn_Ocultar.Click += new System.EventHandler(this.btn_Ocultar_Click);
            // 
            // btn_Visivel
            // 
            this.btn_Visivel.Location = new System.Drawing.Point(482, 217);
            this.btn_Visivel.Name = "btn_Visivel";
            this.btn_Visivel.Size = new System.Drawing.Size(67, 24);
            this.btn_Visivel.TabIndex = 8;
            this.btn_Visivel.Text = "Mostrar";
            this.btn_Visivel.UseVisualStyleBackColor = true;
            this.btn_Visivel.Click += new System.EventHandler(this.btn_Visivel_Click);
            // 
            // txtB_Senha
            // 
            this.txtB_Senha.Location = new System.Drawing.Point(355, 216);
            this.txtB_Senha.Name = "txtB_Senha";
            this.txtB_Senha.Size = new System.Drawing.Size(121, 23);
            this.txtB_Senha.TabIndex = 7;
            this.txtB_Senha.UseSystemPasswordChar = true;
            // 
            // txtB_Login
            // 
            this.txtB_Login.Location = new System.Drawing.Point(118, 216);
            this.txtB_Login.Name = "txtB_Login";
            this.txtB_Login.Size = new System.Drawing.Size(161, 23);
            this.txtB_Login.TabIndex = 6;
            // 
            // lbl_Senha
            // 
            this.lbl_Senha.AutoSize = true;
            this.lbl_Senha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Senha.Location = new System.Drawing.Point(285, 220);
            this.lbl_Senha.Name = "lbl_Senha";
            this.lbl_Senha.Size = new System.Drawing.Size(64, 19);
            this.lbl_Senha.TabIndex = 112;
            this.lbl_Senha.Text = "Senha:";
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Login.Location = new System.Drawing.Point(53, 220);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(59, 19);
            this.lbl_Login.TabIndex = 111;
            this.lbl_Login.Text = "Login:";
            // 
            // lbl_Cidade
            // 
            this.lbl_Cidade.AutoSize = true;
            this.lbl_Cidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Cidade.Location = new System.Drawing.Point(331, 343);
            this.lbl_Cidade.Name = "lbl_Cidade";
            this.lbl_Cidade.Size = new System.Drawing.Size(69, 19);
            this.lbl_Cidade.TabIndex = 110;
            this.lbl_Cidade.Text = "Cidade:";
            // 
            // cmB_Cidade
            // 
            this.cmB_Cidade.FormattingEnabled = true;
            this.cmB_Cidade.Items.AddRange(new object[] {
            "Serra",
            "Vila Velha",
            "Cariacica",
            "Vitória",
            "Viana",
            "Guarapari"});
            this.cmB_Cidade.Location = new System.Drawing.Point(406, 343);
            this.cmB_Cidade.Name = "cmB_Cidade";
            this.cmB_Cidade.Size = new System.Drawing.Size(178, 23);
            this.cmB_Cidade.TabIndex = 14;
            // 
            // cmB_Uf
            // 
            this.cmB_Uf.FormattingEnabled = true;
            this.cmB_Uf.Items.AddRange(new object[] {
            "ES"});
            this.cmB_Uf.Location = new System.Drawing.Point(237, 343);
            this.cmB_Uf.Name = "cmB_Uf";
            this.cmB_Uf.Size = new System.Drawing.Size(76, 23);
            this.cmB_Uf.TabIndex = 13;
            // 
            // lbl_Estado
            // 
            this.lbl_Estado.AutoSize = true;
            this.lbl_Estado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Estado.Location = new System.Drawing.Point(162, 343);
            this.lbl_Estado.Name = "lbl_Estado";
            this.lbl_Estado.Size = new System.Drawing.Size(69, 19);
            this.lbl_Estado.TabIndex = 107;
            this.lbl_Estado.Text = "Estado:";
            // 
            // lbl_Endereco
            // 
            this.lbl_Endereco.AutoSize = true;
            this.lbl_Endereco.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lbl_Endereco.Location = new System.Drawing.Point(228, 272);
            this.lbl_Endereco.Name = "lbl_Endereco";
            this.lbl_Endereco.Size = new System.Drawing.Size(247, 19);
            this.lbl_Endereco.TabIndex = 106;
            this.lbl_Endereco.Text = "ENDEREÇO DO FUNCIONARIO";
            // 
            // lbl_Dados
            // 
            this.lbl_Dados.AutoSize = true;
            this.lbl_Dados.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lbl_Dados.Location = new System.Drawing.Point(230, 9);
            this.lbl_Dados.Name = "lbl_Dados";
            this.lbl_Dados.Size = new System.Drawing.Size(212, 19);
            this.lbl_Dados.TabIndex = 105;
            this.lbl_Dados.Text = "DADOS DO FUNCIONÁRIO";
            // 
            // txtB_CEP
            // 
            this.txtB_CEP.Location = new System.Drawing.Point(62, 343);
            this.txtB_CEP.Name = "txtB_CEP";
            this.txtB_CEP.Size = new System.Drawing.Size(94, 23);
            this.txtB_CEP.TabIndex = 12;
            // 
            // txtB_Bairro
            // 
            this.txtB_Bairro.Location = new System.Drawing.Point(375, 307);
            this.txtB_Bairro.Name = "txtB_Bairro";
            this.txtB_Bairro.Size = new System.Drawing.Size(209, 23);
            this.txtB_Bairro.TabIndex = 11;
            // 
            // txtB_Rua
            // 
            this.txtB_Rua.Location = new System.Drawing.Point(63, 307);
            this.txtB_Rua.Name = "txtB_Rua";
            this.txtB_Rua.Size = new System.Drawing.Size(238, 23);
            this.txtB_Rua.TabIndex = 10;
            // 
            // txtB_Email
            // 
            this.txtB_Email.Location = new System.Drawing.Point(331, 102);
            this.txtB_Email.Name = "txtB_Email";
            this.txtB_Email.Size = new System.Drawing.Size(253, 23);
            this.txtB_Email.TabIndex = 4;
            // 
            // txtB_Telefone
            // 
            this.txtB_Telefone.Location = new System.Drawing.Point(87, 102);
            this.txtB_Telefone.Name = "txtB_Telefone";
            this.txtB_Telefone.Size = new System.Drawing.Size(147, 23);
            this.txtB_Telefone.TabIndex = 3;
            // 
            // txtB_CPF
            // 
            this.txtB_CPF.Location = new System.Drawing.Point(405, 73);
            this.txtB_CPF.Name = "txtB_CPF";
            this.txtB_CPF.Size = new System.Drawing.Size(179, 23);
            this.txtB_CPF.TabIndex = 2;
            // 
            // txtB_Nome
            // 
            this.txtB_Nome.Location = new System.Drawing.Point(87, 73);
            this.txtB_Nome.Name = "txtB_Nome";
            this.txtB_Nome.Size = new System.Drawing.Size(253, 23);
            this.txtB_Nome.TabIndex = 1;
            // 
            // lbl_Cep
            // 
            this.lbl_Cep.AutoSize = true;
            this.lbl_Cep.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Cep.Location = new System.Drawing.Point(11, 347);
            this.lbl_Cep.Name = "lbl_Cep";
            this.lbl_Cep.Size = new System.Drawing.Size(49, 19);
            this.lbl_Cep.TabIndex = 97;
            this.lbl_Cep.Text = "CEP:";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Email.Location = new System.Drawing.Point(263, 106);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(62, 19);
            this.lbl_Email.TabIndex = 96;
            this.lbl_Email.Text = "E-mail:";
            // 
            // lbl_Rua
            // 
            this.lbl_Rua.AutoSize = true;
            this.lbl_Rua.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Rua.Location = new System.Drawing.Point(11, 311);
            this.lbl_Rua.Name = "lbl_Rua";
            this.lbl_Rua.Size = new System.Drawing.Size(46, 19);
            this.lbl_Rua.TabIndex = 95;
            this.lbl_Rua.Text = "Rua:";
            // 
            // lbl_Bairro
            // 
            this.lbl_Bairro.AutoSize = true;
            this.lbl_Bairro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Bairro.Location = new System.Drawing.Point(307, 307);
            this.lbl_Bairro.Name = "lbl_Bairro";
            this.lbl_Bairro.Size = new System.Drawing.Size(62, 19);
            this.lbl_Bairro.TabIndex = 94;
            this.lbl_Bairro.Text = "Bairro:";
            // 
            // lbl_Telefone
            // 
            this.lbl_Telefone.AutoSize = true;
            this.lbl_Telefone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Telefone.Location = new System.Drawing.Point(9, 106);
            this.lbl_Telefone.Name = "lbl_Telefone";
            this.lbl_Telefone.Size = new System.Drawing.Size(80, 19);
            this.lbl_Telefone.TabIndex = 93;
            this.lbl_Telefone.Text = "Telefone:";
            // 
            // lbl_CPF
            // 
            this.lbl_CPF.AutoSize = true;
            this.lbl_CPF.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_CPF.Location = new System.Drawing.Point(346, 73);
            this.lbl_CPF.Name = "lbl_CPF";
            this.lbl_CPF.Size = new System.Drawing.Size(48, 19);
            this.lbl_CPF.TabIndex = 92;
            this.lbl_CPF.Text = "CPF:";
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Nome.Location = new System.Drawing.Point(12, 73);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(60, 19);
            this.lbl_Nome.TabIndex = 91;
            this.lbl_Nome.Text = "Nome:";
            // 
            // dGV_Funcionario
            // 
            this.dGV_Funcionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Funcionario.Location = new System.Drawing.Point(651, 48);
            this.dGV_Funcionario.Name = "dGV_Funcionario";
            this.dGV_Funcionario.ReadOnly = true;
            this.dGV_Funcionario.RowTemplate.Height = 25;
            this.dGV_Funcionario.Size = new System.Drawing.Size(479, 366);
            this.dGV_Funcionario.TabIndex = 117;
            this.dGV_Funcionario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_Funcionario_CellClick);
            // 
            // lbl_Sexo
            // 
            this.lbl_Sexo.AutoSize = true;
            this.lbl_Sexo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Sexo.Location = new System.Drawing.Point(27, 136);
            this.lbl_Sexo.Name = "lbl_Sexo";
            this.lbl_Sexo.Size = new System.Drawing.Size(54, 19);
            this.lbl_Sexo.TabIndex = 118;
            this.lbl_Sexo.Text = "Sexo:";
            // 
            // cmB_Sexo
            // 
            this.cmB_Sexo.FormattingEnabled = true;
            this.cmB_Sexo.Items.AddRange(new object[] {
            "F",
            "M"});
            this.cmB_Sexo.Location = new System.Drawing.Point(87, 132);
            this.cmB_Sexo.Name = "cmB_Sexo";
            this.cmB_Sexo.Size = new System.Drawing.Size(48, 23);
            this.cmB_Sexo.TabIndex = 5;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Cancelar.Location = new System.Drawing.Point(570, 268);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 17;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // lbl_Cod
            // 
            this.lbl_Cod.AutoSize = true;
            this.lbl_Cod.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Cod.Location = new System.Drawing.Point(12, 48);
            this.lbl_Cod.Name = "lbl_Cod";
            this.lbl_Cod.Size = new System.Drawing.Size(71, 19);
            this.lbl_Cod.TabIndex = 121;
            this.lbl_Cod.Text = "Código:";
            // 
            // txtB_Cod
            // 
            this.txtB_Cod.Location = new System.Drawing.Point(87, 44);
            this.txtB_Cod.Name = "txtB_Cod";
            this.txtB_Cod.ReadOnly = true;
            this.txtB_Cod.Size = new System.Drawing.Size(65, 23);
            this.txtB_Cod.TabIndex = 122;
            this.txtB_Cod.TabStop = false;
            // 
            // lbl_AvisoGrid
            // 
            this.lbl_AvisoGrid.AutoSize = true;
            this.lbl_AvisoGrid.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_AvisoGrid.ForeColor = System.Drawing.Color.Red;
            this.lbl_AvisoGrid.Location = new System.Drawing.Point(688, 7);
            this.lbl_AvisoGrid.Name = "lbl_AvisoGrid";
            this.lbl_AvisoGrid.Size = new System.Drawing.Size(379, 38);
            this.lbl_AvisoGrid.TabIndex = 123;
            this.lbl_AvisoGrid.Text = "CLIQUE NO CÓDIGO DO FUNCIONÁRIO ABAIXO \r\nQUE DESEJA EDITAR/EXCLUIR";
            this.lbl_AvisoGrid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_CadFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 419);
            this.Controls.Add(this.lbl_AvisoGrid);
            this.Controls.Add(this.txtB_Cod);
            this.Controls.Add(this.lbl_Cod);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.cmB_Sexo);
            this.Controls.Add(this.lbl_Sexo);
            this.Controls.Add(this.dGV_Funcionario);
            this.Controls.Add(this.btn_Ocultar);
            this.Controls.Add(this.btn_Visivel);
            this.Controls.Add(this.txtB_Senha);
            this.Controls.Add(this.txtB_Login);
            this.Controls.Add(this.lbl_Senha);
            this.Controls.Add(this.lbl_Login);
            this.Controls.Add(this.lbl_Cidade);
            this.Controls.Add(this.cmB_Cidade);
            this.Controls.Add(this.cmB_Uf);
            this.Controls.Add(this.lbl_Estado);
            this.Controls.Add(this.lbl_Endereco);
            this.Controls.Add(this.lbl_Dados);
            this.Controls.Add(this.txtB_CEP);
            this.Controls.Add(this.txtB_Bairro);
            this.Controls.Add(this.txtB_Rua);
            this.Controls.Add(this.txtB_Email);
            this.Controls.Add(this.txtB_Telefone);
            this.Controls.Add(this.txtB_CPF);
            this.Controls.Add(this.txtB_Nome);
            this.Controls.Add(this.lbl_Cep);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.lbl_Rua);
            this.Controls.Add(this.lbl_Bairro);
            this.Controls.Add(this.lbl_Telefone);
            this.Controls.Add(this.lbl_CPF);
            this.Controls.Add(this.lbl_Nome);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.btn_Novo);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_CadFunc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO DE FUNCIONÁRIO";
            this.Load += new System.EventHandler(this.frm_CadFunc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Funcionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Button btn_Editar;
        private Button btn_Excluir;
        private Button btn_Novo;
        private Button btn_Salvar;
        private Button btn_Ocultar;
        private Button btn_Visivel;
        private TextBox txtB_Senha;
        private TextBox txtB_Login;
        private Label lbl_Senha;
        private Label lbl_Login;
        private Label lbl_Cidade;
        private ComboBox cmB_Cidade;
        private ComboBox cmB_Uf;
        private Label lbl_Estado;
        private Label lbl_Endereco;
        private Label lbl_Dados;
        private TextBox txtB_CEP;
        private TextBox txtB_Bairro;
        private TextBox txtB_Rua;
        private TextBox txtB_Email;
        private TextBox txtB_Telefone;
        private TextBox txtB_CPF;
        private TextBox txtB_Nome;
        private Label lbl_Cep;
        private Label lbl_Email;
        private Label lbl_Rua;
        private Label lbl_Bairro;
        private Label lbl_Telefone;
        private Label lbl_CPF;
        private Label lbl_Nome;
        private DataGridView dGV_Funcionario;
        private Label lbl_Sexo;
        private ComboBox cmB_Sexo;
        private Button btn_Cancelar;
        private Label lbl_Cod;
        private TextBox txtB_Cod;
        private Label lbl_AvisoGrid;
    }
}