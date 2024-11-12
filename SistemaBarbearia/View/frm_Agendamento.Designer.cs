namespace SistemaBarbearia.View
{
    partial class frm_Agendamento
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
            this.cmB_Cliente = new System.Windows.Forms.ComboBox();
            this.cmB_Servico = new System.Windows.Forms.ComboBox();
            this.lbl_Cliente = new System.Windows.Forms.Label();
            this.lbl_Servico = new System.Windows.Forms.Label();
            this.dTP_Agendamento = new System.Windows.Forms.DateTimePicker();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.lbl_Data = new System.Windows.Forms.Label();
            this.btn_Agendar = new System.Windows.Forms.Button();
            this.lbl_Funcionario = new System.Windows.Forms.Label();
            this.cmB_Func = new System.Windows.Forms.ComboBox();
            this.dGV_Agendamentos = new System.Windows.Forms.DataGridView();
            this.lbl_Valor = new System.Windows.Forms.Label();
            this.lbl_Hora = new System.Windows.Forms.Label();
            this.cmB_Hora = new System.Windows.Forms.ComboBox();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.lbl_Codigo = new System.Windows.Forms.Label();
            this.txtB_Cod = new System.Windows.Forms.TextBox();
            this.btn_Atualizar = new System.Windows.Forms.Button();
            this.btn_NovoAgen = new System.Windows.Forms.Button();
            this.cmB_Valor = new System.Windows.Forms.ComboBox();
            this.lbl_CliqueGrid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Agendamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmB_Cliente
            // 
            this.cmB_Cliente.FormattingEnabled = true;
            this.cmB_Cliente.Location = new System.Drawing.Point(88, 99);
            this.cmB_Cliente.Name = "cmB_Cliente";
            this.cmB_Cliente.Size = new System.Drawing.Size(216, 23);
            this.cmB_Cliente.TabIndex = 0;
            // 
            // cmB_Servico
            // 
            this.cmB_Servico.FormattingEnabled = true;
            this.cmB_Servico.Location = new System.Drawing.Point(99, 154);
            this.cmB_Servico.Name = "cmB_Servico";
            this.cmB_Servico.Size = new System.Drawing.Size(211, 23);
            this.cmB_Servico.TabIndex = 2;
            this.cmB_Servico.SelectedValueChanged += new System.EventHandler(this.cmB_Servico_SelectedValueChanged);
            this.cmB_Servico.TextChanged += new System.EventHandler(this.cmB_Servico_TextChanged);
            // 
            // lbl_Cliente
            // 
            this.lbl_Cliente.AutoSize = true;
            this.lbl_Cliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Cliente.Location = new System.Drawing.Point(14, 98);
            this.lbl_Cliente.Name = "lbl_Cliente";
            this.lbl_Cliente.Size = new System.Drawing.Size(68, 19);
            this.lbl_Cliente.TabIndex = 5;
            this.lbl_Cliente.Text = "Cliente:";
            // 
            // lbl_Servico
            // 
            this.lbl_Servico.AutoSize = true;
            this.lbl_Servico.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Servico.Location = new System.Drawing.Point(20, 154);
            this.lbl_Servico.Name = "lbl_Servico";
            this.lbl_Servico.Size = new System.Drawing.Size(73, 19);
            this.lbl_Servico.TabIndex = 6;
            this.lbl_Servico.Text = "Serviço:";
            // 
            // dTP_Agendamento
            // 
            this.dTP_Agendamento.CustomFormat = "";
            this.dTP_Agendamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTP_Agendamento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dTP_Agendamento.Location = new System.Drawing.Point(211, 254);
            this.dTP_Agendamento.Name = "dTP_Agendamento";
            this.dTP_Agendamento.Size = new System.Drawing.Size(255, 23);
            this.dTP_Agendamento.TabIndex = 8;
            this.dTP_Agendamento.Value = new System.DateTime(2022, 10, 23, 10, 27, 0, 0);
            // 
            // btn_Novo
            // 
            this.btn_Novo.Location = new System.Drawing.Point(310, 99);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(75, 23);
            this.btn_Novo.TabIndex = 9;
            this.btn_Novo.Text = "Novo";
            this.btn_Novo.UseVisualStyleBackColor = true;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // lbl_Data
            // 
            this.lbl_Data.AutoSize = true;
            this.lbl_Data.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Data.Location = new System.Drawing.Point(20, 258);
            this.lbl_Data.Name = "lbl_Data";
            this.lbl_Data.Size = new System.Drawing.Size(183, 19);
            this.lbl_Data.TabIndex = 10;
            this.lbl_Data.Text = "Data do agendamento:";
            // 
            // btn_Agendar
            // 
            this.btn_Agendar.Location = new System.Drawing.Point(295, 397);
            this.btn_Agendar.Name = "btn_Agendar";
            this.btn_Agendar.Size = new System.Drawing.Size(156, 24);
            this.btn_Agendar.TabIndex = 12;
            this.btn_Agendar.Text = "Salvar";
            this.btn_Agendar.UseVisualStyleBackColor = true;
            this.btn_Agendar.Click += new System.EventHandler(this.btn_Agendar_Click);
            // 
            // lbl_Funcionario
            // 
            this.lbl_Funcionario.AutoSize = true;
            this.lbl_Funcionario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Funcionario.Location = new System.Drawing.Point(20, 205);
            this.lbl_Funcionario.Name = "lbl_Funcionario";
            this.lbl_Funcionario.Size = new System.Drawing.Size(107, 19);
            this.lbl_Funcionario.TabIndex = 33;
            this.lbl_Funcionario.Text = "Funcionário:";
            // 
            // cmB_Func
            // 
            this.cmB_Func.FormattingEnabled = true;
            this.cmB_Func.Location = new System.Drawing.Point(133, 205);
            this.cmB_Func.Name = "cmB_Func";
            this.cmB_Func.Size = new System.Drawing.Size(177, 23);
            this.cmB_Func.TabIndex = 34;
            // 
            // dGV_Agendamentos
            // 
            this.dGV_Agendamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Agendamentos.Location = new System.Drawing.Point(485, 42);
            this.dGV_Agendamentos.Name = "dGV_Agendamentos";
            this.dGV_Agendamentos.RowTemplate.Height = 25;
            this.dGV_Agendamentos.Size = new System.Drawing.Size(524, 407);
            this.dGV_Agendamentos.TabIndex = 38;
            this.dGV_Agendamentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_Agendamentos_CellClick);
            // 
            // lbl_Valor
            // 
            this.lbl_Valor.AutoSize = true;
            this.lbl_Valor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Valor.Location = new System.Drawing.Point(316, 135);
            this.lbl_Valor.Name = "lbl_Valor";
            this.lbl_Valor.Size = new System.Drawing.Size(44, 16);
            this.lbl_Valor.TabIndex = 40;
            this.lbl_Valor.Text = "Valor:";
            // 
            // lbl_Hora
            // 
            this.lbl_Hora.AutoSize = true;
            this.lbl_Hora.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Hora.Location = new System.Drawing.Point(20, 308);
            this.lbl_Hora.Name = "lbl_Hora";
            this.lbl_Hora.Size = new System.Drawing.Size(72, 19);
            this.lbl_Hora.TabIndex = 42;
            this.lbl_Hora.Text = "Horário:";
            // 
            // cmB_Hora
            // 
            this.cmB_Hora.FormattingEnabled = true;
            this.cmB_Hora.Items.AddRange(new object[] {
            "07:00",
            "07:30",
            "08:00",
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00"});
            this.cmB_Hora.Location = new System.Drawing.Point(94, 308);
            this.cmB_Hora.Name = "cmB_Hora";
            this.cmB_Hora.Size = new System.Drawing.Size(121, 23);
            this.cmB_Hora.TabIndex = 43;
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(20, 426);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(156, 23);
            this.btn_Excluir.TabIndex = 45;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(20, 397);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(156, 23);
            this.btn_Editar.TabIndex = 46;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(295, 426);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(156, 23);
            this.btn_Cancelar.TabIndex = 47;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // lbl_Codigo
            // 
            this.lbl_Codigo.AutoSize = true;
            this.lbl_Codigo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Codigo.Location = new System.Drawing.Point(12, 25);
            this.lbl_Codigo.Name = "lbl_Codigo";
            this.lbl_Codigo.Size = new System.Drawing.Size(71, 19);
            this.lbl_Codigo.TabIndex = 48;
            this.lbl_Codigo.Text = "Codigo:";
            // 
            // txtB_Cod
            // 
            this.txtB_Cod.Location = new System.Drawing.Point(86, 25);
            this.txtB_Cod.Name = "txtB_Cod";
            this.txtB_Cod.ReadOnly = true;
            this.txtB_Cod.Size = new System.Drawing.Size(80, 23);
            this.txtB_Cod.TabIndex = 49;
            // 
            // btn_Atualizar
            // 
            this.btn_Atualizar.Location = new System.Drawing.Point(391, 99);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(75, 23);
            this.btn_Atualizar.TabIndex = 50;
            this.btn_Atualizar.Text = "Atualizar";
            this.btn_Atualizar.UseVisualStyleBackColor = true;
            this.btn_Atualizar.Click += new System.EventHandler(this.btn_Atualizar_Click);
            // 
            // btn_NovoAgen
            // 
            this.btn_NovoAgen.Location = new System.Drawing.Point(20, 368);
            this.btn_NovoAgen.Name = "btn_NovoAgen";
            this.btn_NovoAgen.Size = new System.Drawing.Size(156, 23);
            this.btn_NovoAgen.TabIndex = 52;
            this.btn_NovoAgen.Text = "Agendar";
            this.btn_NovoAgen.UseVisualStyleBackColor = true;
            this.btn_NovoAgen.Click += new System.EventHandler(this.btn_NovoAgen_Click);
            // 
            // cmB_Valor
            // 
            this.cmB_Valor.FormattingEnabled = true;
            this.cmB_Valor.Location = new System.Drawing.Point(316, 154);
            this.cmB_Valor.Name = "cmB_Valor";
            this.cmB_Valor.Size = new System.Drawing.Size(44, 23);
            this.cmB_Valor.TabIndex = 53;
            // 
            // lbl_CliqueGrid
            // 
            this.lbl_CliqueGrid.AutoSize = true;
            this.lbl_CliqueGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_CliqueGrid.ForeColor = System.Drawing.Color.Red;
            this.lbl_CliqueGrid.Location = new System.Drawing.Point(510, 9);
            this.lbl_CliqueGrid.Name = "lbl_CliqueGrid";
            this.lbl_CliqueGrid.Size = new System.Drawing.Size(482, 20);
            this.lbl_CliqueGrid.TabIndex = 55;
            this.lbl_CliqueGrid.Text = "Clique no código do agendamento que deseja editar/excluir";
            this.lbl_CliqueGrid.Click += new System.EventHandler(this.lbl_CliqueGrid_Click);
            // 
            // frm_Agendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 464);
            this.Controls.Add(this.lbl_CliqueGrid);
            this.Controls.Add(this.cmB_Valor);
            this.Controls.Add(this.btn_NovoAgen);
            this.Controls.Add(this.btn_Atualizar);
            this.Controls.Add(this.txtB_Cod);
            this.Controls.Add(this.lbl_Codigo);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.cmB_Hora);
            this.Controls.Add(this.lbl_Hora);
            this.Controls.Add(this.lbl_Valor);
            this.Controls.Add(this.dGV_Agendamentos);
            this.Controls.Add(this.cmB_Func);
            this.Controls.Add(this.lbl_Funcionario);
            this.Controls.Add(this.btn_Agendar);
            this.Controls.Add(this.lbl_Data);
            this.Controls.Add(this.btn_Novo);
            this.Controls.Add(this.dTP_Agendamento);
            this.Controls.Add(this.lbl_Servico);
            this.Controls.Add(this.lbl_Cliente);
            this.Controls.Add(this.cmB_Servico);
            this.Controls.Add(this.cmB_Cliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Agendamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendamento";
            this.Load += new System.EventHandler(this.frm_Agendamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Agendamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmB_Cliente;
        private ComboBox cmB_Servico;
        private Label lbl_Cliente;
        private Label lbl_Servico;
        private DateTimePicker dTP_Agendamento;
        private Button btn_Novo;
        private Label lbl_Data;
        private Button btn_Agendar;
        private ListView listView1;
        private ColumnHeader manha;
        private Label lbl_Funcionario;
        private ComboBox cmB_Func;
        private DataGridView dGV_Agendamentos;
        private Label lbl_Valor;
        private Label lbl_Hora;
        private ComboBox cmB_Hora;
        private Button btn_Excluir;
        private Button btn_Editar;
        private Button btn_Cancelar;
        private Label lbl_Codigo;
        private TextBox txtB_Cod;
        private Button btn_Atualizar;
        private Button btn_NovoAgen;
        private ComboBox cmB_Valor;
        private Label lbl_CliqueGrid;
    }
}