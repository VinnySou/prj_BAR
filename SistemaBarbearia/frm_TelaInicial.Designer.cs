namespace SistemaBarbearia
{
    partial class frm_TelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TelaInicial));
            this.lbl_Senha = new System.Windows.Forms.Label();
            this.txtB_Login = new System.Windows.Forms.TextBox();
            this.txtB_Senha = new System.Windows.Forms.TextBox();
            this.lbl_User = new System.Windows.Forms.Label();
            this.btn_Visivel = new System.Windows.Forms.Button();
            this.btn_Ocultar = new System.Windows.Forms.Button();
            this.btn_Entrar = new System.Windows.Forms.Button();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Senha
            // 
            this.lbl_Senha.AutoSize = true;
            this.lbl_Senha.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Senha.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Senha.ForeColor = System.Drawing.Color.Black;
            this.lbl_Senha.Location = new System.Drawing.Point(12, 76);
            this.lbl_Senha.Name = "lbl_Senha";
            this.lbl_Senha.Size = new System.Drawing.Size(91, 30);
            this.lbl_Senha.TabIndex = 3;
            this.lbl_Senha.Text = "Senha:";
            // 
            // txtB_Login
            // 
            this.txtB_Login.Location = new System.Drawing.Point(122, 35);
            this.txtB_Login.Name = "txtB_Login";
            this.txtB_Login.Size = new System.Drawing.Size(165, 23);
            this.txtB_Login.TabIndex = 4;
            // 
            // txtB_Senha
            // 
            this.txtB_Senha.Location = new System.Drawing.Point(114, 81);
            this.txtB_Senha.Name = "txtB_Senha";
            this.txtB_Senha.Size = new System.Drawing.Size(129, 23);
            this.txtB_Senha.TabIndex = 5;
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.BackColor = System.Drawing.Color.Transparent;
            this.lbl_User.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_User.Location = new System.Drawing.Point(12, 28);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(109, 30);
            this.lbl_User.TabIndex = 6;
            this.lbl_User.Text = "Usuário:";
            // 
            // btn_Visivel
            // 
            this.btn_Visivel.Image = ((System.Drawing.Image)(resources.GetObject("btn_Visivel.Image")));
            this.btn_Visivel.Location = new System.Drawing.Point(246, 76);
            this.btn_Visivel.Name = "btn_Visivel";
            this.btn_Visivel.Size = new System.Drawing.Size(41, 30);
            this.btn_Visivel.TabIndex = 7;
            this.btn_Visivel.UseVisualStyleBackColor = true;
            this.btn_Visivel.Click += new System.EventHandler(this.btn_Visivel_Click);
            // 
            // btn_Ocultar
            // 
            this.btn_Ocultar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Ocultar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ocultar.Image")));
            this.btn_Ocultar.Location = new System.Drawing.Point(246, 76);
            this.btn_Ocultar.Name = "btn_Ocultar";
            this.btn_Ocultar.Size = new System.Drawing.Size(41, 30);
            this.btn_Ocultar.TabIndex = 8;
            this.btn_Ocultar.UseVisualStyleBackColor = false;
            this.btn_Ocultar.Click += new System.EventHandler(this.btn_Ocultar_Click);
            // 
            // btn_Entrar
            // 
            this.btn_Entrar.Location = new System.Drawing.Point(59, 146);
            this.btn_Entrar.Name = "btn_Entrar";
            this.btn_Entrar.Size = new System.Drawing.Size(163, 34);
            this.btn_Entrar.TabIndex = 9;
            this.btn_Entrar.Text = "Entrar";
            this.btn_Entrar.UseVisualStyleBackColor = true;
            this.btn_Entrar.Click += new System.EventHandler(this.btn_Entrar_Click);
            // 
            // btn_Menu
            // 
            this.btn_Menu.Location = new System.Drawing.Point(68, 119);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(175, 37);
            this.btn_Menu.TabIndex = 11;
            this.btn_Menu.Text = "Menu";
            this.btn_Menu.UseVisualStyleBackColor = true;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // frm_TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 277);
            this.Controls.Add(this.btn_Menu);
            this.Controls.Add(this.btn_Entrar);
            this.Controls.Add(this.btn_Ocultar);
            this.Controls.Add(this.btn_Visivel);
            this.Controls.Add(this.lbl_User);
            this.Controls.Add(this.txtB_Senha);
            this.Controls.Add(this.txtB_Login);
            this.Controls.Add(this.lbl_Senha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_TelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TELA INICIAL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbl_Senha;
        private TextBox txtB_Login;
        private TextBox txtB_Senha;
        private Label lbl_User;
        private Button btn_Visivel;
        private Button btn_Ocultar;
        private Button btn_Entrar;
        private Button btn_Menu;
    }
}