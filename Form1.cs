using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Watermarker
{
    public partial class Form1 : Form
    {
        string[] filesToWatermark;
        Image watermarkImage;
        string saveLocation;

        Image img;
        Graphics g;

        public Form1()
        {
            InitializeComponent();
        }

        void SavePhotos()
        {
                try
                {
                    //Clear files text box
                    txtFiles.Invoke(new Action(() => {
                        txtFiles.Text = "";
                    }));

                    //File to watermark location
                    filesToWatermark = Directory.GetFiles(txtFolder.Text);

                    //Image to place over photos
                    watermarkImage = Image.FromFile(txtWatermark.Text);
                    
                    //Loop through files to watermark and watermark them
                    for (int i = 0; i < filesToWatermark.Length; i++)
                    {
                        string currentFile = filesToWatermark[i];
                        string saveFormat = null;
                        lblStatus.Invoke(new Action(() =>
                        {
                            saveFormat = cbSaveFormat.Text;
                            txtFiles.Text = txtFiles.Text + "Watermarking " + currentFile + "...\n";
                            lblStatus.Text = "Status: " + (i + 1) + " of " + filesToWatermark.Length;
                        }));
                        
                        
                        img = Image.FromFile(currentFile, true); //Current image to watermark
                        g = Graphics.FromImage(img); //Get graphics object from current image
                        g.DrawImage(watermarkImage, 0, 0, img.Width, img.Height); //Draw the watermark onto our photo
                        img.Save(saveLocation + "\\" + Path.GetFileName(currentFile).Split('.')[0] + "." + saveFormat); //Save the photo


                        //If generate small images is checked, make a new small version of watermarked image
                        if (cbGenerateSmall.Checked) {
                        //Get size for new image from the txtWidth and txtHeight
                        Size size = new Size(int.Parse(txtWidth.Text), int.Parse(txtHeight.Text));

                        //Resize image to size
                        img = resizeImage(img, size);

                        //Create small folder and save in it
                        System.IO.Directory.CreateDirectory(saveLocation + "\\small");
                        img.Save(saveLocation + "\\small\\" + Path.GetFileName(currentFile).Split('.')[0] + "." + saveFormat);
                    }

                

                        //Release memory
                        g.Dispose();
                        img.Dispose();

                        txtFiles.Invoke(new Action(() =>
                        {
                            txtFiles.Text = txtFiles.Text + "Finished watermarking " + currentFile + "...\n";
                        }));
                    }

                    txtFiles.Invoke(new Action(() =>
                    {
                        //Re enable buttons
                        cbSaveFormat.Enabled = true;
                        cbGenerateSmall.Enabled = true;
                        txtWidth.Enabled = true;
                        txtHeight.Enabled = true;
                    }));

                    MessageBox.Show("Finished watermarking " + filesToWatermark.Length + " photos.");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
                finally
                {
                    if (img != null) img.Dispose();
                    if (g != null) g.Dispose();
                }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            BGWorker.RunWorkerAsync();

            //Disable these so the user cannot change the settings while it is watermarking
            cbSaveFormat.Enabled = false;
            cbGenerateSmall.Enabled = false;
            txtWidth.Enabled = false;
            txtHeight.Enabled = false;
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            try
            {
                using (var fbd = new FolderBrowserDialog())
                {
                    //Show a dialog so the user can select a folder
                    fbd.ShowDialog();
                    txtFolder.Text = fbd.SelectedPath;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }

        private void btnSelectWatermark_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ofd = new OpenFileDialog())
                {
                    //Show a dialog so the user can select a file to place over the photos
                    ofd.ShowDialog();
                    txtWatermark.Text = ofd.FileName.ToString();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }

        private void btnSelectSaveLocation_Click(object sender, EventArgs e)
        {
            try
            {
                using (var fbd = new FolderBrowserDialog())
                {
                    //Show a dialog so the user can select a save location
                    fbd.ShowDialog();
                    saveLocation = fbd.SelectedPath;
                    txtSaveLocation.Text = fbd.SelectedPath;
                    saveLocation = fbd.SelectedPath;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }

        private void Form1_Load(object sender, EventArgs e) {}

        private void BGWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            SavePhotos();
        }

        private static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }
    }
}
