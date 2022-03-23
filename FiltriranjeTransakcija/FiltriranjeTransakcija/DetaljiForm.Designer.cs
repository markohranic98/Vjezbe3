namespace FiltriranjeTransakcija
{
    partial class DetaljiForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ibanText = new System.Windows.Forms.TextBox();
            this.vlasnikText = new System.Windows.Forms.TextBox();
            this.stanjeText = new System.Windows.Forms.TextBox();
            this.ukupanPrometText = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IBAN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vlasnik";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stanje";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ukupni promet";
            // 
            // ibanText
            // 
            this.ibanText.Location = new System.Drawing.Point(94, 10);
            this.ibanText.Name = "ibanText";
            this.ibanText.ReadOnly = true;
            this.ibanText.Size = new System.Drawing.Size(100, 20);
            this.ibanText.TabIndex = 4;
            // 
            // vlasnikText
            // 
            this.vlasnikText.Location = new System.Drawing.Point(94, 38);
            this.vlasnikText.Name = "vlasnikText";
            this.vlasnikText.ReadOnly = true;
            this.vlasnikText.Size = new System.Drawing.Size(100, 20);
            this.vlasnikText.TabIndex = 5;
            // 
            // stanjeText
            // 
            this.stanjeText.Location = new System.Drawing.Point(94, 85);
            this.stanjeText.Name = "stanjeText";
            this.stanjeText.ReadOnly = true;
            this.stanjeText.Size = new System.Drawing.Size(100, 20);
            this.stanjeText.TabIndex = 6;
            // 
            // ukupanPrometText
            // 
            this.ukupanPrometText.Location = new System.Drawing.Point(94, 114);
            this.ukupanPrometText.Name = "ukupanPrometText";
            this.ukupanPrometText.ReadOnly = true;
            this.ukupanPrometText.Size = new System.Drawing.Size(100, 20);
            this.ukupanPrometText.TabIndex = 7;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(94, 156);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(95, 34);
            this.closeButton.TabIndex = 8;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // DetaljiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 202);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.ukupanPrometText);
            this.Controls.Add(this.stanjeText);
            this.Controls.Add(this.vlasnikText);
            this.Controls.Add(this.ibanText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DetaljiForm";
            this.Text = "DetaljiForm";
            this.Load += new System.EventHandler(this.DetaljiForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ibanText;
        private System.Windows.Forms.TextBox vlasnikText;
        private System.Windows.Forms.TextBox stanjeText;
        private System.Windows.Forms.TextBox ukupanPrometText;
        private System.Windows.Forms.Button closeButton;
    }
}