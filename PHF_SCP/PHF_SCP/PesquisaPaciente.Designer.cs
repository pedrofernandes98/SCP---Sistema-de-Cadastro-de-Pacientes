namespace PHF_SCP
{
    partial class frmPesquisaPaciente
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
            this.rbrCod = new System.Windows.Forms.RadioButton();
            this.rbrCPF = new System.Windows.Forms.RadioButton();
            this.rbrNome = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.dgvPesquisa = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnListarTodos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // rbrCod
            // 
            this.rbrCod.AutoSize = true;
            this.rbrCod.Location = new System.Drawing.Point(20, 29);
            this.rbrCod.Name = "rbrCod";
            this.rbrCod.Size = new System.Drawing.Size(58, 17);
            this.rbrCod.TabIndex = 0;
            this.rbrCod.TabStop = true;
            this.rbrCod.Text = "Código";
            this.rbrCod.UseVisualStyleBackColor = true;
            // 
            // rbrCPF
            // 
            this.rbrCPF.AutoSize = true;
            this.rbrCPF.Location = new System.Drawing.Point(96, 29);
            this.rbrCPF.Name = "rbrCPF";
            this.rbrCPF.Size = new System.Drawing.Size(45, 17);
            this.rbrCPF.TabIndex = 0;
            this.rbrCPF.TabStop = true;
            this.rbrCPF.Text = "CPF";
            this.rbrCPF.UseVisualStyleBackColor = true;
            // 
            // rbrNome
            // 
            this.rbrNome.AutoSize = true;
            this.rbrNome.Location = new System.Drawing.Point(160, 29);
            this.rbrNome.Name = "rbrNome";
            this.rbrNome.Size = new System.Drawing.Size(53, 17);
            this.rbrNome.TabIndex = 0;
            this.rbrNome.TabStop = true;
            this.rbrNome.Text = "Nome";
            this.rbrNome.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPesquisa);
            this.groupBox1.Controls.Add(this.rbrNome);
            this.groupBox1.Controls.Add(this.rbrCod);
            this.groupBox1.Controls.Add(this.rbrCPF);
            this.groupBox1.Location = new System.Drawing.Point(34, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 69);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Pesquisa";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(266, 28);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(287, 20);
            this.txtPesquisa.TabIndex = 1;
            // 
            // dgvPesquisa
            // 
            this.dgvPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisa.Location = new System.Drawing.Point(34, 121);
            this.dgvPesquisa.Name = "dgvPesquisa";
            this.dgvPesquisa.Size = new System.Drawing.Size(567, 160);
            this.dgvPesquisa.TabIndex = 2;
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(619, 121);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(67, 25);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(619, 152);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(67, 23);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(619, 46);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnListarTodos
            // 
            this.btnListarTodos.Location = new System.Drawing.Point(619, 80);
            this.btnListarTodos.Name = "btnListarTodos";
            this.btnListarTodos.Size = new System.Drawing.Size(75, 23);
            this.btnListarTodos.TabIndex = 6;
            this.btnListarTodos.Text = "Listar Todos";
            this.btnListarTodos.UseVisualStyleBackColor = true;
            this.btnListarTodos.Click += new System.EventHandler(this.btnListarTodos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(616, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 65);
            this.label1.TabIndex = 7;
            this.label1.Text = "OBS: Para fazer \r\nedições e exclusões\r\ndeve-se primeiro \r\nrealizar a pesquisa \r\nd" +
    "o registro desejado.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmPesquisaPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 359);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnListarTodos);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgvPesquisa);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPesquisaPaciente";
            this.Text = "Pesquisa";
            this.Load += new System.EventHandler(this.frmPesquisaPaciente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbrCod;
        private System.Windows.Forms.RadioButton rbrCPF;
        private System.Windows.Forms.RadioButton rbrNome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.DataGridView dgvPesquisa;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnListarTodos;
        private System.Windows.Forms.Label label1;
    }
}