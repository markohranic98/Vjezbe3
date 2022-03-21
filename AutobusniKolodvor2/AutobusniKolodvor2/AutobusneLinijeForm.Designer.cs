namespace AutobusniKolodvor2
{
    partial class AutobusneLinijeForm
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
            this.kupiKartuButton = new System.Windows.Forms.Button();
            this.linijeDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.odredisteTextBox = new System.Windows.Forms.TextBox();
            this.pronadiButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.linijeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // kupiKartuButton
            // 
            this.kupiKartuButton.Location = new System.Drawing.Point(527, 340);
            this.kupiKartuButton.Name = "kupiKartuButton";
            this.kupiKartuButton.Size = new System.Drawing.Size(84, 23);
            this.kupiKartuButton.TabIndex = 0;
            this.kupiKartuButton.Text = "Kupi kartu";
            this.kupiKartuButton.UseVisualStyleBackColor = true;
            this.kupiKartuButton.Click += new System.EventHandler(this.kupiKartuButton_Click);
            // 
            // linijeDataGridView
            // 
            this.linijeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.linijeDataGridView.Location = new System.Drawing.Point(13, 50);
            this.linijeDataGridView.Name = "linijeDataGridView";
            this.linijeDataGridView.Size = new System.Drawing.Size(598, 272);
            this.linijeDataGridView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Odredište:";
            // 
            // odredisteTextBox
            // 
            this.odredisteTextBox.Location = new System.Drawing.Point(119, 13);
            this.odredisteTextBox.Name = "odredisteTextBox";
            this.odredisteTextBox.Size = new System.Drawing.Size(229, 20);
            this.odredisteTextBox.TabIndex = 3;
            // 
            // pronadiButton
            // 
            this.pronadiButton.Location = new System.Drawing.Point(354, 12);
            this.pronadiButton.Name = "pronadiButton";
            this.pronadiButton.Size = new System.Drawing.Size(90, 23);
            this.pronadiButton.TabIndex = 4;
            this.pronadiButton.Text = "Pronađi";
            this.pronadiButton.UseVisualStyleBackColor = true;
            this.pronadiButton.Click += new System.EventHandler(this.pronadiButton_Click);
            // 
            // AutobusneLinijeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 375);
            this.Controls.Add(this.pronadiButton);
            this.Controls.Add(this.odredisteTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linijeDataGridView);
            this.Controls.Add(this.kupiKartuButton);
            this.Name = "AutobusneLinijeForm";
            this.Text = "Autobusne linije";
            this.Load += new System.EventHandler(this.AutobusneLinijeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.linijeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kupiKartuButton;
        private System.Windows.Forms.DataGridView linijeDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox odredisteTextBox;
        private System.Windows.Forms.Button pronadiButton;
    }
}

