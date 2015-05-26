using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using System.Windows.Forms;

namespace ExcelCamAddIn
{
    public partial class ThisAddIn
    {
        public WebCam webcam;

        WinFormsCameraControl winformControl;
        Microsoft.Office.Tools.CustomTaskPane pane;
        System.Windows.Forms.Integration.ElementHost myHost;

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            try
            {
                webcam = new WebCam();

                winformControl = new WinFormsCameraControl();
                pane = CustomTaskPanes.Add(winformControl, "CameraControl");
                //pane.Visible = false;
                pane.Visible = true;
                pane.DockPosition = Office.MsoCTPDockPosition.msoCTPDockPositionRight;

                pane.VisibleChanged += pane_VisibleChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void pane_VisibleChanged(object sender, EventArgs e)
        {
            try
            {
                webcam.Stop();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }

        #endregion
    }
}
