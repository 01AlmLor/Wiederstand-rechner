namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtR1 = new System.Windows.Forms.TextBox();
            this.txtR2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAusgabe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReihe = new System.Windows.Forms.Button();
            this.btnParallel = new System.Windows.Forms.Button();
            this.btnBerechnen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtR1
            // 
            this.txtR1.Location = new System.Drawing.Point(100, 94);
            this.txtR1.Name = "txtR1";
            this.txtR1.Size = new System.Drawing.Size(100, 20);
            this.txtR1.TabIndex = 0;
            this.txtR1.TextChanged += new System.EventHandler(this.txtR1_TextChanged);
            // 
            // txtR2
            // 
            this.txtR2.Location = new System.Drawing.Point(261, 94);
            this.txtR2.Name = "txtR2";
            this.txtR2.Size = new System.Drawing.Size(100, 20);
            this.txtR2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wiederstand 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Wiederstand 2";
            // 
            // txtAusgabe
            // 
            this.txtAusgabe.Location = new System.Drawing.Point(420, 94);
            this.txtAusgabe.Name = "txtAusgabe";
            this.txtAusgabe.Size = new System.Drawing.Size(100, 20);
            this.txtAusgabe.TabIndex = 4;
            this.txtAusgabe.TextChanged += new System.EventHandler(this.txtAusgabe_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gesamt Wiederstand";
            // 
            // btnReihe
            // 
            this.btnReihe.Location = new System.Drawing.Point(100, 150);
            this.btnReihe.Name = "btnReihe";
            this.btnReihe.Size = new System.Drawing.Size(75, 23);
            this.btnReihe.TabIndex = 6;
            this.btnReihe.Text = "Reihe";
            this.btnReihe.UseVisualStyleBackColor = true;
            this.btnReihe.Click += new System.EventHandler(this.btnReihe_Click);
            // 
            // btnParallel
            // 
            this.btnParallel.Location = new System.Drawing.Point(261, 150);
            this.btnParallel.Name = "btnParallel";
            this.btnParallel.Size = new System.Drawing.Size(75, 23);
            this.btnParallel.TabIndex = 7;
            this.btnParallel.Text = "Parallel";
            this.btnParallel.UseVisualStyleBackColor = true;
            this.btnParallel.Click += new System.EventHandler(this.btnParallel_Click);
            // 
            // btnBerechnen
            // 
            this.btnBerechnen.Location = new System.Drawing.Point(420, 150);
            this.btnBerechnen.Name = "btnBerechnen";
            this.btnBerechnen.Size = new System.Drawing.Size(75, 23);
            this.btnBerechnen.TabIndex = 8;
            this.btnBerechnen.Text = "Berechnen";
            this.btnBerechnen.UseVisualStyleBackColor = true;
            this.btnBerechnen.Click += new System.EventHandler(this.btnBerechnen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnBerechnen);
            this.Controls.Add(this.btnParallel);
            this.Controls.Add(this.btnReihe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAusgabe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtR2);
            this.Controls.Add(this.txtR1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtR1;
        private System.Windows.Forms.TextBox txtR2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAusgabe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReihe;
        private System.Windows.Forms.Button btnParallel;
        private System.Windows.Forms.Button btnBerechnen;
    }
}

