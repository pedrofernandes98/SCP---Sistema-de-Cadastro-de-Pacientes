namespace PHF_SCP
{
    partial class frmPesquisaMedico
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.rbrNome = new System.Windows.Forms.RadioButton();
            this.rbrCRM = new System.Windows.Forms.RadioButton();
            this.rbrCodigo = new System.Windows.Forms.RadioButton();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dgvPesquisa = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnListarTodos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPesquisa);
            this.groupBox1.Controls.Add(this.rbrNome);
            this.groupBox1.Controls.Add(this.rbrCRM);
            this.groupBox1.Controls.Add(this.rbrCodigo);
            this.groupBox1.Location = new System.Drawing.Point(34, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Pesquisa";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(263, 35);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(263, 20);
            this.txtPesquisa.TabIndex = 3;
            // 
            // rbrNome
            // 
            this.rbrNome.AutoSize = true;
            this.rbrNome.Location = new System.Drawing.Point(168, 35);
            this.rbrNome.Name = "rbrNome";
            this.rbrNome.Size = new System.Drawing.Size(53, 17);
            this.rbrNome.TabIndex = 0;
            this.rbrNome.TabStop = true;
            this.rbrNome.Text = "Nome";
            this.rbrNome.UseVisualStyleBackColor = true;
            // 
            // rbrCRM
            // 
            this.rbrCRM.AutoSize = true;
            this.rbrCRM.Location = new System.Drawing.Point(102, 35);
            this.rbrCRM.Name = "rbrCRM";
            this.rbrCRM.Size = new System.Drawing.Size(49, 17);
            this.rbrCRM.TabIndex = 0;
            this.rbrCRM.TabStop = true;
            this.rbrCRM.Text = "CRM";
            this.rbrCRM.UseVisualStyleBackColor = true;
            // 
            // rbrCodigo
            // 
            this.rbrCodigo.AutoSize = true;
            this.rbrCodigo.Location = new System.Drawing.Point(27, 35);
            this.rbrCodigo.Name = "rbrCodigo";
            this.rbrCodigo.Size = new System.Drawing.Size(58, 17);
            this.rbrCodigo.TabIndex = 0;
            this.rbrCodigo.TabStop = true;
            this.rbrCodigo.Text = "Código";
            this.rbrCodigo.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(618, 49);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dgvPesquisa
            // 
            this.dgvPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisa.Location = new System.Drawing.Point(34, 130);
            this.dgvPesquisa.Name = "dgvPesquisa";
            this.dgvPesquisa.Size = new System.Drawing.Size(556, 173);
            this.dgvPesquisa.TabIndex = 2;
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(618, 130);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(618, 176);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnListarTodos
            // 
            this.btnListarTodos.Location = new System.Drawing.Point(618, 87);
            this.btnListarTodos.Name = "btnListarTodos";
            this.btnListarTodos.Size = new System.Drawing.Size(75, 23);
            this.btnListarTodos.TabIndex = 5;
            this.btnListarTodos.Text = "Listar Todos";
            this.btnListarTodos.UseVisualStyleBackColor = true;
            this.btnListarTodos.Click += new System.EventHandler(this.btnListarTodos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(605, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 65);
            this.label1.TabIndex = 6;
            this.label1.Text = "OBS: Para fazer \r\nedições e exclusões\r\ndeve-se primeiro \r\nrealizar a pesquisa \r\nd" +
    "o registro desejado.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmPesquisaMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 355);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnListarTodos);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgvPesquisa);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPesquisaMedico";
            this.Text = "PesquisaMedico";
            this.Load += new System.EventHandler(this.frmPesquisaMedico_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.RadioButton rbrNome;
        private System.Windows.Forms.RadioButton rbrCRM;
        private System.Windows.Forms.RadioButton rbrCodigo;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dgvPesquisa;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnListarTodos;
        private System.Windows.Forms.Label label1;
    }
}