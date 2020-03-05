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

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.clearFolder();
        }

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

        // Click on add nodes
        private void button1_Click(object sender, EventArgs e)
        {
            resultBox.Text += System.Environment.NewLine + "    Processing..." + System.Environment.NewLine;
            string script = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\py\showNodes.py";
            var psi = new ProcessStartInfo();
            psi.FileName = @"C:\Users\Gianfranco Lacasella\Anaconda3\python.exe";
            string nodes = nodesTextBox.Text;
            string flag = "-n";
            psi.Arguments = $"{script} {flag} {nodes}";
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
            string Results = results;
            string[] resultSeparated = Results.Split('\n');
            if (resultSeparated.Length > 1)
            {
                resultBox.Text += resultSeparated[1];
                resultBox.Text += errors;
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
            resultBox.Text += System.Environment.NewLine + "    Processing..." + System.Environment.NewLine;
            string script = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\py\showConnections.py";
            var psi = new ProcessStartInfo();
            psi.FileName = @"C:\Users\Gianfranco Lacasella\Anaconda3\python.exe";
            string nodes = nodesTextBox.Text;
            string nodesFlag = "-n";
            string connections = connectionsTextBox.Text;
            string connectionsFlag = "-c";
            psi.Arguments = $"{script} {nodesFlag} {nodes} {connectionsFlag} {connections}";
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
            string Results = results;
            string[] resultSeparated = Results.Split('\n');
            if (resultSeparated.Length > 1)
            {
                resultBox.Text += resultSeparated[1];
                resultBox.Text += errors;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                string imageName = @"\py\connections" + @resultSeparated[0] + ".jpg";
                imageName = imageName.Replace('\r', '.');
                imageName = imageName.Replace("..", ".");
                pictureBox.Image = Bitmap.FromFile(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + imageName);
            }
        }
    }
}
