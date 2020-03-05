using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaticsTrussSolver
{
    public partial class FullSizeForm : Form
    {

        public FullSizeForm(string path)
        {
            InitializeComponent();
            this.fullSizePB.Image = Bitmap.FromFile(path);
            this.fullSizePB.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = ".jpg|*.jpg|.bmp|*.bmp|.png|*.png";
            ImageFormat format = ImageFormat.Jpeg;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(sfd.FileName);
                switch (ext)
                {
                    case ".png":
                        format = ImageFormat.Png;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                }
                Image img = (Image)fullSizePB.Image;
                img.Save(sfd.FileName, format);
            }
        }
    }
}
