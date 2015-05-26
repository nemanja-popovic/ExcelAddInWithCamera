using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelCamAddIn
{
    public partial class WinFormsCameraControl : UserControl
    {
        WebCam webcam;

        public WinFormsCameraControl()
        {
            InitializeComponent();
            webcam = Globals.ThisAddIn.webcam;
        }

        private void WinFormsCameraControl_Load(object sender, EventArgs e)
        {
            try
            {
                webcam = Globals.ThisAddIn.webcam;
                webcam.InitializeWebCam(ref imgVideo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnTakePicture_Click(object sender, EventArgs e)
        {
            try
            {
                bool saveImages = Globals.Ribbons.TakePictureRibbon.saveImages;

                //Save image to localstorage
                Image image = imgVideo.Image;


                string directory = "";
                if (saveImages)
                {
                    directory = Globals.Ribbons.TakePictureRibbon.txtPath.Text;
                }
                else
                {
                    directory = Directory.GetCurrentDirectory();
                }

                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                //Get filename
                int columnIndex = Globals.Ribbons.TakePictureRibbon.column;
                int rowIndex = Globals.ThisAddIn.Application.ActiveCell.Row;

                string name = "";
                if (saveImages)
                {
                    name = (string)(Globals.ThisAddIn.Application.ActiveSheet.Cells[rowIndex, columnIndex] as Excel.Range).Value;

                }
                else//Temp name for temp image
                {
                    name = DateTime.Now.Ticks.ToString();
                }
                string filename = Path.Combine(directory, name + ".jpg");

                //Check if it already exists??
                int addNumberToFilename = 0;
                while (File.Exists(filename))
                {
                    addNumberToFilename++;
                    filename = Path.Combine(directory, name + addNumberToFilename.ToString() + ".jpg");
                }

                FileStream fstream = new FileStream(filename, FileMode.Create);
                image.Save(fstream, System.Drawing.Imaging.ImageFormat.Jpeg);
                fstream.Close();

                //Insert that image to the selected position

                var cell = Globals.ThisAddIn.Application.ActiveCell;

                var left = cell.Left;
                var top = cell.Top;
                var height = cell.Height;
                var width = cell.Width;

                Globals.ThisAddIn.Application.ActiveSheet.Shapes.AddPicture(filename, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, left, top, width, height);

                //Delete temp picture from system
                if (!saveImages)
                {
                    File.Delete(filename);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            webcam = Globals.ThisAddIn.webcam;
            webcam.AdvanceSetting();
        }

        private void btnResolution_Click(object sender, EventArgs e)
        {
            webcam = Globals.ThisAddIn.webcam;
            webcam.ResolutionSetting();
        }


    }
}
