namespace PHF_SCP
{
    partial class frmAgenda
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
            this.dgvConsultas = new System.Windows.Forms.DataGridView();
            this.lblAgenda = new System.Windows.Forms.Label();
            this.lblDataAgenda = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCodPaciente = new System.Windows.Forms.Label();
            this.txtCodPaciente = new System.Windows.Forms.TextBox();
            this.btnPesquisaPaciente = new System.Windows.Forms.Button();
            this.lblCodMedico = new System.Windows.Forms.Label();
            this.txtCodMedico = new System.Windows.Forms.TextBox();
            this.btnListarMedicos = new System.Windows.Forms.Button();
            this.lblDataConsulta = new System.Windows.Forms.Label();
            this.dtpNovaConsulta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.mtbHorario = new System.Windows.Forms.MaskedTextBox();
            this.txtCodEdit = new System.Windows.Forms.TextBox();
            this.btnAgendaCompleta = new System.Windows.Forms.GroupBox();
            this.lblCodPesExc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgCompleta = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPesqCod = new System.Windows.Forms.TextBox();
            this.rbrPaciente = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.btnAgendaCompleta.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvConsultas
            // 
            this.dgvConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultas.Location = new System.Drawing.Point(23, 79);
            this.dgvConsultas.Name = "dgvConsultas";
            this.dgvConsultas.Size = new System.Drawing.Size(567, 280);
            this.dgvConsultas.TabIndex = 0;
            // 
            // lblAgenda
            // 
            this.lblAgenda.AutoSize = true;
            this.lblAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgenda.Location = new System.Drawing.Point(23, 32);
            this.lblAgenda.Name = "lblAgenda";
            this.lblAgenda.Size = new System.Drawing.Size(162, 24);
            this.lblAgenda.TabIndex = 2;
            this.lblAgenda.Text = "Agenda Completa";
            // 
            // lblDataAgenda
            // 
            this.lblDataAgenda.AutoSize = true;
            this.lblDataAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataAgenda.Location = new System.Drawing.Point(197, 31);
            this.lblDataAgenda.Name = "lblDataAgenda";
            this.lblDataAgenda.Size = new System.Drawing.Size(0, 20);
            this.lblDataAgenda.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(615, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Nova Consulta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(35, 72);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 22);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar Consulta";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(35, 100);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 27);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir Consulta";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(459, 32);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(131, 20);
            this.dtpData.TabIndex = 8;
            this.dtpData.ValueChanged += new System.EventHandler(this.dtpData_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtbHorario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpNovaConsulta);
            this.groupBox1.Controls.Add(this.lblDataConsulta);
            this.groupBox1.Controls.Add(this.btnListarMedicos);
            this.groupBox1.Controls.Add(this.txtCodMedico);
            this.groupBox1.Controls.Add(this.lblCodMedico);
            this.groupBox1.Controls.Add(this.btnPesquisaPaciente);
            this.groupBox1.Controls.Add(this.txtCodPaciente);
            this.groupBox1.Controls.Add(this.lblCodPaciente);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(27, 373);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(740, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agendar Nova Consulta";
            // 
            // lblCodPaciente
            // 
            this.lblCodPaciente.AutoSize = true;
            this.lblCodPaciente.Location = new System.Drawing.Point(22, 27);
            this.lblCodPaciente.Name = "lblCodPaciente";
            this.lblCodPaciente.Size = new System.Drawing.Size(103, 13);
            this.lblCodPaciente.TabIndex = 6;
            this.lblCodPaciente.Text = "Código do Paciente:";
            // 
            // txtCodPaciente
            // 
            this.txtCodPaciente.Location = new System.Drawing.Point(131, 24);
            this.txtCodPaciente.Name = "txtCodPaciente";
            this.txtCodPaciente.Size = new System.Drawing.Size(100, 20);
            this.txtCodPaciente.TabIndex = 7;
            // 
            // btnPesquisaPaciente
            // 
            this.btnPesquisaPaciente.Location = new System.Drawing.Point(237, 22);
            this.btnPesquisaPaciente.Name = "btnPesquisaPaciente";
            this.btnPesquisaPaciente.Size = new System.Drawing.Size(99, 23);
            this.btnPesquisaPaciente.TabIndex = 8;
            this.btnPesquisaPaciente.Text = "Listar Pacientes";
            this.btnPesquisaPaciente.UseVisualStyleBackColor = true;
            this.btnPesquisaPaciente.Click += new System.EventHandler(this.btnPesquisaPaciente_Click);
            // 
            // lblCodMedico
            // 
            this.lblCodMedico.AutoSize = true;
            this.lblCodMedico.Location = new System.Drawing.Point(22, 68);
            this.lblCodMedico.Name = "lblCodMedico";
            this.lblCodMedico.Size = new System.Drawing.Size(96, 13);
            this.lblCodMedico.TabIndex = 9;
            this.lblCodMedico.Text = "Código do Médico:";
            // 
            // txtCodMedico
            // 
            this.txtCodMedico.Location = new System.Drawing.Point(131, 65);
            this.txtCodMedico.Name = "txtCodMedico";
            this.txtCodMedico.Size = new System.Drawing.Size(100, 20);
            this.txtCodMedico.TabIndex = 10;
            // 
            // btnListarMedicos
            // 
            this.btnListarMedicos.Location = new System.Drawing.Point(237, 63);
            this.btnListarMedicos.Name = "btnListarMedicos";
            this.btnListarMedicos.Size = new System.Drawing.Size(99, 23);
            this.btnListarMedicos.TabIndex = 11;
            this.btnListarMedicos.Text = "Listar Médicos";
            this.btnListarMedicos.UseVisualStyleBackColor = true;
            this.btnListarMedicos.Click += new System.EventHandler(this.btnListarMedicos_Click);
            // 
            // lblDataConsulta
            // 
            this.lblDataConsulta.AutoSize = true;
            this.lblDataConsulta.Location = new System.Drawing.Point(351, 27);
            this.lblDataConsulta.Name = "lblDataConsulta";
            this.lblDataConsulta.Size = new System.Drawing.Size(92, 13);
            this.lblDataConsulta.TabIndex = 12;
            this.lblDataConsulta.Text = "Data da Consulta:";
            // 
            // dtpNovaConsulta
            // 
            this.dtpNovaConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNovaConsulta.Location = new System.Drawing.Point(449, 24);
            this.dtpNovaConsulta.Name = "dtpNovaConsulta";
            this.dtpNovaConsulta.Size = new System.Drawing.Size(100, 20);
            this.dtpNovaConsulta.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Horário da Consulta:";
            // 
            // mtbHorario
            // 
            this.mtbHorario.Location = new System.Drawing.Point(476, 61);
            this.mtbHorario.Mask = "00:00";
            this.mtbHorario.Name = "mtbHorario";
            this.mtbHorario.Size = new System.Drawing.Size(73, 20);
            this.mtbHorario.TabIndex = 15;
            this.mtbHorario.ValidatingType = typeof(System.DateTime);
            // 
            // txtCodEdit
            // 
            this.txtCodEdit.Location = new System.Drawing.Point(35, 46);
            this.txtCodEdit.Name = "txtCodEdit";
            this.txtCodEdit.Size = new System.Drawing.Size(100, 20);
            this.txtCodEdit.TabIndex = 10;
            // 
            // btnAgendaCompleta
            // 
            this.btnAgendaCompleta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAgendaCompleta.Controls.Add(this.lblCodPesExc);
            this.btnAgendaCompleta.Controls.Add(this.btnExcluir);
            this.btnAgendaCompleta.Controls.Add(this.txtCodEdit);
            this.btnAgendaCompleta.Controls.Add(this.btnEditar);
            this.btnAgendaCompleta.Location = new System.Drawing.Point(607, 226);
            this.btnAgendaCompleta.Name = "btnAgendaCompleta";
            this.btnAgendaCompleta.Size = new System.Drawing.Size(160, 141);
            this.btnAgendaCompleta.TabIndex = 11;
            this.btnAgendaCompleta.TabStop = false;
            this.btnAgendaCompleta.Text = "Edição e Exclusão";
            // 
            // lblCodPesExc
            // 
            this.lblCodPesExc.AutoSize = true;
            this.lblCodPesExc.Location = new System.Drawing.Point(63, 30);
            this.lblCodPesExc.Name = "lblCodPesExc";
            this.lblCodPesExc.Size = new System.Drawing.Size(40, 13);
            this.lblCodPesExc.TabIndex = 11;
            this.lblCodPesExc.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Escolha um dia para pesquisar:";
            // 
            // btnAgCompleta
            // 
            this.btnAgCompleta.Location = new System.Drawing.Point(617, 16);
            this.btnAgCompleta.Name = "btnAgCompleta";
            this.btnAgCompleta.Size = new System.Drawing.Size(127, 40);
            this.btnAgCompleta.TabIndex = 13;
            this.btnAgCompleta.Text = "AgendaCompleta";
            this.btnAgCompleta.UseVisualStyleBackColor = true;
            this.btnAgCompleta.Click += new System.EventHandler(this.btnAgCompleta_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPesquisar);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.rbrPaciente);
            this.groupBox2.Controls.Add(this.txtPesqCod);
            this.groupBox2.Location = new System.Drawing.Point(607, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 141);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pesquisa por Código";
            // 
            // txtPesqCod
            // 
            this.txtPesqCod.Location = new System.Drawing.Point(35, 58);
            this.txtPesqCod.Name = "txtPesqCod";
            this.txtPesqCod.Size = new System.Drawing.Size(100, 20);
            this.txtPesqCod.TabIndex = 0;
            // 
            // rbrPaciente
            // 
            this.rbrPaciente.AutoSize = true;
            this.rbrPaciente.Location = new System.Drawing.Point(10, 25);
            this.rbrPaciente.Name = "rbrPaciente";
            this.rbrPaciente.Size = new System.Drawing.Size(67, 17);
            this.rbrPaciente.TabIndex = 1;
            this.rbrPaciente.TabStop = true;
            this.rbrPaciente.Text = "Paciente";
            this.rbrPaciente.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(94, 25);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(60, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Médico";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(35, 84);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 23);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // frmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 485);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnAgCompleta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAgendaCompleta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.lblDataAgenda);
            this.Controls.Add(this.lblAgenda);
            this.Controls.Add(this.dgvConsultas);
            this.Name = "frmAgenda";
            this.Text = "Pesquisar Código Paciente";
            this.Load += new System.EventHandler(this.Agenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.btnAgendaCompleta.ResumeLayout(false);
            this.btnAgendaCompleta.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultas;
        private System.Windows.Forms.Label lblAgenda;
        private System.Windows.Forms.Label lblDataAgenda;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNovaConsulta;
        private System.Windows.Forms.Label lblDataConsulta;
        private System.Windows.Forms.Button btnListarMedicos;
        private System.Windows.Forms.TextBox txtCodMedico;
        private System.Windows.Forms.Label lblCodMedico;
        private System.Windows.Forms.Button btnPesquisaPaciente;
        private System.Windows.Forms.TextBox txtCodPaciente;
        private System.Windows.Forms.Label lblCodPaciente;
        private System.Windows.Forms.MaskedTextBox mtbHorario;
        private System.Windows.Forms.TextBox txtCodEdit;
        private System.Windows.Forms.GroupBox btnAgendaCompleta;
        private System.Windows.Forms.Label lblCodPesExc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgCompleta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rbrPaciente;
        private System.Windows.Forms.TextBox txtPesqCod;
    }
}