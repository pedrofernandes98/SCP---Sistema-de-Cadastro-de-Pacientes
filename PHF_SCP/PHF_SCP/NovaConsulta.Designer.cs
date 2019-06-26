namespace PHF_SCP
{
    partial class NovaConsulta
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
            this.lblCodPaciente = new System.Windows.Forms.Label();
            this.txtCodPaciente = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblMedico = new System.Windows.Forms.Label();
            this.txtCodMedico = new System.Windows.Forms.TextBox();
            this.btnListaMedicos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCodPaciente
            // 
            this.lblCodPaciente.AutoSize = true;
            this.lblCodPaciente.Location = new System.Drawing.Point(23, 28);
            this.lblCodPaciente.Name = "lblCodPaciente";
            this.lblCodPaciente.Size = new System.Drawing.Size(103, 13);
            this.lblCodPaciente.TabIndex = 0;
            this.lblCodPaciente.Text = "Código do Paciente:";
            // 
            // txtCodPaciente
            // 
            this.txtCodPaciente.Location = new System.Drawing.Point(147, 25);
            this.txtCodPaciente.Name = "txtCodPaciente";
            this.txtCodPaciente.Size = new System.Drawing.Size(100, 20);
            this.txtCodPaciente.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(280, 23);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(128, 23);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Lista de Pacientes";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.Location = new System.Drawing.Point(23, 70);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new System.Drawing.Size(96, 13);
            this.lblMedico.TabIndex = 3;
            this.lblMedico.Text = "Código do Médico:";
            // 
            // txtCodMedico
            // 
            this.txtCodMedico.Location = new System.Drawing.Point(147, 67);
            this.txtCodMedico.Name = "txtCodMedico";
            this.txtCodMedico.Size = new System.Drawing.Size(100, 20);
            this.txtCodMedico.TabIndex = 4;
            // 
            // btnListaMedicos
            // 
            this.btnListaMedicos.Location = new System.Drawing.Point(280, 65);
            this.btnListaMedicos.Name = "btnListaMedicos";
            this.btnListaMedicos.Size = new System.Drawing.Size(128, 23);
            this.btnListaMedicos.TabIndex = 5;
            this.btnListaMedicos.Text = "Lista de Médicos";
            this.btnListaMedicos.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Data da Consulta:";
            // 
            // NovaConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 360);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnListaMedicos);
            this.Controls.Add(this.txtCodMedico);
            this.Controls.Add(this.lblMedico);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtCodPaciente);
            this.Controls.Add(this.lblCodPaciente);
            this.Name = "NovaConsulta";
            this.Text = "Código do Médico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodPaciente;
        private System.Windows.Forms.TextBox txtCodPaciente;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.TextBox txtCodMedico;
        private System.Windows.Forms.Button btnListaMedicos;
        private System.Windows.Forms.Label label1;
    }
}