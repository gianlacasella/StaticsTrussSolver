namespace StaticsTrussSolver
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
            this.solutionPanel = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.nodesTextBox = new System.Windows.Forms.TextBox();
            this.nodesPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.solutionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.nodesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // solutionPanel
            // 
            this.solutionPanel.Controls.Add(this.resultBox);
            this.solutionPanel.Controls.Add(this.pictureBox);
            this.solutionPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.solutionPanel.Location = new System.Drawing.Point(0, 0);
            this.solutionPanel.Name = "solutionPanel";
            this.solutionPanel.Size = new System.Drawing.Size(379, 653);
            this.solutionPanel.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(379, 359);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // resultBox
            // 
            this.resultBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.resultBox.Location = new System.Drawing.Point(0, 359);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(379, 352);
            this.resultBox.TabIndex = 1;
            // 
            // nodesTextBox
            // 
            this.nodesTextBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.nodesTextBox.Location = new System.Drawing.Point(370, 0);
            this.nodesTextBox.Multiline = true;
            this.nodesTextBox.Name = "nodesTextBox";
            this.nodesTextBox.Size = new System.Drawing.Size(384, 117);
            this.nodesTextBox.TabIndex = 1;
            // 
            // nodesPanel
            // 
            this.nodesPanel.Controls.Add(this.label1);
            this.nodesPanel.Controls.Add(this.button1);
            this.nodesPanel.Controls.Add(this.nodesTextBox);
            this.nodesPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.nodesPanel.Location = new System.Drawing.Point(379, 0);
            this.nodesPanel.Name = "nodesPanel";
            this.nodesPanel.Size = new System.Drawing.Size(754, 117);
            this.nodesPanel.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(235, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 117);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Nodes";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Insert nodes coordinates";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 653);
            this.Controls.Add(this.nodesPanel);
            this.Controls.Add(this.solutionPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.solutionPanel.ResumeLayout(false);
            this.solutionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.nodesPanel.ResumeLayout(false);
            this.nodesPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel solutionPanel;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox nodesTextBox;
        private System.Windows.Forms.Panel nodesPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}