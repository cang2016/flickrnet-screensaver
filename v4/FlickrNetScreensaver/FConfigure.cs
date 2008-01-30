using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using FlickrNet;

namespace FlickrNetScreensaver
{
	/// <summary>
	/// Summary description for FConfigure.
	/// </summary>
	public class FConfigure : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button BtnOK;
		private System.Windows.Forms.Button BtnCancel;
		private System.Windows.Forms.TabControl TabControl;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TextBox UserName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox UserWhat;
		private System.Windows.Forms.TextBox UserTagName;
		private System.Windows.Forms.RadioButton UserAll;
		private System.Windows.Forms.RadioButton UserTag;
		private System.Windows.Forms.RadioButton UserSet;
		private System.Windows.Forms.TextBox UserSetName;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox ImageSize;
		private System.Windows.Forms.NumericUpDown DelayTime;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.RadioButton UserFav;
		private System.Windows.Forms.Button AboutButton;
		private System.Windows.Forms.RadioButton UserContacts;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.TextBox EveryoneTagText;
		private System.Windows.Forms.RadioButton EveryoneTag;
		private System.Windows.Forms.RadioButton EveryoneRecent;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox GroupName;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.GroupBox GroupWhat;
		private System.Windows.Forms.GroupBox EveryoneWhat;
		private System.Windows.Forms.RadioButton SelectUser;
		private System.Windows.Forms.RadioButton SelectGroup;
		private System.Windows.Forms.RadioButton SelectEveryone;
		private System.Windows.Forms.PictureBox EveryoneWarning;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ComboBox Drawer;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.ImageList RecentPhotosImages;
		private System.Windows.Forms.ListView RecentPhotosList;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button AuthButton;
		private System.Windows.Forms.Button AuthCompleteButton;
		private System.ComponentModel.IContainer components;

		private string TempFrob;
		private System.Windows.Forms.Label AuthTokenLabel;
		private System.Windows.Forms.Button AuthRemoveButton;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.CheckBox FillScreen;
		private System.Windows.Forms.TabPage tabPage5;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox ProxyIPAddress;
		private System.Windows.Forms.TextBox ProxyPort;
		private System.Windows.Forms.TextBox ProxyPassword;
		private System.Windows.Forms.TextBox ProxyUsername;
		private System.Windows.Forms.TextBox ProxyDomain;
		private System.Windows.Forms.CheckBox ProxyDefined;
		private System.Windows.Forms.Panel ProxyPanel;
		private System.Windows.Forms.Label RecentPhotosLabel;
		private string Token;

		public FConfigure()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
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

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FConfigure));
			this.BtnOK = new System.Windows.Forms.Button();
			this.BtnCancel = new System.Windows.Forms.Button();
			this.TabControl = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.GroupWhat = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.GroupName = new System.Windows.Forms.TextBox();
			this.EveryoneWhat = new System.Windows.Forms.GroupBox();
			this.EveryoneTagText = new System.Windows.Forms.TextBox();
			this.EveryoneTag = new System.Windows.Forms.RadioButton();
			this.EveryoneRecent = new System.Windows.Forms.RadioButton();
			this.UserWhat = new System.Windows.Forms.GroupBox();
			this.UserTagName = new System.Windows.Forms.TextBox();
			this.UserName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.UserContacts = new System.Windows.Forms.RadioButton();
			this.UserFav = new System.Windows.Forms.RadioButton();
			this.UserTag = new System.Windows.Forms.RadioButton();
			this.UserSet = new System.Windows.Forms.RadioButton();
			this.UserAll = new System.Windows.Forms.RadioButton();
			this.UserSetName = new System.Windows.Forms.TextBox();
			this.SelectUser = new System.Windows.Forms.RadioButton();
			this.SelectGroup = new System.Windows.Forms.RadioButton();
			this.SelectEveryone = new System.Windows.Forms.RadioButton();
			this.EveryoneWarning = new System.Windows.Forms.PictureBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.FillScreen = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.Drawer = new System.Windows.Forms.ComboBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.DelayTime = new System.Windows.Forms.NumericUpDown();
			this.ImageSize = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.label9 = new System.Windows.Forms.Label();
			this.AuthRemoveButton = new System.Windows.Forms.Button();
			this.AuthTokenLabel = new System.Windows.Forms.Label();
			this.AuthCompleteButton = new System.Windows.Forms.Button();
			this.AuthButton = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.RecentPhotosLabel = new System.Windows.Forms.Label();
			this.RecentPhotosList = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.RecentPhotosImages = new System.Windows.Forms.ImageList(this.components);
			this.label10 = new System.Windows.Forms.Label();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.ProxyPanel = new System.Windows.Forms.Panel();
			this.ProxyDomain = new System.Windows.Forms.TextBox();
			this.ProxyPassword = new System.Windows.Forms.TextBox();
			this.ProxyUsername = new System.Windows.Forms.TextBox();
			this.ProxyPort = new System.Windows.Forms.TextBox();
			this.ProxyIPAddress = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.ProxyDefined = new System.Windows.Forms.CheckBox();
			this.AboutButton = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.TabControl.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.GroupWhat.SuspendLayout();
			this.EveryoneWhat.SuspendLayout();
			this.UserWhat.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DelayTime)).BeginInit();
			this.tabPage4.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tabPage5.SuspendLayout();
			this.ProxyPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// BtnOK
			// 
			this.BtnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.BtnOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.BtnOK.Location = new System.Drawing.Point(240, 432);
			this.BtnOK.Name = "BtnOK";
			this.BtnOK.Size = new System.Drawing.Size(72, 24);
			this.BtnOK.TabIndex = 1;
			this.BtnOK.Text = "OK";
			this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
			// 
			// BtnCancel
			// 
			this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.BtnCancel.Location = new System.Drawing.Point(320, 432);
			this.BtnCancel.Name = "BtnCancel";
			this.BtnCancel.Size = new System.Drawing.Size(72, 24);
			this.BtnCancel.TabIndex = 2;
			this.BtnCancel.Text = "Cancel";
			this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
			// 
			// TabControl
			// 
			this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.TabControl.Controls.Add(this.tabPage1);
			this.TabControl.Controls.Add(this.tabPage2);
			this.TabControl.Controls.Add(this.tabPage4);
			this.TabControl.Controls.Add(this.tabPage3);
			this.TabControl.Controls.Add(this.tabPage5);
			this.TabControl.Location = new System.Drawing.Point(0, 8);
			this.TabControl.Name = "TabControl";
			this.TabControl.SelectedIndex = 0;
			this.TabControl.Size = new System.Drawing.Size(400, 416);
			this.TabControl.TabIndex = 11;
			this.TabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.GroupWhat);
			this.tabPage1.Controls.Add(this.EveryoneWhat);
			this.tabPage1.Controls.Add(this.UserWhat);
			this.tabPage1.Controls.Add(this.SelectUser);
			this.tabPage1.Controls.Add(this.SelectGroup);
			this.tabPage1.Controls.Add(this.SelectEveryone);
			this.tabPage1.Controls.Add(this.EveryoneWarning);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(392, 390);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Pictures";
			// 
			// GroupWhat
			// 
			this.GroupWhat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.GroupWhat.Controls.Add(this.label4);
			this.GroupWhat.Controls.Add(this.label3);
			this.GroupWhat.Controls.Add(this.GroupName);
			this.GroupWhat.Enabled = false;
			this.GroupWhat.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.GroupWhat.Location = new System.Drawing.Point(16, 192);
			this.GroupWhat.Name = "GroupWhat";
			this.GroupWhat.Size = new System.Drawing.Size(360, 80);
			this.GroupWhat.TabIndex = 18;
			this.GroupWhat.TabStop = false;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 48);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(152, 16);
			this.label4.TabIndex = 14;
			this.label4.Text = "http://www.flickr.com/groups/";
			this.label4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 16);
			this.label3.TabIndex = 13;
			this.label3.Text = "Groupname:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// GroupName
			// 
			this.GroupName.Location = new System.Drawing.Point(168, 48);
			this.GroupName.Name = "GroupName";
			this.GroupName.Size = new System.Drawing.Size(120, 20);
			this.GroupName.TabIndex = 12;
			this.GroupName.Text = "";
			// 
			// EveryoneWhat
			// 
			this.EveryoneWhat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.EveryoneWhat.Controls.Add(this.EveryoneTagText);
			this.EveryoneWhat.Controls.Add(this.EveryoneTag);
			this.EveryoneWhat.Controls.Add(this.EveryoneRecent);
			this.EveryoneWhat.Enabled = false;
			this.EveryoneWhat.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.EveryoneWhat.Location = new System.Drawing.Point(16, 296);
			this.EveryoneWhat.Name = "EveryoneWhat";
			this.EveryoneWhat.Size = new System.Drawing.Size(360, 80);
			this.EveryoneWhat.TabIndex = 10;
			this.EveryoneWhat.TabStop = false;
			// 
			// EveryoneTagText
			// 
			this.EveryoneTagText.Enabled = false;
			this.EveryoneTagText.Location = new System.Drawing.Point(104, 40);
			this.EveryoneTagText.Name = "EveryoneTagText";
			this.EveryoneTagText.Size = new System.Drawing.Size(120, 20);
			this.EveryoneTagText.TabIndex = 2;
			this.EveryoneTagText.Text = "";
			// 
			// EveryoneTag
			// 
			this.EveryoneTag.Location = new System.Drawing.Point(24, 40);
			this.EveryoneTag.Name = "EveryoneTag";
			this.EveryoneTag.Size = new System.Drawing.Size(72, 16);
			this.EveryoneTag.TabIndex = 1;
			this.EveryoneTag.Text = "With Tag:";
			this.EveryoneTag.CheckedChanged += new System.EventHandler(this.EveryoneTag_CheckedChanged);
			// 
			// EveryoneRecent
			// 
			this.EveryoneRecent.Checked = true;
			this.EveryoneRecent.Location = new System.Drawing.Point(24, 16);
			this.EveryoneRecent.Name = "EveryoneRecent";
			this.EveryoneRecent.Size = new System.Drawing.Size(72, 16);
			this.EveryoneRecent.TabIndex = 0;
			this.EveryoneRecent.TabStop = true;
			this.EveryoneRecent.Text = "Recent";
			// 
			// UserWhat
			// 
			this.UserWhat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.UserWhat.Controls.Add(this.UserTagName);
			this.UserWhat.Controls.Add(this.UserName);
			this.UserWhat.Controls.Add(this.label2);
			this.UserWhat.Controls.Add(this.UserContacts);
			this.UserWhat.Controls.Add(this.UserFav);
			this.UserWhat.Controls.Add(this.UserTag);
			this.UserWhat.Controls.Add(this.UserSet);
			this.UserWhat.Controls.Add(this.UserAll);
			this.UserWhat.Controls.Add(this.UserSetName);
			this.UserWhat.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.UserWhat.Location = new System.Drawing.Point(16, 32);
			this.UserWhat.Name = "UserWhat";
			this.UserWhat.Size = new System.Drawing.Size(360, 136);
			this.UserWhat.TabIndex = 7;
			this.UserWhat.TabStop = false;
			// 
			// UserTagName
			// 
			this.UserTagName.Enabled = false;
			this.UserTagName.Location = new System.Drawing.Point(200, 96);
			this.UserTagName.Name = "UserTagName";
			this.UserTagName.Size = new System.Drawing.Size(128, 20);
			this.UserTagName.TabIndex = 9;
			this.UserTagName.Text = "";
			// 
			// UserName
			// 
			this.UserName.Location = new System.Drawing.Point(104, 24);
			this.UserName.Name = "UserName";
			this.UserName.Size = new System.Drawing.Size(128, 20);
			this.UserName.TabIndex = 8;
			this.UserName.Text = "Sam Judson";
			this.toolTip1.SetToolTip(this.UserName, "Enter the users screenname or email address");
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 16);
			this.label2.TabIndex = 9;
			this.label2.Text = "Whose Photos:";
			// 
			// UserContacts
			// 
			this.UserContacts.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.UserContacts.Location = new System.Drawing.Point(24, 88);
			this.UserContacts.Name = "UserContacts";
			this.UserContacts.Size = new System.Drawing.Size(80, 32);
			this.UserContacts.TabIndex = 11;
			this.UserContacts.Text = "Contacts";
			// 
			// UserFav
			// 
			this.UserFav.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.UserFav.Location = new System.Drawing.Point(24, 64);
			this.UserFav.Name = "UserFav";
			this.UserFav.Size = new System.Drawing.Size(80, 32);
			this.UserFav.TabIndex = 10;
			this.UserFav.Text = "Favorites";
			// 
			// UserTag
			// 
			this.UserTag.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.UserTag.Location = new System.Drawing.Point(120, 88);
			this.UserTag.Name = "UserTag";
			this.UserTag.Size = new System.Drawing.Size(80, 32);
			this.UserTag.TabIndex = 6;
			this.UserTag.Text = "With Tag:";
			this.UserTag.CheckedChanged += new System.EventHandler(this.UserTag_CheckedChanged);
			// 
			// UserSet
			// 
			this.UserSet.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.UserSet.Location = new System.Drawing.Point(120, 64);
			this.UserSet.Name = "UserSet";
			this.UserSet.Size = new System.Drawing.Size(80, 32);
			this.UserSet.TabIndex = 5;
			this.UserSet.Text = "From Set:";
			this.UserSet.CheckedChanged += new System.EventHandler(this.UserSet_CheckedChanged);
			// 
			// UserAll
			// 
			this.UserAll.Checked = true;
			this.UserAll.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.UserAll.Location = new System.Drawing.Point(24, 40);
			this.UserAll.Name = "UserAll";
			this.UserAll.Size = new System.Drawing.Size(40, 32);
			this.UserAll.TabIndex = 8;
			this.UserAll.TabStop = true;
			this.UserAll.Text = "All";
			// 
			// UserSetName
			// 
			this.UserSetName.Enabled = false;
			this.UserSetName.Location = new System.Drawing.Point(200, 72);
			this.UserSetName.Name = "UserSetName";
			this.UserSetName.Size = new System.Drawing.Size(128, 20);
			this.UserSetName.TabIndex = 7;
			this.UserSetName.Text = "";
			// 
			// SelectUser
			// 
			this.SelectUser.Checked = true;
			this.SelectUser.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.SelectUser.Location = new System.Drawing.Point(24, 16);
			this.SelectUser.Name = "SelectUser";
			this.SelectUser.TabIndex = 15;
			this.SelectUser.TabStop = true;
			this.SelectUser.Text = "Per User";
			this.SelectUser.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			this.toolTip1.SetToolTip(this.SelectUser, "Display photos from one particular user");
			this.SelectUser.CheckedChanged += new System.EventHandler(this.SelectUser_CheckedChanged);
			// 
			// SelectGroup
			// 
			this.SelectGroup.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.SelectGroup.Location = new System.Drawing.Point(24, 176);
			this.SelectGroup.Name = "SelectGroup";
			this.SelectGroup.TabIndex = 16;
			this.SelectGroup.Text = "Per Group";
			this.SelectGroup.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			this.SelectGroup.CheckedChanged += new System.EventHandler(this.SelectGroup_CheckedChanged);
			// 
			// SelectEveryone
			// 
			this.SelectEveryone.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.SelectEveryone.Location = new System.Drawing.Point(24, 280);
			this.SelectEveryone.Name = "SelectEveryone";
			this.SelectEveryone.TabIndex = 17;
			this.SelectEveryone.Text = "Everyone";
			this.SelectEveryone.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			this.SelectEveryone.CheckedChanged += new System.EventHandler(this.SelectEveryone_CheckedChanged);
			// 
			// EveryoneWarning
			// 
			this.EveryoneWarning.Image = ((System.Drawing.Image)(resources.GetObject("EveryoneWarning.Image")));
			this.EveryoneWarning.Location = new System.Drawing.Point(128, 280);
			this.EveryoneWarning.Name = "EveryoneWarning";
			this.EveryoneWarning.Size = new System.Drawing.Size(16, 16);
			this.EveryoneWarning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.EveryoneWarning.TabIndex = 3;
			this.EveryoneWarning.TabStop = false;
			this.toolTip1.SetToolTip(this.EveryoneWarning, "Warning - Beware of unsafe for work picture if choosing this category");
			this.EveryoneWarning.Visible = false;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.FillScreen);
			this.tabPage2.Controls.Add(this.label1);
			this.tabPage2.Controls.Add(this.Drawer);
			this.tabPage2.Controls.Add(this.panel1);
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Controls.Add(this.label6);
			this.tabPage2.Controls.Add(this.DelayTime);
			this.tabPage2.Controls.Add(this.ImageSize);
			this.tabPage2.Controls.Add(this.label7);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(392, 390);
			this.tabPage2.TabIndex = 2;
			this.tabPage2.Text = "Options";
			// 
			// FillScreen
			// 
			this.FillScreen.Location = new System.Drawing.Point(256, 48);
			this.FillScreen.Name = "FillScreen";
			this.FillScreen.TabIndex = 21;
			this.FillScreen.Text = "Fill Screen?";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 80);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 16);
			this.label1.TabIndex = 20;
			this.label1.Text = "Drawing Method:";
			// 
			// Drawer
			// 
			this.Drawer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Drawer.Location = new System.Drawing.Point(144, 80);
			this.Drawer.Name = "Drawer";
			this.Drawer.Size = new System.Drawing.Size(104, 21);
			this.Drawer.TabIndex = 19;
			this.Drawer.SelectedIndexChanged += new System.EventHandler(this.Drawer_SelectedIndexChanged);
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(8, 104);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(352, 224);
			this.panel1.TabIndex = 18;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label5.Location = new System.Drawing.Point(16, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(128, 16);
			this.label5.TabIndex = 13;
			this.label5.Text = "Delay between photos:";
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label6.Location = new System.Drawing.Point(208, 16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(56, 16);
			this.label6.TabIndex = 1;
			this.label6.Text = "minutes";
			// 
			// DelayTime
			// 
			this.DelayTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.DelayTime.DecimalPlaces = 2;
			this.DelayTime.Increment = new System.Decimal(new int[] {
																		25,
																		0,
																		0,
																		131072});
			this.DelayTime.Location = new System.Drawing.Point(144, 16);
			this.DelayTime.Maximum = new System.Decimal(new int[] {
																	  60,
																	  0,
																	  0,
																	  0});
			this.DelayTime.Minimum = new System.Decimal(new int[] {
																	  25,
																	  0,
																	  0,
																	  131072});
			this.DelayTime.Name = "DelayTime";
			this.DelayTime.Size = new System.Drawing.Size(56, 20);
			this.DelayTime.TabIndex = 14;
			this.DelayTime.Value = new System.Decimal(new int[] {
																	1,
																	0,
																	0,
																	0});
			// 
			// ImageSize
			// 
			this.ImageSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ImageSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ImageSize.Items.AddRange(new object[] {
														   "Small",
														   "Medium",
														   "Large"});
			this.ImageSize.Location = new System.Drawing.Point(144, 48);
			this.ImageSize.Name = "ImageSize";
			this.ImageSize.Size = new System.Drawing.Size(88, 20);
			this.ImageSize.TabIndex = 17;
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label7.Location = new System.Drawing.Point(16, 48);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(128, 16);
			this.label7.TabIndex = 16;
			this.label7.Text = "Image Size:";
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.label9);
			this.tabPage4.Controls.Add(this.AuthRemoveButton);
			this.tabPage4.Controls.Add(this.AuthTokenLabel);
			this.tabPage4.Controls.Add(this.AuthCompleteButton);
			this.tabPage4.Controls.Add(this.AuthButton);
			this.tabPage4.Controls.Add(this.label8);
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(392, 390);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Authentication";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.Location = new System.Drawing.Point(48, 16);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(288, 32);
			this.label9.TabIndex = 5;
			this.label9.Text = "Authentication is only required to view private photos, or those in private group" +
				"s.";
			// 
			// AuthRemoveButton
			// 
			this.AuthRemoveButton.Location = new System.Drawing.Point(48, 288);
			this.AuthRemoveButton.Name = "AuthRemoveButton";
			this.AuthRemoveButton.Size = new System.Drawing.Size(288, 24);
			this.AuthRemoveButton.TabIndex = 4;
			this.AuthRemoveButton.Text = "Remove Authentication";
			this.AuthRemoveButton.Click += new System.EventHandler(this.AuthRemoveButton_Click);
			// 
			// AuthTokenLabel
			// 
			this.AuthTokenLabel.Location = new System.Drawing.Point(56, 256);
			this.AuthTokenLabel.Name = "AuthTokenLabel";
			this.AuthTokenLabel.Size = new System.Drawing.Size(280, 32);
			this.AuthTokenLabel.TabIndex = 3;
			this.AuthTokenLabel.Text = "We currently have a token stored. If it does not appear to be working then feel f" +
				"ree to reauthenticate.";
			// 
			// AuthCompleteButton
			// 
			this.AuthCompleteButton.Enabled = false;
			this.AuthCompleteButton.Location = new System.Drawing.Point(52, 183);
			this.AuthCompleteButton.Name = "AuthCompleteButton";
			this.AuthCompleteButton.Size = new System.Drawing.Size(288, 24);
			this.AuthCompleteButton.TabIndex = 2;
			this.AuthCompleteButton.Text = "Complete Authentication";
			this.AuthCompleteButton.Click += new System.EventHandler(this.AuthCompleteButton_Click);
			// 
			// AuthButton
			// 
			this.AuthButton.Location = new System.Drawing.Point(48, 152);
			this.AuthButton.Name = "AuthButton";
			this.AuthButton.Size = new System.Drawing.Size(288, 24);
			this.AuthButton.TabIndex = 1;
			this.AuthButton.Text = "Authenticate";
			this.AuthButton.Click += new System.EventHandler(this.AuthButton_Click);
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(48, 72);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(288, 80);
			this.label8.TabIndex = 0;
			this.label8.Text = @"Click below to Authentication. Once you click the button the Flickr web site will be loaded and you will be asked to authenticate the Flickr Screensaver for read only access. Once you have successfully completed this task then return to this window and click on the Complete button.";
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.RecentPhotosLabel);
			this.tabPage3.Controls.Add(this.RecentPhotosList);
			this.tabPage3.Controls.Add(this.label10);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(392, 390);
			this.tabPage3.TabIndex = 4;
			this.tabPage3.Text = "Recent Photos";
			// 
			// RecentPhotosLabel
			// 
			this.RecentPhotosLabel.BackColor = System.Drawing.SystemColors.Window;
			this.RecentPhotosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.RecentPhotosLabel.Location = new System.Drawing.Point(96, 104);
			this.RecentPhotosLabel.Name = "RecentPhotosLabel";
			this.RecentPhotosLabel.Size = new System.Drawing.Size(200, 88);
			this.RecentPhotosLabel.TabIndex = 2;
			this.RecentPhotosLabel.Text = "Currently Loading....";
			this.RecentPhotosLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// RecentPhotosList
			// 
			this.RecentPhotosList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																							   this.columnHeader1,
																							   this.columnHeader2,
																							   this.columnHeader3});
			this.RecentPhotosList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.RecentPhotosList.HoverSelection = true;
			this.RecentPhotosList.LargeImageList = this.RecentPhotosImages;
			this.RecentPhotosList.Location = new System.Drawing.Point(0, 0);
			this.RecentPhotosList.Name = "RecentPhotosList";
			this.RecentPhotosList.Size = new System.Drawing.Size(392, 366);
			this.RecentPhotosList.SmallImageList = this.RecentPhotosImages;
			this.RecentPhotosList.TabIndex = 0;
			this.RecentPhotosList.DoubleClick += new System.EventHandler(this.RecentPhotosList_DoubleClick);
			this.RecentPhotosList.SelectedIndexChanged += new System.EventHandler(this.RecentPhotosList_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Title";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Author";
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Url";
			// 
			// RecentPhotosImages
			// 
			this.RecentPhotosImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.RecentPhotosImages.ImageSize = new System.Drawing.Size(100, 100);
			this.RecentPhotosImages.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// label10
			// 
			this.label10.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label10.Location = new System.Drawing.Point(0, 366);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(392, 24);
			this.label10.TabIndex = 1;
			this.label10.Text = "Double click to load picture in browser";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tabPage5
			// 
			this.tabPage5.Controls.Add(this.ProxyPanel);
			this.tabPage5.Controls.Add(this.ProxyDefined);
			this.tabPage5.Location = new System.Drawing.Point(4, 22);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Size = new System.Drawing.Size(392, 390);
			this.tabPage5.TabIndex = 5;
			this.tabPage5.Text = "Proxy";
			// 
			// ProxyPanel
			// 
			this.ProxyPanel.Controls.Add(this.ProxyDomain);
			this.ProxyPanel.Controls.Add(this.ProxyPassword);
			this.ProxyPanel.Controls.Add(this.ProxyUsername);
			this.ProxyPanel.Controls.Add(this.ProxyPort);
			this.ProxyPanel.Controls.Add(this.ProxyIPAddress);
			this.ProxyPanel.Controls.Add(this.label16);
			this.ProxyPanel.Controls.Add(this.label13);
			this.ProxyPanel.Controls.Add(this.label14);
			this.ProxyPanel.Controls.Add(this.label12);
			this.ProxyPanel.Controls.Add(this.label11);
			this.ProxyPanel.Location = new System.Drawing.Point(8, 56);
			this.ProxyPanel.Name = "ProxyPanel";
			this.ProxyPanel.Size = new System.Drawing.Size(264, 152);
			this.ProxyPanel.TabIndex = 1;
			// 
			// ProxyDomain
			// 
			this.ProxyDomain.Location = new System.Drawing.Point(80, 112);
			this.ProxyDomain.Name = "ProxyDomain";
			this.ProxyDomain.TabIndex = 9;
			this.ProxyDomain.Text = "";
			// 
			// ProxyPassword
			// 
			this.ProxyPassword.Location = new System.Drawing.Point(80, 88);
			this.ProxyPassword.Name = "ProxyPassword";
			this.ProxyPassword.PasswordChar = '*';
			this.ProxyPassword.TabIndex = 8;
			this.ProxyPassword.Text = "";
			// 
			// ProxyUsername
			// 
			this.ProxyUsername.Location = new System.Drawing.Point(80, 64);
			this.ProxyUsername.Name = "ProxyUsername";
			this.ProxyUsername.TabIndex = 7;
			this.ProxyUsername.Text = "";
			// 
			// ProxyPort
			// 
			this.ProxyPort.Location = new System.Drawing.Point(192, 16);
			this.ProxyPort.Name = "ProxyPort";
			this.ProxyPort.Size = new System.Drawing.Size(48, 20);
			this.ProxyPort.TabIndex = 6;
			this.ProxyPort.Text = "";
			// 
			// ProxyIPAddress
			// 
			this.ProxyIPAddress.Location = new System.Drawing.Point(80, 16);
			this.ProxyIPAddress.Name = "ProxyIPAddress";
			this.ProxyIPAddress.TabIndex = 5;
			this.ProxyIPAddress.Text = "";
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(8, 112);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(72, 16);
			this.label16.TabIndex = 4;
			this.label16.Text = "Domain:";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(8, 88);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(72, 16);
			this.label13.TabIndex = 3;
			this.label13.Text = "Password:";
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(8, 64);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(72, 16);
			this.label14.TabIndex = 2;
			this.label14.Text = "Username:";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(184, 16);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(8, 16);
			this.label12.TabIndex = 1;
			this.label12.Text = ":";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(8, 16);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(72, 16);
			this.label11.TabIndex = 0;
			this.label11.Text = "IP Address:";
			// 
			// ProxyDefined
			// 
			this.ProxyDefined.Location = new System.Drawing.Point(8, 16);
			this.ProxyDefined.Name = "ProxyDefined";
			this.ProxyDefined.Size = new System.Drawing.Size(272, 24);
			this.ProxyDefined.TabIndex = 0;
			this.ProxyDefined.Text = "Define Proxy (if unchecked it will use IE defaults)";
			this.ProxyDefined.CheckedChanged += new System.EventHandler(this.ProxyDefined_CheckedChanged);
			// 
			// AboutButton
			// 
			this.AboutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.AboutButton.Location = new System.Drawing.Point(8, 432);
			this.AboutButton.Name = "AboutButton";
			this.AboutButton.Size = new System.Drawing.Size(56, 24);
			this.AboutButton.TabIndex = 18;
			this.AboutButton.Text = "About";
			this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
			// 
			// FConfigure
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(402, 464);
			this.Controls.Add(this.AboutButton);
			this.Controls.Add(this.TabControl);
			this.Controls.Add(this.BtnCancel);
			this.Controls.Add(this.BtnOK);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "FConfigure";
			this.Text = "Configure Flickr Screensaver";
			this.Load += new System.EventHandler(this.FConfigure_Load);
			this.TabControl.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.GroupWhat.ResumeLayout(false);
			this.EveryoneWhat.ResumeLayout(false);
			this.UserWhat.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DelayTime)).EndInit();
			this.tabPage4.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.tabPage5.ResumeLayout(false);
			this.ProxyPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void FConfigure_Load(object sender, System.EventArgs e)
		{
			string showWhat = "User";

			if( Settings.Get("ShowWhat") != null ) showWhat = Settings.Get("ShowWhat");

			LoadAuth();

			switch(showWhat)
			{
				case "Everyone":
					TabControl.SelectedIndex = 2;
					LoadEveryone();
					break;
				case "Group":
					TabControl.SelectedIndex = 1;
					LoadGroup();
					break;
				case "User":
				default:
					LoadUser();
					break;
			}

			LoadProxy();

			if( Settings.Contains("DelayTime") )
			{
				try
				{
					DelayTime.Value = decimal.Parse(Settings.Get("DelayTime"));
				}
				catch(FormatException) {}
			}

			if( Settings.Contains("FillScreen") )
			{
				FillScreen.Checked = bool.Parse(Settings.Get("FillScreen"));
			}

			if( Settings.Contains("ImageSize") )
			{
				string size = Settings.Get("ImageSize");
				int i = ImageSize.FindStringExact(size);
				if( i >= 0 ) ImageSize.SelectedIndex = i;
			}
			else
			{
				ImageSize.SelectedIndex = 1;
			}

			Drawer.Items.AddRange(DrawerFactory.GetNames());
			Drawer.SelectedIndex = 0;

			if( Settings.Contains("Drawer") )
			{
				Drawer.SelectedItem = Settings.Get("Drawer");
			}

			DrawOptions.AbstractOptions options = DrawerFactory.GetOptionsControl(Drawer.SelectedItem.ToString());
			panel1.Controls.Clear();
			panel1.Controls.Add(options);
			options.LoadSettings();

		}

		private void LoadProxy()
		{
			bool bUseProxy = false;
			if( Settings.Contains("UseProxy") )
			{
				bUseProxy = bool.Parse(Settings.Get("UseProxy"));
			}

			ProxyDefined.Checked = bUseProxy;
			ProxyPanel.Enabled = bUseProxy;

			if( !bUseProxy ) return;

			ProxyIPAddress.Text = Settings.Get("ProxyIPAddress");
			ProxyPort.Text = Settings.Get("ProxyPort");
			ProxyUsername.Text = Settings.Get("ProxyUsername");
			ProxyPassword.Text = Settings.Get("ProxyPassword");
			ProxyDomain.Text = Settings.Get("ProxyDomain");
		}

		private void LoadAuth()
		{
			Token = Settings.Get("AuthToken");
			if( Token != null && Token.Length > 0 )
			{
				AuthTokenLabel.Visible = true;
				AuthRemoveButton.Visible = true;
			}
			else
			{
				AuthTokenLabel.Visible = false;
				AuthRemoveButton.Visible = false;
			}
		}

		private void LoadUser()
		{
			TabControl.SelectedIndex = 0;
			if( Settings.Contains("UserName") ) UserName.Text = Settings.Get("UserName");
			
			string type = Settings.Get("UserType");
			switch(type)
			{
				case "Set":
					UserSet.Checked = true;
					UserSetName.Text = Settings.Get("UserSet");
					break;
				case "Tag":
					UserTag.Checked = true;
					UserTagName.Text = Settings.Get("UserTag");
					break;
				case "Fav":
					UserFav.Checked = true;
					break;
				case "Contacts":
					UserContacts.Checked = true;
					break;
				case "All":
				default:
					UserAll.Checked = true;
					break;
			}
		}

		private void LoadGroup()
		{
			TabControl.SelectedIndex = 1;
			GroupName.Text = Settings.Get("GroupName");
		}

		private void LoadEveryone()
		{
			TabControl.SelectedIndex = 2;
			
			string type = Settings.Get("EveryoneType");
			switch(type)
			{
				case "Tag":
					EveryoneTag.Checked = true;
					EveryoneTagText.Text = Settings.Get("EveryoneTag");
					break;
				case "Recent":
				default:
					EveryoneRecent.Checked = true;
					break;
			}
		}

		private void BtnOK_Click(object sender, System.EventArgs e)
		{
			if( !CheckProxy() ) return;
			Settings.SaveSettings();

			if( !CheckAuth() ) return;

			try
			{
				if( SelectUser.Checked )
				{
					if( !CheckUsername() ) return;
				}
				if( SelectGroup.Checked )
				{
					if( !CheckGroup() ) return;
				}
				if( SelectEveryone.Checked )
				{
					if( !CheckEveryone() ) return;
				}
			}
			catch(FlickrException ex)
			{
				DialogResult res = MessageBox.Show("A problem occurred with Flickr and your settings could not be verified (" + ex.Message + ")\r\nDo you wish to save your settings anyway?", "Problem saving settings", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if( res == DialogResult.No ) return;
			}
			catch(System.Net.WebException ex)
			{
				DialogResult res = MessageBox.Show("A problem occurred with Flickr and your settings could not be verified (" + ex.Message + ")\r\nDo you wish to save your settings anyway?", "Problem saving settings", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if( res == DialogResult.No ) return;
			}

			Settings.Set("DelayTime", DelayTime.Value.ToString("0.00"));
			Settings.Set("ImageSize", ImageSize.SelectedItem.ToString());
			Settings.Set("FillScreen", FillScreen.Checked.ToString());

			Settings.Set("Drawer", Drawer.SelectedItem.ToString());
			DrawOptions.AbstractOptions options = (DrawOptions.AbstractOptions)panel1.Controls[0];
			options.SaveSettings();

			Settings.SaveSettings();

			Flickr flickr = FlickrFactory.GetInstance();

			Close();
		}

		private bool CheckProxy()
		{
			if( !ProxyDefined.Checked)
			{
				Settings.Set("UseProxy", "False");
				return true;
			}

			System.Net.WebProxy proxy = new System.Net.WebProxy();
			proxy.Address = new Uri("http://" + ProxyIPAddress.Text + ":" + ProxyPort.Text);

			if( ProxyUsername.Text.Length > 0 )
			{
				System.Net.NetworkCredential creds = new System.Net.NetworkCredential();
				creds.UserName = ProxyUsername.Text;
				creds.Password = ProxyPassword.Text;
				if( ProxyDomain.Text.Length > 0 ) creds.Domain = ProxyDomain.Text;
				proxy.Credentials = creds;
			}

			System.Net.HttpWebRequest req = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create("http://www.flickr.com");
			try
			{
				req.Proxy = proxy;
				req.GetResponse();
			}
			catch(Exception ex)
			{
				MessageBox.Show("Unable to connect through proxy to the Flickr web site: " + ex.Message);
				return false;
			}

			Settings.Set("UseProxy", "True");
			Settings.Set("ProxyIPAddress", ProxyIPAddress.Text);
			Settings.Set("ProxyPort", ProxyPort.Text);
			Settings.Set("ProxyUsername", ProxyUsername.Text);
			Settings.Set("ProxyPassword", ProxyPassword.Text);
			Settings.Set("ProxyDomain", ProxyDomain.Text);

			return true;
		}


		private bool CheckAuth()
		{
			if( Token == null || Token.Length == 0 ) 
			{
				Settings.Remove("AuthToken");
				Settings.SaveSettings();
				return true;
			}

			Flickr flickr = FlickrFactory.GetInstance();
			try
			{
				Auth auth = flickr.AuthCheckToken(Token);
				Settings.Set("AuthToken", Token);
				Settings.SaveSettings();
				return true;
			}
			catch(FlickrException)
			{
				MessageBox.Show("The authentication failed. Either reauthenticate or remove authentication.");
				return false;
			}
		}

		private bool CheckUsername()
		{
			Flickr flickr = FlickrFactory.GetInstance();

			FoundUser u = null;

			// Check user exists
			try
			{
				u = flickr.PeopleFindByUsername(UserName.Text);
			}
			catch(FlickrException ex)
			{
				if( ex.Code == 1 )
				{
					MessageBox.Show("Unable to find user: " + ex.Message);
					return false;
				}
				else
				{
					throw ex;
				}
			}

			// Check tag or set.

			if( UserAll.Checked )
			{
				Settings.Add("ShowWhat", "User");
				Settings.Add("UserName", UserName.Text);
				Settings.Add("UserType", "All");
				return true;
			}

			// Check set name
			if( UserSet.Checked )
			{
				Photosets psets = flickr.PhotosetsGetList(u.UserId);
				if( psets.PhotosetCollection == null )
				{
					MessageBox.Show("The user does not have any sets.");
					return false;
				}

				bool bFound = false;
				foreach(Photoset pset in psets.PhotosetCollection)
				{
					if( pset.Title == UserSetName.Text )
					{
						bFound = true;
						Settings.Add("UserSet", UserSetName.Text);
						Settings.Add("UserSetId", pset.PhotosetId.ToString());
						break;
					}
				}
				if( !bFound )
				{
					MessageBox.Show("Set name not found.");
					return false;
				}

				Settings.Add("ShowWhat", "User");
				Settings.Add("UserName", UserName.Text);
				Settings.Add("UserType", "Set");

				return true;
			}

			if( UserTag.Checked )
			{

				PhotoSearchOptions o = new PhotoSearchOptions();
				o.UserId = u.UserId;
				o.Tags = UserTagName.Text;
				o.PerPage = 1;

				Photos taggedPhotos = flickr.PhotosSearch(o);
				if( taggedPhotos.TotalPhotos < 10 )
				{
					MessageBox.Show("Unable to find the tag/s in the users photos.");
					return false;
				}

				Settings.Add("ShowWhat", "User");
				Settings.Add("UserName", UserName.Text);
				Settings.Add("UserType", "Tag");
				Settings.Add("UserTag", UserTagName.Text);

				return true;
			}

			if( UserFav.Checked ) 
			{
				Photos photos = flickr.FavoritesGetPublicList(u.UserId);
				if( photos.TotalPhotos == 0 )
				{
					MessageBox.Show("This user does not have any public favorites");
					return false;
				}

				Settings.Add("ShowWhat", "User");
				Settings.Add("UserName", UserName.Text);
				Settings.Add("UserType", "Fav");

				return true;
			}

			if( UserContacts.Checked ) 
			{
				Photos photos = null;
				if( flickr.IsAuthenticated )
				{
					Auth auth = flickr.AuthCheckToken("");
					if( auth.User.UserId == u.UserId )
					{
						// show own contacts
						Settings.Add("UserContacts", "Own");
						photos = flickr.PhotosGetContactsPhotos(10, false, false, false);
					}
					else
					{
						Settings.Add("UserContacts", "Others");
						photos = flickr.PhotosGetContactsPublicPhotos(u.UserId, 10, false, false, false);
					}
				}
				else
				{
					Settings.Add("UserContacts", "Others");
					photos = flickr.PhotosGetContactsPublicPhotos(u.UserId, 10, false, false, false);
				}

				if( photos.PhotoCollection.Length == 0 )
				{
					MessageBox.Show("This user does not have any contacts with photos");
					return false;
				}

				Settings.Add("ShowWhat", "User");
				Settings.Add("UserName", UserName.Text);
				Settings.Add("UserType", "Contacts");

				return true;
			}

			return false;

		}

		private bool CheckGroup()
		{
			Flickr flickr = FlickrFactory.GetInstance();
			
			try
			{
				string groupId = flickr.UrlsLookupGroup("http://www.flickr.com/groups/" + GroupName.Text);

				if( groupId != null )
				{
					Settings.Add("ShowWhat", "Group");
					Settings.Add("GroupName", GroupName.Text);

					return true;
				}
				else
				{
					MessageBox.Show("Unable to find group - please enter end of the url");
					return false;
				}
			}
			catch(FlickrException ex)
			{
				MessageBox.Show("Unable to find group - please enter end of the url: " + ex.Message);
				return false;
			}
		}

		private bool CheckEveryone()
		{
			Flickr flickr = FlickrFactory.GetInstance();
			
			if( EveryoneRecent.Checked )
			{
				Settings.Add("ShowWhat", "Everyone");
				Settings.Add("EveryoneType", "Recent");

				return true;
			}

			if( EveryoneTag.Checked )
			{
				Photos photos = flickr.PhotosSearch(EveryoneTagText.Text, TagMode.AllTags, null);
				if( photos.TotalPhotos == 0 )
				{
					MessageBox.Show("The tags did not return any photographs. Please check the tag you entered");
					return false;
				}

				Settings.Add("ShowWhat", "Everyone");
				Settings.Add("EveryoneType", "Tag");
				Settings.Add("EveryoneTag", EveryoneTagText.Text);

				return true;
			}

			return false;
		}

		private void BtnCancel_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("http://www.flickr.com");
		}

		private void UserSet_CheckedChanged(object sender, System.EventArgs e)
		{
			UserSetName.Enabled = UserSet.Checked;
		}

		private void UserTag_CheckedChanged(object sender, System.EventArgs e)
		{
			UserTagName.Enabled = UserTag.Checked;
		}

		private void EveryoneTag_CheckedChanged(object sender, System.EventArgs e)
		{
			EveryoneTagText.Enabled = EveryoneTag.Checked;
		}

		private void AboutButton_Click(object sender, System.EventArgs e)
		{
			FAbout f = new FAbout();
			f.ShowDialog();
		}

		private void SelectEveryone_CheckedChanged(object sender, System.EventArgs e)
		{
			EveryoneWarning.Visible = SelectEveryone.Checked;
			EveryoneWhat.Enabled = SelectEveryone.Checked;
		}

		private void SelectGroup_CheckedChanged(object sender, System.EventArgs e)
		{
			GroupWhat.Enabled = SelectGroup.Checked;
		}

		private void SelectUser_CheckedChanged(object sender, System.EventArgs e)
		{
			UserWhat.Enabled = SelectUser.Checked;
		}

		private void Drawer_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			DrawOptions.AbstractOptions options = DrawerFactory.GetOptionsControl(Drawer.SelectedItem.ToString());
			panel1.Controls.Clear();
			panel1.Controls.Add(options);
			options.LoadSettings();
		}

		private void TabControl_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if( TabControl.SelectedTab.Text == "Recent Photos" )
				RefreshRecentPhotos();
		}

		bool refreshRunning = false;
		private void RefreshRecentPhotos()
		{
			if( refreshRunning ) return;
		
			refreshRunning = true;

			System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(DoRefreshRecentPhotos));
			thread.Start();
		}

		private void DoRefreshRecentPhotos()
		{
			RecentPhotosImages.Images.Clear();
			RecentPhotosList.Items.Clear();
			string photoIds = Settings.Get("RecentPhotos");
			if( photoIds == null || photoIds.Length == 0 ) 
			{
				RecentPhotosLabel.Text = "No recent photos to display.";
				RecentPhotosLabel.Visible = true;
				return;
			}

			string[] ids = photoIds.Split('|');

			Flickr f = FlickrFactory.GetInstance();

			foreach(string photoId in ids)
			{
				PhotoInfo info = f.PhotosGetInfo(photoId);
				string url = info.SquareThumbnailUrl;

				System.IO.Stream s = f.DownloadPicture(url);
				Image img = Image.FromStream(s);
				RecentPhotosImages.Images.Add(img);

				ListViewItem item = new ListViewItem(new string[] { info.Title, info.Owner.UserName, info.WebUrl }, RecentPhotosImages.Images.Count - 1);
				RecentPhotosList.Items.Add(item);
			}

			RecentPhotosLabel.Visible = false;

			refreshRunning = false;
		}

		private void RecentPhotosList_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if( RecentPhotosList.SelectedItems.Count == 0 )
			{
				toolTip1.SetToolTip(RecentPhotosList, "");
				return;
			}

			ListViewItem item = RecentPhotosList.SelectedItems[0];

			toolTip1.SetToolTip(RecentPhotosList, "by " + item.SubItems[1].Text);
		}

		private void RecentPhotosList_DoubleClick(object sender, System.EventArgs e)
		{
			ListViewItem item = RecentPhotosList.SelectedItems[0];

			try
			{
				System.Diagnostics.Process.Start(item.SubItems[2].Text);
			}
			catch(Exception ex)
			{
				MessageBox.Show("Unable to open URL : " + ex.Message);
			}
		}

		private void AuthButton_Click(object sender, System.EventArgs e)
		{
			Flickr f = FlickrFactory.GetInstance();
			TempFrob = f.AuthGetFrob();
			string url = f.AuthCalcUrl(TempFrob, AuthLevel.Read);

			AuthCompleteButton.Enabled = true;
			AuthButton.Enabled = false;

			System.Diagnostics.Process.Start(url);
		}

		private void AuthCompleteButton_Click(object sender, System.EventArgs e)
		{
			Flickr f = FlickrFactory.GetInstance();
			try
			{
				Auth auth = f.AuthGetToken(TempFrob);
				Token = auth.Token;
			}
			catch(FlickrException ex)
			{
				MessageBox.Show("Authentication failed! " + ex.Message);
				return;
			}

			AuthButton.Enabled = true;
			AuthCompleteButton.Enabled = false;
			AuthTokenLabel.Visible = true;
			AuthRemoveButton.Visible = true;

			MessageBox.Show("Authentication successful!");
		}

		private void AuthRemoveButton_Click(object sender, System.EventArgs e)
		{
			Token = null;

			MessageBox.Show("Authentication removed!");
			AuthRemoveButton.Visible = false;
			AuthTokenLabel.Visible = false;
		}

		private void ProxyDefined_CheckedChanged(object sender, System.EventArgs e)
		{
			ProxyPanel.Enabled = ProxyDefined.Checked;
		}
	}
}