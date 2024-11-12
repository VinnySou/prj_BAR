namespace SistemaBarbearia.View
{
    partial class frm_CadCategoria
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
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.lbl_Codigo = new System.Windows.Forms.Label();
            this.lbl_NomeCateg = new System.Windows.Forms.Label();
            this.txtB_CodCateg = new System.Windows.Forms.TextBox();
            this.txtB_NomeCateg = new System.Windows.Forms.TextBox();
            this.dGV_Categoria = new System.Windows.Forms.DataGridView();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.lbl_CliqueGrid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Categoria)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(260, 307);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_Salvar.TabIndex = 0;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(179, 307);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_Excluir.TabIndex = 1;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(93, 307);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(75, 23);
            this.btn_Editar.TabIndex = 2;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Novo
            // 
            this.btn_Novo.Location = new System.Drawing.Point(12, 307);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(75, 23);
            this.btn_Novo.TabIndex = 3;
            this.btn_Novo.Text = "Novo";
            this.btn_Novo.UseVisualStyleBackColor = true;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // lbl_Codigo
            // 
            this.lbl_Codigo.AutoSize = true;
            this.lbl_Codigo.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_Codigo.Location = new System.Drawing.Point(12, 22);
            this.lbl_Codigo.Name = "lbl_Codigo";
            this.lbl_Codigo.Size = new System.Drawing.Size(67, 18);
            this.lbl_Codigo.TabIndex = 4;
            this.lbl_Codigo.Text = "Código:";
            // 
            // lbl_NomeCateg
            // 
            this.lbl_NomeCateg.AutoSize = true;
            this.lbl_NomeCateg.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_NomeCateg.Location = new System.Drawing.Point(12, 56);
            this.lbl_NomeCateg.Name = "lbl_NomeCateg";
            this.lbl_NomeCateg.Size = new System.Drawing.Size(161, 19);
            this.lbl_NomeCateg.TabIndex = 5;
            this.lbl_NomeCateg.Text = "Nome da Categoria:";
            // 
            // txtB_CodCateg
            // 
            this.txtB_CodCateg.Location = new System.Drawing.Point(85, 22);
            this.txtB_CodCateg.Name = "txtB_CodCateg";
            this.txtB_CodCateg.ReadOnly = true;
            this.txtB_CodCateg.Size = new System.Drawing.Size(64, 23);
            this.txtB_CodCateg.TabIndex = 6;
            // 
            // txtB_NomeCateg
            // 
            this.txtB_NomeCateg.Location = new System.Drawing.Point(179, 56);
            this.txtB_NomeCateg.Name = "txtB_NomeCateg";
            this.txtB_NomeCateg.Size = new System.Drawing.Size(232, 23);
            this.txtB_NomeCateg.TabIndex = 7;
            // 
            // dGV_Categoria
            // 
            this.dGV_Categoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Categoria.Location = new System.Drawing.Point(12, 139);
            this.dGV_Categoria.Name = "dGV_Categoria";
            this.dGV_Categoria.ReadOnly = true;
            this.dGV_Categoria.RowTemplate.Height = 25;
            this.dGV_Categoria.Size = new System.Drawing.Size(399, 162);
            this.dGV_Categoria.TabIndex = 8;
            this.dGV_Categoria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_Categoria_CellClick);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(341, 307);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 9;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // lbl_CliqueGrid
            // 
            this.lbl_CliqueGrid.AutoSize = true;
            this.lbl_CliqueGrid.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CliqueGrid.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_CliqueGrid.ForeColor = System.Drawing.Color.Red;
            this.lbl_CliqueGrid.Location = new System.Drawing.Point(63, 98);
            this.lbl_CliqueGrid.Name = "lbl_CliqueGrid";
            this.lbl_CliqueGrid.Size = new System.Drawing.Size(290, 38);
            this.lbl_CliqueGrid.TabIndex = 10;
            this.lbl_CliqueGrid.Text = "CLIQUE NO CÓDIGO DA CATEGORIA\r\nQUE DESEJA EDITAR/EXCLUIR\r\n";
            this.lbl_CliqueGrid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_CadCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 342);
            this.Controls.Add(this.lbl_CliqueGrid);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.dGV_Categoria);
            this.Controls.Add(this.txtB_NomeCateg);
            this.Controls.Add(this.txtB_CodCateg);
            this.Controls.Add(this.lbl_NomeCateg);
            this.Controls.Add(this.lbl_Codigo);
            this.Controls.Add(this.btn_Novo);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Salvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_CadCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Categoria";
            this.Load += new System.EventHandler(this.frm_CadCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Categoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Salvar;
        private Button btn_Excluir;
        private Button btn_Editar;
        private Button btn_Novo;
        private Label lbl_Codigo;
        private Label lbl_NomeCateg;
        private TextBox txtB_CodCateg;
        private TextBox txtB_NomeCateg;
        private DataGridView dGV_Categoria;
        private Button btn_Cancelar;
        private Label lbl_CliqueGrid;
    }
}