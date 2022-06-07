﻿namespace OpenDental {
	using System;
	partial class FormMapHQ {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMapHQ));
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.comboRoom = new System.Windows.Forms.ComboBox();
			this.labelCurrentTime = new OpenDental.MapCubicle();
			this.labelTriageCoordinator = new System.Windows.Forms.Label();
			this.menuMain = new OpenDental.UI.MenuOD();
			this.userControlMapDetails1 = new OpenDental.InternalTools.Phones.UserControlMapDetails();
			this.labelCustDownTime = new OpenDental.MapCubicle();
			this.labelCustDownCount = new OpenDental.MapCubicle();
			this.labelTriageOpsCountTotal = new OpenDental.MapCubicle();
			this.escalationView = new OpenDental.EscalationViewControl();
			this.eServiceMetricsControl = new OpenDental.EServiceMetricsControl();
			this.label3 = new System.Windows.Forms.Label();
			this.labelTriageOpsCountLocal = new OpenDental.MapCubicle();
			this.groupPhoneMetrics = new OpenDental.UI.GroupBoxOD();
			this.labelChatTimeSpan = new OpenDental.MapCubicle();
			this.labelChatCount = new OpenDental.MapCubicle();
			this.label2 = new System.Windows.Forms.Label();
			this.labelTriageTimeSpan = new OpenDental.MapCubicle();
			this.labelTriageRedCalls = new OpenDental.MapCubicle();
			this.label1 = new System.Windows.Forms.Label();
			this.labelTriageRedTimeSpan = new OpenDental.MapCubicle();
			this.label4 = new System.Windows.Forms.Label();
			this.labelVoicemailTimeSpan = new OpenDental.MapCubicle();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.labelTriageCalls = new OpenDental.MapCubicle();
			this.labelVoicemailCalls = new OpenDental.MapCubicle();
			this.label6 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.tabMain = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.label7 = new System.Windows.Forms.Label();
			this.officesDownView = new OpenDental.EscalationViewControl();
			this.labelTirageOpTotal = new System.Windows.Forms.Label();
			this.labelTirageOpLocal = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.mapAreaPanel = new OpenDental.MapAreaPanel();
			this.timerWebCam = new System.Windows.Forms.Timer(this.components);
			this.groupPhoneMetrics.SuspendLayout();
			this.tabMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// timer1
			// 
			this.timer1.Interval = 250;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// comboRoom
			// 
			this.comboRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboRoom.ForeColor = System.Drawing.Color.Blue;
			this.comboRoom.ItemHeight = 40;
			this.comboRoom.Location = new System.Drawing.Point(0, 25);
			this.comboRoom.MaxDropDownItems = 30;
			this.comboRoom.Name = "comboRoom";
			this.comboRoom.Size = new System.Drawing.Size(359, 48);
			this.comboRoom.TabIndex = 70;
			this.comboRoom.SelectionChangeCommitted += new System.EventHandler(this.comboRoom_SelectionChangeCommitted);
			// 
			// labelCurrentTime
			// 
			this.labelCurrentTime.AllowDragging = false;
			this.labelCurrentTime.AllowEdit = false;
			this.labelCurrentTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelCurrentTime.BorderThickness = 2;
			this.labelCurrentTime.ChatImage = null;
			this.labelCurrentTime.Elapsed = System.TimeSpan.Parse("00:00:00");
			this.labelCurrentTime.EmployeeName = null;
			this.labelCurrentTime.EmployeeNum = ((long)(0));
			this.labelCurrentTime.Empty = false;
			this.labelCurrentTime.Extension = null;
			this.labelCurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F);
			this.labelCurrentTime.FontHeader = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCurrentTime.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelCurrentTime.InnerColor = System.Drawing.SystemColors.Control;
			this.labelCurrentTime.Location = new System.Drawing.Point(1692, 5);
			this.labelCurrentTime.Name = "labelCurrentTime";
			this.labelCurrentTime.OuterColor = System.Drawing.SystemColors.Control;
			this.labelCurrentTime.PhoneImage = null;
			this.labelCurrentTime.ProxImage = null;
			this.labelCurrentTime.RemoteSupportImage = null;
			this.labelCurrentTime.Size = new System.Drawing.Size(182, 61);
			this.labelCurrentTime.Status = null;
			this.labelCurrentTime.TabIndex = 66;
			this.labelCurrentTime.Text = "12:45 PM";
			this.labelCurrentTime.WebChatImage = null;
			// 
			// labelTriageCoordinator
			// 
			this.labelTriageCoordinator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelTriageCoordinator.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTriageCoordinator.Location = new System.Drawing.Point(406, 3);
			this.labelTriageCoordinator.Name = "labelTriageCoordinator";
			this.labelTriageCoordinator.Size = new System.Drawing.Size(1280, 72);
			this.labelTriageCoordinator.TabIndex = 65;
			this.labelTriageCoordinator.Text = "Call Center Map - Triage Coord - Jim Smith";
			this.labelTriageCoordinator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// menuMain
			// 
			this.menuMain.Location = new System.Drawing.Point(0, 0);
			this.menuMain.Name = "menuMain";
			this.menuMain.Size = new System.Drawing.Size(400, 24);
			this.menuMain.TabIndex = 71;
			// 
			// userControlMapDetails1
			// 
			this.userControlMapDetails1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.userControlMapDetails1.Location = new System.Drawing.Point(4, 656);
			this.userControlMapDetails1.Name = "userControlMapDetails1";
			this.userControlMapDetails1.Size = new System.Drawing.Size(358, 130);
			this.userControlMapDetails1.TabIndex = 1;
			// 
			// labelCustDownTime
			// 
			this.labelCustDownTime.AllowDragging = false;
			this.labelCustDownTime.AllowEdit = false;
			this.labelCustDownTime.BorderThickness = 1;
			this.labelCustDownTime.ChatImage = null;
			this.labelCustDownTime.Elapsed = System.TimeSpan.Parse("00:00:00");
			this.labelCustDownTime.EmployeeName = "";
			this.labelCustDownTime.EmployeeNum = ((long)(0));
			this.labelCustDownTime.Empty = false;
			this.labelCustDownTime.Extension = null;
			this.labelCustDownTime.Font = new System.Drawing.Font("Calibri", 40F);
			this.labelCustDownTime.FontHeader = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCustDownTime.InnerColor = System.Drawing.Color.LightCyan;
			this.labelCustDownTime.Location = new System.Drawing.Point(305, 918);
			this.labelCustDownTime.Name = "labelCustDownTime";
			this.labelCustDownTime.OuterColor = System.Drawing.Color.Blue;
			this.labelCustDownTime.PhoneImage = null;
			this.labelCustDownTime.ProxImage = null;
			this.labelCustDownTime.RemoteSupportImage = null;
			this.labelCustDownTime.Size = new System.Drawing.Size(57, 39);
			this.labelCustDownTime.Status = null;
			this.labelCustDownTime.TabIndex = 94;
			this.labelCustDownTime.Text = "0";
			this.labelCustDownTime.WebChatImage = null;
			// 
			// labelCustDownCount
			// 
			this.labelCustDownCount.AllowDragging = false;
			this.labelCustDownCount.AllowEdit = false;
			this.labelCustDownCount.BorderThickness = 1;
			this.labelCustDownCount.ChatImage = null;
			this.labelCustDownCount.Elapsed = System.TimeSpan.Parse("00:00:00");
			this.labelCustDownCount.EmployeeName = "";
			this.labelCustDownCount.EmployeeNum = ((long)(0));
			this.labelCustDownCount.Empty = false;
			this.labelCustDownCount.Extension = null;
			this.labelCustDownCount.Font = new System.Drawing.Font("Calibri", 40F);
			this.labelCustDownCount.FontHeader = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCustDownCount.InnerColor = System.Drawing.Color.LightCyan;
			this.labelCustDownCount.Location = new System.Drawing.Point(184, 918);
			this.labelCustDownCount.Name = "labelCustDownCount";
			this.labelCustDownCount.OuterColor = System.Drawing.Color.Blue;
			this.labelCustDownCount.PhoneImage = null;
			this.labelCustDownCount.ProxImage = null;
			this.labelCustDownCount.RemoteSupportImage = null;
			this.labelCustDownCount.Size = new System.Drawing.Size(57, 39);
			this.labelCustDownCount.Status = null;
			this.labelCustDownCount.TabIndex = 93;
			this.labelCustDownCount.Text = "0";
			this.labelCustDownCount.WebChatImage = null;
			// 
			// labelTriageOpsCountTotal
			// 
			this.labelTriageOpsCountTotal.AllowDragging = false;
			this.labelTriageOpsCountTotal.AllowEdit = false;
			this.labelTriageOpsCountTotal.BorderThickness = 1;
			this.labelTriageOpsCountTotal.ChatImage = null;
			this.labelTriageOpsCountTotal.Elapsed = System.TimeSpan.Parse("00:00:00");
			this.labelTriageOpsCountTotal.EmployeeName = "";
			this.labelTriageOpsCountTotal.EmployeeNum = ((long)(0));
			this.labelTriageOpsCountTotal.Empty = false;
			this.labelTriageOpsCountTotal.Extension = null;
			this.labelTriageOpsCountTotal.Font = new System.Drawing.Font("Calibri", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTriageOpsCountTotal.FontHeader = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTriageOpsCountTotal.InnerColor = System.Drawing.Color.LightCyan;
			this.labelTriageOpsCountTotal.Location = new System.Drawing.Point(305, 615);
			this.labelTriageOpsCountTotal.Name = "labelTriageOpsCountTotal";
			this.labelTriageOpsCountTotal.OuterColor = System.Drawing.Color.Blue;
			this.labelTriageOpsCountTotal.PhoneImage = null;
			this.labelTriageOpsCountTotal.ProxImage = null;
			this.labelTriageOpsCountTotal.RemoteSupportImage = null;
			this.labelTriageOpsCountTotal.Size = new System.Drawing.Size(57, 39);
			this.labelTriageOpsCountTotal.Status = null;
			this.labelTriageOpsCountTotal.TabIndex = 90;
			this.labelTriageOpsCountTotal.Text = "0";
			this.labelTriageOpsCountTotal.WebChatImage = null;
			// 
			// escalationView
			// 
			this.escalationView.BackColor = System.Drawing.Color.White;
			this.escalationView.BorderThickness = 1;
			this.escalationView.FadeAlphaIncrement = 20;
			this.escalationView.Font = new System.Drawing.Font("Calibri", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.escalationView.Items = ((System.ComponentModel.BindingList<string>)(resources.GetObject("escalationView.Items")));
			this.escalationView.LinePadding = -6;
			this.escalationView.Location = new System.Drawing.Point(58, 331);
			this.escalationView.MinAlpha = 60;
			this.escalationView.MinScrollable = 8;
			this.escalationView.Name = "escalationView";
			this.escalationView.OuterColor = System.Drawing.Color.Black;
			this.escalationView.Size = new System.Drawing.Size(304, 282);
			this.escalationView.StartFadeIndex = 0;
			this.escalationView.TabIndex = 85;
			// 
			// eServiceMetricsControl
			// 
			this.eServiceMetricsControl.AccountBalance = 562F;
			this.eServiceMetricsControl.AlertColor = System.Drawing.Color.Blue;
			this.eServiceMetricsControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.eServiceMetricsControl.Location = new System.Drawing.Point(76, 959);
			this.eServiceMetricsControl.Name = "eServiceMetricsControl";
			this.eServiceMetricsControl.Size = new System.Drawing.Size(286, 62);
			this.eServiceMetricsControl.TabIndex = 88;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Calibri", 16F);
			this.label3.Location = new System.Drawing.Point(1, 924);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(116, 30);
			this.label3.TabIndex = 86;
			this.label3.Text = "Cust Down";
			// 
			// labelTriageOpsCountLocal
			// 
			this.labelTriageOpsCountLocal.AllowDragging = false;
			this.labelTriageOpsCountLocal.AllowEdit = false;
			this.labelTriageOpsCountLocal.BorderThickness = 1;
			this.labelTriageOpsCountLocal.ChatImage = null;
			this.labelTriageOpsCountLocal.Elapsed = System.TimeSpan.Parse("00:00:00");
			this.labelTriageOpsCountLocal.EmployeeName = "";
			this.labelTriageOpsCountLocal.EmployeeNum = ((long)(0));
			this.labelTriageOpsCountLocal.Empty = false;
			this.labelTriageOpsCountLocal.Extension = null;
			this.labelTriageOpsCountLocal.Font = new System.Drawing.Font("Calibri", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTriageOpsCountLocal.FontHeader = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTriageOpsCountLocal.InnerColor = System.Drawing.Color.LightCyan;
			this.labelTriageOpsCountLocal.Location = new System.Drawing.Point(184, 615);
			this.labelTriageOpsCountLocal.Name = "labelTriageOpsCountLocal";
			this.labelTriageOpsCountLocal.OuterColor = System.Drawing.Color.Blue;
			this.labelTriageOpsCountLocal.PhoneImage = null;
			this.labelTriageOpsCountLocal.ProxImage = null;
			this.labelTriageOpsCountLocal.RemoteSupportImage = null;
			this.labelTriageOpsCountLocal.Size = new System.Drawing.Size(57, 39);
			this.labelTriageOpsCountLocal.Status = null;
			this.labelTriageOpsCountLocal.TabIndex = 83;
			this.labelTriageOpsCountLocal.Text = "0";
			this.labelTriageOpsCountLocal.WebChatImage = null;
			// 
			// groupPhoneMetrics
			// 
			this.groupPhoneMetrics.Controls.Add(this.labelChatTimeSpan);
			this.groupPhoneMetrics.Controls.Add(this.labelChatCount);
			this.groupPhoneMetrics.Controls.Add(this.label2);
			this.groupPhoneMetrics.Controls.Add(this.labelTriageTimeSpan);
			this.groupPhoneMetrics.Controls.Add(this.labelTriageRedCalls);
			this.groupPhoneMetrics.Controls.Add(this.label1);
			this.groupPhoneMetrics.Controls.Add(this.labelTriageRedTimeSpan);
			this.groupPhoneMetrics.Controls.Add(this.label4);
			this.groupPhoneMetrics.Controls.Add(this.labelVoicemailTimeSpan);
			this.groupPhoneMetrics.Controls.Add(this.label11);
			this.groupPhoneMetrics.Controls.Add(this.label10);
			this.groupPhoneMetrics.Controls.Add(this.labelTriageCalls);
			this.groupPhoneMetrics.Controls.Add(this.labelVoicemailCalls);
			this.groupPhoneMetrics.Controls.Add(this.label6);
			this.groupPhoneMetrics.Location = new System.Drawing.Point(4, 79);
			this.groupPhoneMetrics.Name = "groupPhoneMetrics";
			this.groupPhoneMetrics.Size = new System.Drawing.Size(357, 251);
			this.groupPhoneMetrics.TabIndex = 82;
			// 
			// labelChatTimeSpan
			// 
			this.labelChatTimeSpan.AllowDragging = false;
			this.labelChatTimeSpan.AllowEdit = false;
			this.labelChatTimeSpan.BorderThickness = 1;
			this.labelChatTimeSpan.ChatImage = null;
			this.labelChatTimeSpan.Elapsed = System.TimeSpan.Parse("00:00:00");
			this.labelChatTimeSpan.EmployeeName = null;
			this.labelChatTimeSpan.EmployeeNum = ((long)(0));
			this.labelChatTimeSpan.Empty = false;
			this.labelChatTimeSpan.Extension = null;
			this.labelChatTimeSpan.Font = new System.Drawing.Font("Calibri", 40F);
			this.labelChatTimeSpan.FontHeader = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelChatTimeSpan.InnerColor = System.Drawing.Color.White;
			this.labelChatTimeSpan.Location = new System.Drawing.Point(206, 140);
			this.labelChatTimeSpan.Name = "labelChatTimeSpan";
			this.labelChatTimeSpan.OuterColor = System.Drawing.Color.Black;
			this.labelChatTimeSpan.PhoneImage = null;
			this.labelChatTimeSpan.ProxImage = null;
			this.labelChatTimeSpan.RemoteSupportImage = null;
			this.labelChatTimeSpan.Size = new System.Drawing.Size(120, 44);
			this.labelChatTimeSpan.Status = null;
			this.labelChatTimeSpan.TabIndex = 36;
			this.labelChatTimeSpan.Text = "00:00";
			this.labelChatTimeSpan.WebChatImage = null;
			// 
			// labelChatCount
			// 
			this.labelChatCount.AllowDragging = false;
			this.labelChatCount.AllowEdit = false;
			this.labelChatCount.BackColor = System.Drawing.Color.White;
			this.labelChatCount.BorderThickness = 1;
			this.labelChatCount.ChatImage = null;
			this.labelChatCount.Elapsed = System.TimeSpan.Parse("00:00:00");
			this.labelChatCount.EmployeeName = "";
			this.labelChatCount.EmployeeNum = ((long)(0));
			this.labelChatCount.Empty = false;
			this.labelChatCount.Extension = null;
			this.labelChatCount.Font = new System.Drawing.Font("Calibri", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelChatCount.FontHeader = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelChatCount.InnerColor = System.Drawing.Color.White;
			this.labelChatCount.Location = new System.Drawing.Point(105, 140);
			this.labelChatCount.Name = "labelChatCount";
			this.labelChatCount.OuterColor = System.Drawing.Color.Black;
			this.labelChatCount.PhoneImage = null;
			this.labelChatCount.ProxImage = null;
			this.labelChatCount.RemoteSupportImage = null;
			this.labelChatCount.Size = new System.Drawing.Size(81, 44);
			this.labelChatCount.Status = null;
			this.labelChatCount.TabIndex = 35;
			this.labelChatCount.Text = "0";
			this.labelChatCount.WebChatImage = null;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 22F);
			this.label2.Location = new System.Drawing.Point(6, 141);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 37);
			this.label2.TabIndex = 34;
			this.label2.Text = "Chat";
			// 
			// labelTriageTimeSpan
			// 
			this.labelTriageTimeSpan.AllowDragging = false;
			this.labelTriageTimeSpan.AllowEdit = false;
			this.labelTriageTimeSpan.BorderThickness = 1;
			this.labelTriageTimeSpan.ChatImage = null;
			this.labelTriageTimeSpan.Elapsed = System.TimeSpan.Parse("00:00:00");
			this.labelTriageTimeSpan.EmployeeName = null;
			this.labelTriageTimeSpan.EmployeeNum = ((long)(0));
			this.labelTriageTimeSpan.Empty = false;
			this.labelTriageTimeSpan.Extension = null;
			this.labelTriageTimeSpan.Font = new System.Drawing.Font("Calibri", 56F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTriageTimeSpan.FontHeader = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTriageTimeSpan.InnerColor = System.Drawing.Color.White;
			this.labelTriageTimeSpan.Location = new System.Drawing.Point(206, 187);
			this.labelTriageTimeSpan.Name = "labelTriageTimeSpan";
			this.labelTriageTimeSpan.OuterColor = System.Drawing.Color.Black;
			this.labelTriageTimeSpan.PhoneImage = null;
			this.labelTriageTimeSpan.ProxImage = null;
			this.labelTriageTimeSpan.RemoteSupportImage = null;
			this.labelTriageTimeSpan.Size = new System.Drawing.Size(120, 58);
			this.labelTriageTimeSpan.Status = null;
			this.labelTriageTimeSpan.TabIndex = 33;
			this.labelTriageTimeSpan.Text = "0000";
			this.labelTriageTimeSpan.WebChatImage = null;
			// 
			// labelTriageRedCalls
			// 
			this.labelTriageRedCalls.AllowDragging = false;
			this.labelTriageRedCalls.AllowEdit = false;
			this.labelTriageRedCalls.BackColor = System.Drawing.Color.White;
			this.labelTriageRedCalls.BorderThickness = 1;
			this.labelTriageRedCalls.ChatImage = null;
			this.labelTriageRedCalls.Elapsed = System.TimeSpan.Parse("00:00:00");
			this.labelTriageRedCalls.EmployeeName = "";
			this.labelTriageRedCalls.EmployeeNum = ((long)(0));
			this.labelTriageRedCalls.Empty = false;
			this.labelTriageRedCalls.Extension = null;
			this.labelTriageRedCalls.Font = new System.Drawing.Font("Calibri", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTriageRedCalls.FontHeader = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTriageRedCalls.InnerColor = System.Drawing.Color.White;
			this.labelTriageRedCalls.Location = new System.Drawing.Point(105, 48);
			this.labelTriageRedCalls.Name = "labelTriageRedCalls";
			this.labelTriageRedCalls.OuterColor = System.Drawing.Color.Black;
			this.labelTriageRedCalls.PhoneImage = null;
			this.labelTriageRedCalls.ProxImage = null;
			this.labelTriageRedCalls.RemoteSupportImage = null;
			this.labelTriageRedCalls.Size = new System.Drawing.Size(81, 44);
			this.labelTriageRedCalls.Status = null;
			this.labelTriageRedCalls.TabIndex = 12;
			this.labelTriageRedCalls.Text = "0";
			this.labelTriageRedCalls.WebChatImage = null;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 22F);
			this.label1.Location = new System.Drawing.Point(6, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 37);
			this.label1.TabIndex = 6;
			this.label1.Text = "Red";
			// 
			// labelTriageRedTimeSpan
			// 
			this.labelTriageRedTimeSpan.AllowDragging = false;
			this.labelTriageRedTimeSpan.AllowEdit = false;
			this.labelTriageRedTimeSpan.BackColor = System.Drawing.Color.White;
			this.labelTriageRedTimeSpan.BorderThickness = 1;
			this.labelTriageRedTimeSpan.ChatImage = null;
			this.labelTriageRedTimeSpan.Elapsed = System.TimeSpan.Parse("00:00:00");
			this.labelTriageRedTimeSpan.EmployeeName = null;
			this.labelTriageRedTimeSpan.EmployeeNum = ((long)(0));
			this.labelTriageRedTimeSpan.Empty = false;
			this.labelTriageRedTimeSpan.Extension = null;
			this.labelTriageRedTimeSpan.Font = new System.Drawing.Font("Calibri", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTriageRedTimeSpan.FontHeader = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTriageRedTimeSpan.InnerColor = System.Drawing.Color.White;
			this.labelTriageRedTimeSpan.Location = new System.Drawing.Point(206, 48);
			this.labelTriageRedTimeSpan.Name = "labelTriageRedTimeSpan";
			this.labelTriageRedTimeSpan.OuterColor = System.Drawing.Color.Black;
			this.labelTriageRedTimeSpan.PhoneImage = null;
			this.labelTriageRedTimeSpan.ProxImage = null;
			this.labelTriageRedTimeSpan.RemoteSupportImage = null;
			this.labelTriageRedTimeSpan.Size = new System.Drawing.Size(120, 44);
			this.labelTriageRedTimeSpan.Status = null;
			this.labelTriageRedTimeSpan.TabIndex = 7;
			this.labelTriageRedTimeSpan.Text = "00:00";
			this.labelTriageRedTimeSpan.WebChatImage = null;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Calibri", 22F);
			this.label4.Location = new System.Drawing.Point(6, 94);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 37);
			this.label4.TabIndex = 8;
			this.label4.Text = "VM";
			// 
			// labelVoicemailTimeSpan
			// 
			this.labelVoicemailTimeSpan.AllowDragging = false;
			this.labelVoicemailTimeSpan.AllowEdit = false;
			this.labelVoicemailTimeSpan.BackColor = System.Drawing.Color.White;
			this.labelVoicemailTimeSpan.BorderThickness = 1;
			this.labelVoicemailTimeSpan.ChatImage = null;
			this.labelVoicemailTimeSpan.Elapsed = System.TimeSpan.Parse("00:00:00");
			this.labelVoicemailTimeSpan.EmployeeName = null;
			this.labelVoicemailTimeSpan.EmployeeNum = ((long)(0));
			this.labelVoicemailTimeSpan.Empty = false;
			this.labelVoicemailTimeSpan.Extension = null;
			this.labelVoicemailTimeSpan.Font = new System.Drawing.Font("Calibri", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelVoicemailTimeSpan.FontHeader = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelVoicemailTimeSpan.InnerColor = System.Drawing.Color.White;
			this.labelVoicemailTimeSpan.Location = new System.Drawing.Point(206, 94);
			this.labelVoicemailTimeSpan.Name = "labelVoicemailTimeSpan";
			this.labelVoicemailTimeSpan.OuterColor = System.Drawing.Color.Black;
			this.labelVoicemailTimeSpan.PhoneImage = null;
			this.labelVoicemailTimeSpan.ProxImage = null;
			this.labelVoicemailTimeSpan.RemoteSupportImage = null;
			this.labelVoicemailTimeSpan.Size = new System.Drawing.Size(120, 44);
			this.labelVoicemailTimeSpan.Status = null;
			this.labelVoicemailTimeSpan.TabIndex = 9;
			this.labelVoicemailTimeSpan.Text = "00:00";
			this.labelVoicemailTimeSpan.WebChatImage = null;
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Calibri", 24F);
			this.label11.Location = new System.Drawing.Point(224, 9);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(97, 36);
			this.label11.TabIndex = 16;
			this.label11.Text = "Time";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Calibri", 24F);
			this.label10.Location = new System.Drawing.Point(99, 9);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(105, 36);
			this.label10.TabIndex = 15;
			this.label10.Text = "# Calls";
			// 
			// labelTriageCalls
			// 
			this.labelTriageCalls.AllowDragging = false;
			this.labelTriageCalls.AllowEdit = false;
			this.labelTriageCalls.BackColor = System.Drawing.Color.White;
			this.labelTriageCalls.BorderThickness = 1;
			this.labelTriageCalls.ChatImage = null;
			this.labelTriageCalls.Elapsed = System.TimeSpan.Parse("00:00:00");
			this.labelTriageCalls.EmployeeName = "";
			this.labelTriageCalls.EmployeeNum = ((long)(0));
			this.labelTriageCalls.Empty = false;
			this.labelTriageCalls.Extension = null;
			this.labelTriageCalls.Font = new System.Drawing.Font("Calibri", 56F);
			this.labelTriageCalls.FontHeader = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTriageCalls.InnerColor = System.Drawing.Color.White;
			this.labelTriageCalls.Location = new System.Drawing.Point(104, 187);
			this.labelTriageCalls.Name = "labelTriageCalls";
			this.labelTriageCalls.OuterColor = System.Drawing.Color.Black;
			this.labelTriageCalls.PhoneImage = null;
			this.labelTriageCalls.ProxImage = null;
			this.labelTriageCalls.RemoteSupportImage = null;
			this.labelTriageCalls.Size = new System.Drawing.Size(82, 58);
			this.labelTriageCalls.Status = null;
			this.labelTriageCalls.TabIndex = 14;
			this.labelTriageCalls.Text = "0";
			this.labelTriageCalls.WebChatImage = null;
			// 
			// labelVoicemailCalls
			// 
			this.labelVoicemailCalls.AllowDragging = false;
			this.labelVoicemailCalls.AllowEdit = false;
			this.labelVoicemailCalls.BackColor = System.Drawing.Color.White;
			this.labelVoicemailCalls.BorderThickness = 1;
			this.labelVoicemailCalls.ChatImage = null;
			this.labelVoicemailCalls.Elapsed = System.TimeSpan.Parse("00:00:00");
			this.labelVoicemailCalls.EmployeeName = "";
			this.labelVoicemailCalls.EmployeeNum = ((long)(0));
			this.labelVoicemailCalls.Empty = false;
			this.labelVoicemailCalls.Extension = null;
			this.labelVoicemailCalls.Font = new System.Drawing.Font("Calibri", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelVoicemailCalls.FontHeader = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelVoicemailCalls.InnerColor = System.Drawing.Color.White;
			this.labelVoicemailCalls.Location = new System.Drawing.Point(105, 94);
			this.labelVoicemailCalls.Name = "labelVoicemailCalls";
			this.labelVoicemailCalls.OuterColor = System.Drawing.Color.Black;
			this.labelVoicemailCalls.PhoneImage = null;
			this.labelVoicemailCalls.ProxImage = null;
			this.labelVoicemailCalls.RemoteSupportImage = null;
			this.labelVoicemailCalls.Size = new System.Drawing.Size(81, 44);
			this.labelVoicemailCalls.Status = null;
			this.labelVoicemailCalls.TabIndex = 13;
			this.labelVoicemailCalls.Text = "0";
			this.labelVoicemailCalls.WebChatImage = null;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Calibri", 22F);
			this.label6.Location = new System.Drawing.Point(6, 187);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(90, 37);
			this.label6.TabIndex = 10;
			this.label6.Text = "Triage";
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Calibri", 16F);
			this.label14.Location = new System.Drawing.Point(1, 622);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(116, 32);
			this.label14.TabIndex = 81;
			this.label14.Text = "Triage Op#";
			// 
			// tabMain
			// 
			this.tabMain.Alignment = System.Windows.Forms.TabAlignment.Left;
			this.tabMain.Controls.Add(this.tabPage1);
			this.tabMain.Controls.Add(this.tabPage2);
			this.tabMain.Controls.Add(this.tabPage3);
			this.tabMain.Controls.Add(this.tabPage4);
			this.tabMain.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
			this.tabMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabMain.ItemSize = new System.Drawing.Size(28, 150);
			this.tabMain.Location = new System.Drawing.Point(0, 331);
			this.tabMain.Multiline = true;
			this.tabMain.Name = "tabMain";
			this.tabMain.SelectedIndex = 0;
			this.tabMain.Size = new System.Drawing.Size(59, 282);
			this.tabMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.tabMain.TabIndex = 89;
			this.tabMain.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabMain_DrawItem);
			this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabMain_SelectedIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.Location = new System.Drawing.Point(154, 4);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(0, 274);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "tabPage1";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(154, 4);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(0, 274);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tabPage3
			// 
			this.tabPage3.Location = new System.Drawing.Point(154, 4);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(0, 274);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "tabPage3";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// tabPage4
			// 
			this.tabPage4.Location = new System.Drawing.Point(154, 4);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(0, 274);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "tabPage4";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Calibri", 16F);
			this.label7.Location = new System.Drawing.Point(247, 924);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(62, 30);
			this.label7.TabIndex = 96;
			this.label7.Text = "Time";
			this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// officesDownView
			// 
			this.officesDownView.BackColor = System.Drawing.Color.White;
			this.officesDownView.BorderThickness = 1;
			this.officesDownView.FadeAlphaIncrement = 0;
			this.officesDownView.Font = new System.Drawing.Font("Calibri", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.officesDownView.Items = ((System.ComponentModel.BindingList<string>)(resources.GetObject("officesDownView.Items")));
			this.officesDownView.LinePadding = -6;
			this.officesDownView.Location = new System.Drawing.Point(4, 789);
			this.officesDownView.MinAlpha = 60;
			this.officesDownView.MinScrollable = 3;
			this.officesDownView.Name = "officesDownView";
			this.officesDownView.OuterColor = System.Drawing.Color.Black;
			this.officesDownView.Size = new System.Drawing.Size(358, 127);
			this.officesDownView.StartFadeIndex = 0;
			this.officesDownView.TabIndex = 88;
			// 
			// labelTirageOpTotal
			// 
			this.labelTirageOpTotal.Font = new System.Drawing.Font("Calibri", 16F);
			this.labelTirageOpTotal.Location = new System.Drawing.Point(253, 622);
			this.labelTirageOpTotal.Name = "labelTirageOpTotal";
			this.labelTirageOpTotal.Size = new System.Drawing.Size(56, 28);
			this.labelTirageOpTotal.TabIndex = 92;
			this.labelTirageOpTotal.Text = "All";
			this.labelTirageOpTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// labelTirageOpLocal
			// 
			this.labelTirageOpLocal.Font = new System.Drawing.Font("Calibri", 16F);
			this.labelTirageOpLocal.Location = new System.Drawing.Point(123, 622);
			this.labelTirageOpLocal.Name = "labelTirageOpLocal";
			this.labelTirageOpLocal.Size = new System.Drawing.Size(66, 32);
			this.labelTirageOpLocal.TabIndex = 91;
			this.labelTirageOpLocal.Text = "Local";
			this.labelTirageOpLocal.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Calibri", 16F);
			this.label5.Location = new System.Drawing.Point(112, 924);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(77, 30);
			this.label5.TabIndex = 95;
			this.label5.Text = "Count";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// mapAreaPanel
			// 
			this.mapAreaPanel.AllowDragging = false;
			this.mapAreaPanel.AllowEditing = false;
			this.mapAreaPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mapAreaPanel.FloorColor = System.Drawing.Color.White;
			this.mapAreaPanel.Font = new System.Drawing.Font("Calibri", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mapAreaPanel.FontCubicle = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mapAreaPanel.FontCubicleHeader = new System.Drawing.Font("Calibri", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mapAreaPanel.FontLabel = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mapAreaPanel.GridColor = System.Drawing.Color.LightGray;
			this.mapAreaPanel.HeightFloorFeet = 55;
			this.mapAreaPanel.Location = new System.Drawing.Point(365, 78);
			this.mapAreaPanel.Name = "mapAreaPanel";
			this.mapAreaPanel.PixelsPerFoot = 17;
			this.mapAreaPanel.ShowGrid = false;
			this.mapAreaPanel.ShowOutline = true;
			this.mapAreaPanel.Size = new System.Drawing.Size(1518, 960);
			this.mapAreaPanel.TabIndex = 71;
			this.mapAreaPanel.WidthFloorFeet = 89;
			// 
			// timerWebCam
			// 
			this.timerWebCam.Enabled = true;
			this.timerWebCam.Interval = 250;
			this.timerWebCam.Tick += new System.EventHandler(this.timerWebCam_Tick);
			// 
			// FormMapHQ
			// 
			this.ClientSize = new System.Drawing.Size(1884, 1042);
			this.Controls.Add(this.mapAreaPanel);
			this.Controls.Add(this.userControlMapDetails1);
			this.Controls.Add(this.labelCustDownTime);
			this.Controls.Add(this.labelCurrentTime);
			this.Controls.Add(this.labelCustDownCount);
			this.Controls.Add(this.menuMain);
			this.Controls.Add(this.labelTriageOpsCountTotal);
			this.Controls.Add(this.labelTriageCoordinator);
			this.Controls.Add(this.escalationView);
			this.Controls.Add(this.comboRoom);
			this.Controls.Add(this.eServiceMetricsControl);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.groupPhoneMetrics);
			this.Controls.Add(this.labelTriageOpsCountLocal);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.labelTirageOpLocal);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.labelTirageOpTotal);
			this.Controls.Add(this.tabMain);
			this.Controls.Add(this.officesDownView);
			this.Controls.Add(this.label7);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormMapHQ";
			this.Text = "Call Center Status Map";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMapHQ_FormClosed);
			this.Load += new System.EventHandler(this.FormMapHQ_Load);
			this.ResizeEnd += new System.EventHandler(this.FormMapHQ_ResizeEnd);
			this.groupPhoneMetrics.ResumeLayout(false);
			this.groupPhoneMetrics.PerformLayout();
			this.tabMain.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ComboBox comboRoom;
		private MapCubicle labelCurrentTime;
		private System.Windows.Forms.Label labelTriageCoordinator;
		private System.Windows.Forms.Timer timer1;
		private EServiceMetricsControl eServiceMetricsControl;
		private System.Windows.Forms.Label label3;
		private EscalationViewControl escalationView;
		private MapCubicle labelTriageOpsCountLocal;
		private OpenDental.UI.GroupBoxOD groupPhoneMetrics;
		private MapCubicle labelTriageTimeSpan;
		private MapCubicle labelTriageRedCalls;
		private System.Windows.Forms.Label label1;
		private MapCubicle labelTriageRedTimeSpan;
		private System.Windows.Forms.Label label4;
		private MapCubicle labelVoicemailTimeSpan;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label10;
		private MapCubicle labelTriageCalls;
		private MapCubicle labelVoicemailCalls;
		private System.Windows.Forms.Label label14;
		private MapAreaPanel mapAreaPanel;
		private System.Windows.Forms.TabControl tabMain;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.Label labelTirageOpTotal;
		private System.Windows.Forms.Label labelTirageOpLocal;
		private MapCubicle labelTriageOpsCountTotal;
		private MapCubicle labelChatTimeSpan;
		private MapCubicle labelChatCount;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label5;
		private MapCubicle labelCustDownTime;
		private MapCubicle labelCustDownCount;
		private EscalationViewControl officesDownView;
		private InternalTools.Phones.UserControlMapDetails userControlMapDetails1;
		private UI.MenuOD menuMain;
		private System.Windows.Forms.Timer timerWebCam;
	}
}