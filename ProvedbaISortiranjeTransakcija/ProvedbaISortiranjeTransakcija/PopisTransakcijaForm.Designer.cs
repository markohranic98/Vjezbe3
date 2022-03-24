namespace ProvedbaISortiranjeTransakcija
{
    partial class PopisTransakcijaForm
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
            this.transakcijeDataGridView = new System.Windows.Forms.DataGridView();
            this.stornirajButton = new System.Windows.Forms.Button();
            this.provediTransakciju = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.transakcijeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // transakcijeDataGridView
            // 
            this.transakcijeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transakcijeDataGridView.Location = new System.Drawing.Point(13, 13);
            this.transakcijeDataGridView.Name = "transakcijeDataGridView";
            this.transakcijeDataGridView.Size = new System.Drawing.Size(627, 232);
            this.transakcijeDataGridView.TabIndex = 0;
            // 
            // stornirajButton
            // 
            this.stornirajButton.Location = new System.Drawing.Point(425, 259);
            this.stornirajButton.Name = "stornirajButton";
            this.stornirajButton.Size = new System.Drawing.Size(75, 23);
            this.stornirajButton.TabIndex = 1;
            this.stornirajButton.Text = "Storniraj";
            this.stornirajButton.UseVisualStyleBackColor = true;
            this.stornirajButton.Click += new System.EventHandler(this.stornirajButton_Click);
            // 
            // provediTransakciju
            // 
            this.provediTransakciju.Location = new System.Drawing.Point(520, 259);
            this.provediTransakciju.Name = "provediTransakciju";
            this.provediTransakciju.Size = new System.Drawing.Size(75, 23);
            this.provediTransakciju.TabIndex = 2;
            this.provediTransakciju.Text = "Provedi";
            this.provediTransakciju.UseVisualStyleBackColor = true;
            this.provediTransakciju.Click += new System.EventHandler(this.provediTransakciju_Click);
            // 
            // PopisTransakcijaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 294);
            this.Controls.Add(this.provediTransakciju);
            this.Controls.Add(this.stornirajButton);
            this.Controls.Add(this.transakcijeDataGridView);
            this.Name = "PopisTransakcijaForm";
            this.Text = "Popis transakcija";
            this.Load += new System.EventHandler(this.PopisTransakcijaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transakcijeDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView transakcijeDataGridView;
        private System.Windows.Forms.Button stornirajButton;
        private System.Windows.Forms.Button provediTransakciju;
    }
}

