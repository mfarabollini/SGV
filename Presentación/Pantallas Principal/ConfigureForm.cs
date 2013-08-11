using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Presentación.Pantallas_Principal
{
	/// <summary>
	/// explanation of the outline of ConfigureForm
	/// </summary>
	public class ConfigureForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonApply;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabImage;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox comboBoxScanFunc;
		/// <summary>
		/// necessary designer variable
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.TabPage tabEndorse;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TabPage tabConfirmation;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.CheckBox checkBoxConfirmation;
		private System.Windows.Forms.TabPage tabPaperMisInsertion;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.CheckBox checkBoxMisInsertDetect;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBoxMisInsertEject;
		private System.Windows.Forms.CheckBox checkBoxMisInsertStamp;
		private System.Windows.Forms.CheckBox checkBoxMisInsertCancel;
		private System.Windows.Forms.TabPage tabNoise;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.CheckBox checkBoxNoiseDetect;
		private System.Windows.Forms.CheckBox checkBoxNoiseStamp;
		private System.Windows.Forms.ComboBox comboBoxNoiseEject;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox checkBoxNoiseCancel;
		private System.Windows.Forms.TabPage tabDoubleFeed;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.CheckBox checkBoxDFStamp;
		private System.Windows.Forms.ComboBox comboBoxDFEject;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox checkBoxDFCancel;
		private System.Windows.Forms.CheckBox checkBoxDFDetect;
		private System.Windows.Forms.TabPage tabNodata;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.CheckBox checkBoxNoStamp;
		private System.Windows.Forms.ComboBox comboBoxNoEject;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox checkBoxNoCancel;
		private System.Windows.Forms.CheckBox checkBoxNoDetect;
		private System.Windows.Forms.TabPage tabBaddata;
		private System.Windows.Forms.GroupBox groupBox8;
		private System.Windows.Forms.CheckBox checkBoxBadStamp;
		private System.Windows.Forms.ComboBox comboBoxBadEject;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.CheckBox checkBoxBadCancel;
		private System.Windows.Forms.CheckBox checkBoxBadDetect;
		private System.Windows.Forms.TabPage tabMICR;
		private System.Windows.Forms.GroupBox groupBox9;
		private System.Windows.Forms.GroupBox groupBox10;
		private System.Windows.Forms.CheckBox checkBoxFrontScan;
		private System.Windows.Forms.CheckBox checkBoxFrontGrayscale;
		private System.Windows.Forms.CheckBox checkBoxFrontDisplay;
		private System.Windows.Forms.CheckBox checkBoxFrontSave;
		private System.Windows.Forms.CheckBox checkBoxBackSave;
		private System.Windows.Forms.CheckBox checkBoxBackDisplay;
		private System.Windows.Forms.CheckBox checkBoxBackGrayscale;
		private System.Windows.Forms.CheckBox checkBoxBackScan;
		private System.Windows.Forms.GroupBox groupBox11;
		private System.Windows.Forms.CheckBox checkBoxMICR;
		private System.Windows.Forms.CheckBox checkBoxSave;
		private System.Windows.Forms.CheckBox checkBoxElecEndorseText;
		private System.Windows.Forms.CheckBox checkBoxElecEndorseImage;
		private System.Windows.Forms.Button buttonSettingValues;
		private System.Windows.Forms.CheckBox checkBoxNoCallScnToResult;
		private System.Windows.Forms.CheckBox checkBoxRunScnToResult;
		private System.Windows.Forms.ComboBox comboBoxMicrFont;
		private System.Windows.Forms.TabPage tabNearFull;
		private System.Windows.Forms.GroupBox groupBox12;
		private System.Windows.Forms.TabPage tabOcrAb;
		private System.Windows.Forms.TabPage tabBuzzer;
		private System.Windows.Forms.GroupBox groupBox13;
		private System.Windows.Forms.ComboBox comboBoxOcrAbFont;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.CheckBox checkBoxOcrAb;
		private System.Windows.Forms.GroupBox groupBox14;
		private System.Windows.Forms.ComboBox comboBoxSuccessCount;
		private System.Windows.Forms.ComboBox comboBoxSuccessHz;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox comboBoxErrorHz;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox comboBoxErrorCount;
		private System.Windows.Forms.ComboBox comboBoxWFeedCount;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox comboBoxWFeedHz;
		private System.Windows.Forms.ComboBox comboBoxNearFull;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textBoxBadCount;
		private System.Windows.Forms.TabPage tabSuccessStamp;
		private System.Windows.Forms.GroupBox groupBox15;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox comboBoxSuccessStamp;
		private System.Windows.Forms.TabPage tabIqa;
		private System.Windows.Forms.GroupBox groupBox16;
		private System.Windows.Forms.CheckBox checkBoxIqaStamp;
		private System.Windows.Forms.ComboBox comboBoxIqaEject;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.CheckBox checkBoxIqaCancel;
		private System.Windows.Forms.CheckBox checkBoxIqaDetect;
		private System.Windows.Forms.CheckBox checkBoxIqaGray;
		private System.Windows.Forms.TabPage tabWaterfall;
		private System.Windows.Forms.GroupBox groupBox17;
		private System.Windows.Forms.CheckBox checkBoxWaterfallEnable;
		private System.Windows.Forms.ComboBox comboBoxWaterfallMode;
		private System.Windows.Forms.TabPage tabBarcode;
		private System.Windows.Forms.GroupBox groupBox19;
		private System.Windows.Forms.CheckBox checkBoxBarcodeFrontStamp;
		private System.Windows.Forms.ComboBox comboBoxBarcodeFrontEject;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.CheckBox checkBoxBarcodeFrontCancel;
		private System.Windows.Forms.CheckBox checkBoxBarcodeFrontDetect;
		private System.Windows.Forms.GroupBox groupBox18;
		private System.Windows.Forms.CheckBox checkBoxBarcodeBackStamp;
		private System.Windows.Forms.ComboBox comboBoxBarcodeBackEject;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.CheckBox checkBoxBarcodeBackCancel;
		private System.Windows.Forms.CheckBox checkBoxBarcodeBackDetect;

		protected Properties m_objConfig = null;

		public ConfigureForm()
		{
			//
			// Required by the Windows Form Designer
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent
			//
			m_objConfig = new Properties();
			LoadProPerties();
		}

		/// <summary>
		/// Postprocessing is run to the resource that is used
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Create code by Windwos Form Designer 
		/// <summary>
		/// The following procedure is required by the Windows Form Designer
		/// It can be modified using the Windows Form Designer.
		/// Do not modify it using the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ConfigureForm));
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonApply = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabImage = new System.Windows.Forms.TabPage();
			this.groupBox9 = new System.Windows.Forms.GroupBox();
			this.checkBoxFrontSave = new System.Windows.Forms.CheckBox();
			this.checkBoxFrontDisplay = new System.Windows.Forms.CheckBox();
			this.checkBoxFrontGrayscale = new System.Windows.Forms.CheckBox();
			this.checkBoxFrontScan = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.comboBoxScanFunc = new System.Windows.Forms.ComboBox();
			this.groupBox10 = new System.Windows.Forms.GroupBox();
			this.checkBoxBackSave = new System.Windows.Forms.CheckBox();
			this.checkBoxBackDisplay = new System.Windows.Forms.CheckBox();
			this.checkBoxBackGrayscale = new System.Windows.Forms.CheckBox();
			this.checkBoxBackScan = new System.Windows.Forms.CheckBox();
			this.tabNoise = new System.Windows.Forms.TabPage();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.checkBoxNoiseStamp = new System.Windows.Forms.CheckBox();
			this.comboBoxNoiseEject = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.checkBoxNoiseCancel = new System.Windows.Forms.CheckBox();
			this.checkBoxNoiseDetect = new System.Windows.Forms.CheckBox();
			this.tabMICR = new System.Windows.Forms.TabPage();
			this.groupBox11 = new System.Windows.Forms.GroupBox();
			this.comboBoxMicrFont = new System.Windows.Forms.ComboBox();
			this.checkBoxSave = new System.Windows.Forms.CheckBox();
			this.checkBoxMICR = new System.Windows.Forms.CheckBox();
			this.tabOcrAb = new System.Windows.Forms.TabPage();
			this.groupBox13 = new System.Windows.Forms.GroupBox();
			this.comboBoxOcrAbFont = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.checkBoxOcrAb = new System.Windows.Forms.CheckBox();
			this.tabEndorse = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.checkBoxElecEndorseText = new System.Windows.Forms.CheckBox();
			this.checkBoxElecEndorseImage = new System.Windows.Forms.CheckBox();
			this.tabPaperMisInsertion = new System.Windows.Forms.TabPage();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.checkBoxMisInsertStamp = new System.Windows.Forms.CheckBox();
			this.comboBoxMisInsertEject = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.checkBoxMisInsertDetect = new System.Windows.Forms.CheckBox();
			this.checkBoxMisInsertCancel = new System.Windows.Forms.CheckBox();
			this.tabConfirmation = new System.Windows.Forms.TabPage();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.buttonSettingValues = new System.Windows.Forms.Button();
			this.checkBoxNoCallScnToResult = new System.Windows.Forms.CheckBox();
			this.checkBoxRunScnToResult = new System.Windows.Forms.CheckBox();
			this.checkBoxConfirmation = new System.Windows.Forms.CheckBox();
			this.tabDoubleFeed = new System.Windows.Forms.TabPage();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.checkBoxDFStamp = new System.Windows.Forms.CheckBox();
			this.comboBoxDFEject = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.checkBoxDFCancel = new System.Windows.Forms.CheckBox();
			this.checkBoxDFDetect = new System.Windows.Forms.CheckBox();
			this.tabBaddata = new System.Windows.Forms.TabPage();
			this.groupBox8 = new System.Windows.Forms.GroupBox();
			this.textBoxBadCount = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.checkBoxBadStamp = new System.Windows.Forms.CheckBox();
			this.comboBoxBadEject = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.checkBoxBadCancel = new System.Windows.Forms.CheckBox();
			this.checkBoxBadDetect = new System.Windows.Forms.CheckBox();
			this.tabNodata = new System.Windows.Forms.TabPage();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.checkBoxNoStamp = new System.Windows.Forms.CheckBox();
			this.comboBoxNoEject = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.checkBoxNoCancel = new System.Windows.Forms.CheckBox();
			this.checkBoxNoDetect = new System.Windows.Forms.CheckBox();
			this.tabNearFull = new System.Windows.Forms.TabPage();
			this.groupBox12 = new System.Windows.Forms.GroupBox();
			this.comboBoxNearFull = new System.Windows.Forms.ComboBox();
			this.tabBuzzer = new System.Windows.Forms.TabPage();
			this.groupBox14 = new System.Windows.Forms.GroupBox();
			this.comboBoxSuccessCount = new System.Windows.Forms.ComboBox();
			this.comboBoxSuccessHz = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.comboBoxErrorHz = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.comboBoxErrorCount = new System.Windows.Forms.ComboBox();
			this.comboBoxWFeedCount = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.comboBoxWFeedHz = new System.Windows.Forms.ComboBox();
			this.tabSuccessStamp = new System.Windows.Forms.TabPage();
			this.groupBox15 = new System.Windows.Forms.GroupBox();
			this.comboBoxSuccessStamp = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.tabIqa = new System.Windows.Forms.TabPage();
			this.groupBox16 = new System.Windows.Forms.GroupBox();
			this.checkBoxIqaGray = new System.Windows.Forms.CheckBox();
			this.checkBoxIqaStamp = new System.Windows.Forms.CheckBox();
			this.comboBoxIqaEject = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.checkBoxIqaCancel = new System.Windows.Forms.CheckBox();
			this.checkBoxIqaDetect = new System.Windows.Forms.CheckBox();
			this.tabWaterfall = new System.Windows.Forms.TabPage();
			this.groupBox17 = new System.Windows.Forms.GroupBox();
			this.comboBoxWaterfallMode = new System.Windows.Forms.ComboBox();
			this.checkBoxWaterfallEnable = new System.Windows.Forms.CheckBox();
			this.tabBarcode = new System.Windows.Forms.TabPage();
			this.groupBox19 = new System.Windows.Forms.GroupBox();
			this.checkBoxBarcodeFrontStamp = new System.Windows.Forms.CheckBox();
			this.comboBoxBarcodeFrontEject = new System.Windows.Forms.ComboBox();
			this.label13 = new System.Windows.Forms.Label();
			this.checkBoxBarcodeFrontCancel = new System.Windows.Forms.CheckBox();
			this.checkBoxBarcodeFrontDetect = new System.Windows.Forms.CheckBox();
			this.groupBox18 = new System.Windows.Forms.GroupBox();
			this.checkBoxBarcodeBackStamp = new System.Windows.Forms.CheckBox();
			this.comboBoxBarcodeBackEject = new System.Windows.Forms.ComboBox();
			this.label14 = new System.Windows.Forms.Label();
			this.checkBoxBarcodeBackCancel = new System.Windows.Forms.CheckBox();
			this.checkBoxBarcodeBackDetect = new System.Windows.Forms.CheckBox();
			this.tabControl1.SuspendLayout();
			this.tabImage.SuspendLayout();
			this.groupBox9.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox10.SuspendLayout();
			this.tabNoise.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.tabMICR.SuspendLayout();
			this.groupBox11.SuspendLayout();
			this.tabOcrAb.SuspendLayout();
			this.groupBox13.SuspendLayout();
			this.tabEndorse.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.tabPaperMisInsertion.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.tabConfirmation.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.tabDoubleFeed.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.tabBaddata.SuspendLayout();
			this.groupBox8.SuspendLayout();
			this.tabNodata.SuspendLayout();
			this.groupBox7.SuspendLayout();
			this.tabNearFull.SuspendLayout();
			this.groupBox12.SuspendLayout();
			this.tabBuzzer.SuspendLayout();
			this.groupBox14.SuspendLayout();
			this.tabSuccessStamp.SuspendLayout();
			this.groupBox15.SuspendLayout();
			this.tabIqa.SuspendLayout();
			this.groupBox16.SuspendLayout();
			this.tabWaterfall.SuspendLayout();
			this.groupBox17.SuspendLayout();
			this.tabBarcode.SuspendLayout();
			this.groupBox19.SuspendLayout();
			this.groupBox18.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonOK
			// 
			this.buttonOK.Location = new System.Drawing.Point(8, 256);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.TabIndex = 0;
			this.buttonOK.Text = "OK";
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(112, 256);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.TabIndex = 0;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// buttonApply
			// 
			this.buttonApply.Location = new System.Drawing.Point(216, 256);
			this.buttonApply.Name = "buttonApply";
			this.buttonApply.TabIndex = 0;
			this.buttonApply.Text = "Apply";
			this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabImage);
			this.tabControl1.Controls.Add(this.tabNoise);
			this.tabControl1.Controls.Add(this.tabMICR);
			this.tabControl1.Controls.Add(this.tabOcrAb);
			this.tabControl1.Controls.Add(this.tabEndorse);
			this.tabControl1.Controls.Add(this.tabPaperMisInsertion);
			this.tabControl1.Controls.Add(this.tabConfirmation);
			this.tabControl1.Controls.Add(this.tabDoubleFeed);
			this.tabControl1.Controls.Add(this.tabBaddata);
			this.tabControl1.Controls.Add(this.tabNodata);
			this.tabControl1.Controls.Add(this.tabNearFull);
			this.tabControl1.Controls.Add(this.tabBuzzer);
			this.tabControl1.Controls.Add(this.tabSuccessStamp);
			this.tabControl1.Controls.Add(this.tabIqa);
			this.tabControl1.Controls.Add(this.tabWaterfall);
			this.tabControl1.Controls.Add(this.tabBarcode);
			this.tabControl1.Location = new System.Drawing.Point(8, 8);
			this.tabControl1.Multiline = true;
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(280, 232);
			this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
			this.tabControl1.TabIndex = 1;
			// 
			// tabImage
			// 
			this.tabImage.Controls.Add(this.groupBox9);
			this.tabImage.Controls.Add(this.groupBox1);
			this.tabImage.Controls.Add(this.groupBox10);
			this.tabImage.Location = new System.Drawing.Point(4, 72);
			this.tabImage.Name = "tabImage";
			this.tabImage.Size = new System.Drawing.Size(272, 156);
			this.tabImage.TabIndex = 0;
			this.tabImage.Text = "Image";
			// 
			// groupBox9
			// 
			this.groupBox9.Controls.Add(this.checkBoxFrontSave);
			this.groupBox9.Controls.Add(this.checkBoxFrontDisplay);
			this.groupBox9.Controls.Add(this.checkBoxFrontGrayscale);
			this.groupBox9.Controls.Add(this.checkBoxFrontScan);
			this.groupBox9.Location = new System.Drawing.Point(0, 64);
			this.groupBox9.Name = "groupBox9";
			this.groupBox9.Size = new System.Drawing.Size(136, 88);
			this.groupBox9.TabIndex = 1;
			this.groupBox9.TabStop = false;
			this.groupBox9.Text = "Front";
			// 
			// checkBoxFrontSave
			// 
			this.checkBoxFrontSave.Location = new System.Drawing.Point(8, 64);
			this.checkBoxFrontSave.Name = "checkBoxFrontSave";
			this.checkBoxFrontSave.Size = new System.Drawing.Size(120, 16);
			this.checkBoxFrontSave.TabIndex = 3;
			this.checkBoxFrontSave.Text = "Save to Harddisk";
			this.checkBoxFrontSave.CheckedChanged += new System.EventHandler(this.checkBoxFrontSave_CheckedChanged);
			// 
			// checkBoxFrontDisplay
			// 
			this.checkBoxFrontDisplay.Location = new System.Drawing.Point(8, 48);
			this.checkBoxFrontDisplay.Name = "checkBoxFrontDisplay";
			this.checkBoxFrontDisplay.Size = new System.Drawing.Size(120, 16);
			this.checkBoxFrontDisplay.TabIndex = 2;
			this.checkBoxFrontDisplay.Text = "Display on Screen";
			this.checkBoxFrontDisplay.CheckedChanged += new System.EventHandler(this.checkBoxFrontDisplay_CheckedChanged);
			// 
			// checkBoxFrontGrayscale
			// 
			this.checkBoxFrontGrayscale.Location = new System.Drawing.Point(8, 32);
			this.checkBoxFrontGrayscale.Name = "checkBoxFrontGrayscale";
			this.checkBoxFrontGrayscale.Size = new System.Drawing.Size(104, 16);
			this.checkBoxFrontGrayscale.TabIndex = 1;
			this.checkBoxFrontGrayscale.Text = "Grayscale";
			this.checkBoxFrontGrayscale.CheckedChanged += new System.EventHandler(this.checkBoxFrontGrayscale_CheckedChanged);
			// 
			// checkBoxFrontScan
			// 
			this.checkBoxFrontScan.Location = new System.Drawing.Point(8, 16);
			this.checkBoxFrontScan.Name = "checkBoxFrontScan";
			this.checkBoxFrontScan.Size = new System.Drawing.Size(104, 16);
			this.checkBoxFrontScan.TabIndex = 0;
			this.checkBoxFrontScan.Text = "Scan";
			this.checkBoxFrontScan.CheckedChanged += new System.EventHandler(this.checkBoxFrontScan_CheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.comboBoxScanFunc);
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(272, 64);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Scanner";
			// 
			// comboBoxScanFunc
			// 
			this.comboBoxScanFunc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxScanFunc.Items.AddRange(new object[] {
																  "Multi Scan",
																  "Single Scan"});
			this.comboBoxScanFunc.Location = new System.Drawing.Point(72, 24);
			this.comboBoxScanFunc.Name = "comboBoxScanFunc";
			this.comboBoxScanFunc.Size = new System.Drawing.Size(136, 20);
			this.comboBoxScanFunc.TabIndex = 0;
			this.comboBoxScanFunc.SelectedIndexChanged += new System.EventHandler(this.comboBoxScanFunc_SelectedIndexChanged);
			// 
			// groupBox10
			// 
			this.groupBox10.Controls.Add(this.checkBoxBackSave);
			this.groupBox10.Controls.Add(this.checkBoxBackDisplay);
			this.groupBox10.Controls.Add(this.checkBoxBackGrayscale);
			this.groupBox10.Controls.Add(this.checkBoxBackScan);
			this.groupBox10.Location = new System.Drawing.Point(136, 64);
			this.groupBox10.Name = "groupBox10";
			this.groupBox10.Size = new System.Drawing.Size(136, 88);
			this.groupBox10.TabIndex = 1;
			this.groupBox10.TabStop = false;
			this.groupBox10.Text = "Back";
			// 
			// checkBoxBackSave
			// 
			this.checkBoxBackSave.Location = new System.Drawing.Point(8, 64);
			this.checkBoxBackSave.Name = "checkBoxBackSave";
			this.checkBoxBackSave.Size = new System.Drawing.Size(120, 16);
			this.checkBoxBackSave.TabIndex = 7;
			this.checkBoxBackSave.Text = "Save to Harddisk";
			this.checkBoxBackSave.CheckedChanged += new System.EventHandler(this.checkBoxBackSave_CheckedChanged);
			// 
			// checkBoxBackDisplay
			// 
			this.checkBoxBackDisplay.Location = new System.Drawing.Point(8, 48);
			this.checkBoxBackDisplay.Name = "checkBoxBackDisplay";
			this.checkBoxBackDisplay.Size = new System.Drawing.Size(120, 16);
			this.checkBoxBackDisplay.TabIndex = 6;
			this.checkBoxBackDisplay.Text = "Display on Screen";
			this.checkBoxBackDisplay.CheckedChanged += new System.EventHandler(this.checkBoxBackDisplay_CheckedChanged);
			// 
			// checkBoxBackGrayscale
			// 
			this.checkBoxBackGrayscale.Location = new System.Drawing.Point(8, 32);
			this.checkBoxBackGrayscale.Name = "checkBoxBackGrayscale";
			this.checkBoxBackGrayscale.Size = new System.Drawing.Size(104, 16);
			this.checkBoxBackGrayscale.TabIndex = 5;
			this.checkBoxBackGrayscale.Text = "Grayscale";
			this.checkBoxBackGrayscale.CheckedChanged += new System.EventHandler(this.checkBoxBackGrayscale_CheckedChanged);
			// 
			// checkBoxBackScan
			// 
			this.checkBoxBackScan.Location = new System.Drawing.Point(8, 16);
			this.checkBoxBackScan.Name = "checkBoxBackScan";
			this.checkBoxBackScan.Size = new System.Drawing.Size(104, 16);
			this.checkBoxBackScan.TabIndex = 4;
			this.checkBoxBackScan.Text = "Scan";
			this.checkBoxBackScan.CheckedChanged += new System.EventHandler(this.checkBoxBackScan_CheckedChanged);
			// 
			// tabNoise
			// 
			this.tabNoise.Controls.Add(this.groupBox5);
			this.tabNoise.Location = new System.Drawing.Point(4, 72);
			this.tabNoise.Name = "tabNoise";
			this.tabNoise.Size = new System.Drawing.Size(272, 156);
			this.tabNoise.TabIndex = 4;
			this.tabNoise.Text = "Noise";
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.checkBoxNoiseStamp);
			this.groupBox5.Controls.Add(this.comboBoxNoiseEject);
			this.groupBox5.Controls.Add(this.label2);
			this.groupBox5.Controls.Add(this.checkBoxNoiseCancel);
			this.groupBox5.Controls.Add(this.checkBoxNoiseDetect);
			this.groupBox5.Location = new System.Drawing.Point(0, 0);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(272, 152);
			this.groupBox5.TabIndex = 0;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Settings";
			// 
			// checkBoxNoiseStamp
			// 
			this.checkBoxNoiseStamp.Location = new System.Drawing.Point(120, 88);
			this.checkBoxNoiseStamp.Name = "checkBoxNoiseStamp";
			this.checkBoxNoiseStamp.TabIndex = 6;
			this.checkBoxNoiseStamp.Text = "Stamp";
			this.checkBoxNoiseStamp.CheckedChanged += new System.EventHandler(this.checkBoxNoiseStamp_CheckedChanged);
			// 
			// comboBoxNoiseEject
			// 
			this.comboBoxNoiseEject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxNoiseEject.Items.AddRange(new object[] {
																	"Main Eject",
																	"Sub Eject"});
			this.comboBoxNoiseEject.Location = new System.Drawing.Point(120, 56);
			this.comboBoxNoiseEject.Name = "comboBoxNoiseEject";
			this.comboBoxNoiseEject.Size = new System.Drawing.Size(121, 20);
			this.comboBoxNoiseEject.TabIndex = 5;
			this.comboBoxNoiseEject.SelectedIndexChanged += new System.EventHandler(this.comboBoxNoiseEject_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Eject Type";
			// 
			// checkBoxNoiseCancel
			// 
			this.checkBoxNoiseCancel.Location = new System.Drawing.Point(120, 120);
			this.checkBoxNoiseCancel.Name = "checkBoxNoiseCancel";
			this.checkBoxNoiseCancel.TabIndex = 7;
			this.checkBoxNoiseCancel.Text = "Cancel";
			this.checkBoxNoiseCancel.CheckedChanged += new System.EventHandler(this.checkBoxNoiseCancel_CheckedChanged);
			// 
			// checkBoxNoiseDetect
			// 
			this.checkBoxNoiseDetect.Location = new System.Drawing.Point(48, 24);
			this.checkBoxNoiseDetect.Name = "checkBoxNoiseDetect";
			this.checkBoxNoiseDetect.TabIndex = 0;
			this.checkBoxNoiseDetect.Text = "Detect";
			this.checkBoxNoiseDetect.CheckedChanged += new System.EventHandler(this.checkBoxNoiseDetect_CheckedChanged);
			// 
			// tabMICR
			// 
			this.tabMICR.Controls.Add(this.groupBox11);
			this.tabMICR.Location = new System.Drawing.Point(4, 72);
			this.tabMICR.Name = "tabMICR";
			this.tabMICR.Size = new System.Drawing.Size(272, 156);
			this.tabMICR.TabIndex = 8;
			this.tabMICR.Text = "MICR";
			// 
			// groupBox11
			// 
			this.groupBox11.Controls.Add(this.comboBoxMicrFont);
			this.groupBox11.Controls.Add(this.checkBoxSave);
			this.groupBox11.Controls.Add(this.checkBoxMICR);
			this.groupBox11.Location = new System.Drawing.Point(0, 0);
			this.groupBox11.Name = "groupBox11";
			this.groupBox11.Size = new System.Drawing.Size(272, 152);
			this.groupBox11.TabIndex = 0;
			this.groupBox11.TabStop = false;
			this.groupBox11.Text = "Settings";
			// 
			// comboBoxMicrFont
			// 
			this.comboBoxMicrFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxMicrFont.Items.AddRange(new object[] {
																  "E13B",
																  "CMC7"});
			this.comboBoxMicrFont.Location = new System.Drawing.Point(8, 112);
			this.comboBoxMicrFont.Name = "comboBoxMicrFont";
			this.comboBoxMicrFont.Size = new System.Drawing.Size(96, 20);
			this.comboBoxMicrFont.TabIndex = 4;
			this.comboBoxMicrFont.SelectedIndexChanged += new System.EventHandler(this.comboBoxMicrFont_SelectedIndexChanged);
			// 
			// checkBoxSave
			// 
			this.checkBoxSave.Location = new System.Drawing.Point(8, 64);
			this.checkBoxSave.Name = "checkBoxSave";
			this.checkBoxSave.Size = new System.Drawing.Size(256, 24);
			this.checkBoxSave.TabIndex = 3;
			this.checkBoxSave.Text = "Save MICR/OcrAB information to Harddisk";
			this.checkBoxSave.CheckedChanged += new System.EventHandler(this.checkBoxSave_CheckedChanged);
			// 
			// checkBoxMICR
			// 
			this.checkBoxMICR.Location = new System.Drawing.Point(8, 24);
			this.checkBoxMICR.Name = "checkBoxMICR";
			this.checkBoxMICR.Size = new System.Drawing.Size(248, 24);
			this.checkBoxMICR.TabIndex = 0;
			this.checkBoxMICR.Text = "Read characters magnetically [MICR}";
			this.checkBoxMICR.CheckedChanged += new System.EventHandler(this.checkBoxMICR_CheckedChanged);
			// 
			// tabOcrAb
			// 
			this.tabOcrAb.Controls.Add(this.groupBox13);
			this.tabOcrAb.Location = new System.Drawing.Point(4, 72);
			this.tabOcrAb.Name = "tabOcrAb";
			this.tabOcrAb.Size = new System.Drawing.Size(272, 156);
			this.tabOcrAb.TabIndex = 10;
			this.tabOcrAb.Text = "OcrAB";
			// 
			// groupBox13
			// 
			this.groupBox13.Controls.Add(this.comboBoxOcrAbFont);
			this.groupBox13.Controls.Add(this.label6);
			this.groupBox13.Controls.Add(this.checkBoxOcrAb);
			this.groupBox13.Location = new System.Drawing.Point(0, 2);
			this.groupBox13.Name = "groupBox13";
			this.groupBox13.Size = new System.Drawing.Size(272, 152);
			this.groupBox13.TabIndex = 1;
			this.groupBox13.TabStop = false;
			this.groupBox13.Text = "Settings";
			// 
			// comboBoxOcrAbFont
			// 
			this.comboBoxOcrAbFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxOcrAbFont.Items.AddRange(new object[] {
																   "OCR_A",
																   "OCR_B"});
			this.comboBoxOcrAbFont.Location = new System.Drawing.Point(120, 80);
			this.comboBoxOcrAbFont.Name = "comboBoxOcrAbFont";
			this.comboBoxOcrAbFont.Size = new System.Drawing.Size(121, 20);
			this.comboBoxOcrAbFont.TabIndex = 2;
			this.comboBoxOcrAbFont.SelectedIndexChanged += new System.EventHandler(this.comboBoxOcrAbFont_SelectedIndexChanged);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(40, 80);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(48, 16);
			this.label6.TabIndex = 1;
			this.label6.Text = "Font";
			// 
			// checkBoxOcrAb
			// 
			this.checkBoxOcrAb.Location = new System.Drawing.Point(32, 24);
			this.checkBoxOcrAb.Name = "checkBoxOcrAb";
			this.checkBoxOcrAb.TabIndex = 0;
			this.checkBoxOcrAb.Text = "OCR AB";
			this.checkBoxOcrAb.CheckedChanged += new System.EventHandler(this.checkBoxOcrAb_CheckedChanged);
			// 
			// tabEndorse
			// 
			this.tabEndorse.Controls.Add(this.groupBox2);
			this.tabEndorse.Location = new System.Drawing.Point(4, 72);
			this.tabEndorse.Name = "tabEndorse";
			this.tabEndorse.Size = new System.Drawing.Size(272, 156);
			this.tabEndorse.TabIndex = 1;
			this.tabEndorse.Text = "Endorse";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.checkBoxElecEndorseText);
			this.groupBox2.Controls.Add(this.checkBoxElecEndorseImage);
			this.groupBox2.Location = new System.Drawing.Point(0, 0);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(272, 152);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Settings";
			// 
			// checkBoxElecEndorseText
			// 
			this.checkBoxElecEndorseText.Location = new System.Drawing.Point(16, 48);
			this.checkBoxElecEndorseText.Name = "checkBoxElecEndorseText";
			this.checkBoxElecEndorseText.Size = new System.Drawing.Size(224, 24);
			this.checkBoxElecEndorseText.TabIndex = 0;
			this.checkBoxElecEndorseText.Text = "Perform electronic endorsement[Text]";
			this.checkBoxElecEndorseText.CheckedChanged += new System.EventHandler(this.checkBoxElecEndorseText_CheckedChanged);
			// 
			// checkBoxElecEndorseImage
			// 
			this.checkBoxElecEndorseImage.Location = new System.Drawing.Point(16, 80);
			this.checkBoxElecEndorseImage.Name = "checkBoxElecEndorseImage";
			this.checkBoxElecEndorseImage.Size = new System.Drawing.Size(240, 24);
			this.checkBoxElecEndorseImage.TabIndex = 0;
			this.checkBoxElecEndorseImage.Text = "Perform electronic endorsement[Image]";
			this.checkBoxElecEndorseImage.CheckedChanged += new System.EventHandler(this.checkBoxElecEndorseImage_CheckedChanged);
			// 
			// tabPaperMisInsertion
			// 
			this.tabPaperMisInsertion.Controls.Add(this.groupBox4);
			this.tabPaperMisInsertion.Location = new System.Drawing.Point(4, 38);
			this.tabPaperMisInsertion.Name = "tabPaperMisInsertion";
			this.tabPaperMisInsertion.Size = new System.Drawing.Size(272, 190);
			this.tabPaperMisInsertion.TabIndex = 3;
			this.tabPaperMisInsertion.Text = "PaperMisInsert";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.checkBoxMisInsertStamp);
			this.groupBox4.Controls.Add(this.comboBoxMisInsertEject);
			this.groupBox4.Controls.Add(this.label1);
			this.groupBox4.Controls.Add(this.checkBoxMisInsertDetect);
			this.groupBox4.Controls.Add(this.checkBoxMisInsertCancel);
			this.groupBox4.Location = new System.Drawing.Point(0, 0);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(272, 160);
			this.groupBox4.TabIndex = 0;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Settings";
			// 
			// checkBoxMisInsertStamp
			// 
			this.checkBoxMisInsertStamp.Location = new System.Drawing.Point(120, 88);
			this.checkBoxMisInsertStamp.Name = "checkBoxMisInsertStamp";
			this.checkBoxMisInsertStamp.TabIndex = 3;
			this.checkBoxMisInsertStamp.Text = "Stamp";
			this.checkBoxMisInsertStamp.CheckedChanged += new System.EventHandler(this.checkBoxMisInsertStamp_CheckedChanged);
			// 
			// comboBoxMisInsertEject
			// 
			this.comboBoxMisInsertEject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxMisInsertEject.Items.AddRange(new object[] {
																		"Main Eject",
																		"Sub Eject"});
			this.comboBoxMisInsertEject.Location = new System.Drawing.Point(120, 56);
			this.comboBoxMisInsertEject.Name = "comboBoxMisInsertEject";
			this.comboBoxMisInsertEject.Size = new System.Drawing.Size(121, 20);
			this.comboBoxMisInsertEject.TabIndex = 2;
			this.comboBoxMisInsertEject.SelectedIndexChanged += new System.EventHandler(this.comboBoxMisInsertEject_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Eject Type";
			// 
			// checkBoxMisInsertDetect
			// 
			this.checkBoxMisInsertDetect.Location = new System.Drawing.Point(48, 24);
			this.checkBoxMisInsertDetect.Name = "checkBoxMisInsertDetect";
			this.checkBoxMisInsertDetect.TabIndex = 0;
			this.checkBoxMisInsertDetect.Text = "Detect";
			this.checkBoxMisInsertDetect.CheckedChanged += new System.EventHandler(this.checkBoxMisInsertDetect_CheckedChanged);
			// 
			// checkBoxMisInsertCancel
			// 
			this.checkBoxMisInsertCancel.Location = new System.Drawing.Point(120, 120);
			this.checkBoxMisInsertCancel.Name = "checkBoxMisInsertCancel";
			this.checkBoxMisInsertCancel.TabIndex = 3;
			this.checkBoxMisInsertCancel.Text = "Cancel";
			this.checkBoxMisInsertCancel.CheckedChanged += new System.EventHandler(this.checkBoxMisInsertCancel_CheckedChanged);
			// 
			// tabConfirmation
			// 
			this.tabConfirmation.Controls.Add(this.groupBox3);
			this.tabConfirmation.Location = new System.Drawing.Point(4, 38);
			this.tabConfirmation.Name = "tabConfirmation";
			this.tabConfirmation.Size = new System.Drawing.Size(272, 190);
			this.tabConfirmation.TabIndex = 2;
			this.tabConfirmation.Text = "Confirmation";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.buttonSettingValues);
			this.groupBox3.Controls.Add(this.checkBoxNoCallScnToResult);
			this.groupBox3.Controls.Add(this.checkBoxRunScnToResult);
			this.groupBox3.Controls.Add(this.checkBoxConfirmation);
			this.groupBox3.Location = new System.Drawing.Point(0, 0);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(272, 152);
			this.groupBox3.TabIndex = 0;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Settings";
			// 
			// buttonSettingValues
			// 
			this.buttonSettingValues.Location = new System.Drawing.Point(104, 120);
			this.buttonSettingValues.Name = "buttonSettingValues";
			this.buttonSettingValues.Size = new System.Drawing.Size(88, 23);
			this.buttonSettingValues.TabIndex = 12;
			this.buttonSettingValues.Text = "Setting Values";
			this.buttonSettingValues.Click += new System.EventHandler(this.buttonSettingValues_Click);
			// 
			// checkBoxNoCallScnToResult
			// 
			this.checkBoxNoCallScnToResult.Location = new System.Drawing.Point(72, 88);
			this.checkBoxNoCallScnToResult.Name = "checkBoxNoCallScnToResult";
			this.checkBoxNoCallScnToResult.Size = new System.Drawing.Size(192, 16);
			this.checkBoxNoCallScnToResult.TabIndex = 11;
			this.checkBoxNoCallScnToResult.Text = "No call SetBehaviorToScnResult";
			this.checkBoxNoCallScnToResult.CheckedChanged += new System.EventHandler(this.checkBoxNoCallScnToResult_CheckedChanged);
			// 
			// checkBoxRunScnToResult
			// 
			this.checkBoxRunScnToResult.Location = new System.Drawing.Point(48, 56);
			this.checkBoxRunScnToResult.Name = "checkBoxRunScnToResult";
			this.checkBoxRunScnToResult.Size = new System.Drawing.Size(184, 16);
			this.checkBoxRunScnToResult.TabIndex = 10;
			this.checkBoxRunScnToResult.Text = "Run SetBehaviorToScnResult";
			this.checkBoxRunScnToResult.CheckedChanged += new System.EventHandler(this.checkBoxRunScnToResult_CheckedChanged);
			// 
			// checkBoxConfirmation
			// 
			this.checkBoxConfirmation.Location = new System.Drawing.Point(32, 24);
			this.checkBoxConfirmation.Name = "checkBoxConfirmation";
			this.checkBoxConfirmation.Size = new System.Drawing.Size(144, 16);
			this.checkBoxConfirmation.TabIndex = 0;
			this.checkBoxConfirmation.Text = "Confirmation Mode";
			this.checkBoxConfirmation.CheckedChanged += new System.EventHandler(this.checkBoxConfirmation_CheckedChanged);
			// 
			// tabDoubleFeed
			// 
			this.tabDoubleFeed.Controls.Add(this.groupBox6);
			this.tabDoubleFeed.Location = new System.Drawing.Point(4, 38);
			this.tabDoubleFeed.Name = "tabDoubleFeed";
			this.tabDoubleFeed.Size = new System.Drawing.Size(272, 190);
			this.tabDoubleFeed.TabIndex = 5;
			this.tabDoubleFeed.Text = "DoubleFeed";
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.checkBoxDFStamp);
			this.groupBox6.Controls.Add(this.comboBoxDFEject);
			this.groupBox6.Controls.Add(this.label3);
			this.groupBox6.Controls.Add(this.checkBoxDFCancel);
			this.groupBox6.Controls.Add(this.checkBoxDFDetect);
			this.groupBox6.Location = new System.Drawing.Point(0, 3);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(272, 149);
			this.groupBox6.TabIndex = 1;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Settings";
			// 
			// checkBoxDFStamp
			// 
			this.checkBoxDFStamp.Location = new System.Drawing.Point(120, 88);
			this.checkBoxDFStamp.Name = "checkBoxDFStamp";
			this.checkBoxDFStamp.TabIndex = 6;
			this.checkBoxDFStamp.Text = "Stamp";
			this.checkBoxDFStamp.CheckedChanged += new System.EventHandler(this.checkBoxDFStamp_CheckedChanged);
			// 
			// comboBoxDFEject
			// 
			this.comboBoxDFEject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxDFEject.Items.AddRange(new object[] {
																 "Main Eject",
																 "Sub Eject"});
			this.comboBoxDFEject.Location = new System.Drawing.Point(120, 56);
			this.comboBoxDFEject.Name = "comboBoxDFEject";
			this.comboBoxDFEject.Size = new System.Drawing.Size(121, 20);
			this.comboBoxDFEject.TabIndex = 5;
			this.comboBoxDFEject.SelectedIndexChanged += new System.EventHandler(this.comboBoxDFEject_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 56);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Eject Type";
			// 
			// checkBoxDFCancel
			// 
			this.checkBoxDFCancel.Location = new System.Drawing.Point(120, 120);
			this.checkBoxDFCancel.Name = "checkBoxDFCancel";
			this.checkBoxDFCancel.TabIndex = 7;
			this.checkBoxDFCancel.Text = "Cancel";
			this.checkBoxDFCancel.CheckedChanged += new System.EventHandler(this.checkBoxDFCancel_CheckedChanged);
			// 
			// checkBoxDFDetect
			// 
			this.checkBoxDFDetect.Location = new System.Drawing.Point(48, 24);
			this.checkBoxDFDetect.Name = "checkBoxDFDetect";
			this.checkBoxDFDetect.TabIndex = 0;
			this.checkBoxDFDetect.Text = "Detect";
			this.checkBoxDFDetect.CheckedChanged += new System.EventHandler(this.checkBoxDFDetect_CheckedChanged);
			// 
			// tabBaddata
			// 
			this.tabBaddata.Controls.Add(this.groupBox8);
			this.tabBaddata.Location = new System.Drawing.Point(4, 55);
			this.tabBaddata.Name = "tabBaddata";
			this.tabBaddata.Size = new System.Drawing.Size(272, 173);
			this.tabBaddata.TabIndex = 7;
			this.tabBaddata.Text = "Baddata";
			// 
			// groupBox8
			// 
			this.groupBox8.Controls.Add(this.textBoxBadCount);
			this.groupBox8.Controls.Add(this.label10);
			this.groupBox8.Controls.Add(this.checkBoxBadStamp);
			this.groupBox8.Controls.Add(this.comboBoxBadEject);
			this.groupBox8.Controls.Add(this.label5);
			this.groupBox8.Controls.Add(this.checkBoxBadCancel);
			this.groupBox8.Controls.Add(this.checkBoxBadDetect);
			this.groupBox8.Location = new System.Drawing.Point(0, 3);
			this.groupBox8.Name = "groupBox8";
			this.groupBox8.Size = new System.Drawing.Size(272, 149);
			this.groupBox8.TabIndex = 3;
			this.groupBox8.TabStop = false;
			this.groupBox8.Text = "Settings";
			// 
			// textBoxBadCount
			// 
			this.textBoxBadCount.Location = new System.Drawing.Point(120, 120);
			this.textBoxBadCount.Name = "textBoxBadCount";
			this.textBoxBadCount.TabIndex = 9;
			this.textBoxBadCount.Text = "";
			this.textBoxBadCount.TextChanged += new System.EventHandler(this.textBoxBadCount_TextChanged);
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(16, 120);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(56, 23);
			this.label10.TabIndex = 8;
			this.label10.Text = "Count";
			// 
			// checkBoxBadStamp
			// 
			this.checkBoxBadStamp.Location = new System.Drawing.Point(120, 72);
			this.checkBoxBadStamp.Name = "checkBoxBadStamp";
			this.checkBoxBadStamp.TabIndex = 6;
			this.checkBoxBadStamp.Text = "Stamp";
			this.checkBoxBadStamp.CheckedChanged += new System.EventHandler(this.checkBoxBadStamp_CheckedChanged);
			// 
			// comboBoxBadEject
			// 
			this.comboBoxBadEject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxBadEject.Items.AddRange(new object[] {
																  "Main Eject",
																  "Sub Eject"});
			this.comboBoxBadEject.Location = new System.Drawing.Point(120, 48);
			this.comboBoxBadEject.Name = "comboBoxBadEject";
			this.comboBoxBadEject.Size = new System.Drawing.Size(121, 20);
			this.comboBoxBadEject.TabIndex = 5;
			this.comboBoxBadEject.SelectedIndexChanged += new System.EventHandler(this.comboBoxBadEject_SelectedIndexChanged);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 48);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "Eject Type";
			// 
			// checkBoxBadCancel
			// 
			this.checkBoxBadCancel.Location = new System.Drawing.Point(120, 96);
			this.checkBoxBadCancel.Name = "checkBoxBadCancel";
			this.checkBoxBadCancel.TabIndex = 7;
			this.checkBoxBadCancel.Text = "Cancel";
			this.checkBoxBadCancel.CheckedChanged += new System.EventHandler(this.checkBoxBadCancel_CheckedChanged);
			// 
			// checkBoxBadDetect
			// 
			this.checkBoxBadDetect.Location = new System.Drawing.Point(48, 16);
			this.checkBoxBadDetect.Name = "checkBoxBadDetect";
			this.checkBoxBadDetect.TabIndex = 0;
			this.checkBoxBadDetect.Text = "Detect";
			this.checkBoxBadDetect.CheckedChanged += new System.EventHandler(this.checkBoxBadDetect_CheckedChanged);
			// 
			// tabNodata
			// 
			this.tabNodata.Controls.Add(this.groupBox7);
			this.tabNodata.Location = new System.Drawing.Point(4, 55);
			this.tabNodata.Name = "tabNodata";
			this.tabNodata.Size = new System.Drawing.Size(272, 173);
			this.tabNodata.TabIndex = 6;
			this.tabNodata.Text = "Nodata";
			// 
			// groupBox7
			// 
			this.groupBox7.Controls.Add(this.checkBoxNoStamp);
			this.groupBox7.Controls.Add(this.comboBoxNoEject);
			this.groupBox7.Controls.Add(this.label4);
			this.groupBox7.Controls.Add(this.checkBoxNoCancel);
			this.groupBox7.Controls.Add(this.checkBoxNoDetect);
			this.groupBox7.Location = new System.Drawing.Point(0, 3);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(272, 149);
			this.groupBox7.TabIndex = 2;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "Settings";
			// 
			// checkBoxNoStamp
			// 
			this.checkBoxNoStamp.Location = new System.Drawing.Point(120, 88);
			this.checkBoxNoStamp.Name = "checkBoxNoStamp";
			this.checkBoxNoStamp.TabIndex = 6;
			this.checkBoxNoStamp.Text = "Stamp";
			this.checkBoxNoStamp.CheckedChanged += new System.EventHandler(this.checkBoxNoStamp_CheckedChanged);
			// 
			// comboBoxNoEject
			// 
			this.comboBoxNoEject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxNoEject.Items.AddRange(new object[] {
																 "Main Eject",
																 "Sub Eject"});
			this.comboBoxNoEject.Location = new System.Drawing.Point(120, 56);
			this.comboBoxNoEject.Name = "comboBoxNoEject";
			this.comboBoxNoEject.Size = new System.Drawing.Size(121, 20);
			this.comboBoxNoEject.TabIndex = 5;
			this.comboBoxNoEject.SelectedIndexChanged += new System.EventHandler(this.comboBoxNoEject_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 56);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 23);
			this.label4.TabIndex = 4;
			this.label4.Text = "Eject Type";
			// 
			// checkBoxNoCancel
			// 
			this.checkBoxNoCancel.Location = new System.Drawing.Point(120, 120);
			this.checkBoxNoCancel.Name = "checkBoxNoCancel";
			this.checkBoxNoCancel.TabIndex = 7;
			this.checkBoxNoCancel.Text = "Cancel";
			this.checkBoxNoCancel.CheckedChanged += new System.EventHandler(this.checkBoxNoCancel_CheckedChanged);
			// 
			// checkBoxNoDetect
			// 
			this.checkBoxNoDetect.Location = new System.Drawing.Point(48, 24);
			this.checkBoxNoDetect.Name = "checkBoxNoDetect";
			this.checkBoxNoDetect.TabIndex = 0;
			this.checkBoxNoDetect.Text = "Detect";
			this.checkBoxNoDetect.CheckedChanged += new System.EventHandler(this.checkBoxNoDetect_CheckedChanged);
			// 
			// tabNearFull
			// 
			this.tabNearFull.Controls.Add(this.groupBox12);
			this.tabNearFull.Location = new System.Drawing.Point(4, 72);
			this.tabNearFull.Name = "tabNearFull";
			this.tabNearFull.Size = new System.Drawing.Size(272, 156);
			this.tabNearFull.TabIndex = 9;
			this.tabNearFull.Text = "NearFull";
			// 
			// groupBox12
			// 
			this.groupBox12.Controls.Add(this.comboBoxNearFull);
			this.groupBox12.Location = new System.Drawing.Point(0, 0);
			this.groupBox12.Name = "groupBox12";
			this.groupBox12.Size = new System.Drawing.Size(272, 152);
			this.groupBox12.TabIndex = 0;
			this.groupBox12.TabStop = false;
			this.groupBox12.Text = "Settings";
			// 
			// comboBoxNearFull
			// 
			this.comboBoxNearFull.Items.AddRange(new object[] {
																  "NEARFULL_PERMIT",
																  "NEARFULL_MAIN_PERMIT",
																  "NEARFULL_SUB_PERMIT",
																  "NEARFULL_NOT_PERMIT"});
			this.comboBoxNearFull.Location = new System.Drawing.Point(40, 64);
			this.comboBoxNearFull.Name = "comboBoxNearFull";
			this.comboBoxNearFull.Size = new System.Drawing.Size(160, 20);
			this.comboBoxNearFull.TabIndex = 1;
			this.comboBoxNearFull.SelectedIndexChanged += new System.EventHandler(this.comboBoxNearFull_SelectedIndexChanged);
			// 
			// tabBuzzer
			// 
			this.tabBuzzer.Controls.Add(this.groupBox14);
			this.tabBuzzer.Location = new System.Drawing.Point(4, 55);
			this.tabBuzzer.Name = "tabBuzzer";
			this.tabBuzzer.Size = new System.Drawing.Size(272, 173);
			this.tabBuzzer.TabIndex = 11;
			this.tabBuzzer.Text = "Buzzer";
			// 
			// groupBox14
			// 
			this.groupBox14.Controls.Add(this.comboBoxSuccessCount);
			this.groupBox14.Controls.Add(this.comboBoxSuccessHz);
			this.groupBox14.Controls.Add(this.label7);
			this.groupBox14.Controls.Add(this.comboBoxErrorHz);
			this.groupBox14.Controls.Add(this.label8);
			this.groupBox14.Controls.Add(this.comboBoxErrorCount);
			this.groupBox14.Controls.Add(this.comboBoxWFeedCount);
			this.groupBox14.Controls.Add(this.label9);
			this.groupBox14.Controls.Add(this.comboBoxWFeedHz);
			this.groupBox14.Location = new System.Drawing.Point(0, 2);
			this.groupBox14.Name = "groupBox14";
			this.groupBox14.Size = new System.Drawing.Size(272, 152);
			this.groupBox14.TabIndex = 1;
			this.groupBox14.TabStop = false;
			this.groupBox14.Text = "Settings";
			// 
			// comboBoxSuccessCount
			// 
			this.comboBoxSuccessCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxSuccessCount.Items.AddRange(new object[] {
																	  "DISABLE",
																	  "ONE",
																	  "TWO",
																	  "MAX"});
			this.comboBoxSuccessCount.Location = new System.Drawing.Point(200, 32);
			this.comboBoxSuccessCount.Name = "comboBoxSuccessCount";
			this.comboBoxSuccessCount.Size = new System.Drawing.Size(48, 20);
			this.comboBoxSuccessCount.TabIndex = 2;
			this.comboBoxSuccessCount.SelectedIndexChanged += new System.EventHandler(this.comboBoxSuccessCount_SelectedIndexChanged);
			// 
			// comboBoxSuccessHz
			// 
			this.comboBoxSuccessHz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxSuccessHz.Items.AddRange(new object[] {
																   "440Hz",
																   "880Hz",
																   "4000Hz"});
			this.comboBoxSuccessHz.Location = new System.Drawing.Point(80, 32);
			this.comboBoxSuccessHz.Name = "comboBoxSuccessHz";
			this.comboBoxSuccessHz.Size = new System.Drawing.Size(88, 20);
			this.comboBoxSuccessHz.TabIndex = 1;
			this.comboBoxSuccessHz.SelectedIndexChanged += new System.EventHandler(this.comboBoxSuccessHz_SelectedIndexChanged);
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(8, 32);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(48, 16);
			this.label7.TabIndex = 0;
			this.label7.Text = "Success";
			this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// comboBoxErrorHz
			// 
			this.comboBoxErrorHz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxErrorHz.Items.AddRange(new object[] {
																 "440Hz",
																 "880Hz",
																 "4000Hz"});
			this.comboBoxErrorHz.Location = new System.Drawing.Point(80, 72);
			this.comboBoxErrorHz.Name = "comboBoxErrorHz";
			this.comboBoxErrorHz.Size = new System.Drawing.Size(88, 20);
			this.comboBoxErrorHz.TabIndex = 3;
			this.comboBoxErrorHz.SelectedIndexChanged += new System.EventHandler(this.comboBoxErrorHz_SelectedIndexChanged);
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(8, 72);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(48, 16);
			this.label8.TabIndex = 0;
			this.label8.Text = "Error";
			this.label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// comboBoxErrorCount
			// 
			this.comboBoxErrorCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxErrorCount.Items.AddRange(new object[] {
																	"DISABLE",
																	"ONE",
																	"TWO",
																	"MAX"});
			this.comboBoxErrorCount.Location = new System.Drawing.Point(200, 72);
			this.comboBoxErrorCount.Name = "comboBoxErrorCount";
			this.comboBoxErrorCount.Size = new System.Drawing.Size(48, 20);
			this.comboBoxErrorCount.TabIndex = 4;
			this.comboBoxErrorCount.SelectedIndexChanged += new System.EventHandler(this.comboBoxErrorCount_SelectedIndexChanged);
			// 
			// comboBoxWFeedCount
			// 
			this.comboBoxWFeedCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxWFeedCount.Items.AddRange(new object[] {
																	"DISABLE",
																	"ONE",
																	"TWO",
																	"MAX"});
			this.comboBoxWFeedCount.Location = new System.Drawing.Point(200, 112);
			this.comboBoxWFeedCount.Name = "comboBoxWFeedCount";
			this.comboBoxWFeedCount.Size = new System.Drawing.Size(48, 20);
			this.comboBoxWFeedCount.TabIndex = 6;
			this.comboBoxWFeedCount.SelectedIndexChanged += new System.EventHandler(this.comboBoxWFeedCount_SelectedIndexChanged);
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(8, 112);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(48, 16);
			this.label9.TabIndex = 0;
			this.label9.Text = "WFeed";
			this.label9.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// comboBoxWFeedHz
			// 
			this.comboBoxWFeedHz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxWFeedHz.Items.AddRange(new object[] {
																 "440Hz",
																 "880Hz",
																 "4000Hz"});
			this.comboBoxWFeedHz.Location = new System.Drawing.Point(80, 112);
			this.comboBoxWFeedHz.Name = "comboBoxWFeedHz";
			this.comboBoxWFeedHz.Size = new System.Drawing.Size(88, 20);
			this.comboBoxWFeedHz.TabIndex = 5;
			this.comboBoxWFeedHz.SelectedIndexChanged += new System.EventHandler(this.comboBoxWFeedHz_SelectedIndexChanged);
			// 
			// tabSuccessStamp
			// 
			this.tabSuccessStamp.Controls.Add(this.groupBox15);
			this.tabSuccessStamp.Location = new System.Drawing.Point(4, 72);
			this.tabSuccessStamp.Name = "tabSuccessStamp";
			this.tabSuccessStamp.Size = new System.Drawing.Size(272, 156);
			this.tabSuccessStamp.TabIndex = 12;
			this.tabSuccessStamp.Text = "SuccessStamp";
			// 
			// groupBox15
			// 
			this.groupBox15.Controls.Add(this.comboBoxSuccessStamp);
			this.groupBox15.Controls.Add(this.label11);
			this.groupBox15.Location = new System.Drawing.Point(0, 0);
			this.groupBox15.Name = "groupBox15";
			this.groupBox15.Size = new System.Drawing.Size(272, 152);
			this.groupBox15.TabIndex = 0;
			this.groupBox15.TabStop = false;
			this.groupBox15.Text = "Settings";
			// 
			// comboBoxSuccessStamp
			// 
			this.comboBoxSuccessStamp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxSuccessStamp.Items.AddRange(new object[] {
																	  "DISABLE",
																	  "ENABLE"});
			this.comboBoxSuccessStamp.Location = new System.Drawing.Point(128, 64);
			this.comboBoxSuccessStamp.Name = "comboBoxSuccessStamp";
			this.comboBoxSuccessStamp.Size = new System.Drawing.Size(121, 20);
			this.comboBoxSuccessStamp.TabIndex = 1;
			this.comboBoxSuccessStamp.SelectedIndexChanged += new System.EventHandler(this.comboBoxSuccessStamp_SelectedIndexChanged);
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(16, 64);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(104, 23);
			this.label11.TabIndex = 0;
			this.label11.Text = "SuccessStamp";
			// 
			// tabIqa
			// 
			this.tabIqa.Controls.Add(this.groupBox16);
			this.tabIqa.Location = new System.Drawing.Point(4, 72);
			this.tabIqa.Name = "tabIqa";
			this.tabIqa.Size = new System.Drawing.Size(272, 156);
			this.tabIqa.TabIndex = 13;
			this.tabIqa.Text = "IQA";
			// 
			// groupBox16
			// 
			this.groupBox16.Controls.Add(this.checkBoxIqaGray);
			this.groupBox16.Controls.Add(this.checkBoxIqaStamp);
			this.groupBox16.Controls.Add(this.comboBoxIqaEject);
			this.groupBox16.Controls.Add(this.label12);
			this.groupBox16.Controls.Add(this.checkBoxIqaCancel);
			this.groupBox16.Controls.Add(this.checkBoxIqaDetect);
			this.groupBox16.Location = new System.Drawing.Point(0, 0);
			this.groupBox16.Name = "groupBox16";
			this.groupBox16.Size = new System.Drawing.Size(272, 152);
			this.groupBox16.TabIndex = 0;
			this.groupBox16.TabStop = false;
			this.groupBox16.Text = "Settings";
			// 
			// checkBoxIqaGray
			// 
			this.checkBoxIqaGray.Location = new System.Drawing.Point(128, 48);
			this.checkBoxIqaGray.Name = "checkBoxIqaGray";
			this.checkBoxIqaGray.Size = new System.Drawing.Size(104, 16);
			this.checkBoxIqaGray.TabIndex = 13;
			this.checkBoxIqaGray.Text = "Grayscale";
			this.checkBoxIqaGray.CheckedChanged += new System.EventHandler(this.checkBoxIqaGray_CheckedChanged);
			// 
			// checkBoxIqaStamp
			// 
			this.checkBoxIqaStamp.Location = new System.Drawing.Point(128, 96);
			this.checkBoxIqaStamp.Name = "checkBoxIqaStamp";
			this.checkBoxIqaStamp.TabIndex = 11;
			this.checkBoxIqaStamp.Text = "Stamp";
			this.checkBoxIqaStamp.CheckedChanged += new System.EventHandler(this.checkBoxIqaStamp_CheckedChanged);
			// 
			// comboBoxIqaEject
			// 
			this.comboBoxIqaEject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxIqaEject.Items.AddRange(new object[] {
																  "Main Eject",
																  "Sub Eject"});
			this.comboBoxIqaEject.Location = new System.Drawing.Point(128, 72);
			this.comboBoxIqaEject.Name = "comboBoxIqaEject";
			this.comboBoxIqaEject.Size = new System.Drawing.Size(121, 20);
			this.comboBoxIqaEject.TabIndex = 10;
			this.comboBoxIqaEject.SelectedIndexChanged += new System.EventHandler(this.comboBoxIqaEject_SelectedIndexChanged);
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(24, 72);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(72, 23);
			this.label12.TabIndex = 9;
			this.label12.Text = "Eject Type";
			// 
			// checkBoxIqaCancel
			// 
			this.checkBoxIqaCancel.Location = new System.Drawing.Point(128, 120);
			this.checkBoxIqaCancel.Name = "checkBoxIqaCancel";
			this.checkBoxIqaCancel.TabIndex = 12;
			this.checkBoxIqaCancel.Text = "Cancel";
			this.checkBoxIqaCancel.CheckedChanged += new System.EventHandler(this.checkBoxIqaCancel_CheckedChanged);
			// 
			// checkBoxIqaDetect
			// 
			this.checkBoxIqaDetect.Location = new System.Drawing.Point(56, 16);
			this.checkBoxIqaDetect.Name = "checkBoxIqaDetect";
			this.checkBoxIqaDetect.TabIndex = 8;
			this.checkBoxIqaDetect.Text = "Detect";
			this.checkBoxIqaDetect.CheckedChanged += new System.EventHandler(this.checkBoxIqaDetect_CheckedChanged);
			// 
			// tabWaterfall
			// 
			this.tabWaterfall.Controls.Add(this.groupBox17);
			this.tabWaterfall.Location = new System.Drawing.Point(4, 72);
			this.tabWaterfall.Name = "tabWaterfall";
			this.tabWaterfall.Size = new System.Drawing.Size(272, 156);
			this.tabWaterfall.TabIndex = 14;
			this.tabWaterfall.Text = "Waterfall";
			// 
			// groupBox17
			// 
			this.groupBox17.Controls.Add(this.comboBoxWaterfallMode);
			this.groupBox17.Controls.Add(this.checkBoxWaterfallEnable);
			this.groupBox17.Location = new System.Drawing.Point(0, 0);
			this.groupBox17.Name = "groupBox17";
			this.groupBox17.Size = new System.Drawing.Size(272, 152);
			this.groupBox17.TabIndex = 0;
			this.groupBox17.TabStop = false;
			this.groupBox17.Text = "Settings";
			// 
			// comboBoxWaterfallMode
			// 
			this.comboBoxWaterfallMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxWaterfallMode.Items.AddRange(new object[] {
																	   "STANDARD",
																	   "INHERIT_POCKET"});
			this.comboBoxWaterfallMode.Location = new System.Drawing.Point(72, 72);
			this.comboBoxWaterfallMode.Name = "comboBoxWaterfallMode";
			this.comboBoxWaterfallMode.Size = new System.Drawing.Size(136, 20);
			this.comboBoxWaterfallMode.TabIndex = 1;
			this.comboBoxWaterfallMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxWaterfallMode_SelectedIndexChanged);
			// 
			// checkBoxWaterfallEnable
			// 
			this.checkBoxWaterfallEnable.Location = new System.Drawing.Point(32, 32);
			this.checkBoxWaterfallEnable.Name = "checkBoxWaterfallEnable";
			this.checkBoxWaterfallEnable.TabIndex = 0;
			this.checkBoxWaterfallEnable.Text = "Waterfall";
			this.checkBoxWaterfallEnable.CheckedChanged += new System.EventHandler(this.checkBoxWaterfallEnable_CheckedChanged);
			// 
			// tabBarcode
			// 
			this.tabBarcode.Controls.Add(this.groupBox18);
			this.tabBarcode.Controls.Add(this.groupBox19);
			this.tabBarcode.Location = new System.Drawing.Point(4, 72);
			this.tabBarcode.Name = "tabBarcode";
			this.tabBarcode.Size = new System.Drawing.Size(272, 156);
			this.tabBarcode.TabIndex = 15;
			this.tabBarcode.Text = "Barcode";
			// 
			// groupBox19
			// 
			this.groupBox19.Controls.Add(this.checkBoxBarcodeFrontStamp);
			this.groupBox19.Controls.Add(this.comboBoxBarcodeFrontEject);
			this.groupBox19.Controls.Add(this.label13);
			this.groupBox19.Controls.Add(this.checkBoxBarcodeFrontCancel);
			this.groupBox19.Controls.Add(this.checkBoxBarcodeFrontDetect);
			this.groupBox19.Location = new System.Drawing.Point(0, 0);
			this.groupBox19.Name = "groupBox19";
			this.groupBox19.Size = new System.Drawing.Size(136, 152);
			this.groupBox19.TabIndex = 14;
			this.groupBox19.TabStop = false;
			this.groupBox19.Text = "Front";
			// 
			// checkBoxBarcodeFrontStamp
			// 
			this.checkBoxBarcodeFrontStamp.Location = new System.Drawing.Point(16, 96);
			this.checkBoxBarcodeFrontStamp.Name = "checkBoxBarcodeFrontStamp";
			this.checkBoxBarcodeFrontStamp.TabIndex = 16;
			this.checkBoxBarcodeFrontStamp.Text = "Stamp";
			this.checkBoxBarcodeFrontStamp.CheckedChanged += new System.EventHandler(this.checkBoxBarcodeFrontStamp_CheckedChanged);
			// 
			// comboBoxBarcodeFrontEject
			// 
			this.comboBoxBarcodeFrontEject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxBarcodeFrontEject.Items.AddRange(new object[] {
																		   "Main Eject",
																		   "Sub Eject"});
			this.comboBoxBarcodeFrontEject.Location = new System.Drawing.Point(16, 72);
			this.comboBoxBarcodeFrontEject.Name = "comboBoxBarcodeFrontEject";
			this.comboBoxBarcodeFrontEject.Size = new System.Drawing.Size(104, 20);
			this.comboBoxBarcodeFrontEject.TabIndex = 15;
			this.comboBoxBarcodeFrontEject.SelectedIndexChanged += new System.EventHandler(this.comboBoxBarcodeFrontEject_SelectedIndexChanged);
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(16, 56);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(104, 16);
			this.label13.TabIndex = 14;
			this.label13.Text = "Eject Type";
			// 
			// checkBoxBarcodeFrontCancel
			// 
			this.checkBoxBarcodeFrontCancel.Location = new System.Drawing.Point(16, 120);
			this.checkBoxBarcodeFrontCancel.Name = "checkBoxBarcodeFrontCancel";
			this.checkBoxBarcodeFrontCancel.TabIndex = 17;
			this.checkBoxBarcodeFrontCancel.Text = "Cancel";
			this.checkBoxBarcodeFrontCancel.CheckedChanged += new System.EventHandler(this.checkBoxBarcodeFrontCancel_CheckedChanged);
			// 
			// checkBoxBarcodeFrontDetect
			// 
			this.checkBoxBarcodeFrontDetect.Location = new System.Drawing.Point(16, 24);
			this.checkBoxBarcodeFrontDetect.Name = "checkBoxBarcodeFrontDetect";
			this.checkBoxBarcodeFrontDetect.TabIndex = 13;
			this.checkBoxBarcodeFrontDetect.Text = "Detect";
			this.checkBoxBarcodeFrontDetect.CheckedChanged += new System.EventHandler(this.checkBoxBarcodeFrontDetect_CheckedChanged);
			// 
			// groupBox18
			// 
			this.groupBox18.Controls.Add(this.checkBoxBarcodeBackStamp);
			this.groupBox18.Controls.Add(this.comboBoxBarcodeBackEject);
			this.groupBox18.Controls.Add(this.label14);
			this.groupBox18.Controls.Add(this.checkBoxBarcodeBackCancel);
			this.groupBox18.Controls.Add(this.checkBoxBarcodeBackDetect);
			this.groupBox18.Location = new System.Drawing.Point(136, 0);
			this.groupBox18.Name = "groupBox18";
			this.groupBox18.Size = new System.Drawing.Size(136, 152);
			this.groupBox18.TabIndex = 15;
			this.groupBox18.TabStop = false;
			this.groupBox18.Text = "Back";
			// 
			// checkBoxBarcodeBackStamp
			// 
			this.checkBoxBarcodeBackStamp.Location = new System.Drawing.Point(16, 96);
			this.checkBoxBarcodeBackStamp.Name = "checkBoxBarcodeBackStamp";
			this.checkBoxBarcodeBackStamp.TabIndex = 16;
			this.checkBoxBarcodeBackStamp.Text = "Stamp";
			this.checkBoxBarcodeBackStamp.CheckedChanged += new System.EventHandler(this.checkBoxBarcodeBackStamp_CheckedChanged);
			// 
			// comboBoxBarcodeBackEject
			// 
			this.comboBoxBarcodeBackEject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxBarcodeBackEject.Items.AddRange(new object[] {
																		  "Main Eject",
																		  "Sub Eject"});
			this.comboBoxBarcodeBackEject.Location = new System.Drawing.Point(16, 72);
			this.comboBoxBarcodeBackEject.Name = "comboBoxBarcodeBackEject";
			this.comboBoxBarcodeBackEject.Size = new System.Drawing.Size(104, 20);
			this.comboBoxBarcodeBackEject.TabIndex = 15;
			this.comboBoxBarcodeBackEject.SelectedIndexChanged += new System.EventHandler(this.comboBoxBarcodeBackEject_SelectedIndexChanged);
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(16, 56);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(104, 16);
			this.label14.TabIndex = 14;
			this.label14.Text = "Eject Type";
			// 
			// checkBoxBarcodeBackCancel
			// 
			this.checkBoxBarcodeBackCancel.Location = new System.Drawing.Point(16, 120);
			this.checkBoxBarcodeBackCancel.Name = "checkBoxBarcodeBackCancel";
			this.checkBoxBarcodeBackCancel.TabIndex = 17;
			this.checkBoxBarcodeBackCancel.Text = "Cancel";
			this.checkBoxBarcodeBackCancel.CheckedChanged += new System.EventHandler(this.checkBoxBarcodeBackCancel_CheckedChanged);
			// 
			// checkBoxBarcodeBackDetect
			// 
			this.checkBoxBarcodeBackDetect.Location = new System.Drawing.Point(16, 24);
			this.checkBoxBarcodeBackDetect.Name = "checkBoxBarcodeBackDetect";
			this.checkBoxBarcodeBackDetect.TabIndex = 13;
			this.checkBoxBarcodeBackDetect.Text = "Detect";
			this.checkBoxBarcodeBackDetect.CheckedChanged += new System.EventHandler(this.checkBoxBarcodeBackDetect_CheckedChanged);
			// 
			// ConfigureForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
			this.ClientSize = new System.Drawing.Size(298, 288);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonApply);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "ConfigureForm";
			this.Text = "ConfigureForm";
			this.tabControl1.ResumeLayout(false);
			this.tabImage.ResumeLayout(false);
			this.groupBox9.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox10.ResumeLayout(false);
			this.tabNoise.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.tabMICR.ResumeLayout(false);
			this.groupBox11.ResumeLayout(false);
			this.tabOcrAb.ResumeLayout(false);
			this.groupBox13.ResumeLayout(false);
			this.tabEndorse.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.tabPaperMisInsertion.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.tabConfirmation.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.tabDoubleFeed.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.tabBaddata.ResumeLayout(false);
			this.groupBox8.ResumeLayout(false);
			this.tabNodata.ResumeLayout(false);
			this.groupBox7.ResumeLayout(false);
			this.tabNearFull.ResumeLayout(false);
			this.groupBox12.ResumeLayout(false);
			this.tabBuzzer.ResumeLayout(false);
			this.groupBox14.ResumeLayout(false);
			this.tabSuccessStamp.ResumeLayout(false);
			this.groupBox15.ResumeLayout(false);
			this.tabIqa.ResumeLayout(false);
			this.groupBox16.ResumeLayout(false);
			this.tabWaterfall.ResumeLayout(false);
			this.groupBox17.ResumeLayout(false);
			this.tabBarcode.ResumeLayout(false);
			this.groupBox19.ResumeLayout(false);
			this.groupBox18.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		// input of the property  
		public void SetProc(Properties Proc)
		{
			m_objConfig = new Properties(Proc);
			LoadProPerties();
		}

		// output of the property  
		public Properties GetProc()
		{
			return new Properties(m_objConfig);
		}

		// this method is called when the user click the OK button
		private void buttonOK_Click(object sender, System.EventArgs e)
		{
			SetProperties();
			Close();
		}

		// this method is called when the user click the Cancel button
		private void buttonCancel_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		// this method is called when the user click the Apply button
		private void buttonApply_Click(object sender, System.EventArgs e)
		{
			SetProperties();
			buttonApply.Enabled = false;
		}

		// this method is Each value is bound to the property   
		private void SetProperties()
		{
			m_objConfig.SetValue(Properties.SCAN_FUNC, comboBoxScanFunc.SelectedIndex);

			m_objConfig.SetValue(Properties.SCAN_FRONT, checkBoxFrontScan.Checked);
			m_objConfig.SetValue(Properties.FRONT_GRAYSCALE, checkBoxFrontGrayscale.Checked);
			m_objConfig.SetValue(Properties.FRONT_DISPLAY, checkBoxFrontDisplay.Checked);
			m_objConfig.SetValue(Properties.FRONT_SAVE, checkBoxFrontSave.Checked);

			m_objConfig.SetValue(Properties.SCAN_BACK, checkBoxBackScan.Checked);
			m_objConfig.SetValue(Properties.BACK_GRAYSCALE, checkBoxBackGrayscale.Checked);
			m_objConfig.SetValue(Properties.BACK_DISPLAY, checkBoxBackDisplay.Checked);
			m_objConfig.SetValue(Properties.BACK_SAVE, checkBoxBackSave.Checked);

			m_objConfig.SetValue(Properties.MICR, checkBoxMICR.Checked);
			m_objConfig.SetValue(Properties.MICR_SAVE, checkBoxSave.Checked);
			m_objConfig.SetValue(Properties.MICR_FONT, comboBoxMicrFont.SelectedIndex);
			m_objConfig.SetValue(Properties.MICR_SAVE_ENABLE, checkBoxSave.Enabled);

			m_objConfig.SetValue(Properties.ELEC_ENDORSE_TEXT, checkBoxElecEndorseText.Checked);
			m_objConfig.SetValue(Properties.ELEC_ENDORSE_IMAGE, checkBoxElecEndorseImage.Checked);

			m_objConfig.SetValue(Properties.CONFIRMATION, checkBoxConfirmation.Checked);
			m_objConfig.SetValue(Properties.RUN_SCN_TO_RESULT, checkBoxRunScnToResult.Checked);
			m_objConfig.SetValue(Properties.NO_CALL_SCN_TO_RESULT, checkBoxNoCallScnToResult.Checked);

			m_objConfig.SetValue(Properties.MIS_INSERT_DETECT, checkBoxMisInsertDetect.Checked);
			m_objConfig.SetValue(Properties.MIS_INSERT_EJECT, comboBoxMisInsertEject.SelectedIndex);
			m_objConfig.SetValue(Properties.MIS_INSERT_STAMP, checkBoxMisInsertStamp.Checked);
			m_objConfig.SetValue(Properties.MIS_INSERT_CANCEL, checkBoxMisInsertCancel.Checked);

			m_objConfig.SetValue(Properties.NOISE_DETECT, checkBoxNoiseDetect.Checked);
			m_objConfig.SetValue(Properties.NOISE_EJECT, comboBoxNoiseEject.SelectedIndex);
			m_objConfig.SetValue(Properties.NOISE_STAMP, checkBoxNoiseStamp.Checked);
			m_objConfig.SetValue(Properties.NOISE_CANCEL, checkBoxNoiseCancel.Checked);

			m_objConfig.SetValue(Properties.DOUBLE_FEED_DETECT, checkBoxDFDetect.Checked);
			m_objConfig.SetValue(Properties.DOUBLE_FEED_EJECT, comboBoxDFEject.SelectedIndex);
			m_objConfig.SetValue(Properties.DOUBLE_FEED_STAMP, checkBoxDFStamp.Checked);
			m_objConfig.SetValue(Properties.DOUBLE_FEED_CANCEL, checkBoxDFCancel.Checked);

			m_objConfig.SetValue(Properties.BADDATA_COUNT, Convert.ToInt32(textBoxBadCount.Text));
			m_objConfig.SetValue(Properties.BADDATA_DETECT, checkBoxBadDetect.Checked);
			m_objConfig.SetValue(Properties.BADDATA_EJECT, comboBoxBadEject.SelectedIndex);
			m_objConfig.SetValue(Properties.BADDATA_STAMP, checkBoxBadStamp.Checked);
			m_objConfig.SetValue(Properties.BADDATA_CANCEL, checkBoxBadCancel.Checked);

			m_objConfig.SetValue(Properties.NODATA_DETECT, checkBoxNoDetect.Checked);
			m_objConfig.SetValue(Properties.NODATA_EJECT, comboBoxNoEject.SelectedIndex);
			m_objConfig.SetValue(Properties.NODATA_STAMP, checkBoxNoStamp.Checked);
			m_objConfig.SetValue(Properties.NODATA_CANCEL, checkBoxNoCancel.Checked);

			m_objConfig.SetValue(Properties.OCR_AB, checkBoxOcrAb.Checked);
			m_objConfig.SetValue(Properties.OCR_AB_FONT, comboBoxOcrAbFont.SelectedIndex);

			m_objConfig.SetValue(Properties.BUZZER_SUCCESS_HZ, comboBoxSuccessHz.SelectedIndex);
			m_objConfig.SetValue(Properties.BUZZER_SUCCESS_COUNT, comboBoxSuccessCount.SelectedIndex);
			m_objConfig.SetValue(Properties.BUZZER_ERROR_HZ, comboBoxErrorHz.SelectedIndex);
			m_objConfig.SetValue(Properties.BUZZER_ERROR_COUNT, comboBoxErrorCount.SelectedIndex);
			m_objConfig.SetValue(Properties.BUZZER_WFEED_HZ, comboBoxWFeedHz.SelectedIndex);
			m_objConfig.SetValue(Properties.BUZZER_WFEED_COUNT, comboBoxWFeedCount.SelectedIndex);

			m_objConfig.SetValue(Properties.NEAR_FULL, comboBoxNearFull.SelectedIndex);

			m_objConfig.SetValue(Properties.SUCCESS_STAMP, comboBoxSuccessStamp.SelectedIndex);

			m_objConfig.SetValue(Properties.IQA_DETECT, checkBoxIqaDetect.Checked);
			m_objConfig.SetValue(Properties.IQA_GRAYSCALE, checkBoxIqaGray.Checked);
			m_objConfig.SetValue(Properties.IQA_EJECT, comboBoxIqaEject.SelectedIndex);
			m_objConfig.SetValue(Properties.IQA_STAMP, checkBoxIqaStamp.Checked);
			m_objConfig.SetValue(Properties.IQA_CANCEL, checkBoxIqaCancel.Checked);

			m_objConfig.SetValue(Properties.WATERFALL_ENABLE, checkBoxWaterfallEnable.Checked);
			m_objConfig.SetValue(Properties.WATERFALL_MODE, comboBoxWaterfallMode.SelectedIndex);

			m_objConfig.SetValue(Properties.BARCODE_FRONT_DETECT, checkBoxBarcodeFrontDetect.Checked);
			m_objConfig.SetValue(Properties.BARCODE_FRONT_EJECT, comboBoxBarcodeFrontEject.SelectedIndex);
			m_objConfig.SetValue(Properties.BARCODE_FRONT_STAMP, checkBoxBarcodeFrontStamp.Checked);
			m_objConfig.SetValue(Properties.BARCODE_FRONT_CANCEL, checkBoxBarcodeFrontCancel.Checked);

			m_objConfig.SetValue(Properties.BARCODE_BACK_DETECT, checkBoxBarcodeBackDetect.Checked);
			m_objConfig.SetValue(Properties.BARCODE_BACK_EJECT, comboBoxBarcodeBackEject.SelectedIndex);
			m_objConfig.SetValue(Properties.BARCODE_BACK_STAMP, checkBoxBarcodeBackStamp.Checked);
			m_objConfig.SetValue(Properties.BARCODE_BACK_CANCEL, checkBoxBarcodeBackCancel.Checked);
		}

		// this method is property is bound to the  Each value
		private void LoadProPerties()
		{
			comboBoxScanFunc.SelectedIndex = m_objConfig.GetValue(Properties.SCAN_FUNC);

			checkBoxFrontScan.Checked = m_objConfig.GetValueBool(Properties.SCAN_FRONT);
			checkBoxFrontGrayscale.Checked = m_objConfig.GetValueBool(Properties.FRONT_GRAYSCALE);
			checkBoxFrontDisplay.Checked = m_objConfig.GetValueBool(Properties.FRONT_DISPLAY);
			checkBoxFrontSave.Checked = m_objConfig.GetValueBool(Properties.FRONT_SAVE);

			checkBoxBackScan.Checked = m_objConfig.GetValueBool(Properties.SCAN_BACK);
			checkBoxBackGrayscale.Checked = m_objConfig.GetValueBool(Properties.BACK_GRAYSCALE);
			checkBoxBackDisplay.Checked = m_objConfig.GetValueBool(Properties.BACK_DISPLAY);
			checkBoxBackSave.Checked = m_objConfig.GetValueBool(Properties.BACK_SAVE);

			checkBoxMICR.Checked = m_objConfig.GetValueBool(Properties.MICR);
			checkBoxSave.Checked = m_objConfig.GetValueBool(Properties.MICR_SAVE);
			comboBoxMicrFont.SelectedIndex = m_objConfig.GetValue(Properties.MICR_FONT);
			checkBoxSave.Enabled = m_objConfig.GetValueBool(Properties.MICR_SAVE_ENABLE);

			checkBoxElecEndorseText.Checked = m_objConfig.GetValueBool(Properties.ELEC_ENDORSE_TEXT);
			checkBoxElecEndorseImage.Checked = m_objConfig.GetValueBool(Properties.ELEC_ENDORSE_IMAGE);

			checkBoxConfirmation.Checked = m_objConfig.GetValueBool(Properties.CONFIRMATION);
			checkBoxRunScnToResult.Checked = m_objConfig.GetValueBool(Properties.RUN_SCN_TO_RESULT);
			checkBoxNoCallScnToResult.Checked = m_objConfig.GetValueBool(Properties.NO_CALL_SCN_TO_RESULT);

			checkBoxMisInsertDetect.Checked = m_objConfig.GetValueBool(Properties.MIS_INSERT_DETECT);
			comboBoxMisInsertEject.SelectedIndex = m_objConfig.GetValue(Properties.MIS_INSERT_EJECT);
			checkBoxMisInsertStamp.Checked = m_objConfig.GetValueBool(Properties.MIS_INSERT_STAMP);
			checkBoxMisInsertCancel.Checked = m_objConfig.GetValueBool(Properties.MIS_INSERT_CANCEL);

			checkBoxNoiseDetect.Checked = m_objConfig.GetValueBool(Properties.NOISE_DETECT);
			comboBoxNoiseEject.SelectedIndex = m_objConfig.GetValue(Properties.NOISE_EJECT);
			checkBoxNoiseStamp.Checked = m_objConfig.GetValueBool(Properties.NOISE_STAMP);
			checkBoxNoiseCancel.Checked = m_objConfig.GetValueBool(Properties.NOISE_CANCEL);

			checkBoxDFDetect.Checked = m_objConfig.GetValueBool(Properties.DOUBLE_FEED_DETECT);
			comboBoxDFEject.SelectedIndex = m_objConfig.GetValue(Properties.DOUBLE_FEED_EJECT);
			checkBoxDFStamp.Checked = m_objConfig.GetValueBool(Properties.DOUBLE_FEED_STAMP);
			checkBoxDFCancel.Checked = m_objConfig.GetValueBool(Properties.DOUBLE_FEED_CANCEL);

			textBoxBadCount.Text = m_objConfig.GetValue(Properties.BADDATA_COUNT).ToString();
			checkBoxBadDetect.Checked = m_objConfig.GetValueBool(Properties.BADDATA_DETECT);
			comboBoxBadEject.SelectedIndex = m_objConfig.GetValue(Properties.BADDATA_EJECT);
			checkBoxBadStamp.Checked = m_objConfig.GetValueBool(Properties.BADDATA_STAMP);
			checkBoxBadCancel.Checked = m_objConfig.GetValueBool(Properties.BADDATA_CANCEL);

			checkBoxNoDetect.Checked = m_objConfig.GetValueBool(Properties.NODATA_DETECT);
			comboBoxNoEject.SelectedIndex = m_objConfig.GetValue(Properties.NODATA_EJECT);
			checkBoxNoStamp.Checked = m_objConfig.GetValueBool(Properties.NODATA_STAMP);
			checkBoxNoCancel.Checked = m_objConfig.GetValueBool(Properties.NODATA_CANCEL);

			comboBoxNearFull.SelectedIndex = m_objConfig.GetValue(Properties.NEAR_FULL);

			EnableMisInsert(m_objConfig.GetValueBool(Properties.MIS_INSERT_DETECT));
			EnableNoise(m_objConfig.GetValueBool(Properties.NOISE_DETECT));
			EnableDoubleFeed(m_objConfig.GetValueBool(Properties.DOUBLE_FEED_DETECT));
			EnableBaddata(m_objConfig.GetValueBool(Properties.BADDATA_DETECT));
			EnableNodata(m_objConfig.GetValueBool(Properties.NODATA_DETECT));
			RunEnable(checkBoxConfirmation.Checked);

			checkBoxOcrAb.Checked = m_objConfig.GetValueBool(Properties.OCR_AB);
			comboBoxOcrAbFont.Enabled = checkBoxOcrAb.Checked;
			comboBoxOcrAbFont.SelectedIndex = m_objConfig.GetValue(Properties.OCR_AB_FONT);

			comboBoxSuccessHz.SelectedIndex = m_objConfig.GetValue(Properties.BUZZER_SUCCESS_HZ);
			comboBoxSuccessCount.SelectedIndex = m_objConfig.GetValue(Properties.BUZZER_SUCCESS_COUNT);
			comboBoxErrorHz.SelectedIndex = m_objConfig.GetValue(Properties.BUZZER_ERROR_HZ);
			comboBoxErrorCount.SelectedIndex = m_objConfig.GetValue(Properties.BUZZER_ERROR_COUNT);
			comboBoxWFeedHz.SelectedIndex = m_objConfig.GetValue(Properties.BUZZER_WFEED_HZ);
			comboBoxWFeedCount.SelectedIndex = m_objConfig.GetValue(Properties.BUZZER_WFEED_COUNT);

			comboBoxSuccessStamp.SelectedIndex = m_objConfig.GetValue(Properties.SUCCESS_STAMP);


			checkBoxIqaDetect.Checked = m_objConfig.GetValueBool(Properties.IQA_DETECT);
			checkBoxIqaGray.Checked = m_objConfig.GetValueBool(Properties.IQA_GRAYSCALE);
			comboBoxIqaEject.SelectedIndex = m_objConfig.GetValue(Properties.IQA_EJECT);
			checkBoxIqaStamp.Checked = m_objConfig.GetValueBool(Properties.IQA_STAMP);
			checkBoxIqaCancel.Checked = m_objConfig.GetValueBool(Properties.IQA_CANCEL);
			EnableIqa(checkBoxIqaDetect.Checked);

			checkBoxWaterfallEnable.Checked = m_objConfig.GetValueBool(Properties.WATERFALL_ENABLE);
			comboBoxWaterfallMode.SelectedIndex = m_objConfig.GetValue(Properties.WATERFALL_MODE);
			EnableWaterfall(checkBoxWaterfallEnable.Checked);

			checkBoxBarcodeFrontDetect.Checked = m_objConfig.GetValueBool(Properties.BARCODE_FRONT_DETECT);
			comboBoxBarcodeFrontEject.SelectedIndex = m_objConfig.GetValue(Properties.BARCODE_FRONT_EJECT);
			checkBoxBarcodeFrontStamp.Checked = m_objConfig.GetValueBool(Properties.BARCODE_FRONT_STAMP);
			checkBoxBarcodeFrontCancel.Checked = m_objConfig.GetValueBool(Properties.BARCODE_FRONT_CANCEL);
			EnableBarcodeFront(checkBoxBarcodeFrontDetect.Checked);

			checkBoxBarcodeBackDetect.Checked = m_objConfig.GetValueBool(Properties.BARCODE_BACK_DETECT);
			comboBoxBarcodeBackEject.SelectedIndex = m_objConfig.GetValue(Properties.BARCODE_BACK_EJECT);
			checkBoxBarcodeBackStamp.Checked = m_objConfig.GetValueBool(Properties.BARCODE_BACK_STAMP);
			checkBoxBarcodeBackCancel.Checked = m_objConfig.GetValueBool(Properties.BARCODE_BACK_CANCEL);
			EnableBarcodeBack(checkBoxBarcodeBackDetect.Checked);

			buttonApply.Enabled = false;
		}

		private void comboBoxScanFunc_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			buttonApply.Enabled = true;
		}

		private void checkBoxElecEndorseText_CheckedChanged(object sender, System.EventArgs e)
		{
			buttonApply.Enabled = true;
		}

		private void checkBoxConfirmation_CheckedChanged(object sender, System.EventArgs e)
		{
			RunEnable(checkBoxConfirmation.Checked);
			
			buttonApply.Enabled = true;
		}

		private void checkBoxMisInsertDetect_CheckedChanged(object sender, System.EventArgs e)
		{
			buttonApply.Enabled = true;	
			EnableMisInsert(checkBoxMisInsertDetect.Checked);
		}

		private void comboBoxMisInsertEject_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			buttonApply.Enabled = true;	
		}

		private void checkBoxMisInsertStamp_CheckedChanged(object sender, System.EventArgs e)
		{
			buttonApply.Enabled = true;
		}

		private void checkBoxMisInsertCancel_CheckedChanged(object sender, System.EventArgs e)
		{
			buttonApply.Enabled = true;
		}

		private void checkBoxNoiseDetect_CheckedChanged(object sender, System.EventArgs e)
		{
			buttonApply.Enabled = true;
			EnableNoise(checkBoxNoiseDetect.Checked);
		}

		private void comboBoxNoiseEject_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			buttonApply.Enabled = true;
		}

		private void checkBoxNoiseStamp_CheckedChanged(object sender, System.EventArgs e)
		{
			buttonApply.Enabled = true;
		}

		private void checkBoxNoiseCancel_CheckedChanged(object sender, System.EventArgs e)
		{
			buttonApply.Enabled = true;
		}

		private void checkBoxDFDetect_CheckedChanged(object sender, System.EventArgs e)
		{
			buttonApply.Enabled = true;
			EnableDoubleFeed(checkBoxDFDetect.Checked);
		}

		private void comboBoxDFEject_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			buttonApply.Enabled = true;
		}

		private void checkBoxDFStamp_CheckedChanged(object sender, System.EventArgs e)
		{
			buttonApply.Enabled = true;
		}

		private void checkBoxDFCancel_CheckedChanged(object sender, System.EventArgs e)
		{
			buttonApply.Enabled = true;
		}
		private void checkBoxBadDetect_CheckedChanged(object sender, System.EventArgs e)
		{
			buttonApply.Enabled = true;
			EnableBaddata(checkBoxBadDetect.Checked);
		}

		private void comboBoxBadEject_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			buttonApply.Enabled = true;
		}

		private void checkBoxBadStamp_CheckedChanged(object sender, System.EventArgs e)
		{
			buttonApply.Enabled = true;
		}

		private void checkBoxBadCancel_CheckedChanged(object sender, System.EventArgs e)
		{
			buttonApply.Enabled = true;
		}

		private void checkBoxNoDetect_CheckedChanged(object sender, System.EventArgs e)
		{
			buttonApply.Enabled = true;
			EnableNodata(checkBoxNoDetect.Checked);
		}

		private void comboBoxNoEject_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			buttonApply.Enabled = true;
		}

		private void checkBoxNoStamp_CheckedChanged(object sender, System.EventArgs e)
		{
			buttonApply.Enabled = true;
		}

		private void checkBoxNoCancel_CheckedChanged(object sender, System.EventArgs e)
		{
			buttonApply.Enabled = true;
		}

		// Condition of the control of MisInsett it changes
		private void EnableMisInsert(bool bEnable)
		{
			comboBoxMisInsertEject.Enabled = bEnable;
			checkBoxMisInsertStamp.Enabled = bEnable;
			checkBoxMisInsertCancel.Enabled = bEnable;
		}

		// Condition of the control of Noise it changes
		private void EnableNoise(bool bEnable)
		{
			comboBoxNoiseEject.Enabled = bEnable;
			checkBoxNoiseStamp.Enabled = bEnable;
			checkBoxNoiseCancel.Enabled = bEnable;
		}

		// Condition of the control of DoubleFeed it changes
		private void EnableDoubleFeed(bool bEnable)
		{
			comboBoxDFEject.Enabled = bEnable;
			checkBoxDFStamp.Enabled = bEnable;
			checkBoxDFCancel.Enabled = bEnable;
		}
		
		// Condition of the control of Baddata it changes
		private void EnableBaddata(bool bEnable)
		{
			comboBoxBadEject.Enabled = bEnable;
			checkBoxBadStamp.Enabled = bEnable;
			checkBoxBadCancel.Enabled = bEnable;
			textBoxBadCount.Enabled = bEnable;
		}

		// Condition of the control of Nodata it changes
		private void EnableNodata(bool bEnable)
		{
			comboBoxNoEject.Enabled = bEnable;
			checkBoxNoStamp.Enabled = bEnable;
			checkBoxNoCancel.Enabled = bEnable;
		}

		private void checkBoxElecEndorseImage_CheckedChanged(object sender, System.EventArgs e)
		{
			buttonApply.Enabled = true;
		}

		private void RunEnable(bool bCheck)
		{
			checkBoxRunScnToResult.Enabled = bCheck;
			NoCallEnable(checkBoxRunScnToResult.Checked);
			if(!bCheck)
			{
				NoCallEnable(bCheck);
			}
		}

		private void NoCallEnable(bool bCheck)
		{
			checkBoxNoCallScnToResult.Enabled = bCheck;
			buttonSettingValues.Enabled = checkBoxNoCallScnToResult.Checked;
			if(!bCheck)
			{
				buttonSettingValues.Enabled = bCheck;
			}
		}

		private void checkBoxRunScnToResult_CheckedChanged(object sender, System.EventArgs e)
		{
			NoCallEnable(checkBoxRunScnToResult.Checked);

			buttonApply.Enabled = true;
		}

		private void checkBoxNoCallScnToResult_CheckedChanged(object sender, System.EventArgs e)
		{
			buttonSettingValues.Enabled = checkBoxNoCallScnToResult.Checked;

			buttonApply.Enabled = true;
		}

		private void buttonSettingValues_Click(object sender, System.EventArgs e)
		{
			ConfirmationForm pDlg = new ConfirmationForm();
			pDlg.SetProc(m_objConfig, "");
			pDlg.ShowDialog();
			m_objConfig = pDlg.GetProc();		
			buttonApply.Enabled = true;
		}

		private void comboBoxMicrFont_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			buttonApply.Enabled = true;
		}

		private void checkBoxNearFull_CheckedChanged(object sender, System.EventArgs e)
		{
			buttonApply.Enabled = true;
		}

		private void checkBoxFrontScan_CheckedChanged(object sender, System.EventArgs e)
		{
			buttonApply.Enabled = true;

			SetFrontEnable(checkBoxFrontScan.Checked);
		}

		private void checkBoxFrontGrayscale_CheckedChanged(object sender, System.EventArgs e)
		{
			buttonApply.Enabled = true;
		}

		private void checkBoxFrontDisplay_CheckedChanged(object sender, System.EventArgs e)
		{
			buttonApply.Enabled = true;
		}

		private void checkBoxFrontSave_CheckedChanged(object sender, System.EventArgs e)
		{
			buttonApply.Enabled = true;
		}

		private void checkBoxBackScan_CheckedChanged(object sender, System.EventArgs e)
		{
			buttonApply.Enabled = true;

			SetBackEnable(checkBoxBackScan.Checked);
		}

		private void checkBoxBackGrayscale_CheckedChanged(object sender, System.EventArgs e)
		{
			buttonApply.Enabled = true;
		}

		private void checkBoxBackDisplay_CheckedChanged(object sender, System.EventArgs e)
		{
			buttonApply.Enabled = true;
		}

		private void checkBoxBackSave_CheckedChanged(object sender, System.EventArgs e)
		{
			buttonApply.Enabled = true;
		}

		private void checkBoxMICR_CheckedChanged(object sender, System.EventArgs e)
		{
			buttonApply.Enabled = true;

			if(!checkBoxOcrAb.Checked)
			{
				checkBoxSave.Enabled = checkBoxMICR.Checked;
			}

			comboBoxMicrFont.Enabled = checkBoxMICR.Checked;
		}

		private void checkBoxSave_CheckedChanged(object sender, System.EventArgs e)
		{
			buttonApply.Enabled = true;
		}

		private void checkBoxOcrAb_CheckedChanged(object sender, System.EventArgs e)
		{
			buttonApply.Enabled = true;

			comboBoxOcrAbFont.Enabled = checkBoxOcrAb.Checked;

			if(!checkBoxMICR.Checked)
			{
				checkBoxSave.Enabled = checkBoxOcrAb.Checked;
			}
		}

		private void comboBoxOcrAbFont_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			buttonApply.Enabled = true;
		}

		private void comboBoxSuccessHz_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			buttonApply.Enabled = true;
		}

		private void comboBoxSuccessCount_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			buttonApply.Enabled = true;
		}

		private void comboBoxErrorHz_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			buttonApply.Enabled = true;
		}

		private void comboBoxErrorCount_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			buttonApply.Enabled = true;
		}

		private void comboBoxWFeedHz_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			buttonApply.Enabled = true;
		}

		private void comboBoxWFeedCount_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			buttonApply.Enabled = true;
		}

		private void comboBoxNearFull_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			buttonApply.Enabled = true;
		}

		private void textBoxBadCount_TextChanged(object sender, System.EventArgs e)
		{
			buttonApply.Enabled = true;
		}

		private void SetFrontEnable(bool bEnable)
		{
			checkBoxFrontGrayscale.Enabled = bEnable;
			checkBoxFrontDisplay.Enabled = bEnable;
			checkBoxFrontSave.Enabled = bEnable;
		}

		private void SetBackEnable(bool bEnable)
		{
			checkBoxBackGrayscale.Enabled = bEnable;
			checkBoxBackDisplay.Enabled = bEnable;
			checkBoxBackSave.Enabled = bEnable;
		}

		private void comboBoxSuccessStamp_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			buttonApply.Enabled = true;
		}

		private void checkBoxIqaDetect_CheckedChanged(object sender, System.EventArgs e)
		{
			EnableIqa(checkBoxIqaDetect.Checked);

			buttonApply.Enabled = true;
		}

		// Condition of the control of Iqa it changes
		private void EnableIqa(bool bEnable)
		{
			checkBoxIqaGray.Enabled = bEnable;
			comboBoxIqaEject.Enabled = bEnable;
			checkBoxIqaStamp.Enabled = bEnable;
			checkBoxIqaCancel.Enabled = bEnable;
		}

		private void checkBoxIqaGray_CheckedChanged(object sender, System.EventArgs e)
		{
			buttonApply.Enabled = true;
		}

		private void comboBoxIqaEject_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			buttonApply.Enabled = true;
		}

		private void checkBoxIqaStamp_CheckedChanged(object sender, System.EventArgs e)
		{
			buttonApply.Enabled = true;
		}

		private void checkBoxIqaCancel_CheckedChanged(object sender, System.EventArgs e)
		{
			buttonApply.Enabled = true;
		}

		private void checkBoxWaterfallEnable_CheckedChanged(object sender, System.EventArgs e)
		{
			EnableWaterfall(checkBoxWaterfallEnable.Checked);

			buttonApply.Enabled = true;
		}

		// Condition of the control of Waterfall it changes
		private void EnableWaterfall(bool bEnable)
		{
			comboBoxWaterfallMode.Enabled = bEnable;
		}

		private void comboBoxWaterfallMode_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			buttonApply.Enabled = true;
		}

		private void checkBoxBarcodeFrontDetect_CheckedChanged(object sender, System.EventArgs e)
		{
			EnableBarcodeFront(checkBoxBarcodeFrontDetect.Checked);

			buttonApply.Enabled = true;
		}

		// Condition of the control of Barcode(front) it changes
		private void EnableBarcodeFront(bool bEnable)
		{
			comboBoxBarcodeFrontEject.Enabled = bEnable;
			checkBoxBarcodeFrontStamp.Enabled = bEnable;
			checkBoxBarcodeFrontCancel.Enabled = bEnable;
		}

		private void comboBoxBarcodeFrontEject_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			buttonApply.Enabled = true;
		}

		private void checkBoxBarcodeFrontStamp_CheckedChanged(object sender, System.EventArgs e)
		{
			buttonApply.Enabled = true;
		}

		private void checkBoxBarcodeFrontCancel_CheckedChanged(object sender, System.EventArgs e)
		{
			buttonApply.Enabled = true;
		}

		private void checkBoxBarcodeBackDetect_CheckedChanged(object sender, System.EventArgs e)
		{
			EnableBarcodeBack(checkBoxBarcodeBackDetect.Checked);

			buttonApply.Enabled = true;
		}
		// Condition of the control of Barcode(back) it changes
		private void EnableBarcodeBack(bool bEnable)
		{
			comboBoxBarcodeBackEject.Enabled = bEnable;
			checkBoxBarcodeBackStamp.Enabled = bEnable;
			checkBoxBarcodeBackCancel.Enabled = bEnable;
		}

		private void comboBoxBarcodeBackEject_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			buttonApply.Enabled = true;
		}

		private void checkBoxBarcodeBackStamp_CheckedChanged(object sender, System.EventArgs e)
		{
			buttonApply.Enabled = true;
		}

		private void checkBoxBarcodeBackCancel_CheckedChanged(object sender, System.EventArgs e)
		{
			buttonApply.Enabled = true;
		}
	}
}
