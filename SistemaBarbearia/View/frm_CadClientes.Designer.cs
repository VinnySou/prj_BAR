namespace SistemaBarbearia.View
{
    partial class frm_CadClientes
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
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.lbl_CPF = new System.Windows.Forms.Label();
            this.lbl_Telefone = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.txtB_NomeClie = new System.Windows.Forms.TextBox();
            this.txtB_CPF = new System.Windows.Forms.TextBox();
            this.txtB_Telefone = new System.Windows.Forms.TextBox();
            this.txtB_Email = new System.Windows.Forms.TextBox();
            this.lbl_DadosClie = new System.Windows.Forms.Label();
            this.lbl_Endereco = new System.Windows.Forms.Label();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.dGV_Clie = new System.Windows.Forms.DataGridView();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.lbl_Senha = new System.Windows.Forms.Label();
            this.txtB_Login = new System.Windows.Forms.TextBox();
            this.txtB_Senha = new System.Windows.Forms.TextBox();
            this.btn_Visivel = new System.Windows.Forms.Button();
            this.btn_Ocultar = new System.Windows.Forms.Button();
            this.lbl_Cod = new System.Windows.Forms.Label();
            this.txtB_Cod = new System.Windows.Forms.TextBox();
            this.cmB_Sexo = new System.Windows.Forms.ComboBox();
            this.lbl_Sexo = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.lbl_CliqueGrid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Clie)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Nome.Location = new System.Drawing.Point(9, 100);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(60, 19);
            this.lbl_Nome.TabIndex = 0;
            this.lbl_Nome.Text = "Nome:";
            // 
            // lbl_CPF
            // 
            this.lbl_CPF.AutoSize = true;
            this.lbl_CPF.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_CPF.Location = new System.Drawing.Point(340, 141);
            this.lbl_CPF.Name = "lbl_CPF";
            this.lbl_CPF.Size = new System.Drawing.Size(48, 19);
            this.lbl_CPF.TabIndex = 1;
            this.lbl_CPF.Text = "CPF:";
            // 
            // lbl_Telefone
            // 
            this.lbl_Telefone.AutoSize = true;
            this.lbl_Telefone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Telefone.Location = new System.Drawing.Point(340, 100);
            this.lbl_Telefone.Name = "lbl_Telefone";
            this.lbl_Telefone.Size = new System.Drawing.Size(80, 19);
            this.lbl_Telefone.TabIndex = 2;
            this.lbl_Telefone.Text = "Telefone:";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Email.Location = new System.Drawing.Point(10, 141);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(62, 19);
            this.lbl_Email.TabIndex = 6;
            this.lbl_Email.Text = "E-mail:";
            // 
            // txtB_NomeClie
            // 
            this.txtB_NomeClie.Location = new System.Drawing.Point(75, 101);
            this.txtB_NomeClie.Name = "txtB_NomeClie";
            this.txtB_NomeClie.Size = new System.Drawing.Size(253, 23);
            this.txtB_NomeClie.TabIndex = 1;
            // 
            // txtB_CPF
            // 
            this.txtB_CPF.Location = new System.Drawing.Point(390, 142);
            this.txtB_CPF.Name = "txtB_CPF";
            this.txtB_CPF.Size = new System.Drawing.Size(179, 23);
            this.txtB_CPF.TabIndex = 4;
            // 
            // txtB_Telefone
            // 
            this.txtB_Telefone.Location = new System.Drawing.Point(421, 100);
            this.txtB_Telefone.Name = "txtB_Telefone";
            this.txtB_Telefone.Size = new System.Drawing.Size(147, 23);
            this.txtB_Telefone.TabIndex = 2;
            // 
            // txtB_Email
            // 
            this.txtB_Email.Location = new System.Drawing.Point(77, 141);
            this.txtB_Email.Name = "txtB_Email";
            this.txtB_Email.Size = new System.Drawing.Size(253, 23);
            this.txtB_Email.TabIndex = 3;
            // 
            // lbl_DadosClie
            // 
            this.lbl_DadosClie.AutoSize = true;
            this.lbl_DadosClie.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lbl_DadosClie.Location = new System.Drawing.Point(214, 36);
            this.lbl_DadosClie.Name = "lbl_DadosClie";
            this.lbl_DadosClie.Size = new System.Drawing.Size(169, 19);
            this.lbl_DadosClie.TabIndex = 17;
            this.lbl_DadosClie.Text = "DADOS DO CLIENTE";
            // 
            // lbl_Endereco
            // 
            this.lbl_Endereco.AutoSize = true;
            this.lbl_Endereco.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lbl_Endereco.Location = new System.Drawing.Point(180, 218);
            this.lbl_Endereco.Name = "lbl_Endereco";
            this.lbl_Endereco.Size = new System.Drawing.Size(204, 19);
            this.lbl_Endereco.TabIndex = 18;
            this.lbl_Endereco.Text = "ENDEREÇO DO CLIENTE";
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(214, 385);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(166, 23);
            this.btn_Salvar.TabIndex = 14;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Location = new System.Drawing.Point(214, 327);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(166, 23);
            this.btn_Alterar.TabIndex = 18;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = true;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(214, 356);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(166, 23);
            this.btn_Excluir.TabIndex = 17;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // dGV_Clie
            // 
            this.dGV_Clie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Clie.Location = new System.Drawing.Point(574, 50);
            this.dGV_Clie.Name = "dGV_Clie";
            this.dGV_Clie.ReadOnly = true;
            this.dGV_Clie.RowTemplate.Height = 25;
            this.dGV_Clie.Size = new System.Drawing.Size(490, 388);
            this.dGV_Clie.TabIndex = 20;
            this.dGV_Clie.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_Clie_CellClick);
            // 
            // btn_Novo
            // 
            this.btn_Novo.Location = new System.Drawing.Point(214, 298);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(166, 23);
            this.btn_Novo.TabIndex = 16;
            this.btn_Novo.Text = "Novo";
            this.btn_Novo.UseVisualStyleBackColor = true;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Login.Location = new System.Drawing.Point(28, 251);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(59, 19);
            this.lbl_Login.TabIndex = 28;
            this.lbl_Login.Text = "Login:";
            // 
            // lbl_Senha
            // 
            this.lbl_Senha.AutoSize = true;
            this.lbl_Senha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Senha.Location = new System.Drawing.Point(281, 252);
            this.lbl_Senha.Name = "lbl_Senha";
            this.lbl_Senha.Size = new System.Drawing.Size(64, 19);
            this.lbl_Senha.TabIndex = 29;
            this.lbl_Senha.Text = "Senha:";
            // 
            // txtB_Login
            // 
            this.txtB_Login.Location = new System.Drawing.Point(93, 249);
            this.txtB_Login.Name = "txtB_Login";
            this.txtB_Login.Size = new System.Drawing.Size(171, 23);
            this.txtB_Login.TabIndex = 6;
            // 
            // txtB_Senha
            // 
            this.txtB_Senha.Location = new System.Drawing.Point(351, 250);
            this.txtB_Senha.Name = "txtB_Senha";
            this.txtB_Senha.Size = new System.Drawing.Size(121, 23);
            this.txtB_Senha.TabIndex = 7;
            this.txtB_Senha.UseSystemPasswordChar = true;
            // 
            // btn_Visivel
            // 
            this.btn_Visivel.Location = new System.Drawing.Point(478, 252);
            this.btn_Visivel.Name = "btn_Visivel";
            this.btn_Visivel.Size = new System.Drawing.Size(67, 24);
            this.btn_Visivel.TabIndex = 32;
            this.btn_Visivel.Text = "Mostrar";
            this.btn_Visivel.UseVisualStyleBackColor = true;
            this.btn_Visivel.Click += new System.EventHandler(this.btn_Visivel_Click);
            // 
            // btn_Ocultar
            // 
            this.btn_Ocultar.Location = new System.Drawing.Point(478, 250);
            this.btn_Ocultar.Name = "btn_Ocultar";
            this.btn_Ocultar.Size = new System.Drawing.Size(67, 25);
            this.btn_Ocultar.TabIndex = 19;
            this.btn_Ocultar.Text = "Ocultar";
            this.btn_Ocultar.UseVisualStyleBackColor = true;
            this.btn_Ocultar.Click += new System.EventHandler(this.btn_Ocultar_Click);
            // 
            // lbl_Cod
            // 
            this.lbl_Cod.AutoSize = true;
            this.lbl_Cod.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Cod.Location = new System.Drawing.Point(9, 65);
            this.lbl_Cod.Name = "lbl_Cod";
            this.lbl_Cod.Size = new System.Drawing.Size(71, 19);
            this.lbl_Cod.TabIndex = 34;
            this.lbl_Cod.Text = "Código:";
            // 
            // txtB_Cod
            // 
            this.txtB_Cod.Location = new System.Drawing.Point(77, 65);
            this.txtB_Cod.Name = "txtB_Cod";
            this.txtB_Cod.ReadOnly = true;
            this.txtB_Cod.Size = new System.Drawing.Size(52, 23);
            this.txtB_Cod.TabIndex = 35;
            this.txtB_Cod.TabStop = false;
            // 
            // cmB_Sexo
            // 
            this.cmB_Sexo.FormattingEnabled = true;
            this.cmB_Sexo.Items.AddRange(new object[] {
            "F",
            "M"});
            this.cmB_Sexo.Location = new System.Drawing.Point(77, 170);
            this.cmB_Sexo.Name = "cmB_Sexo";
            this.cmB_Sexo.Size = new System.Drawing.Size(52, 23);
            this.cmB_Sexo.TabIndex = 5;
            // 
            // lbl_Sexo
            // 
            this.lbl_Sexo.AutoSize = true;
            this.lbl_Sexo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Sexo.Location = new System.Drawing.Point(10, 176);
            this.lbl_Sexo.Name = "lbl_Sexo";
            this.lbl_Sexo.Size = new System.Drawing.Size(54, 19);
            this.lbl_Sexo.TabIndex = 37;
            this.lbl_Sexo.Text = "Sexo:";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(214, 414);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(166, 23);
            this.btn_Cancelar.TabIndex = 15;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // lbl_CliqueGrid
            // 
            this.lbl_CliqueGrid.AutoSize = true;
            this.lbl_CliqueGrid.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_CliqueGrid.ForeColor = System.Drawing.Color.Red;
            this.lbl_CliqueGrid.Location = new System.Drawing.Point(663, 9);
            this.lbl_CliqueGrid.Name = "lbl_CliqueGrid";
            this.lbl_CliqueGrid.Size = new System.Drawing.Size(336, 38);
            this.lbl_CliqueGrid.TabIndex = 39;
            this.lbl_CliqueGrid.Text = "CLIQUE NO CÓDIGO DO CLIENTE ABAIXO \r\nQUE DESEJA EDITAR/EXCLUIR";
            this.lbl_CliqueGrid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_CliqueGrid.Click += new System.EventHandler(this.lbl_CliqueGrid_Click);
            // 
            // frm_CadClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 449);
            this.Controls.Add(this.lbl_CliqueGrid);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.lbl_Sexo);
            this.Controls.Add(this.cmB_Sexo);
            this.Controls.Add(this.txtB_Cod);
            this.Controls.Add(this.lbl_Cod);
            this.Controls.Add(this.btn_Ocultar);
            this.Controls.Add(this.btn_Visivel);
            this.Controls.Add(this.txtB_Senha);
            this.Controls.Add(this.txtB_Login);
            this.Controls.Add(this.lbl_Senha);
            this.Controls.Add(this.lbl_Login);
            this.Controls.Add(this.btn_Novo);
            this.Controls.Add(this.dGV_Clie);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Alterar);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.lbl_Endereco);
            this.Controls.Add(this.lbl_DadosClie);
            this.Controls.Add(this.txtB_Email);
            this.Controls.Add(this.txtB_Telefone);
            this.Controls.Add(this.txtB_CPF);
            this.Controls.Add(this.txtB_NomeClie);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.lbl_Telefone);
            this.Controls.Add(this.lbl_CPF);
            this.Controls.Add(this.lbl_Nome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_CadClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO DE CLIENTES";
            this.Load += new System.EventHandler(this.frm_CadClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Clie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_Nome;
        private Label lbl_CPF;
        private Label lbl_Telefone;
        private Label lbl_Email;
        private TextBox txtB_NomeClie;
        private TextBox txtB_CPF;
        private TextBox txtB_Telefone;
        private TextBox txtB_Email;
        private Label lbl_DadosClie;
        private Label lbl_Endereco;
        private Button btn_Salvar;
        private Button btn_Alterar;
        private Button btn_Excluir;
        private DataGridView dGV_Clie;
        private Button btn_Novo;
        private Label lbl_Login;
        private Label lbl_Senha;
        private TextBox txtB_Login;
        private TextBox txtB_Senha;
        private Button btn_Visivel;
        private Button btn_Ocultar;
        private Label lbl_Cod;
        private TextBox txtB_Cod;
        private ComboBox cmB_Sexo;
        private Label lbl_Sexo;
        private Button btn_Cancelar;
        private Label lbl_CliqueGrid;
    }
}