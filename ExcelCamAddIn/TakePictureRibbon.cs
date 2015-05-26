using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using System.Windows.Forms;
using System.IO;


namespace ExcelCamAddIn
{
    public partial class TakePictureRibbon
    {
        public bool saveImages;
        public int column;
        WebCam webcam;

        private void TakePictureRibbon_Load(object sender, RibbonUIEventArgs e)
        {
            column = 1;
            saveImages = false;

            groupImage.Visible = saveImages;

            txtPath.Text = Directory.GetCurrentDirectory();

            webcam = Globals.ThisAddIn.webcam;
        }

        private void btnTakePicture_Click(object sender, RibbonControlEventArgs e)
        {

        }

        private void btnShowCamDialog_Click(object sender, RibbonControlEventArgs e)
        {
            StartCamera();
        }

        private void StartCamera()
        {
            try
            {

                Globals.ThisAddIn.CustomTaskPanes[0].Visible = true;

                webcam = Globals.ThisAddIn.webcam;

                webcam.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chbSaveImages_Click(object sender, RibbonControlEventArgs e)
        {
            saveImages = chbSaveImages.Checked;

            groupImage.Visible = saveImages;
        }

        private void btnChoosePath_Click(object sender, RibbonControlEventArgs e)
        {
            var dialog = new System.Windows.Forms.FolderBrowserDialog();
            System.Windows.Forms.DialogResult result = dialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                txtPath.Text = dialog.SelectedPath.ToString();
            }
        }

        private void btnSetCellForName_Click(object sender, RibbonControlEventArgs e)
        {
            var cell = Globals.ThisAddIn.Application.ActiveCell;
            column = cell.Column;

            btnSetCellForName.Label = "Cell for name: " + column.ToString();
        }
    }
}
