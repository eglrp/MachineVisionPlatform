﻿namespace UIDemo
{
    partial class ImiTechForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImiTechForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.CtrlBtn = new System.Windows.Forms.Button();
            this.PropertyBtn = new System.Windows.Forms.Button();
            this.CameraCBox = new System.Windows.Forms.ComboBox();
            this.SaveCBox = new System.Windows.Forms.CheckBox();
            this.CameraCtrl = new AxNeptuneLib.AxNeptuneCtrl();
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.TimeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.LongitudeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.LatitudeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.SpeedLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.FrameCntLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.UpdateTimeTicker = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CameraCtrl)).BeginInit();
            this.MainStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CameraCtrl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.MainStatusStrip, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(573, 416);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.CtrlBtn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.PropertyBtn, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.CameraCBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.SaveCBox, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(567, 29);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // CtrlBtn
            // 
            this.CtrlBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CtrlBtn.Location = new System.Drawing.Point(3, 3);
            this.CtrlBtn.Name = "CtrlBtn";
            this.CtrlBtn.Size = new System.Drawing.Size(84, 23);
            this.CtrlBtn.TabIndex = 0;
            this.CtrlBtn.Text = "Start";
            this.CtrlBtn.UseVisualStyleBackColor = true;
            this.CtrlBtn.Click += new System.EventHandler(this.CtrlBtn_Click);
            // 
            // PropertyBtn
            // 
            this.PropertyBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PropertyBtn.Location = new System.Drawing.Point(423, 3);
            this.PropertyBtn.Name = "PropertyBtn";
            this.PropertyBtn.Size = new System.Drawing.Size(84, 23);
            this.PropertyBtn.TabIndex = 1;
            this.PropertyBtn.Text = "Property";
            this.PropertyBtn.UseVisualStyleBackColor = true;
            this.PropertyBtn.Click += new System.EventHandler(this.PropertyBtn_Click);
            // 
            // CameraCBox
            // 
            this.CameraCBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CameraCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CameraCBox.FormattingEnabled = true;
            this.CameraCBox.Location = new System.Drawing.Point(93, 3);
            this.CameraCBox.Name = "CameraCBox";
            this.CameraCBox.Size = new System.Drawing.Size(234, 20);
            this.CameraCBox.TabIndex = 2;
            this.CameraCBox.SelectedIndexChanged += new System.EventHandler(this.CameraCBox_SelectedIndexChanged);
            // 
            // SaveCBox
            // 
            this.SaveCBox.AutoSize = true;
            this.SaveCBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveCBox.Location = new System.Drawing.Point(333, 3);
            this.SaveCBox.Name = "SaveCBox";
            this.SaveCBox.Size = new System.Drawing.Size(84, 23);
            this.SaveCBox.TabIndex = 3;
            this.SaveCBox.Text = "Save";
            this.SaveCBox.UseVisualStyleBackColor = true;
            this.SaveCBox.CheckedChanged += new System.EventHandler(this.SaveCBox_CheckedChanged);
            // 
            // CameraCtrl
            // 
            this.CameraCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CameraCtrl.Enabled = true;
            this.CameraCtrl.Location = new System.Drawing.Point(3, 38);
            this.CameraCtrl.Name = "CameraCtrl";
            this.CameraCtrl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("CameraCtrl.OcxState")));
            this.CameraCtrl.Size = new System.Drawing.Size(567, 345);
            this.CameraCtrl.TabIndex = 3;
            this.CameraCtrl.ImageReceived += new AxNeptuneLib._INeptuneEvents_ImageReceivedEventHandler(this.CameraCtrl_ImageReceived);
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel,
            this.TimeLabel,
            this.LongitudeLabel,
            this.LatitudeLabel,
            this.SpeedLabel,
            this.FrameCntLabel});
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 394);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Size = new System.Drawing.Size(573, 22);
            this.MainStatusStrip.TabIndex = 4;
            this.MainStatusStrip.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(59, 17);
            this.StatusLabel.Text = "状态:停止";
            // 
            // TimeLabel
            // 
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(66, 17);
            this.TimeLabel.Text = "UTC时间:0";
            // 
            // LongitudeLabel
            // 
            this.LongitudeLabel.Name = "LongitudeLabel";
            this.LongitudeLabel.Size = new System.Drawing.Size(42, 17);
            this.LongitudeLabel.Text = "经度:0";
            // 
            // LatitudeLabel
            // 
            this.LatitudeLabel.Name = "LatitudeLabel";
            this.LatitudeLabel.Size = new System.Drawing.Size(42, 17);
            this.LatitudeLabel.Text = "纬度:0";
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(42, 17);
            this.SpeedLabel.Text = "速度:0";
            // 
            // FrameCntLabel
            // 
            this.FrameCntLabel.Name = "FrameCntLabel";
            this.FrameCntLabel.Size = new System.Drawing.Size(42, 17);
            this.FrameCntLabel.Text = "帧数:0";
            // 
            // UpdateTimeTicker
            // 
            this.UpdateTimeTicker.Tick += new System.EventHandler(this.UpdateTimeTicker_Tick);
            // 
            // ImiTechForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 416);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ImiTechForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CameraCtrl)).EndInit();
            this.MainStatusStrip.ResumeLayout(false);
            this.MainStatusStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button CtrlBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button PropertyBtn;
        private AxNeptuneLib.AxNeptuneCtrl CameraCtrl;
        private System.Windows.Forms.ComboBox CameraCBox;
        private System.Windows.Forms.StatusStrip MainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel LongitudeLabel;
        private System.Windows.Forms.ToolStripStatusLabel LatitudeLabel;
        private System.Windows.Forms.ToolStripStatusLabel SpeedLabel;
        private System.Windows.Forms.ToolStripStatusLabel FrameCntLabel;
        private System.Windows.Forms.Timer UpdateTimeTicker;
        private System.Windows.Forms.ToolStripStatusLabel TimeLabel;
        private System.Windows.Forms.CheckBox SaveCBox;
    }
}

