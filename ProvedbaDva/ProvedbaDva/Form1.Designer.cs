namespace ProvedbaDva
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
            this.prethodnoButton = new System.Windows.Forms.Button();
            this.sljedeceButton = new System.Windows.Forms.Button();
            this.prviButton = new System.Windows.Forms.Button();
            this.drugiButton = new System.Windows.Forms.Button();
            this.treciButton = new System.Windows.Forms.Button();
            this.cetvrtiButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prethodnoButton
            // 
            this.prethodnoButton.Location = new System.Drawing.Point(49, 36);
            this.prethodnoButton.Name = "prethodnoButton";
            this.prethodnoButton.Size = new System.Drawing.Size(75, 23);
            this.prethodnoButton.TabIndex = 0;
            this.prethodnoButton.Text = "button1";
            this.prethodnoButton.UseVisualStyleBackColor = true;
            this.prethodnoButton.Click += new System.EventHandler(this.prethodnoButton_Click);
            // 
            // sljedeceButton
            // 
            this.sljedeceButton.Location = new System.Drawing.Point(207, 36);
            this.sljedeceButton.Name = "sljedeceButton";
            this.sljedeceButton.Size = new System.Drawing.Size(75, 23);
            this.sljedeceButton.TabIndex = 1;
            this.sljedeceButton.Text = "button2";
            this.sljedeceButton.UseVisualStyleBackColor = true;
            this.sljedeceButton.Click += new System.EventHandler(this.sljedeceButton_Click);
            // 
            // prviButton
            // 
            this.prviButton.Location = new System.Drawing.Point(119, 256);
            this.prviButton.Name = "prviButton";
            this.prviButton.Size = new System.Drawing.Size(102, 23);
            this.prviButton.TabIndex = 2;
            this.prviButton.Text = "button3";
            this.prviButton.UseVisualStyleBackColor = true;
            this.prviButton.Click += new System.EventHandler(this.prviButton_Click);
            // 
            // drugiButton
            // 
            this.drugiButton.Location = new System.Drawing.Point(119, 285);
            this.drugiButton.Name = "drugiButton";
            this.drugiButton.Size = new System.Drawing.Size(102, 23);
            this.drugiButton.TabIndex = 3;
            this.drugiButton.Text = "button4";
            this.drugiButton.UseVisualStyleBackColor = true;
            // 
            // treciButton
            // 
            this.treciButton.Location = new System.Drawing.Point(119, 314);
            this.treciButton.Name = "treciButton";
            this.treciButton.Size = new System.Drawing.Size(102, 23);
            this.treciButton.TabIndex = 4;
            this.treciButton.Text = "button5";
            this.treciButton.UseVisualStyleBackColor = true;
            // 
            // cetvrtiButton
            // 
            this.cetvrtiButton.Location = new System.Drawing.Point(119, 343);
            this.cetvrtiButton.Name = "cetvrtiButton";
            this.cetvrtiButton.Size = new System.Drawing.Size(102, 23);
            this.cetvrtiButton.TabIndex = 5;
            this.cetvrtiButton.Text = "button6";
            this.cetvrtiButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(93, 163);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 56);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "PITANJE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 417);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cetvrtiButton);
            this.Controls.Add(this.treciButton);
            this.Controls.Add(this.drugiButton);
            this.Controls.Add(this.prviButton);
            this.Controls.Add(this.sljedeceButton);
            this.Controls.Add(this.prethodnoButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button prethodnoButton;
        private System.Windows.Forms.Button sljedeceButton;
        private System.Windows.Forms.Button prviButton;
        private System.Windows.Forms.Button drugiButton;
        private System.Windows.Forms.Button treciButton;
        private System.Windows.Forms.Button cetvrtiButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

