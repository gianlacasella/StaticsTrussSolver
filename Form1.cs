using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StaticsTrussSolver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox.Image = Bitmap.FromFile(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\py\empty.jpg");
            this.clearFolder();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e){}

        private void clearFolder()
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\py\";
            string notDelete = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\py\empty.jpg";
            foreach (string file in Directory.GetFiles(path, "*.jpg").Where(item => item.EndsWith(".jpg")))
                {
                    if (file != notDelete) 
                    {
                        File.Delete(file);
                    }
                }
        }

        private List<string> executeScript(string argument) 
        {
            resultBox.Text += System.Environment.NewLine + "    Processing..." + System.Environment.NewLine;
            var psi = new ProcessStartInfo();
            psi.FileName = @"C:\Users\Gianfranco Lacasella\Anaconda3\python.exe";
            psi.Arguments = argument;
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;
            var errors = "";
            var results = "";
            using (var process = Process.Start(psi))
            {
                errors = process.StandardError.ReadToEnd();
                results = process.StandardOutput.ReadToEnd();
                process.Close();
            }
            return new List<string>() { results, errors };
        }

        // Click on add nodes
        private void button1_Click(object sender, EventArgs e)
        {
            string script = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\py\showNodes.py";
            string nodes = nodesTextBox.Text;
            string flag = "-n";
            List<string> resultList = this.executeScript($"{script} {flag} {nodes}");
            string Results = resultList[0];
            string[] resultSeparated = Results.Split('\n');
            if (resultSeparated.Length > 1)
            {
                resultBox.Text += resultSeparated[1];
                resultBox.Text += resultList[1];
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                string imageName = @"\py\nodes" + @resultSeparated[0] + ".jpg";
                imageName = imageName.Replace('\r', '.');
                imageName = imageName.Replace("..", ".");
                pictureBox.Image = Bitmap.FromFile(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + imageName);
            }
        }

        // Click on add connections
        private void button2_Click(object sender, EventArgs e)
        {
            string script = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\py\showConnections.py";
            string nodes = nodesTextBox.Text;
            string nodesFlag = "-n";
            string connections = connectionsTextBox.Text;
            string connectionsFlag = "-c";
            List<string> resultList = executeScript($"{script} {nodesFlag} {nodes} {connectionsFlag} {connections}");
            string Results = resultList[0];
            string[] resultSeparated = Results.Split('\n');
            if (resultSeparated.Length > 1)
            {
                resultBox.Text += resultSeparated[1];
                resultBox.Text += resultList[1];
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                string imageName = @"\py\connections" + @resultSeparated[0] + ".jpg";
                imageName = imageName.Replace('\r', '.');
                imageName = imageName.Replace("..", ".");
                pictureBox.Image = Bitmap.FromFile(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + imageName);
            }
        }

        // Click on add forces
        private void button3_Click(object sender, EventArgs e)
        {
            
            string script = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\py\showForces.py";
            string nodes = nodesTextBox.Text;
            string nodesFlag = "-n";
            string connections = connectionsTextBox.Text;
            string connectionsFlag = "-c";
            string forces= forcesTextBox.Text;
            string forcesFlag = "-f";
            List<string> resultList = executeScript($"{script} {nodesFlag} {nodes} {connectionsFlag} {connections} {forcesFlag} {forces}");
            string Results = resultList[0];
            string[] resultSeparated = Results.Split('\n');
            if (resultSeparated.Length > 1)
            {
                resultBox.Text += resultSeparated[1];
                resultBox.Text += resultList[1];
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                string imageName = @"\py\forces" + @resultSeparated[0] + ".jpg";
                imageName = imageName.Replace('\r', '.');
                imageName = imageName.Replace("..", ".");
                pictureBox.Image = Bitmap.FromFile(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + imageName);
            }
        }

        // Solve button
        private void solveButton_Click(object sender, EventArgs e)
        {
            string script = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\py\solver.py";
            string nodes = nodesTextBox.Text;
            string nodesFlag = "-n";
            string connections = connectionsTextBox.Text;
            string connectionsFlag = "-c";
            string forces = forcesTextBox.Text;
            string forcesFlag = "-f";
            string restrictions = restrictionsTextBox.Text;
            string restrictionsFlag = "-r";
            List<string> resultList = executeScript($"{script} {nodesFlag} {nodes} {connectionsFlag} {connections} {forcesFlag} {forces} {restrictionsFlag} {restrictions}");
            string Results = resultList[0];
            string[] resultSeparated = Results.Split('\n');
            if (resultSeparated.Length > 1 && resultSeparated[0] != "ERRORI\r" && resultSeparated[0] != "ERRORM\r")
            {
                resultBox.Text += resultSeparated[1] + Environment.NewLine;
                int i = 2;
                while (i < resultSeparated.Length)
                {
                    resultBox.Text += resultSeparated[i] + Environment.NewLine;
                    i++;
                }
                resultBox.Text += resultList[1];
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                string imageName = @"\py\result" + @resultSeparated[0] + ".jpg";
                imageName = imageName.Replace('\r', '.');
                imageName = imageName.Replace("..", ".");
                if (imageName != @"\py\resultERROR.jpg")
                {
                    pictureBox.Image = Bitmap.FromFile(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + imageName);
                }
            }
            else 
            {
                switch (resultSeparated[0])
                {
                    case "ERRORI\r":
                        resultBox.Text += "ERROR: GIE<0";
                        break;
                    case "ERRORM\r":
                        resultBox.Text += "ERROR: GIE>0";
                        break;
                }
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.resultBox.Text = "";
        }
    }
}
