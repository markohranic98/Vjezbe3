namespace Knjiznica2
{
    partial class KnjiznicaForm
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
            this.svePosudbeRadio = new System.Windows.Forms.RadioButton();
            this.trenutneRadioButton = new System.Windows.Forms.RadioButton();
            this.prosleRadioButton = new System.Windows.Forms.RadioButton();
            this.knjigeDGV = new System.Windows.Forms.DataGridView();
            this.vratiButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.knjigeDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prikazi:";
            // 
            // svePosudbeRadio
            // 
            this.svePosudbeRadio.AutoSize = true;
            this.svePosudbeRadio.Checked = true;
            this.svePosudbeRadio.Location = new System.Drawing.Point(77, 34);
            this.svePosudbeRadio.Name = "svePosudbeRadio";
            this.svePosudbeRadio.Size = new System.Drawing.Size(88, 17);
            this.svePosudbeRadio.TabIndex = 1;
            this.svePosudbeRadio.TabStop = true;
            this.svePosudbeRadio.Text = "Sve posudbe";
            this.svePosudbeRadio.UseVisualStyleBackColor = true;
            // 
            // trenutneRadioButton
            // 
            this.trenutneRadioButton.AutoSize = true;
            this.trenutneRadioButton.Location = new System.Drawing.Point(168, 34);
            this.trenutneRadioButton.Name = "trenutneRadioButton";
            this.trenutneRadioButton.Size = new System.Drawing.Size(112, 17);
            this.trenutneRadioButton.TabIndex = 2;
            this.trenutneRadioButton.Text = "Trenutne posudbe";
            this.trenutneRadioButton.UseVisualStyleBackColor = true;
            // 
            // prosleRadioButton
            // 
            this.prosleRadioButton.AutoSize = true;
            this.prosleRadioButton.Location = new System.Drawing.Point(286, 34);
            this.prosleRadioButton.Name = "prosleRadioButton";
            this.prosleRadioButton.Size = new System.Drawing.Size(98, 17);
            this.prosleRadioButton.TabIndex = 3;
            this.prosleRadioButton.Text = "Prosle posudbe";
            this.prosleRadioButton.UseVisualStyleBackColor = true;
            // 
            // knjigeDGV
            // 
            this.knjigeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.knjigeDGV.Location = new System.Drawing.Point(22, 57);
            this.knjigeDGV.Name = "knjigeDGV";
            this.knjigeDGV.Size = new System.Drawing.Size(523, 214);
            this.knjigeDGV.TabIndex = 4;
            // 
            // vratiButton
            // 
            this.vratiButton.Location = new System.Drawing.Point(455, 303);
            this.vratiButton.Name = "vratiButton";
            this.vratiButton.Size = new System.Drawing.Size(75, 23);
            this.vratiButton.TabIndex = 5;
            this.vratiButton.Text = "Vrati knjigu";
            this.vratiButton.UseVisualStyleBackColor = true;
            // 
            // KnjiznicaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 352);
            this.Controls.Add(this.vratiButton);
            this.Controls.Add(this.knjigeDGV);
            this.Controls.Add(this.prosleRadioButton);
            this.Controls.Add(this.trenutneRadioButton);
            this.Controls.Add(this.svePosudbeRadio);
            this.Controls.Add(this.label1);
            this.Name = "KnjiznicaForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.knjigeDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton svePosudbeRadio;
        private System.Windows.Forms.RadioButton trenutneRadioButton;
        private System.Windows.Forms.RadioButton prosleRadioButton;
        private System.Windows.Forms.DataGridView knjigeDGV;
        private System.Windows.Forms.Button vratiButton;
    }
}

