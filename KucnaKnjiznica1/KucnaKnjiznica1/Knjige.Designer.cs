namespace KucnaKnjiznica1
{
    partial class Knjige
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
            this.dostupneKnjigeDGV = new System.Windows.Forms.DataGridView();
            this.posudiButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.posudeneKnjigeDGV = new System.Windows.Forms.DataGridView();
            this.vratiButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dostupneKnjigeDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posudeneKnjigeDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dostupne knjige:";
            // 
            // dostupneKnjigeDGV
            // 
            this.dostupneKnjigeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dostupneKnjigeDGV.Location = new System.Drawing.Point(13, 30);
            this.dostupneKnjigeDGV.Name = "dostupneKnjigeDGV";
            this.dostupneKnjigeDGV.Size = new System.Drawing.Size(299, 161);
            this.dostupneKnjigeDGV.TabIndex = 1;
            this.dostupneKnjigeDGV.SelectionChanged += new System.EventHandler(this.dostupneKnjigeDGV_SelectionChanged);
            // 
            // posudiButton
            // 
            this.posudiButton.Location = new System.Drawing.Point(202, 198);
            this.posudiButton.Name = "posudiButton";
            this.posudiButton.Size = new System.Drawing.Size(110, 23);
            this.posudiButton.TabIndex = 2;
            this.posudiButton.Text = "Posudi";
            this.posudiButton.UseVisualStyleBackColor = true;
            this.posudiButton.Click += new System.EventHandler(this.posudiButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Knjige na posudbi:";
            // 
            // posudeneKnjigeDGV
            // 
            this.posudeneKnjigeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.posudeneKnjigeDGV.Location = new System.Drawing.Point(13, 261);
            this.posudeneKnjigeDGV.Name = "posudeneKnjigeDGV";
            this.posudeneKnjigeDGV.Size = new System.Drawing.Size(299, 150);
            this.posudeneKnjigeDGV.TabIndex = 4;
            this.posudeneKnjigeDGV.SelectionChanged += new System.EventHandler(this.posudeneKnjigeDGV_SelectionChanged);
            // 
            // vratiButton
            // 
            this.vratiButton.Location = new System.Drawing.Point(202, 418);
            this.vratiButton.Name = "vratiButton";
            this.vratiButton.Size = new System.Drawing.Size(109, 23);
            this.vratiButton.TabIndex = 5;
            this.vratiButton.Text = "Vrati";
            this.vratiButton.UseVisualStyleBackColor = true;
            this.vratiButton.Click += new System.EventHandler(this.vratiButton_Click);
            // 
            // Knjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 471);
            this.Controls.Add(this.vratiButton);
            this.Controls.Add(this.posudeneKnjigeDGV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.posudiButton);
            this.Controls.Add(this.dostupneKnjigeDGV);
            this.Controls.Add(this.label1);
            this.Name = "Knjige";
            this.Text = "Knjige";
            this.Load += new System.EventHandler(this.Knjige_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dostupneKnjigeDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posudeneKnjigeDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dostupneKnjigeDGV;
        private System.Windows.Forms.Button posudiButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView posudeneKnjigeDGV;
        private System.Windows.Forms.Button vratiButton;
    }
}

