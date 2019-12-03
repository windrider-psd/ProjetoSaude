namespace ProjetoSaude.Apresentacao
{
    partial class BemVindoAdmin
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cadAlimentos = new System.Windows.Forms.Button();
            this.btnRemoverAlimentos = new System.Windows.Forms.Button();
            this.btnControleCalorias = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalcularImc
            // 
            this.btnCalcularImc.Location = new System.Drawing.Point(35, 100);
            this.btnCalcularImc.Name = "btnCalcularImc";
            this.btnCalcularImc.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularImc.TabIndex = 0;
            this.btnCalcularImc.Text = "Calcular IMC";
            this.btnCalcularImc.UseVisualStyleBackColor = true;
            this.btnCalcularImc.Click += new System.EventHandler(this.btnCalcularImc_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(149, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Op2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(267, 100);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Op3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cadAlimentos
            // 
            this.cadAlimentos.Location = new System.Drawing.Point(106, 152);
            this.cadAlimentos.Name = "cadAlimentos";
            this.cadAlimentos.Size = new System.Drawing.Size(155, 23);
            this.cadAlimentos.TabIndex = 3;
            this.cadAlimentos.Text = "Cadastrar Alimentos";
            this.cadAlimentos.UseVisualStyleBackColor = true;
            this.cadAlimentos.Click += new System.EventHandler(this.CadAlimentos_Click);
            // 
            // btnRemoverAlimentos
            // 
            this.btnRemoverAlimentos.Location = new System.Drawing.Point(106, 181);
            this.btnRemoverAlimentos.Name = "btnRemoverAlimentos";
            this.btnRemoverAlimentos.Size = new System.Drawing.Size(155, 23);
            this.btnRemoverAlimentos.TabIndex = 4;
            this.btnRemoverAlimentos.Text = "Remover Alimentos";
            this.btnRemoverAlimentos.UseVisualStyleBackColor = true;
            this.btnRemoverAlimentos.Click += new System.EventHandler(this.BtnRemoverAlimentos_Click);
            // 
            // btnControleCalorias
            // 
            this.btnControleCalorias.Location = new System.Drawing.Point(106, 229);
            this.btnControleCalorias.Name = "btnControleCalorias";
            this.btnControleCalorias.Size = new System.Drawing.Size(155, 23);
            this.btnControleCalorias.TabIndex = 5;
            this.btnControleCalorias.Text = "Controle de Calorias";
            this.btnControleCalorias.UseVisualStyleBackColor = true;
            this.btnControleCalorias.Click += new System.EventHandler(this.BtnControleCalorias_Click);
            // 
            // BemVindoAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 282);
            this.Controls.Add(this.btnControleCalorias);
            this.Controls.Add(this.btnRemoverAlimentos);
            this.Controls.Add(this.cadAlimentos);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCalcularImc);
            this.Name = "BemVindoAdmin";
            this.Text = "BemVindo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalcularImc;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button cadAlimentos;
        private System.Windows.Forms.Button btnRemoverAlimentos;
        private System.Windows.Forms.Button btnControleCalorias;
    }
}