namespace GUIA.Clases
{
    partial class Finicio
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
            this.textboxmarca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxcolor = new System.Windows.Forms.TextBox();
            this.textBoxmodelo = new System.Windows.Forms.TextBox();
            this.CrearCarro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textboxmarca
            // 
            this.textboxmarca.Location = new System.Drawing.Point(195, 57);
            this.textboxmarca.Name = "textboxmarca";
            this.textboxmarca.Size = new System.Drawing.Size(100, 20);
            this.textboxmarca.TabIndex = 0;
            this.textboxmarca.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marca del Carro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modelo del Carro";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Color del Carro";
            // 
            // textBoxcolor
            // 
            this.textBoxcolor.Location = new System.Drawing.Point(195, 179);
            this.textBoxcolor.Name = "textBoxcolor";
            this.textBoxcolor.Size = new System.Drawing.Size(100, 20);
            this.textBoxcolor.TabIndex = 4;
            // 
            // textBoxmodelo
            // 
            this.textBoxmodelo.Location = new System.Drawing.Point(195, 114);
            this.textBoxmodelo.Name = "textBoxmodelo";
            this.textBoxmodelo.Size = new System.Drawing.Size(100, 20);
            this.textBoxmodelo.TabIndex = 5;
            // 
            // CrearCarro
            // 
            this.CrearCarro.Location = new System.Drawing.Point(356, 320);
            this.CrearCarro.Name = "CrearCarro";
            this.CrearCarro.Size = new System.Drawing.Size(158, 40);
            this.CrearCarro.TabIndex = 6;
            this.CrearCarro.Text = "Crear Carro";
            this.CrearCarro.UseVisualStyleBackColor = true;
            this.CrearCarro.Click += new System.EventHandler(this.CrearCarro_Click);
            // 
            // Finicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 461);
            this.Controls.Add(this.CrearCarro);
            this.Controls.Add(this.textBoxmodelo);
            this.Controls.Add(this.textBoxcolor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textboxmarca);
            this.Name = "Finicio";
            this.Text = "Finicio";
            this.Load += new System.EventHandler(this.Finicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxmarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxcolor;
        private System.Windows.Forms.TextBox textBoxmodelo;
        private System.Windows.Forms.Button CrearCarro;
    }
}