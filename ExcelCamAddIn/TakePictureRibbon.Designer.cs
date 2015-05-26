namespace ExcelCamAddIn
{
    partial class TakePictureRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public TakePictureRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.groupCamera = this.Factory.CreateRibbonGroup();
            this.btnShowCamDialog = this.Factory.CreateRibbonButton();
            this.chbSaveImages = this.Factory.CreateRibbonCheckBox();
            this.groupImage = this.Factory.CreateRibbonGroup();
            this.txtPath = this.Factory.CreateRibbonEditBox();
            this.btnChoosePath = this.Factory.CreateRibbonButton();
            this.btnSetCellForName = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.groupCamera.SuspendLayout();
            this.groupImage.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.groupCamera);
            this.tab1.Groups.Add(this.groupImage);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // groupCamera
            // 
            this.groupCamera.Items.Add(this.btnShowCamDialog);
            this.groupCamera.Items.Add(this.chbSaveImages);
            this.groupCamera.Label = "Camera";
            this.groupCamera.Name = "groupCamera";
            // 
            // btnShowCamDialog
            // 
            this.btnShowCamDialog.Label = "Show camera dialog";
            this.btnShowCamDialog.Name = "btnShowCamDialog";
            this.btnShowCamDialog.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnShowCamDialog_Click);
            // 
            // chbSaveImages
            // 
            this.chbSaveImages.Label = "Save images";
            this.chbSaveImages.Name = "chbSaveImages";
            this.chbSaveImages.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.chbSaveImages_Click);
            // 
            // groupImage
            // 
            this.groupImage.Items.Add(this.txtPath);
            this.groupImage.Items.Add(this.btnChoosePath);
            this.groupImage.Items.Add(this.btnSetCellForName);
            this.groupImage.Label = "Image";
            this.groupImage.Name = "groupImage";
            // 
            // txtPath
            // 
            this.txtPath.Label = "Path";
            this.txtPath.Name = "txtPath";
            this.txtPath.ShowLabel = false;
            this.txtPath.SuperTip = "Path of saved images.";
            this.txtPath.Text = null;
            // 
            // btnChoosePath
            // 
            this.btnChoosePath.Label = "Choose path";
            this.btnChoosePath.Name = "btnChoosePath";
            this.btnChoosePath.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnChoosePath_Click);
            // 
            // btnSetCellForName
            // 
            this.btnSetCellForName.Label = "Select column for name";
            this.btnSetCellForName.Name = "btnSetCellForName";
            this.btnSetCellForName.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnSetCellForName_Click);
            // 
            // TakePictureRibbon
            // 
            this.Name = "TakePictureRibbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.TakePictureRibbon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.groupCamera.ResumeLayout(false);
            this.groupCamera.PerformLayout();
            this.groupImage.ResumeLayout(false);
            this.groupImage.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupCamera;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnShowCamDialog;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox txtPath;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox chbSaveImages;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnChoosePath;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupImage;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnSetCellForName;
    }

    partial class ThisRibbonCollection
    {
        internal TakePictureRibbon TakePictureRibbon
        {
            get { return this.GetRibbon<TakePictureRibbon>(); }
        }
    }
}
