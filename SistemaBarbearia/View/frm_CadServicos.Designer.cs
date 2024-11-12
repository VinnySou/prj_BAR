namespace SistemaBarbearia.View
{
    partial class frm_CadServicos
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
            this.btn_Novo = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.lbl_Cod = new System.Windows.Forms.Label();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.lbl_Categ = new System.Windows.Forms.Label();
            this.lbl_Preco = new System.Windows.Forms.Label();
            this.txtB_Cod = new System.Windows.Forms.TextBox();
            this.txtB_Nome = new System.Windows.Forms.TextBox();
            this.txtB_Preco = new System.Windows.Forms.TextBox();
            this.cmB_CategSer = new System.Windows.Forms.ComboBox();
            this.dGV_Servicos = new System.Windows.Forms.DataGridView();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.lbl_CliqueGrid = new System.Windows.Forms.Label();
            this.lbl_Servico = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Servicos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Novo
            // 
            this.btn_Novo.Location = new System.Drawing.Point(24, 314);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(75, 23);
            this.btn_Novo.TabIndex = 0;
            this.btn_Novo.Text = "Novo";
            this.btn_Novo.UseVisualStyleBackColor = true;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(24, 372);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_Excluir.TabIndex = 1;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(359, 357);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 2;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(24, 343);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(75, 23);
            this.btn_Editar.TabIndex = 3;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // lbl_Cod
            // 
            this.lbl_Cod.AutoSize = true;
            this.lbl_Cod.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Cod.Location = new System.Drawing.Point(12, 68);
            this.lbl_Cod.Name = "lbl_Cod";
            this.lbl_Cod.Size = new System.Drawing.Size(71, 19);
            this.lbl_Cod.TabIndex = 4;
            this.lbl_Cod.Text = "Código:";
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Nome.Location = new System.Drawing.Point(12, 119);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(148, 19);
            this.lbl_Nome.TabIndex = 5;
            this.lbl_Nome.Text = "Nome Do Serviço:";
            // 
            // lbl_Categ
            // 
            this.lbl_Categ.AutoSize = true;
            this.lbl_Categ.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Categ.Location = new System.Drawing.Point(12, 221);
            this.lbl_Categ.Name = "lbl_Categ";
            this.lbl_Categ.Size = new System.Drawing.Size(175, 19);
            this.lbl_Categ.TabIndex = 6;
            this.lbl_Categ.Text = "Categoria do Serviço:";
            // 
            // lbl_Preco
            // 
            this.lbl_Preco.AutoSize = true;
            this.lbl_Preco.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Preco.Location = new System.Drawing.Point(14, 168);
            this.lbl_Preco.Name = "lbl_Preco";
            this.lbl_Preco.Size = new System.Drawing.Size(146, 19);
            this.lbl_Preco.TabIndex = 7;
            this.lbl_Preco.Text = "Preço do Serviço:";
            // 
            // txtB_Cod
            // 
            this.txtB_Cod.Location = new System.Drawing.Point(87, 64);
            this.txtB_Cod.Name = "txtB_Cod";
            this.txtB_Cod.ReadOnly = true;
            this.txtB_Cod.Size = new System.Drawing.Size(73, 23);
            this.txtB_Cod.TabIndex = 8;
            // 
            // txtB_Nome
            // 
            this.txtB_Nome.Location = new System.Drawing.Point(166, 115);
            this.txtB_Nome.Name = "txtB_Nome";
            this.txtB_Nome.Size = new System.Drawing.Size(268, 23);
            this.txtB_Nome.TabIndex = 9;
            // 
            // txtB_Preco
            // 
            this.txtB_Preco.Location = new System.Drawing.Point(166, 168);
            this.txtB_Preco.Name = "txtB_Preco";
            this.txtB_Preco.Size = new System.Drawing.Size(90, 23);
            this.txtB_Preco.TabIndex = 10;
            // 
            // cmB_CategSer
            // 
            this.cmB_CategSer.FormattingEnabled = true;
            this.cmB_CategSer.Location = new System.Drawing.Point(193, 221);
            this.cmB_CategSer.Name = "cmB_CategSer";
            this.cmB_CategSer.Size = new System.Drawing.Size(241, 23);
            this.cmB_CategSer.TabIndex = 11;
            // 
            // dGV_Servicos
            // 
            this.dGV_Servicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Servicos.Location = new System.Drawing.Point(457, 52);
            this.dGV_Servicos.Name = "dGV_Servicos";
            this.dGV_Servicos.ReadOnly = true;
            this.dGV_Servicos.RowTemplate.Height = 25;
            this.dGV_Servicos.Size = new System.Drawing.Size(500, 343);
            this.dGV_Servicos.TabIndex = 12;
            this.dGV_Servicos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_Servicos_CellClick);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(359, 328);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_Salvar.TabIndex = 13;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // lbl_CliqueGrid
            // 
            this.lbl_CliqueGrid.AutoSize = true;
            this.lbl_CliqueGrid.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_CliqueGrid.ForeColor = System.Drawing.Color.Red;
            this.lbl_CliqueGrid.Location = new System.Drawing.Point(574, 9);
            this.lbl_CliqueGrid.Name = "lbl_CliqueGrid";
            this.lbl_CliqueGrid.Size = new System.Drawing.Size(275, 38);
            this.lbl_CliqueGrid.TabIndex = 14;
            this.lbl_CliqueGrid.Text = "CLIQUE NO CODIGO DO SERVICO \r\nQUE DESEJA EDITAR/EXCLUIR";
            this.lbl_CliqueGrid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Servico
            // 
            this.lbl_Servico.AutoSize = true;
            this.lbl_Servico.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Servico.ForeColor = System.Drawing.Color.Red;
            this.lbl_Servico.Location = new System.Drawing.Point(106, 25);
            this.lbl_Servico.Name = "lbl_Servico";
            this.lbl_Servico.Size = new System.Drawing.Size(172, 19);
            this.lbl_Servico.TabIndex = 15;
            this.lbl_Servico.Text = "DADOS DO SERVICO";
            this.lbl_Servico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_CadServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 407);
            this.Controls.Add(this.lbl_Servico);
            this.Controls.Add(this.lbl_CliqueGrid);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.dGV_Servicos);
            this.Controls.Add(this.cmB_CategSer);
            this.Controls.Add(this.txtB_Preco);
            this.Controls.Add(this.txtB_Nome);
            this.Controls.Add(this.txtB_Cod);
            this.Controls.Add(this.lbl_Preco);
            this.Controls.Add(this.lbl_Categ);
            this.Controls.Add(this.lbl_Nome);
            this.Controls.Add(this.lbl_Cod);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Novo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_CadServicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO DE SERVIÇOS";
            this.Load += new System.EventHandler(this.frm_CadServicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Servicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Novo;
        private Button btn_Excluir;
        private Button btn_Cancelar;
        private Button btn_Editar;
        private Label lbl_Cod;
        private Label lbl_Nome;
        private Label lbl_Categ;
        private Label lbl_Preco;
        private TextBox txtB_Cod;
        private TextBox txtB_Nome;
        private TextBox txtB_Preco;
        private ComboBox cmB_CategSer;
        private DataGridView dGV_Servicos;
        private Button btn_Salvar;
        private Label lbl_CliqueGrid;
        private Label lbl_Servico;
    }
}