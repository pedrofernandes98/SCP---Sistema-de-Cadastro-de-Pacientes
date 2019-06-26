namespace PHF_SCP
{
    partial class frmEditarConsulta
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
            this.lblNovaData = new System.Windows.Forms.Label();
            this.dtpNovaData = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNovaData
            // 
            this.lblNovaData.AutoSize = true;
            this.lblNovaData.Location = new System.Drawing.Point(32, 40);
            this.lblNovaData.Name = "lblNovaData";
            this.lblNovaData.Size = new System.Drawing.Size(62, 13);
            this.lblNovaData.TabIndex = 0;
            this.lblNovaData.Text = "Nova Data:";
            // 
            // dtpNovaData
            // 
            this.dtpNovaData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNovaData.Location = new System.Drawing.Point(125, 34);
            this.dtpNovaData.Name = "dtpNovaData";
            this.dtpNovaData.Size = new System.Drawing.Size(109, 20);
            this.dtpNovaData.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Novo Horario:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(125, 74);
            this.maskedTextBox1.Mask = "00:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 3;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(89, 123);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(117, 35);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // frmEditarConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 182);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpNovaData);
            this.Controls.Add(this.lblNovaData);
            this.Name = "frmEditarConsulta";
            this.Text = "EditarConsulta";
            this.Load += new System.EventHandler(this.frmEditarConsulta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNovaData;
        private System.Windows.Forms.DateTimePicker dtpNovaData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button btnEditar;
    }
}