using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using com.epson.bank.driver;

namespace Presentación.Pantallas_Principal
{
	/// <summary>
	/// explanation of the outline of DeviceStatusForm
	/// </summary>
	public class DeviceStatusForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		/// <summary>
		/// necessary designer variable
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.CheckBox checkBox_NO_RESPONSE;
		private System.Windows.Forms.CheckBox checkBox_OFF_LINE;
		private System.Windows.Forms.CheckBox checkBox_COVER_OPEN;
		private System.Windows.Forms.CheckBox checkBox_WAIT_PEPRT_EJECT;
		private System.Windows.Forms.CheckBox checkBox_MECHANICAL_ERR;
		private System.Windows.Forms.CheckBox checkBox_UNRECOVER_ERR;
		private System.Windows.Forms.CheckBox checkBox_PAPER_INTERMEDIATE;
		private System.Windows.Forms.CheckBox checkBox_MAIN_NEAR_FULL;
		private System.Windows.Forms.CheckBox checkBox_EJECT_SENSOR_NO_PAPER;
		private System.Windows.Forms.CheckBox checkBox_SUB_NEAR_FULL;
		private System.Windows.Forms.CheckBox checkBox_SLIP_PAPER_SIZE;
		private System.Windows.Forms.CheckBox checkBox_ASF_PAPER;
		private System.Windows.Forms.CheckBox checkBox_STAMP_EXIST;
		private System.Windows.Forms.CheckBox checkBox_WAIT_INSERT;
		private System.Windows.Forms.CheckBox checkBox_FRANKING_SENSOR;

		protected Ingreso_Cheque m_objTms1000 = null;

		public DeviceStatusForm()
		{
			//
			// Required by the Windows Form Designer
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent
			//
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

			// Because I put out DeviceStatusForm it makes bDeviceStatus false
			m_objTms1000.m_bDeviceStatus = false;
		}

		#region Create code by Windwos Form Designer 
		/// <summary>
		/// The following procedure is required by the Windows Form Designer
		/// It can be modified using the Windows Form Designer.
		/// Do not modify it using the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(DeviceStatusForm));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.checkBox_FRANKING_SENSOR = new System.Windows.Forms.CheckBox();
			this.checkBox_WAIT_INSERT = new System.Windows.Forms.CheckBox();
			this.checkBox_STAMP_EXIST = new System.Windows.Forms.CheckBox();
			this.checkBox_ASF_PAPER = new System.Windows.Forms.CheckBox();
			this.checkBox_SLIP_PAPER_SIZE = new System.Windows.Forms.CheckBox();
			this.checkBox_SUB_NEAR_FULL = new System.Windows.Forms.CheckBox();
			this.checkBox_EJECT_SENSOR_NO_PAPER = new System.Windows.Forms.CheckBox();
			this.checkBox_MAIN_NEAR_FULL = new System.Windows.Forms.CheckBox();
			this.checkBox_PAPER_INTERMEDIATE = new System.Windows.Forms.CheckBox();
			this.checkBox_UNRECOVER_ERR = new System.Windows.Forms.CheckBox();
			this.checkBox_MECHANICAL_ERR = new System.Windows.Forms.CheckBox();
			this.checkBox_WAIT_PEPRT_EJECT = new System.Windows.Forms.CheckBox();
			this.checkBox_COVER_OPEN = new System.Windows.Forms.CheckBox();
			this.checkBox_OFF_LINE = new System.Windows.Forms.CheckBox();
			this.checkBox_NO_RESPONSE = new System.Windows.Forms.CheckBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBox_FRANKING_SENSOR);
			this.groupBox1.Controls.Add(this.checkBox_WAIT_INSERT);
			this.groupBox1.Controls.Add(this.checkBox_STAMP_EXIST);
			this.groupBox1.Controls.Add(this.checkBox_ASF_PAPER);
			this.groupBox1.Controls.Add(this.checkBox_SLIP_PAPER_SIZE);
			this.groupBox1.Controls.Add(this.checkBox_SUB_NEAR_FULL);
			this.groupBox1.Controls.Add(this.checkBox_EJECT_SENSOR_NO_PAPER);
			this.groupBox1.Controls.Add(this.checkBox_MAIN_NEAR_FULL);
			this.groupBox1.Controls.Add(this.checkBox_PAPER_INTERMEDIATE);
			this.groupBox1.Controls.Add(this.checkBox_UNRECOVER_ERR);
			this.groupBox1.Controls.Add(this.checkBox_MECHANICAL_ERR);
			this.groupBox1.Controls.Add(this.checkBox_WAIT_PEPRT_EJECT);
			this.groupBox1.Controls.Add(this.checkBox_COVER_OPEN);
			this.groupBox1.Controls.Add(this.checkBox_OFF_LINE);
			this.groupBox1.Controls.Add(this.checkBox_NO_RESPONSE);
			this.groupBox1.Location = new System.Drawing.Point(8, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(280, 392);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Device Status";
			// 
			// checkBox_FRANKING_SENSOR
			// 
			this.checkBox_FRANKING_SENSOR.AutoCheck = false;
			this.checkBox_FRANKING_SENSOR.Location = new System.Drawing.Point(24, 360);
			this.checkBox_FRANKING_SENSOR.Name = "checkBox_FRANKING_SENSOR";
			this.checkBox_FRANKING_SENSOR.Size = new System.Drawing.Size(240, 24);
			this.checkBox_FRANKING_SENSOR.TabIndex = 14;
			this.checkBox_FRANKING_SENSOR.Text = "FRANKING_SENSOR";
			// 
			// checkBox_WAIT_INSERT
			// 
			this.checkBox_WAIT_INSERT.AutoCheck = false;
			this.checkBox_WAIT_INSERT.Location = new System.Drawing.Point(24, 336);
			this.checkBox_WAIT_INSERT.Name = "checkBox_WAIT_INSERT";
			this.checkBox_WAIT_INSERT.Size = new System.Drawing.Size(240, 24);
			this.checkBox_WAIT_INSERT.TabIndex = 13;
			this.checkBox_WAIT_INSERT.Text = "WAIT_INSERT";
			// 
			// checkBox_STAMP_EXIST
			// 
			this.checkBox_STAMP_EXIST.AutoCheck = false;
			this.checkBox_STAMP_EXIST.Location = new System.Drawing.Point(24, 312);
			this.checkBox_STAMP_EXIST.Name = "checkBox_STAMP_EXIST";
			this.checkBox_STAMP_EXIST.Size = new System.Drawing.Size(240, 24);
			this.checkBox_STAMP_EXIST.TabIndex = 12;
			this.checkBox_STAMP_EXIST.Text = "NO_STAMP_EXIST";
			// 
			// checkBox_ASF_PAPER
			// 
			this.checkBox_ASF_PAPER.AutoCheck = false;
			this.checkBox_ASF_PAPER.Location = new System.Drawing.Point(24, 288);
			this.checkBox_ASF_PAPER.Name = "checkBox_ASF_PAPER";
			this.checkBox_ASF_PAPER.Size = new System.Drawing.Size(240, 24);
			this.checkBox_ASF_PAPER.TabIndex = 11;
			this.checkBox_ASF_PAPER.Text = "ASF_PAPER";
			// 
			// checkBox_SLIP_PAPER_SIZE
			// 
			this.checkBox_SLIP_PAPER_SIZE.AutoCheck = false;
			this.checkBox_SLIP_PAPER_SIZE.Location = new System.Drawing.Point(24, 264);
			this.checkBox_SLIP_PAPER_SIZE.Name = "checkBox_SLIP_PAPER_SIZE";
			this.checkBox_SLIP_PAPER_SIZE.Size = new System.Drawing.Size(240, 24);
			this.checkBox_SLIP_PAPER_SIZE.TabIndex = 10;
			this.checkBox_SLIP_PAPER_SIZE.Text = "SLIP_PAPER_SIZE";
			// 
			// checkBox_SUB_NEAR_FULL
			// 
			this.checkBox_SUB_NEAR_FULL.AutoCheck = false;
			this.checkBox_SUB_NEAR_FULL.Location = new System.Drawing.Point(24, 240);
			this.checkBox_SUB_NEAR_FULL.Name = "checkBox_SUB_NEAR_FULL";
			this.checkBox_SUB_NEAR_FULL.Size = new System.Drawing.Size(240, 24);
			this.checkBox_SUB_NEAR_FULL.TabIndex = 9;
			this.checkBox_SUB_NEAR_FULL.Text = "SUB_NEAR_FULL";
			// 
			// checkBox_EJECT_SENSOR_NO_PAPER
			// 
			this.checkBox_EJECT_SENSOR_NO_PAPER.AutoCheck = false;
			this.checkBox_EJECT_SENSOR_NO_PAPER.Location = new System.Drawing.Point(24, 216);
			this.checkBox_EJECT_SENSOR_NO_PAPER.Name = "checkBox_EJECT_SENSOR_NO_PAPER";
			this.checkBox_EJECT_SENSOR_NO_PAPER.Size = new System.Drawing.Size(240, 24);
			this.checkBox_EJECT_SENSOR_NO_PAPER.TabIndex = 8;
			this.checkBox_EJECT_SENSOR_NO_PAPER.Text = "EJECT_SENSOR_NO_PAPER";
			// 
			// checkBox_MAIN_NEAR_FULL
			// 
			this.checkBox_MAIN_NEAR_FULL.AutoCheck = false;
			this.checkBox_MAIN_NEAR_FULL.Location = new System.Drawing.Point(24, 192);
			this.checkBox_MAIN_NEAR_FULL.Name = "checkBox_MAIN_NEAR_FULL";
			this.checkBox_MAIN_NEAR_FULL.Size = new System.Drawing.Size(240, 24);
			this.checkBox_MAIN_NEAR_FULL.TabIndex = 7;
			this.checkBox_MAIN_NEAR_FULL.Text = "MAIN_NEAR_FULL";
			// 
			// checkBox_PAPER_INTERMEDIATE
			// 
			this.checkBox_PAPER_INTERMEDIATE.AutoCheck = false;
			this.checkBox_PAPER_INTERMEDIATE.Location = new System.Drawing.Point(24, 168);
			this.checkBox_PAPER_INTERMEDIATE.Name = "checkBox_PAPER_INTERMEDIATE";
			this.checkBox_PAPER_INTERMEDIATE.Size = new System.Drawing.Size(240, 24);
			this.checkBox_PAPER_INTERMEDIATE.TabIndex = 6;
			this.checkBox_PAPER_INTERMEDIATE.Text = "PAPER_INTERMEDIATE";
			// 
			// checkBox_UNRECOVER_ERR
			// 
			this.checkBox_UNRECOVER_ERR.AutoCheck = false;
			this.checkBox_UNRECOVER_ERR.Location = new System.Drawing.Point(24, 144);
			this.checkBox_UNRECOVER_ERR.Name = "checkBox_UNRECOVER_ERR";
			this.checkBox_UNRECOVER_ERR.Size = new System.Drawing.Size(232, 24);
			this.checkBox_UNRECOVER_ERR.TabIndex = 5;
			this.checkBox_UNRECOVER_ERR.Text = "UNRECOVER_ERR";
			// 
			// checkBox_MECHANICAL_ERR
			// 
			this.checkBox_MECHANICAL_ERR.AutoCheck = false;
			this.checkBox_MECHANICAL_ERR.Location = new System.Drawing.Point(24, 120);
			this.checkBox_MECHANICAL_ERR.Name = "checkBox_MECHANICAL_ERR";
			this.checkBox_MECHANICAL_ERR.Size = new System.Drawing.Size(240, 24);
			this.checkBox_MECHANICAL_ERR.TabIndex = 4;
			this.checkBox_MECHANICAL_ERR.Text = "MECHANICAL_ERR";
			// 
			// checkBox_WAIT_PEPRT_EJECT
			// 
			this.checkBox_WAIT_PEPRT_EJECT.AutoCheck = false;
			this.checkBox_WAIT_PEPRT_EJECT.Location = new System.Drawing.Point(24, 96);
			this.checkBox_WAIT_PEPRT_EJECT.Name = "checkBox_WAIT_PEPRT_EJECT";
			this.checkBox_WAIT_PEPRT_EJECT.Size = new System.Drawing.Size(240, 24);
			this.checkBox_WAIT_PEPRT_EJECT.TabIndex = 3;
			this.checkBox_WAIT_PEPRT_EJECT.Text = "WAIT_PEPRT_EJECT";
			// 
			// checkBox_COVER_OPEN
			// 
			this.checkBox_COVER_OPEN.AutoCheck = false;
			this.checkBox_COVER_OPEN.Location = new System.Drawing.Point(24, 72);
			this.checkBox_COVER_OPEN.Name = "checkBox_COVER_OPEN";
			this.checkBox_COVER_OPEN.Size = new System.Drawing.Size(240, 24);
			this.checkBox_COVER_OPEN.TabIndex = 2;
			this.checkBox_COVER_OPEN.Text = "COVER_OPEN";
			// 
			// checkBox_OFF_LINE
			// 
			this.checkBox_OFF_LINE.AutoCheck = false;
			this.checkBox_OFF_LINE.Location = new System.Drawing.Point(24, 48);
			this.checkBox_OFF_LINE.Name = "checkBox_OFF_LINE";
			this.checkBox_OFF_LINE.Size = new System.Drawing.Size(240, 24);
			this.checkBox_OFF_LINE.TabIndex = 1;
			this.checkBox_OFF_LINE.Text = "OFF_LINE";
			// 
			// checkBox_NO_RESPONSE
			// 
			this.checkBox_NO_RESPONSE.AutoCheck = false;
			this.checkBox_NO_RESPONSE.Location = new System.Drawing.Point(24, 24);
			this.checkBox_NO_RESPONSE.Name = "checkBox_NO_RESPONSE";
			this.checkBox_NO_RESPONSE.Size = new System.Drawing.Size(240, 24);
			this.checkBox_NO_RESPONSE.TabIndex = 0;
			this.checkBox_NO_RESPONSE.Text = "NO_RESPONSE";
			// 
			// DeviceStatusForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
			this.ClientSize = new System.Drawing.Size(292, 400);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "DeviceStatusForm";
			this.Text = "DeviceStatus";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		// copy TMS1000SampleForm object
		public void SetMainForm(Ingreso_Cheque Item)
		{
			m_objTms1000 = Item;
		}

		// Change the values to Boolean
		private bool GetCheck(ASB values)
		{
			if(Convert.ToBoolean(values))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		// This delegate enables asynchronous calls for setting.
		delegate void SetDeviceStatusCallback(ASB Status);

		// Renewal the check box by the status
		public void SetDeviceStatus(ASB Status)
		{
			if(this.InvokeRequired)
			{
				SetDeviceStatusCallback c = new SetDeviceStatusCallback(SetDeviceStatus);
				this.Invoke(c, new object [] { Status } );
			}
			else
			{

				// Display the status
				this.Text = "DeviceStatus - " + Status.ToString("X") + "h";

				// ASB_NO_RESPONSE
				if(Status == ASB.ASB_NO_RESPONSE)
				{
					// ASB_NO_RESPONSE
					checkBox_NO_RESPONSE.Checked = true;

					// ASB_OFF_LINE
					checkBox_OFF_LINE.Checked = false;

					// ASB_COVER_OPEN
					checkBox_COVER_OPEN.Checked = false;

					// ASB_WAIT_PEPRT_EJECT
					checkBox_WAIT_PEPRT_EJECT.Checked = false;

					// ASB_MECHANICAL_ERR
					checkBox_MECHANICAL_ERR.Checked = false;

					// ASB_UNRECOVER_ERR
					checkBox_UNRECOVER_ERR.Checked = false;

					// ASB_PAPER_INTERMEDIATE
					checkBox_PAPER_INTERMEDIATE.Checked = false;

					// ASB_MAIN_NEAR_FULL
					checkBox_MAIN_NEAR_FULL.Checked = false;

					// ASB_EJECT_SENSOR_NO_PAPER
					checkBox_EJECT_SENSOR_NO_PAPER.Checked = false;

					// ASB_SUB_NEAR_FULL
					checkBox_SUB_NEAR_FULL.Checked = false;

					// ASB_SLIP_PAPER_SIZE
					checkBox_SLIP_PAPER_SIZE.Checked = false;

					// ASB_ASF_PAPER
					checkBox_ASF_PAPER.Checked = false;

					// ASB_STAMP_EXIST
					checkBox_STAMP_EXIST.Checked = false;

					// ASB_WAIT_INSERT
					checkBox_WAIT_INSERT.Checked = false;

					// ASB_FRANKING_SENSOR
					checkBox_FRANKING_SENSOR.Checked = false;
				}
				else
				{
					// Not ASB_NO_RESPONSE

					// ASB_NO_RESPONSE
					checkBox_NO_RESPONSE.Checked = false;

					// ASB_OFF_LINE
					checkBox_OFF_LINE.Checked = GetCheck(Status & ASB.ASB_OFF_LINE);

					// ASB_COVER_OPEN
					checkBox_COVER_OPEN.Checked = GetCheck(Status & ASB.ASB_COVER_OPEN);

					// ASB_WAIT_PEPRT_EJECT
					checkBox_WAIT_PEPRT_EJECT.Checked = GetCheck(Status & ASB.ASB_WAIT_PEPRT_EJECT);

					// ASB_MECHANICAL_ERR
					checkBox_MECHANICAL_ERR.Checked = GetCheck(Status & ASB.ASB_MECHANICAL_ERR);

					// ASB_UNRECOVER_ERR
					checkBox_UNRECOVER_ERR.Checked = GetCheck(Status & ASB.ASB_UNRECOVER_ERR);

					// ASB_PAPER_INTERMEDIATE
					checkBox_PAPER_INTERMEDIATE.Checked = !GetCheck(Status & ASB.ASB_PAPER_INTERMEDIATE);

					// ASB_MAIN_NEAR_FULL
					checkBox_MAIN_NEAR_FULL.Checked = !GetCheck(Status & ASB.ASB_MAIN_NEAR_FULL);

					// ASB_EJECT_SENSOR_NO_PAPER
					checkBox_EJECT_SENSOR_NO_PAPER.Checked = !GetCheck(Status & ASB.ASB_EJECT_SENSOR_NO_PAPER);

					// ASB_SUB_NEAR_FULL
					checkBox_SUB_NEAR_FULL.Checked = !GetCheck(Status & ASB.ASB_SUB_NEAR_FULL);

					// ASB_SLIP_PAPER_SIZE
					checkBox_SLIP_PAPER_SIZE.Checked = !GetCheck(Status & ASB.ASB_SLIP_PAPER_SIZE);

					// ASB_ASF_PAPER
					checkBox_ASF_PAPER.Checked = !GetCheck(Status & ASB.ASB_ASF_PAPER);

					// ASB_STAMP_EXIST
					checkBox_STAMP_EXIST.Checked = GetCheck(Status & ASB.ASB_STAMP_EXIST);

					// ASB_WAIT_INSERT
					checkBox_WAIT_INSERT.Checked = GetCheck(Status & ASB.ASB_WAIT_INSERT);

					// ASB_FRANKING_SENSOR
					checkBox_FRANKING_SENSOR.Checked = !GetCheck(Status & ASB.ASB_FRANKING_SENSOR);
				}
			}
		}
	}
}
