namespace ProjetoSaude.Apresentacao
{
    partial class EditarAlimento
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.calorias = new System.Windows.Forms.NumericUpDown();
            this.quantidade = new System.Windows.Forms.NumericUpDown();
            this.medida = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.calorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(37, 75);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(226, 20);
            this.txtNome.TabIndex = 2;
            this.txtNome.TextChanged += new System.EventHandler(this.TxtNome_TextChanged);
            // 
            // calorias
            // 
            this.calorias.Location = new System.Drawing.Point(37, 120);
            this.calorias.Name = "calorias";
            this.calorias.Size = new System.Drawing.Size(226, 20);
            this.calorias.TabIndex = 3;
            this.calorias.ValueChanged += new System.EventHandler(this.Calorias_ValueChanged);
            // 
            // quantidade
            // 
            this.quantidade.Location = new System.Drawing.Point(37, 167);
            this.quantidade.Name = "quantidade";
            this.quantidade.Size = new System.Drawing.Size(226, 20);
            this.quantidade.TabIndex = 4;
            this.quantidade.ValueChanged += new System.EventHandler(this.Quantidade_ValueChanged);
            // 
            // medida
            // 
            this.medida.Location = new System.Drawing.Point(37, 217);
            this.medida.Name = "medida";
            this.medida.Size = new System.Drawing.Size(226, 20);
            this.medida.TabIndex = 5;
            this.medida.TextChanged += new System.EventHandler(this.Medida_TextChanged);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(108, 258);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Cadastrar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Calorias";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Quantidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Medida";
            // 
            // EditarAlimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 331);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.medida);
            this.Controls.Add(this.quantidade);
            this.Controls.Add(this.calorias);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "EditarAlimento";
            this.Text = "CadastroAlimento";
            ((System.ComponentModel.ISupportInitialize)(this.calorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.NumericUpDown calorias;
        private System.Windows.Forms.NumericUpDown quantidade;
        private System.Windows.Forms.TextBox medida;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}