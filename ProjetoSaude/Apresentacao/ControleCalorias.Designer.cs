namespace ProjetoSaude.Apresentacao
{
    partial class ControleCalorias
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
            this.horasExercicio = new System.Windows.Forms.NumericUpDown();
            this.exercicio = new System.Windows.Forms.ComboBox();
            this.btnAddExercicio = new System.Windows.Forms.Button();
            this.quantidadeAlimento = new System.Windows.Forms.NumericUpDown();
            this.alimento = new System.Windows.Forms.ComboBox();
            this.btnAddAlimento = new System.Windows.Forms.Button();
            this.tipoRefeicaoComboBox = new System.Windows.Forms.ComboBox();
            this.exercicioCalorias = new System.Windows.Forms.Label();
            this.alimentoCalorias = new System.Windows.Forms.Label();
            this.balancoCalorias = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.horasExercicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantidadeAlimento)).BeginInit();
            this.SuspendLayout();
            // 
            // horasExercicio
            // 
            this.horasExercicio.Location = new System.Drawing.Point(56, 203);
            this.horasExercicio.Name = "horasExercicio";
            this.horasExercicio.Size = new System.Drawing.Size(120, 20);
            this.horasExercicio.TabIndex = 0;
            // 
            // exercicio
            // 
            this.exercicio.FormattingEnabled = true;
            this.exercicio.Location = new System.Drawing.Point(55, 152);
            this.exercicio.Name = "exercicio";
            this.exercicio.Size = new System.Drawing.Size(121, 21);
            this.exercicio.TabIndex = 1;
            // 
            // btnAddExercicio
            // 
            this.btnAddExercicio.Location = new System.Drawing.Point(59, 254);
            this.btnAddExercicio.Name = "btnAddExercicio";
            this.btnAddExercicio.Size = new System.Drawing.Size(117, 23);
            this.btnAddExercicio.TabIndex = 2;
            this.btnAddExercicio.Text = "AdicionarExercicio";
            this.btnAddExercicio.UseVisualStyleBackColor = true;
            this.btnAddExercicio.Click += new System.EventHandler(this.BtnAddExercicio_Click);
            // 
            // quantidadeAlimento
            // 
            this.quantidadeAlimento.Location = new System.Drawing.Point(579, 203);
            this.quantidadeAlimento.Name = "quantidadeAlimento";
            this.quantidadeAlimento.Size = new System.Drawing.Size(120, 20);
            this.quantidadeAlimento.TabIndex = 3;
            // 
            // alimento
            // 
            this.alimento.FormattingEnabled = true;
            this.alimento.Location = new System.Drawing.Point(578, 152);
            this.alimento.Name = "alimento";
            this.alimento.Size = new System.Drawing.Size(121, 21);
            this.alimento.TabIndex = 4;
            // 
            // btnAddAlimento
            // 
            this.btnAddAlimento.Location = new System.Drawing.Point(579, 254);
            this.btnAddAlimento.Name = "btnAddAlimento";
            this.btnAddAlimento.Size = new System.Drawing.Size(131, 23);
            this.btnAddAlimento.TabIndex = 5;
            this.btnAddAlimento.Text = "Adicionar Alimento";
            this.btnAddAlimento.UseVisualStyleBackColor = true;
            this.btnAddAlimento.Click += new System.EventHandler(this.BtnAddAlimento_Click);
            // 
            // tipoRefeicaoComboBox
            // 
            this.tipoRefeicaoComboBox.FormattingEnabled = true;
            this.tipoRefeicaoComboBox.Location = new System.Drawing.Point(317, 50);
            this.tipoRefeicaoComboBox.Name = "tipoRefeicaoComboBox";
            this.tipoRefeicaoComboBox.Size = new System.Drawing.Size(121, 21);
            this.tipoRefeicaoComboBox.TabIndex = 6;
            this.tipoRefeicaoComboBox.SelectedIndexChanged += new System.EventHandler(this.TipoRefeicao_SelectedIndexChanged);
            // 
            // exercicioCalorias
            // 
            this.exercicioCalorias.AutoSize = true;
            this.exercicioCalorias.Location = new System.Drawing.Point(82, 314);
            this.exercicioCalorias.Name = "exercicioCalorias";
            this.exercicioCalorias.Size = new System.Drawing.Size(52, 13);
            this.exercicioCalorias.TabIndex = 8;
            this.exercicioCalorias.Text = "0 calorias";
            // 
            // alimentoCalorias
            // 
            this.alimentoCalorias.AutoSize = true;
            this.alimentoCalorias.Location = new System.Drawing.Point(612, 314);
            this.alimentoCalorias.Name = "alimentoCalorias";
            this.alimentoCalorias.Size = new System.Drawing.Size(52, 13);
            this.alimentoCalorias.TabIndex = 9;
            this.alimentoCalorias.Text = "0 calorias";
            // 
            // balancoCalorias
            // 
            this.balancoCalorias.AutoSize = true;
            this.balancoCalorias.Location = new System.Drawing.Point(354, 385);
            this.balancoCalorias.Name = "balancoCalorias";
            this.balancoCalorias.Size = new System.Drawing.Size(52, 13);
            this.balancoCalorias.TabIndex = 10;
            this.balancoCalorias.Text = "0 calorias";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Balanço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(65, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Exercícios";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(587, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Alimentos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(301, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tipo de refeição";
            // 
            // ControleCalorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.balancoCalorias);
            this.Controls.Add(this.alimentoCalorias);
            this.Controls.Add(this.exercicioCalorias);
            this.Controls.Add(this.tipoRefeicaoComboBox);
            this.Controls.Add(this.btnAddAlimento);
            this.Controls.Add(this.alimento);
            this.Controls.Add(this.quantidadeAlimento);
            this.Controls.Add(this.btnAddExercicio);
            this.Controls.Add(this.exercicio);
            this.Controls.Add(this.horasExercicio);
            this.Name = "ControleCalorias";
            this.Text = "Controle Calorias";
            ((System.ComponentModel.ISupportInitialize)(this.horasExercicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantidadeAlimento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown horasExercicio;
        private System.Windows.Forms.ComboBox exercicio;
        private System.Windows.Forms.Button btnAddExercicio;
        private System.Windows.Forms.NumericUpDown quantidadeAlimento;
        private System.Windows.Forms.ComboBox alimento;
        private System.Windows.Forms.Button btnAddAlimento;
        private System.Windows.Forms.ComboBox tipoRefeicaoComboBox;
        private System.Windows.Forms.Label exercicioCalorias;
        private System.Windows.Forms.Label alimentoCalorias;
        private System.Windows.Forms.Label balancoCalorias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}