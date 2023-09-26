namespace basithesapmakinesi
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
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.btnTopla = new System.Windows.Forms.Button();
            this.btnÇıkarma = new System.Windows.Forms.Button();
            this.btnÇarpa = new System.Windows.Forms.Button();
            this.btnBölme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSayi2
            // 
            this.txtSayi2.Location = new System.Drawing.Point(83, 91);
            this.txtSayi2.Multiline = true;
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(134, 30);
            this.txtSayi2.TabIndex = 0;
            this.txtSayi2.TextChanged += new System.EventHandler(this.txtSayi2_TextChanged);
            // 
            // txtSayi1
            // 
            this.txtSayi1.Location = new System.Drawing.Point(83, 127);
            this.txtSayi1.Multiline = true;
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(134, 30);
            this.txtSayi1.TabIndex = 1;
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.ForeColor = System.Drawing.Color.Black;
            this.lblSonuc.Location = new System.Drawing.Point(79, 194);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(70, 24);
            this.lblSonuc.TabIndex = 2;
            this.lblSonuc.Text = "Sonuç";
            // 
            // btnTopla
            // 
            this.btnTopla.BackColor = System.Drawing.Color.Coral;
            this.btnTopla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTopla.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTopla.Location = new System.Drawing.Point(248, 92);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(103, 29);
            this.btnTopla.TabIndex = 3;
            this.btnTopla.Text = "Toplama";
            this.btnTopla.UseVisualStyleBackColor = false;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // btnÇıkarma
            // 
            this.btnÇıkarma.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnÇıkarma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnÇıkarma.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnÇıkarma.Location = new System.Drawing.Point(248, 128);
            this.btnÇıkarma.Name = "btnÇıkarma";
            this.btnÇıkarma.Size = new System.Drawing.Size(103, 29);
            this.btnÇıkarma.TabIndex = 4;
            this.btnÇıkarma.Text = "Çıkarma";
            this.btnÇıkarma.UseVisualStyleBackColor = false;
            this.btnÇıkarma.Click += new System.EventHandler(this.btnÇıkarma_Click);
            // 
            // btnÇarpa
            // 
            this.btnÇarpa.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnÇarpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnÇarpa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnÇarpa.Location = new System.Drawing.Point(357, 92);
            this.btnÇarpa.Name = "btnÇarpa";
            this.btnÇarpa.Size = new System.Drawing.Size(103, 29);
            this.btnÇarpa.TabIndex = 5;
            this.btnÇarpa.Text = "Çarpa";
            this.btnÇarpa.UseVisualStyleBackColor = false;
            this.btnÇarpa.Click += new System.EventHandler(this.btnÇarpa_Click);
            // 
            // btnBölme
            // 
            this.btnBölme.BackColor = System.Drawing.Color.Purple;
            this.btnBölme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBölme.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBölme.Location = new System.Drawing.Point(357, 128);
            this.btnBölme.Name = "btnBölme";
            this.btnBölme.Size = new System.Drawing.Size(103, 29);
            this.btnBölme.TabIndex = 6;
            this.btnBölme.Text = "Bölme";
            this.btnBölme.UseVisualStyleBackColor = false;
            this.btnBölme.Click += new System.EventHandler(this.btnBölme_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBölme);
            this.Controls.Add(this.btnÇarpa);
            this.Controls.Add(this.btnÇıkarma);
            this.Controls.Add(this.btnTopla);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.txtSayi1);
            this.Controls.Add(this.txtSayi2);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.Button btnÇıkarma;
        private System.Windows.Forms.Button btnÇarpa;
        private System.Windows.Forms.Button btnBölme;
    }
}

