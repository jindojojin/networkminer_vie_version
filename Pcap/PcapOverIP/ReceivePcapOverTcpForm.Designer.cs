﻿namespace NetworkMiner.PcapOverIP {
    partial class ReceivePcapOverTcpForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceivePcapOverTcpForm));
            this.portNumberSelectorIncoming = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.useSslCheckBox = new System.Windows.Forms.CheckBox();
            this.startReceivingButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.receivedFramesLabel = new System.Windows.Forms.Label();
            this.socketStateLabel = new System.Windows.Forms.Label();
            this.receivedFramesValueLabel = new System.Windows.Forms.Label();
            this.socketStateValueLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timoutSelector = new System.Windows.Forms.NumericUpDown();
            this.incomingTcpRadioButton = new System.Windows.Forms.RadioButton();
            this.outgoingTcpRadioButton = new System.Windows.Forms.RadioButton();
            this.portNumberSelectorOutgoing = new System.Windows.Forms.NumericUpDown();
            this.ipTextBoxOutgoing = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.portNumberSelectorIncoming)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timoutSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portNumberSelectorOutgoing)).BeginInit();
            this.SuspendLayout();
            // 
            // portNumberSelectorIncoming
            // 
            this.portNumberSelectorIncoming.Location = new System.Drawing.Point(116, 43);
            this.portNumberSelectorIncoming.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.portNumberSelectorIncoming.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.portNumberSelectorIncoming.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.portNumberSelectorIncoming.Name = "portNumberSelectorIncoming";
            this.portNumberSelectorIncoming.Size = new System.Drawing.Size(76, 22);
            this.portNumberSelectorIncoming.TabIndex = 0;
            this.portNumberSelectorIncoming.Value = new decimal(new int[] {
            57012,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "cổng TCP";
            // 
            // useSslCheckBox
            // 
            this.useSslCheckBox.AutoSize = true;
            this.useSslCheckBox.Location = new System.Drawing.Point(16, 169);
            this.useSslCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.useSslCheckBox.Name = "useSslCheckBox";
            this.useSslCheckBox.Size = new System.Drawing.Size(113, 21);
            this.useSslCheckBox.TabIndex = 3;
            this.useSslCheckBox.Text = "Sử dụng SSL";
            this.useSslCheckBox.UseVisualStyleBackColor = true;
            // 
            // startReceivingButton
            // 
            this.startReceivingButton.Location = new System.Drawing.Point(16, 198);
            this.startReceivingButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startReceivingButton.Name = "startReceivingButton";
            this.startReceivingButton.Size = new System.Drawing.Size(229, 28);
            this.startReceivingButton.TabIndex = 5;
            this.startReceivingButton.Text = "Bắt đầu nhận";
            this.startReceivingButton.UseVisualStyleBackColor = true;
            this.startReceivingButton.Click += new System.EventHandler(this.startReceivingButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(253, 198);
            this.stopButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(144, 28);
            this.stopButton.TabIndex = 6;
            this.stopButton.Text = "Dừng lại";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // receivedFramesLabel
            // 
            this.receivedFramesLabel.AutoSize = true;
            this.receivedFramesLabel.Location = new System.Drawing.Point(12, 256);
            this.receivedFramesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.receivedFramesLabel.Name = "receivedFramesLabel";
            this.receivedFramesLabel.Size = new System.Drawing.Size(189, 17);
            this.receivedFramesLabel.TabIndex = 6;
            this.receivedFramesLabel.Text = "Số khung(frame) nhận được:";
            // 
            // socketStateLabel
            // 
            this.socketStateLabel.AutoSize = true;
            this.socketStateLabel.Location = new System.Drawing.Point(12, 230);
            this.socketStateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.socketStateLabel.Name = "socketStateLabel";
            this.socketStateLabel.Size = new System.Drawing.Size(122, 17);
            this.socketStateLabel.TabIndex = 7;
            this.socketStateLabel.Text = "Trạng thái socket:";
            // 
            // receivedFramesValueLabel
            // 
            this.receivedFramesValueLabel.AutoSize = true;
            this.receivedFramesValueLabel.Location = new System.Drawing.Point(210, 256);
            this.receivedFramesValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.receivedFramesValueLabel.Name = "receivedFramesValueLabel";
            this.receivedFramesValueLabel.Size = new System.Drawing.Size(16, 17);
            this.receivedFramesValueLabel.TabIndex = 8;
            this.receivedFramesValueLabel.Text = "0";
            // 
            // socketStateValueLabel
            // 
            this.socketStateValueLabel.AutoSize = true;
            this.socketStateValueLabel.Location = new System.Drawing.Point(144, 230);
            this.socketStateValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.socketStateValueLabel.Name = "socketStateValueLabel";
            this.socketStateValueLabel.Size = new System.Drawing.Size(51, 17);
            this.socketStateValueLabel.TabIndex = 9;
            this.socketStateValueLabel.Text = "Closed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Idle timeout (giây)";
            // 
            // timoutSelector
            // 
            this.timoutSelector.Location = new System.Drawing.Point(267, 167);
            this.timoutSelector.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.timoutSelector.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.timoutSelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.timoutSelector.Name = "timoutSelector";
            this.timoutSelector.Size = new System.Drawing.Size(76, 22);
            this.timoutSelector.TabIndex = 4;
            this.timoutSelector.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // incomingTcpRadioButton
            // 
            this.incomingTcpRadioButton.AutoSize = true;
            this.incomingTcpRadioButton.Checked = true;
            this.incomingTcpRadioButton.Location = new System.Drawing.Point(16, 16);
            this.incomingTcpRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.incomingTcpRadioButton.Name = "incomingTcpRadioButton";
            this.incomingTcpRadioButton.Size = new System.Drawing.Size(218, 21);
            this.incomingTcpRadioButton.TabIndex = 11;
            this.incomingTcpRadioButton.TabStop = true;
            this.incomingTcpRadioButton.Text = "Lắng nghe từ kết nối TCP đến";
            this.incomingTcpRadioButton.UseVisualStyleBackColor = true;
            this.incomingTcpRadioButton.CheckedChanged += new System.EventHandler(this.inOutTcpRadioButton_CheckedChanged);
            // 
            // outgoingTcpRadioButton
            // 
            this.outgoingTcpRadioButton.AutoSize = true;
            this.outgoingTcpRadioButton.Location = new System.Drawing.Point(16, 75);
            this.outgoingTcpRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.outgoingTcpRadioButton.Name = "outgoingTcpRadioButton";
            this.outgoingTcpRadioButton.Size = new System.Drawing.Size(150, 21);
            this.outgoingTcpRadioButton.TabIndex = 12;
            this.outgoingTcpRadioButton.Text = "kết nối đến cổng/IP";
            this.outgoingTcpRadioButton.UseVisualStyleBackColor = true;
            this.outgoingTcpRadioButton.CheckedChanged += new System.EventHandler(this.inOutTcpRadioButton_CheckedChanged);
            // 
            // portNumberSelectorOutgoing
            // 
            this.portNumberSelectorOutgoing.Enabled = false;
            this.portNumberSelectorOutgoing.Location = new System.Drawing.Point(290, 108);
            this.portNumberSelectorOutgoing.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.portNumberSelectorOutgoing.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.portNumberSelectorOutgoing.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.portNumberSelectorOutgoing.Name = "portNumberSelectorOutgoing";
            this.portNumberSelectorOutgoing.Size = new System.Drawing.Size(76, 22);
            this.portNumberSelectorOutgoing.TabIndex = 13;
            this.portNumberSelectorOutgoing.Value = new decimal(new int[] {
            57012,
            0,
            0,
            0});
            // 
            // ipTextBoxOutgoing
            // 
            this.ipTextBoxOutgoing.Enabled = false;
            this.ipTextBoxOutgoing.Location = new System.Drawing.Point(69, 107);
            this.ipTextBoxOutgoing.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ipTextBoxOutgoing.Name = "ipTextBoxOutgoing";
            this.ipTextBoxOutgoing.Size = new System.Drawing.Size(132, 22);
            this.ipTextBoxOutgoing.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "IP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "cổng TCP";
            // 
            // ReceivePcapOverTcpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 287);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ipTextBoxOutgoing);
            this.Controls.Add(this.portNumberSelectorOutgoing);
            this.Controls.Add(this.outgoingTcpRadioButton);
            this.Controls.Add(this.incomingTcpRadioButton);
            this.Controls.Add(this.timoutSelector);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.socketStateValueLabel);
            this.Controls.Add(this.receivedFramesValueLabel);
            this.Controls.Add(this.socketStateLabel);
            this.Controls.Add(this.receivedFramesLabel);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startReceivingButton);
            this.Controls.Add(this.useSslCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.portNumberSelectorIncoming);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReceivePcapOverTcpForm";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Pcap-over-IP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReceivePcapOverTcpForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.portNumberSelectorIncoming)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timoutSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portNumberSelectorOutgoing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown portNumberSelectorIncoming;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox useSslCheckBox;
        private System.Windows.Forms.Button startReceivingButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label receivedFramesLabel;
        private System.Windows.Forms.Label socketStateLabel;
        private System.Windows.Forms.Label receivedFramesValueLabel;
        private System.Windows.Forms.Label socketStateValueLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown timoutSelector;
        private System.Windows.Forms.RadioButton incomingTcpRadioButton;
        private System.Windows.Forms.RadioButton outgoingTcpRadioButton;
        private System.Windows.Forms.NumericUpDown portNumberSelectorOutgoing;
        private System.Windows.Forms.TextBox ipTextBoxOutgoing;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}