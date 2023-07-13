namespace Modbus
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.listSend = new System.Windows.Forms.ListBox();
            this.listReceived = new System.Windows.Forms.ListBox();
            this.btnDisConnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.GrpBoxSetting = new System.Windows.Forms.GroupBox();
            this.labStopBits = new System.Windows.Forms.Label();
            this.labDataBits = new System.Windows.Forms.Label();
            this.labParity = new System.Windows.Forms.Label();
            this.labBaudrate = new System.Windows.Forms.Label();
            this.labPortName = new System.Windows.Forms.Label();
            this.comBStopBits = new System.Windows.Forms.ComboBox();
            this.comBDataBits = new System.Windows.Forms.ComboBox();
            this.comBParity = new System.Windows.Forms.ComboBox();
            this.comBBaudrate = new System.Windows.Forms.ComboBox();
            this.comBPortName = new System.Windows.Forms.ComboBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.tabCrlSend = new System.Windows.Forms.TabControl();
            this.tabPString = new System.Windows.Forms.TabPage();
            this.txtSendString = new System.Windows.Forms.TextBox();
            this.tabPByte = new System.Windows.Forms.TabPage();
            this.txtSendByte = new System.Windows.Forms.TextBox();
            this.GrpBoxModBus = new System.Windows.Forms.GroupBox();
            this.btnModbusSend = new System.Windows.Forms.Button();
            this.comBFunctionCode = new System.Windows.Forms.ComboBox();
            this.labFunctionCode = new System.Windows.Forms.Label();
            this.GrpBoxSetting.SuspendLayout();
            this.tabCrlSend.SuspendLayout();
            this.tabPString.SuspendLayout();
            this.tabPByte.SuspendLayout();
            this.GrpBoxModBus.SuspendLayout();
            this.SuspendLayout();
            // 
            // listSend
            // 
            this.listSend.BackColor = System.Drawing.Color.Black;
            this.listSend.ForeColor = System.Drawing.Color.Lime;
            this.listSend.FormattingEnabled = true;
            this.listSend.ItemHeight = 18;
            this.listSend.Location = new System.Drawing.Point(3, 38);
            this.listSend.Name = "listSend";
            this.listSend.Size = new System.Drawing.Size(770, 310);
            this.listSend.TabIndex = 0;
            // 
            // listReceived
            // 
            this.listReceived.BackColor = System.Drawing.Color.Black;
            this.listReceived.ForeColor = System.Drawing.Color.Lime;
            this.listReceived.FormattingEnabled = true;
            this.listReceived.ItemHeight = 18;
            this.listReceived.Location = new System.Drawing.Point(3, 396);
            this.listReceived.Name = "listReceived";
            this.listReceived.Size = new System.Drawing.Size(770, 310);
            this.listReceived.TabIndex = 1;
            // 
            // btnDisConnect
            // 
            this.btnDisConnect.Location = new System.Drawing.Point(1066, 334);
            this.btnDisConnect.Name = "btnDisConnect";
            this.btnDisConnect.Size = new System.Drawing.Size(158, 64);
            this.btnDisConnect.TabIndex = 4;
            this.btnDisConnect.Text = "Disconnected";
            this.btnDisConnect.UseVisualStyleBackColor = true;
            this.btnDisConnect.Click += new System.EventHandler(this.btnDisConnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(845, 336);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(158, 62);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // GrpBoxSetting
            // 
            this.GrpBoxSetting.Controls.Add(this.labStopBits);
            this.GrpBoxSetting.Controls.Add(this.labDataBits);
            this.GrpBoxSetting.Controls.Add(this.labParity);
            this.GrpBoxSetting.Controls.Add(this.labBaudrate);
            this.GrpBoxSetting.Controls.Add(this.labPortName);
            this.GrpBoxSetting.Controls.Add(this.comBStopBits);
            this.GrpBoxSetting.Controls.Add(this.comBDataBits);
            this.GrpBoxSetting.Controls.Add(this.comBParity);
            this.GrpBoxSetting.Controls.Add(this.comBBaudrate);
            this.GrpBoxSetting.Controls.Add(this.comBPortName);
            this.GrpBoxSetting.Location = new System.Drawing.Point(817, 12);
            this.GrpBoxSetting.Name = "GrpBoxSetting";
            this.GrpBoxSetting.Size = new System.Drawing.Size(445, 318);
            this.GrpBoxSetting.TabIndex = 5;
            this.GrpBoxSetting.TabStop = false;
            this.GrpBoxSetting.Text = "Port Setting";
            // 
            // labStopBits
            // 
            this.labStopBits.AutoSize = true;
            this.labStopBits.Location = new System.Drawing.Point(6, 245);
            this.labStopBits.Name = "labStopBits";
            this.labStopBits.Size = new System.Drawing.Size(66, 18);
            this.labStopBits.TabIndex = 5;
            this.labStopBits.Text = "StopBits";
            // 
            // labDataBits
            // 
            this.labDataBits.AutoSize = true;
            this.labDataBits.Location = new System.Drawing.Point(6, 196);
            this.labDataBits.Name = "labDataBits";
            this.labDataBits.Size = new System.Drawing.Size(69, 18);
            this.labDataBits.TabIndex = 5;
            this.labDataBits.Text = "DataBits";
            // 
            // labParity
            // 
            this.labParity.AutoSize = true;
            this.labParity.Location = new System.Drawing.Point(6, 149);
            this.labParity.Name = "labParity";
            this.labParity.Size = new System.Drawing.Size(49, 18);
            this.labParity.TabIndex = 5;
            this.labParity.Text = "Parity";
            // 
            // labBaudrate
            // 
            this.labBaudrate.AutoSize = true;
            this.labBaudrate.Location = new System.Drawing.Point(6, 104);
            this.labBaudrate.Name = "labBaudrate";
            this.labBaudrate.Size = new System.Drawing.Size(70, 18);
            this.labBaudrate.TabIndex = 5;
            this.labBaudrate.Text = "Baudrate";
            // 
            // labPortName
            // 
            this.labPortName.AutoSize = true;
            this.labPortName.Location = new System.Drawing.Point(6, 50);
            this.labPortName.Name = "labPortName";
            this.labPortName.Size = new System.Drawing.Size(77, 18);
            this.labPortName.TabIndex = 5;
            this.labPortName.Text = "PortName";
            // 
            // comBStopBits
            // 
            this.comBStopBits.FormattingEnabled = true;
            this.comBStopBits.Items.AddRange(new object[] {
            " None",
            "One",
            "Two",
            "OnePointFive"});
            this.comBStopBits.Location = new System.Drawing.Point(102, 245);
            this.comBStopBits.Name = "comBStopBits";
            this.comBStopBits.Size = new System.Drawing.Size(323, 26);
            this.comBStopBits.TabIndex = 4;
            this.comBStopBits.Text = "None";
            // 
            // comBDataBits
            // 
            this.comBDataBits.FormattingEnabled = true;
            this.comBDataBits.Items.AddRange(new object[] {
            "7",
            "8"});
            this.comBDataBits.Location = new System.Drawing.Point(102, 196);
            this.comBDataBits.Name = "comBDataBits";
            this.comBDataBits.Size = new System.Drawing.Size(323, 26);
            this.comBDataBits.TabIndex = 4;
            this.comBDataBits.Text = "8";
            // 
            // comBParity
            // 
            this.comBParity.FormattingEnabled = true;
            this.comBParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.comBParity.Location = new System.Drawing.Point(102, 149);
            this.comBParity.Name = "comBParity";
            this.comBParity.Size = new System.Drawing.Size(323, 26);
            this.comBParity.TabIndex = 4;
            this.comBParity.Text = "None";
            // 
            // comBBaudrate
            // 
            this.comBBaudrate.FormattingEnabled = true;
            this.comBBaudrate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.comBBaudrate.Location = new System.Drawing.Point(102, 104);
            this.comBBaudrate.Name = "comBBaudrate";
            this.comBBaudrate.Size = new System.Drawing.Size(323, 26);
            this.comBBaudrate.TabIndex = 4;
            this.comBBaudrate.Text = "115200";
            // 
            // comBPortName
            // 
            this.comBPortName.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comBPortName.FormattingEnabled = true;
            this.comBPortName.Location = new System.Drawing.Point(102, 39);
            this.comBPortName.Name = "comBPortName";
            this.comBPortName.Size = new System.Drawing.Size(323, 36);
            this.comBPortName.TabIndex = 3;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(779, 641);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(472, 85);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tabCrlSend
            // 
            this.tabCrlSend.Controls.Add(this.tabPString);
            this.tabCrlSend.Controls.Add(this.tabPByte);
            this.tabCrlSend.Location = new System.Drawing.Point(779, 396);
            this.tabCrlSend.Name = "tabCrlSend";
            this.tabCrlSend.SelectedIndex = 0;
            this.tabCrlSend.Size = new System.Drawing.Size(483, 237);
            this.tabCrlSend.TabIndex = 8;
            // 
            // tabPString
            // 
            this.tabPString.Controls.Add(this.txtSendString);
            this.tabPString.Location = new System.Drawing.Point(4, 28);
            this.tabPString.Name = "tabPString";
            this.tabPString.Padding = new System.Windows.Forms.Padding(3);
            this.tabPString.Size = new System.Drawing.Size(475, 205);
            this.tabPString.TabIndex = 0;
            this.tabPString.Text = "String";
            this.tabPString.UseVisualStyleBackColor = true;
            // 
            // txtSendString
            // 
            this.txtSendString.Location = new System.Drawing.Point(0, 3);
            this.txtSendString.Multiline = true;
            this.txtSendString.Name = "txtSendString";
            this.txtSendString.Size = new System.Drawing.Size(459, 199);
            this.txtSendString.TabIndex = 8;
            // 
            // tabPByte
            // 
            this.tabPByte.Controls.Add(this.txtSendByte);
            this.tabPByte.Location = new System.Drawing.Point(4, 28);
            this.tabPByte.Name = "tabPByte";
            this.tabPByte.Padding = new System.Windows.Forms.Padding(3);
            this.tabPByte.Size = new System.Drawing.Size(475, 205);
            this.tabPByte.TabIndex = 1;
            this.tabPByte.Text = "Byte";
            this.tabPByte.UseVisualStyleBackColor = true;
            // 
            // txtSendByte
            // 
            this.txtSendByte.Location = new System.Drawing.Point(8, 3);
            this.txtSendByte.Multiline = true;
            this.txtSendByte.Name = "txtSendByte";
            this.txtSendByte.Size = new System.Drawing.Size(459, 199);
            this.txtSendByte.TabIndex = 9;
            // 
            // GrpBoxModBus
            // 
            this.GrpBoxModBus.Controls.Add(this.labFunctionCode);
            this.GrpBoxModBus.Controls.Add(this.comBFunctionCode);
            this.GrpBoxModBus.Controls.Add(this.btnModbusSend);
            this.GrpBoxModBus.Location = new System.Drawing.Point(1277, 25);
            this.GrpBoxModBus.Name = "GrpBoxModBus";
            this.GrpBoxModBus.Size = new System.Drawing.Size(596, 701);
            this.GrpBoxModBus.TabIndex = 9;
            this.GrpBoxModBus.TabStop = false;
            this.GrpBoxModBus.Text = "groupBox1";
            // 
            // btnModbusSend
            // 
            this.btnModbusSend.Location = new System.Drawing.Point(61, 610);
            this.btnModbusSend.Name = "btnModbusSend";
            this.btnModbusSend.Size = new System.Drawing.Size(472, 85);
            this.btnModbusSend.TabIndex = 7;
            this.btnModbusSend.Text = "Send";
            this.btnModbusSend.UseVisualStyleBackColor = true;
            // 
            // comBFunctionCode
            // 
            this.comBFunctionCode.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comBFunctionCode.FormattingEnabled = true;
            this.comBFunctionCode.Items.AddRange(new object[] {
            "01-Read Coil Status",
            "02-Read Input Status",
            "03-Read Holding Registers ",
            "04-Read Input Registers",
            "05-Force Single Coil",
            "06-Preset Single Register ",
            "16-Preset Multiple Regs "});
            this.comBFunctionCode.Location = new System.Drawing.Point(61, 64);
            this.comBFunctionCode.Name = "comBFunctionCode";
            this.comBFunctionCode.Size = new System.Drawing.Size(472, 40);
            this.comBFunctionCode.TabIndex = 10;
            // 
            // labFunctionCode
            // 
            this.labFunctionCode.AutoSize = true;
            this.labFunctionCode.Location = new System.Drawing.Point(58, 37);
            this.labFunctionCode.Name = "labFunctionCode";
            this.labFunctionCode.Size = new System.Drawing.Size(107, 18);
            this.labFunctionCode.TabIndex = 11;
            this.labFunctionCode.Text = "Function Code";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2267, 755);
            this.Controls.Add(this.GrpBoxModBus);
            this.Controls.Add(this.tabCrlSend);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.GrpBoxSetting);
            this.Controls.Add(this.btnDisConnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.listReceived);
            this.Controls.Add(this.listSend);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GrpBoxSetting.ResumeLayout(false);
            this.GrpBoxSetting.PerformLayout();
            this.tabCrlSend.ResumeLayout(false);
            this.tabPString.ResumeLayout(false);
            this.tabPString.PerformLayout();
            this.tabPByte.ResumeLayout(false);
            this.tabPByte.PerformLayout();
            this.GrpBoxModBus.ResumeLayout(false);
            this.GrpBoxModBus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listSend;
        private System.Windows.Forms.ListBox listReceived;
        private System.Windows.Forms.Button btnDisConnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox GrpBoxSetting;
        private System.Windows.Forms.Label labBaudrate;
        private System.Windows.Forms.Label labPortName;
        private System.Windows.Forms.ComboBox comBBaudrate;
        private System.Windows.Forms.ComboBox comBPortName;
        private System.Windows.Forms.Label labParity;
        private System.Windows.Forms.ComboBox comBParity;
        private System.Windows.Forms.Label labDataBits;
        private System.Windows.Forms.ComboBox comBDataBits;
        private System.Windows.Forms.Label labStopBits;
        private System.Windows.Forms.ComboBox comBStopBits;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TabControl tabCrlSend;
        private System.Windows.Forms.TabPage tabPString;
        private System.Windows.Forms.TextBox txtSendString;
        private System.Windows.Forms.TabPage tabPByte;
        private System.Windows.Forms.TextBox txtSendByte;
        private System.Windows.Forms.GroupBox GrpBoxModBus;
        private System.Windows.Forms.Button btnModbusSend;
        private System.Windows.Forms.Label labFunctionCode;
        private System.Windows.Forms.ComboBox comBFunctionCode;
    }
}

