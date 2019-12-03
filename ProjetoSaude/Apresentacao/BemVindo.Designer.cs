namespace ProjetoSaude.Apresentacao
{
    partial class BemVindo
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
            this.btnCalcularImc = new System.Windows.Forms.Button();
            this.cadAlimentos = new System.Windows.Forms.Button();
            this.btnRemoverAlimentos = new System.Windows.Forms.Button();
            this.btnControleCalorias = new System.Windows.Forms.Button();
            this.btnEditAlimentos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalcularImc
            // 
            this.btnCalcularImc.Location = new System.Drawing.Point(147, 47);
            this.btnCalcularImc.Name = "btnCalcularImc";
            this.btnCalcularImc.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularImc.TabIndex = 0;
            this.btnCalcularImc.Text = "Calcular IMC";
            this.btnCalcularImc.UseVisualStyleBackColor = true;
            this.btnCalcularImc.Click += new System.EventHandler(this.btnCalcularImc_Click);
            // 
            // cadAlimentos
            // 
            this.cadAlimentos.Location = new System.Drawing.Point(106, 106);
            this.cadAlimentos.Name = "cadAlimentos";
            this.cadAlimentos.Size = new System.Drawing.Size(155, 23);
            this.cadAlimentos.TabIndex = 3;
            this.cadAlimentos.Text = "Cadastrar Alimentos";
            this.cadAlimentos.UseVisualStyleBackColor = true;
            this.cadAlimentos.Click += new System.EventHandler(this.CadAlimentos_Click);
            // 
            // btnRemoverAlimentos
            // 
            this.btnRemoverAlimentos.Location = new System.Drawing.Point(106, 187);
            this.btnRemoverAlimentos.Name = "btnRemoverAlimentos";
            this.btnRemoverAlimentos.Size = new System.Drawing.Size(155, 23);
            this.btnRemoverAlimentos.TabIndex = 4;
            this.btnRemoverAlimentos.Text = "Remover Alimentos";
            this.btnRemoverAlimentos.UseVisualStyleBackColor = true;
            this.btnRemoverAlimentos.Click += new System.EventHandler(this.BtnRemoverAlimentos_Click);
            // 
            // btnControleCalorias
            // 
            this.btnControleCalorias.Location = new System.Drawing.Point(106, 230);
            this.btnControleCalorias.Name = "btnControleCalorias";
            this.btnControleCalorias.Size = new System.Drawing.Size(155, 23);
            this.btnControleCalorias.TabIndex = 5;
            this.btnControleCalorias.Text = "Controle de Calorias";
            this.btnControleCalorias.UseVisualStyleBackColor = true;
            this.btnControleCalorias.Click += new System.EventHandler(this.BtnControleCalorias_Click);
            // 
            // btnEditAlimentos
            // 
            this.btnEditAlimentos.Location = new System.Drawing.Point(106, 145);
            this.btnEditAlimentos.Name = "btnEditAlimentos";
            this.btnEditAlimentos.Size = new System.Drawing.Size(155, 23);
            this.btnEditAlimentos.TabIndex = 6;
            this.btnEditAlimentos.Text = "Editar Alimentos";
            this.btnEditAlimentos.UseVisualStyleBackColor = true;
            this.btnEditAlimentos.Click += new System.EventHandler(this.BtnEditAlimentos_Click);
            // 
            // BemVindo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 282);
            this.Controls.Add(this.btnEditAlimentos);
            this.Controls.Add(this.btnControleCalorias);
            this.Controls.Add(this.btnRemoverAlimentos);
            this.Controls.Add(this.cadAlimentos);
            this.Controls.Add(this.btnCalcularImc);
            this.Name = "BemVindo";
            this.Text = "Bem Vindo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalcularImc;
        private System.Windows.Forms.Button cadAlimentos;
        private System.Windows.Forms.Button btnRemoverAlimentos;
        private System.Windows.Forms.Button btnControleCalorias;
        private System.Windows.Forms.Button btnEditAlimentos;
    }
}