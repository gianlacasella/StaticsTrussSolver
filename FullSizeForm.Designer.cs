namespace StaticsTrussSolver
{
    partial class FullSizeForm
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
            this.fullSizePB = new System.Windows.Forms.PictureBox();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fullSizePB)).BeginInit();
            this.SuspendLayout();
            // 
            // fullSizePB
            // 
            this.fullSizePB.Dock = System.Windows.Forms.DockStyle.Top;
            this.fullSizePB.Location = new System.Drawing.Point(0, 0);
            this.fullSizePB.Name = "fullSizePB";
            this.fullSizePB.Size = new System.Drawing.Size(1041, 728);
            this.fullSizePB.TabIndex = 0;
            this.fullSizePB.TabStop = false;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(909, 734);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(120, 33);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save picture";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // FullSizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 774);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.fullSizePB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FullSizeForm";
            this.Text = "Full Size View";
            ((System.ComponentModel.ISupportInitialize)(this.fullSizePB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox fullSizePB;
        private System.Windows.Forms.Button saveButton;
    }
}