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
            this.resultBox = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.nodesTextBox = new System.Windows.Forms.TextBox();
            this.nodesPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.connectionsPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.connectionsTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.forcesTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.restrictionsTextBox = new System.Windows.Forms.TextBox();
            this.solveButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.solutionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.nodesPanel.SuspendLayout();
            this.connectionsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // solutionPanel
            // 
            this.solutionPanel.Controls.Add(this.button4);
            this.solutionPanel.Controls.Add(this.pictureBox);
            this.solutionPanel.Controls.Add(this.solveButton);
            this.solutionPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.solutionPanel.Location = new System.Drawing.Point(0, 0);
            this.solutionPanel.Name = "solutionPanel";
            this.solutionPanel.Size = new System.Drawing.Size(430, 653);
            this.solutionPanel.TabIndex = 0;
            // 
            // resultBox
            // 
            this.resultBox.BackColor = System.Drawing.Color.Black;
            this.resultBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBox.ForeColor = System.Drawing.Color.White;
            this.resultBox.Location = new System.Drawing.Point(430, 411);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultBox.Size = new System.Drawing.Size(703, 242);
            this.resultBox.TabIndex = 1;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(430, 411);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // nodesTextBox
            // 
            this.nodesTextBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.nodesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nodesTextBox.Location = new System.Drawing.Point(365, 0);
            this.nodesTextBox.Multiline = true;
            this.nodesTextBox.Name = "nodesTextBox";
            this.nodesTextBox.Size = new System.Drawing.Size(338, 111);
            this.nodesTextBox.TabIndex = 1;
            // 
            // nodesPanel
            // 
            this.nodesPanel.Controls.Add(this.label1);
            this.nodesPanel.Controls.Add(this.button1);
            this.nodesPanel.Controls.Add(this.nodesTextBox);
            this.nodesPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.nodesPanel.Location = new System.Drawing.Point(430, 0);
            this.nodesPanel.Name = "nodesPanel";
            this.nodesPanel.Size = new System.Drawing.Size(703, 111);
            this.nodesPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Insert nodes coordinates";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 111);
            this.button1.TabIndex = 2;
            this.button1.Text = "Show Nodes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // connectionsPanel
            // 
            this.connectionsPanel.Controls.Add(this.label2);
            this.connectionsPanel.Controls.Add(this.connectionsTextBox);
            this.connectionsPanel.Controls.Add(this.button2);
            this.connectionsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.connectionsPanel.Location = new System.Drawing.Point(430, 111);
            this.connectionsPanel.Name = "connectionsPanel";
            this.connectionsPanel.Size = new System.Drawing.Size(703, 100);
            this.connectionsPanel.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 100);
            this.button2.TabIndex = 3;
            this.button2.Text = "Show Connections";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // connectionsTextBox
            // 
            this.connectionsTextBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.connectionsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionsTextBox.Location = new System.Drawing.Point(365, 0);
            this.connectionsTextBox.Multiline = true;
            this.connectionsTextBox.Name = "connectionsTextBox";
            this.connectionsTextBox.Size = new System.Drawing.Size(338, 100);
            this.connectionsTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Insert connections coordinates";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.forcesTextBox);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(430, 211);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 100);
            this.panel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(209, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Insert forces";
            // 
            // forcesTextBox
            // 
            this.forcesTextBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.forcesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forcesTextBox.Location = new System.Drawing.Point(365, 0);
            this.forcesTextBox.Multiline = true;
            this.forcesTextBox.Name = "forcesTextBox";
            this.forcesTextBox.Size = new System.Drawing.Size(338, 100);
            this.forcesTextBox.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Left;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 100);
            this.button3.TabIndex = 3;
            this.button3.Text = "Show Forces";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.restrictionsTextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(430, 311);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(703, 100);
            this.panel2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(198, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Insert restrictions";
            // 
            // restrictionsTextBox
            // 
            this.restrictionsTextBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.restrictionsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restrictionsTextBox.Location = new System.Drawing.Point(365, 0);
            this.restrictionsTextBox.Multiline = true;
            this.restrictionsTextBox.Name = "restrictionsTextBox";
            this.restrictionsTextBox.Size = new System.Drawing.Size(338, 100);
            this.restrictionsTextBox.TabIndex = 4;
            // 
            // solveButton
            // 
            this.solveButton.Location = new System.Drawing.Point(102, 442);
            this.solveButton.Name = "solveButton";
            this.solveButton.Size = new System.Drawing.Size(164, 69);
            this.solveButton.TabIndex = 6;
            this.solveButton.Text = "SOLVE SYSTEM";
            this.solveButton.UseVisualStyleBackColor = true;
            this.solveButton.Click += new System.EventHandler(this.solveButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(102, 543);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(164, 69);
            this.button4.TabIndex = 7;
            this.button4.Text = "CLEAR LOG";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 653);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.connectionsPanel);
            this.Controls.Add(this.nodesPanel);
            this.Controls.Add(this.solutionPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.solutionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.nodesPanel.ResumeLayout(false);
            this.nodesPanel.PerformLayout();
            this.connectionsPanel.ResumeLayout(false);
            this.connectionsPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel solutionPanel;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox nodesTextBox;
        private System.Windows.Forms.Panel nodesPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel connectionsPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox connectionsTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox forcesTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox restrictionsTextBox;
        private System.Windows.Forms.Button solveButton;
        private System.Windows.Forms.Button button4;
    }
}