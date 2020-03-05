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
            this.fullSizeButton = new System.Windows.Forms.Button();
            this.clearPlotButton = new System.Windows.Forms.Button();
            this.clearLogButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.solveButton = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.nodesTextBox = new System.Windows.Forms.TextBox();
            this.nodesPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.showNodesButton = new System.Windows.Forms.Button();
            this.connectionsPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.connectionsTextBox = new System.Windows.Forms.TextBox();
            this.showConnectionButtons = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.forcesTextBox = new System.Windows.Forms.TextBox();
            this.showForcesButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.restrictionsTextBox = new System.Windows.Forms.TextBox();
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
            this.solutionPanel.Controls.Add(this.fullSizeButton);
            this.solutionPanel.Controls.Add(this.clearPlotButton);
            this.solutionPanel.Controls.Add(this.clearLogButton);
            this.solutionPanel.Controls.Add(this.pictureBox);
            this.solutionPanel.Controls.Add(this.solveButton);
            this.solutionPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.solutionPanel.Location = new System.Drawing.Point(0, 0);
            this.solutionPanel.Name = "solutionPanel";
            this.solutionPanel.Size = new System.Drawing.Size(430, 653);
            this.solutionPanel.TabIndex = 0;
            // 
            // fullSizeButton
            // 
            this.fullSizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fullSizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fullSizeButton.Location = new System.Drawing.Point(237, 436);
            this.fullSizeButton.Name = "fullSizeButton";
            this.fullSizeButton.Size = new System.Drawing.Size(164, 69);
            this.fullSizeButton.TabIndex = 9;
            this.fullSizeButton.Text = "SHOW IN FULL SIZE";
            this.fullSizeButton.UseVisualStyleBackColor = true;
            this.fullSizeButton.Click += new System.EventHandler(this.fullSizeButton_Click);
            // 
            // clearPlotButton
            // 
            this.clearPlotButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearPlotButton.Location = new System.Drawing.Point(43, 436);
            this.clearPlotButton.Name = "clearPlotButton";
            this.clearPlotButton.Size = new System.Drawing.Size(164, 69);
            this.clearPlotButton.TabIndex = 8;
            this.clearPlotButton.Text = "CLEAR PLOT";
            this.clearPlotButton.UseVisualStyleBackColor = true;
            this.clearPlotButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // clearLogButton
            // 
            this.clearLogButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearLogButton.Location = new System.Drawing.Point(43, 543);
            this.clearLogButton.Name = "clearLogButton";
            this.clearLogButton.Size = new System.Drawing.Size(164, 69);
            this.clearLogButton.TabIndex = 7;
            this.clearLogButton.Text = "CLEAR LOG";
            this.clearLogButton.UseVisualStyleBackColor = true;
            this.clearLogButton.Click += new System.EventHandler(this.button4_Click);
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
            // solveButton
            // 
            this.solveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.solveButton.Location = new System.Drawing.Point(237, 543);
            this.solveButton.Name = "solveButton";
            this.solveButton.Size = new System.Drawing.Size(164, 69);
            this.solveButton.TabIndex = 6;
            this.solveButton.Text = "SOLVE SYSTEM";
            this.solveButton.UseVisualStyleBackColor = true;
            this.solveButton.Click += new System.EventHandler(this.solveButton_Click);
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
            this.nodesPanel.Controls.Add(this.showNodesButton);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Insert nodes coordinates:";
            // 
            // showNodesButton
            // 
            this.showNodesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showNodesButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.showNodesButton.Location = new System.Drawing.Point(0, 41);
            this.showNodesButton.Name = "showNodesButton";
            this.showNodesButton.Size = new System.Drawing.Size(365, 70);
            this.showNodesButton.TabIndex = 2;
            this.showNodesButton.Text = "SHOW NODES";
            this.showNodesButton.UseVisualStyleBackColor = true;
            this.showNodesButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // connectionsPanel
            // 
            this.connectionsPanel.Controls.Add(this.label2);
            this.connectionsPanel.Controls.Add(this.connectionsTextBox);
            this.connectionsPanel.Controls.Add(this.showConnectionButtons);
            this.connectionsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.connectionsPanel.Location = new System.Drawing.Point(430, 111);
            this.connectionsPanel.Name = "connectionsPanel";
            this.connectionsPanel.Size = new System.Drawing.Size(703, 111);
            this.connectionsPanel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Insert connections coordinates:";
            // 
            // connectionsTextBox
            // 
            this.connectionsTextBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.connectionsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionsTextBox.Location = new System.Drawing.Point(365, 0);
            this.connectionsTextBox.Multiline = true;
            this.connectionsTextBox.Name = "connectionsTextBox";
            this.connectionsTextBox.Size = new System.Drawing.Size(338, 111);
            this.connectionsTextBox.TabIndex = 4;
            // 
            // showConnectionButtons
            // 
            this.showConnectionButtons.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showConnectionButtons.Location = new System.Drawing.Point(0, 41);
            this.showConnectionButtons.Name = "showConnectionButtons";
            this.showConnectionButtons.Size = new System.Drawing.Size(365, 70);
            this.showConnectionButtons.TabIndex = 3;
            this.showConnectionButtons.Text = "SHOW CONNECTIONS";
            this.showConnectionButtons.UseVisualStyleBackColor = true;
            this.showConnectionButtons.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.forcesTextBox);
            this.panel1.Controls.Add(this.showForcesButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(430, 222);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 111);
            this.panel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(263, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Insert forces:";
            // 
            // forcesTextBox
            // 
            this.forcesTextBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.forcesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forcesTextBox.Location = new System.Drawing.Point(365, 0);
            this.forcesTextBox.Multiline = true;
            this.forcesTextBox.Name = "forcesTextBox";
            this.forcesTextBox.Size = new System.Drawing.Size(338, 111);
            this.forcesTextBox.TabIndex = 4;
            // 
            // showForcesButton
            // 
            this.showForcesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showForcesButton.Location = new System.Drawing.Point(0, 41);
            this.showForcesButton.Name = "showForcesButton";
            this.showForcesButton.Size = new System.Drawing.Size(365, 70);
            this.showForcesButton.TabIndex = 3;
            this.showForcesButton.Text = "SHOW FORCES";
            this.showForcesButton.UseVisualStyleBackColor = true;
            this.showForcesButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.restrictionsTextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(430, 333);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(703, 78);
            this.panel2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(228, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Insert restrictions:";
            // 
            // restrictionsTextBox
            // 
            this.restrictionsTextBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.restrictionsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restrictionsTextBox.Location = new System.Drawing.Point(365, 0);
            this.restrictionsTextBox.Multiline = true;
            this.restrictionsTextBox.Name = "restrictionsTextBox";
            this.restrictionsTextBox.Size = new System.Drawing.Size(338, 78);
            this.restrictionsTextBox.TabIndex = 4;
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Statics Truss Solver";
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
        private System.Windows.Forms.Button showNodesButton;
        private System.Windows.Forms.Panel connectionsPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox connectionsTextBox;
        private System.Windows.Forms.Button showConnectionButtons;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox forcesTextBox;
        private System.Windows.Forms.Button showForcesButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox restrictionsTextBox;
        private System.Windows.Forms.Button solveButton;
        private System.Windows.Forms.Button clearLogButton;
        private System.Windows.Forms.Button clearPlotButton;
        private System.Windows.Forms.Button fullSizeButton;
    }
}