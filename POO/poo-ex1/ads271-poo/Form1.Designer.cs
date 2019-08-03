namespace ads271_poo
{
    partial class formMedia
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxNota1 = new System.Windows.Forms.TextBox();
            this.labelNota1 = new System.Windows.Forms.Label();
            this.textBoxNota2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelRetornaMedia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(37, 58);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 15);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(96, 56);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(145, 20);
            this.textBoxNome.TabIndex = 1;
            // 
            // textBoxNota1
            // 
            this.textBoxNota1.Location = new System.Drawing.Point(96, 95);
            this.textBoxNota1.Name = "textBoxNota1";
            this.textBoxNota1.Size = new System.Drawing.Size(145, 20);
            this.textBoxNota1.TabIndex = 3;
            // 
            // labelNota1
            // 
            this.labelNota1.AutoSize = true;
            this.labelNota1.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNota1.Location = new System.Drawing.Point(37, 97);
            this.labelNota1.Name = "labelNota1";
            this.labelNota1.Size = new System.Drawing.Size(42, 15);
            this.labelNota1.TabIndex = 2;
            this.labelNota1.Text = "Nota 1";
            // 
            // textBoxNota2
            // 
            this.textBoxNota2.Location = new System.Drawing.Point(96, 135);
            this.textBoxNota2.Name = "textBoxNota2";
            this.textBoxNota2.Size = new System.Drawing.Size(145, 20);
            this.textBoxNota2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nota 2";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(28, 192);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5);
            this.button1.Size = new System.Drawing.Size(79, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Descubra a média";
            // 
            // labelRetornaMedia
            // 
            this.labelRetornaMedia.AutoSize = true;
            this.labelRetornaMedia.Font = new System.Drawing.Font("Carlito", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRetornaMedia.Location = new System.Drawing.Point(125, 203);
            this.labelRetornaMedia.Name = "labelRetornaMedia";
            this.labelRetornaMedia.Size = new System.Drawing.Size(128, 13);
            this.labelRetornaMedia.TabIndex = 8;
            this.labelRetornaMedia.Text = "Sua nota será exibida aqui";
            // 
            // formMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(283, 263);
            this.Controls.Add(this.labelRetornaMedia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxNota2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNota1);
            this.Controls.Add(this.labelNota1);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelNome);
            this.Name = "formMedia";
            this.Text = "Descubra a média";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxNota1;
        private System.Windows.Forms.Label labelNota1;
        private System.Windows.Forms.TextBox textBoxNota2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelRetornaMedia;
    }
}

