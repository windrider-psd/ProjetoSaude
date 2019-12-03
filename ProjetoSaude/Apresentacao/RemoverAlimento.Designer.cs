namespace ProjetoSaude.Apresentacao
{
    partial class RemoverAlimento
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
            this.selecaoAlimento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selecaoAlimento
            // 
            this.selecaoAlimento.FormattingEnabled = true;
            this.selecaoAlimento.Location = new System.Drawing.Point(51, 103);
            this.selecaoAlimento.Name = "selecaoAlimento";
            this.selecaoAlimento.Size = new System.Drawing.Size(211, 21);
            this.selecaoAlimento.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alimento:";
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(119, 170);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 2;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.BtnRemover_Click);
            // 
            // RemoverAlimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 450);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selecaoAlimento);
            this.Name = "RemoverAlimento";
            this.Text = "RemoverAlimento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox selecaoAlimento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemover;
    }
}