namespace SistemaBarbearia.View
{
    partial class frm_BuscaAgendamentos
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
            this.dGV_BuscarAgenda = new System.Windows.Forms.DataGridView();
            this.dTP_Buscar = new System.Windows.Forms.DateTimePicker();
            this.lbl_Data = new System.Windows.Forms.Label();
            this.btn_BuscarClie = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.lbl_Cliente = new System.Windows.Forms.Label();
            this.cmB_Cliente = new System.Windows.Forms.ComboBox();
            this.cmB_Func = new System.Windows.Forms.ComboBox();
            this.lbl_Func = new System.Windows.Forms.Label();
            this.lbl_Serv = new System.Windows.Forms.Label();
            this.cmB_Serv = new System.Windows.Forms.ComboBox();
            this.cmB_Horario = new System.Windows.Forms.ComboBox();
            this.lbl_Hora = new System.Windows.Forms.Label();
            this.btn_Completa = new System.Windows.Forms.Button();
            this.btn_BuscarDt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_BuscarAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV_BuscarAgenda
            // 
            this.dGV_BuscarAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_BuscarAgenda.Location = new System.Drawing.Point(477, 12);
            this.dGV_BuscarAgenda.Name = "dGV_BuscarAgenda";
            this.dGV_BuscarAgenda.ReadOnly = true;
            this.dGV_BuscarAgenda.Size = new System.Drawing.Size(610, 353);
            this.dGV_BuscarAgenda.TabIndex = 0;
            // 
            // dTP_Buscar
            // 
            this.dTP_Buscar.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dTP_Buscar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTP_Buscar.Location = new System.Drawing.Point(337, 191);
            this.dTP_Buscar.Name = "dTP_Buscar";
            this.dTP_Buscar.Size = new System.Drawing.Size(117, 23);
            this.dTP_Buscar.TabIndex = 1;
            // 
            // lbl_Data
            // 
            this.lbl_Data.AutoSize = true;
            this.lbl_Data.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Data.Location = new System.Drawing.Point(12, 191);
            this.lbl_Data.Name = "lbl_Data";
            this.lbl_Data.Size = new System.Drawing.Size(319, 23);
            this.lbl_Data.TabIndex = 3;
            this.lbl_Data.Text = "Selecione a Data do agendamento:";
            // 
            // btn_BuscarClie
            // 
            this.btn_BuscarClie.Location = new System.Drawing.Point(12, 342);
            this.btn_BuscarClie.Name = "btn_BuscarClie";
            this.btn_BuscarClie.Size = new System.Drawing.Size(102, 23);
            this.btn_BuscarClie.TabIndex = 5;
            this.btn_BuscarClie.Text = "Buscar";
            this.btn_BuscarClie.UseVisualStyleBackColor = true;
            this.btn_BuscarClie.Click += new System.EventHandler(this.btn_BuscarClie_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(337, 342);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(117, 23);
            this.btn_Cancelar.TabIndex = 6;
            this.btn_Cancelar.Text = "Mostrar Todos";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // lbl_Cliente
            // 
            this.lbl_Cliente.AutoSize = true;
            this.lbl_Cliente.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Cliente.Location = new System.Drawing.Point(12, 46);
            this.lbl_Cliente.Name = "lbl_Cliente";
            this.lbl_Cliente.Size = new System.Drawing.Size(186, 23);
            this.lbl_Cliente.TabIndex = 8;
            this.lbl_Cliente.Text = "Selecione o Cliente:";
            // 
            // cmB_Cliente
            // 
            this.cmB_Cliente.FormattingEnabled = true;
            this.cmB_Cliente.Location = new System.Drawing.Point(207, 46);
            this.cmB_Cliente.Name = "cmB_Cliente";
            this.cmB_Cliente.Size = new System.Drawing.Size(194, 23);
            this.cmB_Cliente.TabIndex = 9;
            // 
            // cmB_Func
            // 
            this.cmB_Func.FormattingEnabled = true;
            this.cmB_Func.Location = new System.Drawing.Point(241, 139);
            this.cmB_Func.Name = "cmB_Func";
            this.cmB_Func.Size = new System.Drawing.Size(170, 23);
            this.cmB_Func.TabIndex = 11;
            // 
            // lbl_Func
            // 
            this.lbl_Func.AutoSize = true;
            this.lbl_Func.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Func.Location = new System.Drawing.Point(12, 139);
            this.lbl_Func.Name = "lbl_Func";
            this.lbl_Func.Size = new System.Drawing.Size(229, 23);
            this.lbl_Func.TabIndex = 12;
            this.lbl_Func.Text = "Selecione o Funcionário:";
            // 
            // lbl_Serv
            // 
            this.lbl_Serv.AutoSize = true;
            this.lbl_Serv.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Serv.Location = new System.Drawing.Point(12, 95);
            this.lbl_Serv.Name = "lbl_Serv";
            this.lbl_Serv.Size = new System.Drawing.Size(192, 23);
            this.lbl_Serv.TabIndex = 14;
            this.lbl_Serv.Text = "Selecione o Serviço:";
            // 
            // cmB_Serv
            // 
            this.cmB_Serv.FormattingEnabled = true;
            this.cmB_Serv.Location = new System.Drawing.Point(207, 95);
            this.cmB_Serv.Name = "cmB_Serv";
            this.cmB_Serv.Size = new System.Drawing.Size(194, 23);
            this.cmB_Serv.TabIndex = 15;
            // 
            // cmB_Horario
            // 
            this.cmB_Horario.FormattingEnabled = true;
            this.cmB_Horario.Items.AddRange(new object[] {
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
            this.cmB_Horario.Location = new System.Drawing.Point(213, 230);
            this.cmB_Horario.Name = "cmB_Horario";
            this.cmB_Horario.Size = new System.Drawing.Size(118, 23);
            this.cmB_Horario.TabIndex = 16;
            // 
            // lbl_Hora
            // 
            this.lbl_Hora.AutoSize = true;
            this.lbl_Hora.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Hora.Location = new System.Drawing.Point(12, 230);
            this.lbl_Hora.Name = "lbl_Hora";
            this.lbl_Hora.Size = new System.Drawing.Size(189, 23);
            this.lbl_Hora.TabIndex = 17;
            this.lbl_Hora.Text = "Selecione o Horário:";
            // 
            // btn_Completa
            // 
            this.btn_Completa.Location = new System.Drawing.Point(12, 342);
            this.btn_Completa.Name = "btn_Completa";
            this.btn_Completa.Size = new System.Drawing.Size(102, 23);
            this.btn_Completa.TabIndex = 22;
            this.btn_Completa.Text = "Buscar";
            this.btn_Completa.UseVisualStyleBackColor = true;
            this.btn_Completa.Click += new System.EventHandler(this.btn_Completa_Click);
            // 
            // btn_BuscarDt
            // 
            this.btn_BuscarDt.Location = new System.Drawing.Point(12, 342);
            this.btn_BuscarDt.Name = "btn_BuscarDt";
            this.btn_BuscarDt.Size = new System.Drawing.Size(102, 23);
            this.btn_BuscarDt.TabIndex = 23;
            this.btn_BuscarDt.Text = "Buscar";
            this.btn_BuscarDt.UseVisualStyleBackColor = true;
            this.btn_BuscarDt.Click += new System.EventHandler(this.btn_BuscarComp_Click);
            // 
            // frm_BuscaAgendamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 377);
            this.Controls.Add(this.btn_BuscarDt);
            this.Controls.Add(this.btn_Completa);
            this.Controls.Add(this.lbl_Hora);
            this.Controls.Add(this.cmB_Horario);
            this.Controls.Add(this.cmB_Serv);
            this.Controls.Add(this.lbl_Serv);
            this.Controls.Add(this.lbl_Func);
            this.Controls.Add(this.cmB_Func);
            this.Controls.Add(this.cmB_Cliente);
            this.Controls.Add(this.lbl_Cliente);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_BuscarClie);
            this.Controls.Add(this.lbl_Data);
            this.Controls.Add(this.dTP_Buscar);
            this.Controls.Add(this.dGV_BuscarAgenda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_BuscaAgendamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BUSCAR AGENDAMENTOS";
            this.Load += new System.EventHandler(this.frm_Busca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_BuscarAgenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dGV_BuscarAgenda;
        private DateTimePicker dTP_Buscar;
        private Label lbl_Data;
        private Button btn_BuscarClie;
        private Button btn_Cancelar;
        private Label lbl_Cliente;
        private ComboBox cmB_Cliente;
        private ComboBox cmB_Func;
        private Label lbl_Func;
        private Label lbl_Serv;
        private ComboBox cmB_Serv;
        private ComboBox cmB_Horario;
        private Label lbl_Hora;
        private Button btn_Completa;
        private Button btn_BuscarDt;
    }
}