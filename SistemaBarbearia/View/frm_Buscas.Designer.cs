namespace SistemaBarbearia.View
{
    partial class frm_Buscas
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
            this.btn_BuscarServ = new System.Windows.Forms.Button();
            this.cmB_CategServ = new System.Windows.Forms.ComboBox();
            this.dGV_Busca = new System.Windows.Forms.DataGridView();
            this.txtB_NomeServ = new System.Windows.Forms.TextBox();
            this.lbl_NomeServ = new System.Windows.Forms.Label();
            this.lbl_ServCateg = new System.Windows.Forms.Label();
            this.txtB_NomeClie = new System.Windows.Forms.TextBox();
            this.lbl_Cliente = new System.Windows.Forms.Label();
            this.btn_BuscarClie = new System.Windows.Forms.Button();
            this.btn_PorNome = new System.Windows.Forms.Button();
            this.btn_MostrarClie = new System.Windows.Forms.Button();
            this.btn_MostarServ = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Busca)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_BuscarServ
            // 
            this.btn_BuscarServ.Location = new System.Drawing.Point(413, 73);
            this.btn_BuscarServ.Name = "btn_BuscarServ";
            this.btn_BuscarServ.Size = new System.Drawing.Size(75, 23);
            this.btn_BuscarServ.TabIndex = 0;
            this.btn_BuscarServ.Text = "Buscar";
            this.btn_BuscarServ.UseVisualStyleBackColor = true;
            this.btn_BuscarServ.Click += new System.EventHandler(this.btn_BuscarServ_Click);
            // 
            // cmB_CategServ
            // 
            this.cmB_CategServ.FormattingEnabled = true;
            this.cmB_CategServ.Location = new System.Drawing.Point(227, 73);
            this.cmB_CategServ.Name = "cmB_CategServ";
            this.cmB_CategServ.Size = new System.Drawing.Size(180, 23);
            this.cmB_CategServ.TabIndex = 2;
            // 
            // dGV_Busca
            // 
            this.dGV_Busca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Busca.Location = new System.Drawing.Point(497, 12);
            this.dGV_Busca.Name = "dGV_Busca";
            this.dGV_Busca.ReadOnly = true;
            this.dGV_Busca.RowTemplate.Height = 25;
            this.dGV_Busca.Size = new System.Drawing.Size(583, 252);
            this.dGV_Busca.TabIndex = 3;
            // 
            // txtB_NomeServ
            // 
            this.txtB_NomeServ.Location = new System.Drawing.Point(205, 137);
            this.txtB_NomeServ.Name = "txtB_NomeServ";
            this.txtB_NomeServ.Size = new System.Drawing.Size(215, 23);
            this.txtB_NomeServ.TabIndex = 4;
            // 
            // lbl_NomeServ
            // 
            this.lbl_NomeServ.AutoSize = true;
            this.lbl_NomeServ.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_NomeServ.Location = new System.Drawing.Point(9, 138);
            this.lbl_NomeServ.Name = "lbl_NomeServ";
            this.lbl_NomeServ.Size = new System.Drawing.Size(175, 22);
            this.lbl_NomeServ.TabIndex = 5;
            this.lbl_NomeServ.Text = "Nome do Serviço:";
            // 
            // lbl_ServCateg
            // 
            this.lbl_ServCateg.AutoSize = true;
            this.lbl_ServCateg.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_ServCateg.Location = new System.Drawing.Point(9, 70);
            this.lbl_ServCateg.Name = "lbl_ServCateg";
            this.lbl_ServCateg.Size = new System.Drawing.Size(212, 22);
            this.lbl_ServCateg.TabIndex = 6;
            this.lbl_ServCateg.Text = "Categoria do Serviço:";
            // 
            // txtB_NomeClie
            // 
            this.txtB_NomeClie.Location = new System.Drawing.Point(205, 108);
            this.txtB_NomeClie.Name = "txtB_NomeClie";
            this.txtB_NomeClie.Size = new System.Drawing.Size(215, 23);
            this.txtB_NomeClie.TabIndex = 7;
            // 
            // lbl_Cliente
            // 
            this.lbl_Cliente.AutoSize = true;
            this.lbl_Cliente.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Cliente.Location = new System.Drawing.Point(9, 105);
            this.lbl_Cliente.Name = "lbl_Cliente";
            this.lbl_Cliente.Size = new System.Drawing.Size(168, 22);
            this.lbl_Cliente.TabIndex = 8;
            this.lbl_Cliente.Text = "Nome do Cliente:";
            // 
            // btn_BuscarClie
            // 
            this.btn_BuscarClie.Location = new System.Drawing.Point(267, 241);
            this.btn_BuscarClie.Name = "btn_BuscarClie";
            this.btn_BuscarClie.Size = new System.Drawing.Size(75, 23);
            this.btn_BuscarClie.TabIndex = 9;
            this.btn_BuscarClie.Text = "Buscar";
            this.btn_BuscarClie.UseVisualStyleBackColor = true;
            this.btn_BuscarClie.Click += new System.EventHandler(this.btn_BuscarClie_Click);
            // 
            // btn_PorNome
            // 
            this.btn_PorNome.Location = new System.Drawing.Point(18, 241);
            this.btn_PorNome.Name = "btn_PorNome";
            this.btn_PorNome.Size = new System.Drawing.Size(168, 23);
            this.btn_PorNome.TabIndex = 10;
            this.btn_PorNome.Text = "Buscar Serviço Por Nome";
            this.btn_PorNome.UseVisualStyleBackColor = true;
            this.btn_PorNome.Click += new System.EventHandler(this.btn_PorNome_Click);
            // 
            // btn_MostrarClie
            // 
            this.btn_MostrarClie.Location = new System.Drawing.Point(360, 241);
            this.btn_MostrarClie.Name = "btn_MostrarClie";
            this.btn_MostrarClie.Size = new System.Drawing.Size(120, 23);
            this.btn_MostrarClie.TabIndex = 11;
            this.btn_MostrarClie.Text = "Mostar Todos";
            this.btn_MostrarClie.UseVisualStyleBackColor = true;
            this.btn_MostrarClie.Click += new System.EventHandler(this.btn_MostrarClie_Click);
            // 
            // btn_MostarServ
            // 
            this.btn_MostarServ.Location = new System.Drawing.Point(360, 241);
            this.btn_MostarServ.Name = "btn_MostarServ";
            this.btn_MostarServ.Size = new System.Drawing.Size(120, 23);
            this.btn_MostarServ.TabIndex = 12;
            this.btn_MostarServ.Text = "Mostar Todos";
            this.btn_MostarServ.UseVisualStyleBackColor = true;
            this.btn_MostarServ.Click += new System.EventHandler(this.btn_MostarServ_Click);
            // 
            // frm_Buscas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 280);
            this.Controls.Add(this.btn_MostarServ);
            this.Controls.Add(this.btn_MostrarClie);
            this.Controls.Add(this.btn_PorNome);
            this.Controls.Add(this.btn_BuscarClie);
            this.Controls.Add(this.lbl_Cliente);
            this.Controls.Add(this.txtB_NomeClie);
            this.Controls.Add(this.lbl_ServCateg);
            this.Controls.Add(this.lbl_NomeServ);
            this.Controls.Add(this.txtB_NomeServ);
            this.Controls.Add(this.dGV_Busca);
            this.Controls.Add(this.cmB_CategServ);
            this.Controls.Add(this.btn_BuscarServ);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Buscas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BUSCAR";
            this.Load += new System.EventHandler(this.frm_Buscas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Busca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_BuscarServ;
        private ComboBox cmB_CategServ;
        private DataGridView dGV_Busca;
        private TextBox txtB_NomeServ;
        private Label lbl_NomeServ;
        private Label lbl_ServCateg;
        private TextBox txtB_NomeClie;
        private Label lbl_Cliente;
        private Button btn_BuscarClie;
        private Button btn_PorNome;
        private Button btn_MostrarClie;
        private Button btn_MostarServ;
    }
}