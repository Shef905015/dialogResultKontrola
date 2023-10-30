namespace dialogResultKontrola
{
    partial class Form1
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
            this.buttonOtvori = new System.Windows.Forms.Button();
            this.textBoxRezultat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonOtvori
            // 
            this.buttonOtvori.Location = new System.Drawing.Point(135, 39);
            this.buttonOtvori.Name = "buttonOtvori";
            this.buttonOtvori.Size = new System.Drawing.Size(157, 23);
            this.buttonOtvori.TabIndex = 0;
            this.buttonOtvori.Text = "Otvorite messagebox";
            this.buttonOtvori.UseVisualStyleBackColor = true;
            this.buttonOtvori.Click += new System.EventHandler(this.buttonOtvori_Click);
            // 
            // textBoxRezultat
            // 
            this.textBoxRezultat.Location = new System.Drawing.Point(46, 68);
            this.textBoxRezultat.Multiline = true;
            this.textBoxRezultat.Name = "textBoxRezultat";
            this.textBoxRezultat.Size = new System.Drawing.Size(331, 91);
            this.textBoxRezultat.TabIndex = 1;
            this.textBoxRezultat.TextChanged += new System.EventHandler(this.textBoxRezultat_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 192);
            this.Controls.Add(this.textBoxRezultat);
            this.Controls.Add(this.buttonOtvori);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOtvori;
        private System.Windows.Forms.TextBox textBoxRezultat;
    }
}

