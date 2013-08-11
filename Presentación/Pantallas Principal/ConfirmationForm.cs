using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Presentación.Pantallas_Principal
{
	/// <summary>
	/// explanation of the outline of ConfirmationForm
	/// </summary>
	public class ConfirmationForm : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.ComboBox ComboBoxNextCheck;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.ComboBox ComboBoxEjectType;
		internal System.Windows.Forms.Button ButtonOK;
		internal System.Windows.Forms.Button ButtonCancel;
		internal System.Windows.Forms.CheckBox CheckBoxStamp;
		/// <summary>
		/// necessary designer variable
		/// </summary>
		private System.ComponentModel.Container components = null;

		protected Properties m_objConfig = null;

		public ConfirmationForm()
		{
			//
			// Required by the Windows Form Designer
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent
			//
			m_objConfig = new Properties();
			LoadProperties();
			m_objConfig.SetValue(Properties.CONF_OK, false);
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ConfirmationForm));
			this.Label2 = new System.Windows.Forms.Label();
			this.ComboBoxNextCheck = new System.Windows.Forms.ComboBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.ComboBoxEjectType = new System.Windows.Forms.ComboBox();
			this.ButtonOK = new System.Windows.Forms.Button();
			this.ButtonCancel = new System.Windows.Forms.Button();
			this.CheckBoxStamp = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// Label2
			// 
			this.Label2.Location = new System.Drawing.Point(29, 80);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(80, 23);
			this.Label2.TabIndex = 19;
			this.Label2.Text = "Next Check";
			// 
			// ComboBoxNextCheck
			// 
			this.ComboBoxNextCheck.Items.AddRange(new object[] {
																   "OVERLAP",
																   "NOOVERLAP",
																   "CANCEL"});
			this.ComboBoxNextCheck.Location = new System.Drawing.Point(117, 80);
			this.ComboBoxNextCheck.Name = "ComboBoxNextCheck";
			this.ComboBoxNextCheck.Size = new System.Drawing.Size(121, 20);
			this.ComboBoxNextCheck.TabIndex = 2;
			// 
			// Label1
			// 
			this.Label1.Location = new System.Drawing.Point(29, 16);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(80, 23);
			this.Label1.TabIndex = 17;
			this.Label1.Text = "Eject Type";
			// 
			// ComboBoxEjectType
			// 
			this.ComboBoxEjectType.Items.AddRange(new object[] {
																   "MAIN",
																   "SUB"});
			this.ComboBoxEjectType.Location = new System.Drawing.Point(117, 16);
			this.ComboBoxEjectType.Name = "ComboBoxEjectType";
			this.ComboBoxEjectType.Size = new System.Drawing.Size(121, 20);
			this.ComboBoxEjectType.TabIndex = 0;
			// 
			// ButtonOK
			// 
			this.ButtonOK.Location = new System.Drawing.Point(45, 120);
			this.ButtonOK.Name = "ButtonOK";
			this.ButtonOK.TabIndex = 3;
			this.ButtonOK.Text = "OK";
			this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
			// 
			// ButtonCancel
			// 
			this.ButtonCancel.Location = new System.Drawing.Point(189, 120);
			this.ButtonCancel.Name = "ButtonCancel";
			this.ButtonCancel.TabIndex = 4;
			this.ButtonCancel.Text = "Cancel";
			this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
			// 
			// CheckBoxStamp
			// 
			this.CheckBoxStamp.Location = new System.Drawing.Point(117, 48);
			this.CheckBoxStamp.Name = "CheckBoxStamp";
			this.CheckBoxStamp.TabIndex = 1;
			this.CheckBoxStamp.Text = "Stamp";
			// 
			// ConfirmationForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
			this.ClientSize = new System.Drawing.Size(292, 150);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.ComboBoxNextCheck);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.ComboBoxEjectType);
			this.Controls.Add(this.ButtonOK);
			this.Controls.Add(this.ButtonCancel);
			this.Controls.Add(this.CheckBoxStamp);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "ConfirmationForm";
			this.Text = "ConfirmationForm";
			this.ResumeLayout(false);

		}
		#endregion

		// input of the property  
		public void SetProc(Properties Proc, string title)
		{
			if(title.Length > 0)
			{
				this.Text = title;
			}
			m_objConfig = new Properties(Proc);
			LoadProperties();
		}

		// output of the property  
		public Properties GetProc()
		{
			return new Properties(m_objConfig);
		}

		// this method is called when the user click the OK button
		private void ButtonOK_Click(object sender, System.EventArgs e)
		{
			m_objConfig.SetValue(Properties.CONF_EJECT, ComboBoxEjectType.SelectedIndex);
			m_objConfig.SetValue(Properties.CONF_STAMP, CheckBoxStamp.Checked);
			m_objConfig.SetValue(Properties.CONF_NEXT_CHECK, ComboBoxNextCheck.SelectedIndex);
			m_objConfig.SetValue(Properties.CONF_OK, true);
			Close();
		}

		// this method is called when the user click the Cancel button
		private void ButtonCancel_Click(object sender, System.EventArgs e)
		{
			m_objConfig.SetValue(Properties.CONF_OK, false);
			Close();
		}

		// this method is property is bound to the  Each value
		private void LoadProperties()
		{
			ComboBoxEjectType.SelectedIndex = m_objConfig.GetValue(Properties.CONF_EJECT);
			CheckBoxStamp.Checked = m_objConfig.GetValueBool(Properties.CONF_STAMP);
			ComboBoxNextCheck.SelectedIndex = m_objConfig.GetValue(Properties.CONF_NEXT_CHECK);
		}
	}
}
