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
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
            string nodesResults = results;
            string nodesErrors = errors;
            string[] resultSeparated = nodesResults.Split('\n');
            if (resultSeparated.Length > 1)
            {
                resultBox.Text = resultSeparated[1];
                resultBox.Text += errors;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                string imageName = @"\py\nodes" + @resultSeparated[0] + ".jpg";
                imageName = imageName.Replace('\r', '.');
                imageName = imageName.Replace("..", ".");
                pictureBox.Image = Bitmap.FromFile(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + imageName);
            }
        }
    }
}
