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
            this.GrpBoxModBus_01 = new System.Windows.Forms.GroupBox();
            this.txtRegisterLength = new System.Windows.Forms.TextBox();
            this.labRegisterLength = new System.Windows.Forms.Label();
            this.txtRegisterAddress = new System.Windows.Forms.TextBox();
            this.labRegisterAddress = new System.Windows.Forms.Label();
            this.txtSlaveAddress = new System.Windows.Forms.TextBox();
            this.labAddress = new System.Windows.Forms.Label();
            this.labFunctionCode = new System.Windows.Forms.Label();
            this.comBFunctionCode = new System.Windows.Forms.ComboBox();
            this.btnModbusSend_01 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabCtrMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.GrpBoxModBus_02 = new System.Windows.Forms.GroupBox();
            this.txtRegisterLength_02 = new System.Windows.Forms.TextBox();
            this.labRegisterLength_02 = new System.Windows.Forms.Label();
            this.txtRegisterAddress_02 = new System.Windows.Forms.TextBox();
            this.labRegisterAddress_02 = new System.Windows.Forms.Label();
            this.txtSlaveAddress_02 = new System.Windows.Forms.TextBox();
            this.labAddress_02 = new System.Windows.Forms.Label();
            this.labFunctionCode_02 = new System.Windows.Forms.Label();
            this.comBFunctionCode_02 = new System.Windows.Forms.ComboBox();
            this.btnModbusSend_02 = new System.Windows.Forms.Button();
            this.labSend_00 = new System.Windows.Forms.Label();
            this.labReceived = new System.Windows.Forms.Label();
            this.GrpBoxModBus_03 = new System.Windows.Forms.GroupBox();
            this.txtRegisterLength_03 = new System.Windows.Forms.TextBox();
            this.labRegisterLength_03 = new System.Windows.Forms.Label();
            this.txtRegisterAddress_03 = new System.Windows.Forms.TextBox();
            this.labRegisterAddress_03 = new System.Windows.Forms.Label();
            this.txtSlaveAddress_03 = new System.Windows.Forms.TextBox();
            this.labAddress_03 = new System.Windows.Forms.Label();
            this.labFunctionCode_03 = new System.Windows.Forms.Label();
            this.comBFunctionCode_03 = new System.Windows.Forms.ComboBox();
            this.btnModbusSend_03 = new System.Windows.Forms.Button();
            this.chkIO_Y_0_7 = new System.Windows.Forms.CheckBox();
            this.chkIO_Y_0_6 = new System.Windows.Forms.CheckBox();
            this.chkIO_Y_0_5 = new System.Windows.Forms.CheckBox();
            this.chkIO_Y_0_4 = new System.Windows.Forms.CheckBox();
            this.chkIO_Y_0_3 = new System.Windows.Forms.CheckBox();
            this.chkIO_Y_0_2 = new System.Windows.Forms.CheckBox();
            this.chkIO_Y_0_1 = new System.Windows.Forms.CheckBox();
            this.chkIO_Y_0_0 = new System.Windows.Forms.CheckBox();
            this.chkIO_Y_1_7 = new System.Windows.Forms.CheckBox();
            this.chkIO_Y_1_6 = new System.Windows.Forms.CheckBox();
            this.chkIO_Y_1_5 = new System.Windows.Forms.CheckBox();
            this.chkIO_Y_1_4 = new System.Windows.Forms.CheckBox();
            this.chkIO_Y_1_3 = new System.Windows.Forms.CheckBox();
            this.chkIO_Y_1_2 = new System.Windows.Forms.CheckBox();
            this.chkIO_Y_1_1 = new System.Windows.Forms.CheckBox();
            this.chkIO_Y_1_0 = new System.Windows.Forms.CheckBox();
            this.chkIO_Y_2_7 = new System.Windows.Forms.CheckBox();
            this.chkIO_Y_2_6 = new System.Windows.Forms.CheckBox();
            this.chkIO_Y_2_5 = new System.Windows.Forms.CheckBox();
            this.chkIO_Y_2_4 = new System.Windows.Forms.CheckBox();
            this.chkIO_Y_2_3 = new System.Windows.Forms.CheckBox();
            this.chkIO_Y_2_2 = new System.Windows.Forms.CheckBox();
            this.chkIO_Y_2_1 = new System.Windows.Forms.CheckBox();
            this.chkIO_Y_2_0 = new System.Windows.Forms.CheckBox();
            this.chkIO_Y_3_7 = new System.Windows.Forms.CheckBox();
            this.chkIO_Y_3_6 = new System.Windows.Forms.CheckBox();
            this.chkIO_Y_3_5 = new System.Windows.Forms.CheckBox();
            this.chkIO_Y_3_4 = new System.Windows.Forms.CheckBox();
            this.chkIO_Y_3_3 = new System.Windows.Forms.CheckBox();
            this.chkIO_Y_3_2 = new System.Windows.Forms.CheckBox();
            this.chkIO_Y_3_1 = new System.Windows.Forms.CheckBox();
            this.chkIO_Y_3_0 = new System.Windows.Forms.CheckBox();
            this.panel_IO_001 = new System.Windows.Forms.Panel();
            this.GrpBoxModBus_04 = new System.Windows.Forms.GroupBox();
            this.txtRegisterLength_04 = new System.Windows.Forms.TextBox();
            this.labRegisterLength_04 = new System.Windows.Forms.Label();
            this.txtRegisterAddress_04 = new System.Windows.Forms.TextBox();
            this.labRegisterAddress_04 = new System.Windows.Forms.Label();
            this.txtSlaveAddress_04 = new System.Windows.Forms.TextBox();
            this.labAddress_04 = new System.Windows.Forms.Label();
            this.labFunctionCode_04 = new System.Windows.Forms.Label();
            this.comBFunctionCode_04 = new System.Windows.Forms.ComboBox();
            this.btnModbusSend_04 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrpBoxSetting.SuspendLayout();
            this.tabCrlSend.SuspendLayout();
            this.tabPString.SuspendLayout();
            this.tabPByte.SuspendLayout();
            this.GrpBoxModBus_01.SuspendLayout();
            this.tabCtrMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.GrpBoxModBus_02.SuspendLayout();
            this.GrpBoxModBus_03.SuspendLayout();
            this.panel_IO_001.SuspendLayout();
            this.GrpBoxModBus_04.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listSend
            // 
            this.listSend.BackColor = System.Drawing.Color.Black;
            this.listSend.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listSend.ForeColor = System.Drawing.Color.Lime;
            this.listSend.FormattingEnabled = true;
            this.listSend.ItemHeight = 22;
            this.listSend.Location = new System.Drawing.Point(1041, 76);
            this.listSend.Name = "listSend";
            this.listSend.Size = new System.Drawing.Size(566, 312);
            this.listSend.TabIndex = 0;
            // 
            // listReceived
            // 
            this.listReceived.BackColor = System.Drawing.Color.Black;
            this.listReceived.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listReceived.ForeColor = System.Drawing.Color.Lime;
            this.listReceived.FormattingEnabled = true;
            this.listReceived.ItemHeight = 22;
            this.listReceived.Location = new System.Drawing.Point(1041, 424);
            this.listReceived.Name = "listReceived";
            this.listReceived.Size = new System.Drawing.Size(566, 312);
            this.listReceived.TabIndex = 1;
            // 
            // btnDisConnect
            // 
            this.btnDisConnect.Location = new System.Drawing.Point(176, 348);
            this.btnDisConnect.Name = "btnDisConnect";
            this.btnDisConnect.Size = new System.Drawing.Size(158, 64);
            this.btnDisConnect.TabIndex = 4;
            this.btnDisConnect.Text = "Disconnected";
            this.btnDisConnect.UseVisualStyleBackColor = true;
            this.btnDisConnect.Click += new System.EventHandler(this.btnDisConnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 350);
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
            this.GrpBoxSetting.Location = new System.Drawing.Point(12, 26);
            this.GrpBoxSetting.Name = "GrpBoxSetting";
            this.GrpBoxSetting.Size = new System.Drawing.Size(446, 318);
            this.GrpBoxSetting.TabIndex = 5;
            this.GrpBoxSetting.TabStop = false;
            this.GrpBoxSetting.Text = "Port Setting";
            // 
            // labStopBits
            // 
            this.labStopBits.AutoSize = true;
            this.labStopBits.Location = new System.Drawing.Point(6, 244);
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
            this.labParity.Location = new System.Drawing.Point(6, 148);
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
            this.comBStopBits.Location = new System.Drawing.Point(102, 244);
            this.comBStopBits.Name = "comBStopBits";
            this.comBStopBits.Size = new System.Drawing.Size(324, 26);
            this.comBStopBits.TabIndex = 4;
            this.comBStopBits.Text = "One";
            // 
            // comBDataBits
            // 
            this.comBDataBits.FormattingEnabled = true;
            this.comBDataBits.Items.AddRange(new object[] {
            "7",
            "8"});
            this.comBDataBits.Location = new System.Drawing.Point(102, 196);
            this.comBDataBits.Name = "comBDataBits";
            this.comBDataBits.Size = new System.Drawing.Size(324, 26);
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
            this.comBParity.Location = new System.Drawing.Point(102, 148);
            this.comBParity.Name = "comBParity";
            this.comBParity.Size = new System.Drawing.Size(324, 26);
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
            this.comBBaudrate.Size = new System.Drawing.Size(324, 26);
            this.comBBaudrate.TabIndex = 4;
            this.comBBaudrate.Text = "115200";
            // 
            // comBPortName
            // 
            this.comBPortName.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comBPortName.FormattingEnabled = true;
            this.comBPortName.Location = new System.Drawing.Point(102, 39);
            this.comBPortName.Name = "comBPortName";
            this.comBPortName.Size = new System.Drawing.Size(324, 36);
            this.comBPortName.TabIndex = 3;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(12, 654);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(436, 86);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tabCrlSend
            // 
            this.tabCrlSend.Controls.Add(this.tabPString);
            this.tabCrlSend.Controls.Add(this.tabPByte);
            this.tabCrlSend.Location = new System.Drawing.Point(12, 418);
            this.tabCrlSend.Name = "tabCrlSend";
            this.tabCrlSend.SelectedIndex = 0;
            this.tabCrlSend.Size = new System.Drawing.Size(446, 237);
            this.tabCrlSend.TabIndex = 8;
            // 
            // tabPString
            // 
            this.tabPString.Controls.Add(this.txtSendString);
            this.tabPString.Location = new System.Drawing.Point(4, 28);
            this.tabPString.Name = "tabPString";
            this.tabPString.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPString.Size = new System.Drawing.Size(438, 205);
            this.tabPString.TabIndex = 0;
            this.tabPString.Text = "String";
            this.tabPString.UseVisualStyleBackColor = true;
            // 
            // txtSendString
            // 
            this.txtSendString.Location = new System.Drawing.Point(0, 3);
            this.txtSendString.Multiline = true;
            this.txtSendString.Name = "txtSendString";
            this.txtSendString.Size = new System.Drawing.Size(432, 199);
            this.txtSendString.TabIndex = 8;
            // 
            // tabPByte
            // 
            this.tabPByte.Controls.Add(this.txtSendByte);
            this.tabPByte.Location = new System.Drawing.Point(4, 28);
            this.tabPByte.Name = "tabPByte";
            this.tabPByte.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
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
            this.txtSendByte.Size = new System.Drawing.Size(458, 199);
            this.txtSendByte.TabIndex = 9;
            // 
            // GrpBoxModBus_01
            // 
            this.GrpBoxModBus_01.Controls.Add(this.txtRegisterLength);
            this.GrpBoxModBus_01.Controls.Add(this.labRegisterLength);
            this.GrpBoxModBus_01.Controls.Add(this.txtRegisterAddress);
            this.GrpBoxModBus_01.Controls.Add(this.labRegisterAddress);
            this.GrpBoxModBus_01.Controls.Add(this.txtSlaveAddress);
            this.GrpBoxModBus_01.Controls.Add(this.labAddress);
            this.GrpBoxModBus_01.Controls.Add(this.labFunctionCode);
            this.GrpBoxModBus_01.Controls.Add(this.comBFunctionCode);
            this.GrpBoxModBus_01.Controls.Add(this.btnModbusSend_01);
            this.GrpBoxModBus_01.Location = new System.Drawing.Point(6, 6);
            this.GrpBoxModBus_01.Name = "GrpBoxModBus_01";
            this.GrpBoxModBus_01.Size = new System.Drawing.Size(538, 659);
            this.GrpBoxModBus_01.TabIndex = 9;
            this.GrpBoxModBus_01.TabStop = false;
            this.GrpBoxModBus_01.Text = "Read";
            // 
            // txtRegisterLength
            // 
            this.txtRegisterLength.Location = new System.Drawing.Point(329, 168);
            this.txtRegisterLength.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRegisterLength.Name = "txtRegisterLength";
            this.txtRegisterLength.Size = new System.Drawing.Size(169, 29);
            this.txtRegisterLength.TabIndex = 12;
            this.txtRegisterLength.Text = "01";
            // 
            // labRegisterLength
            // 
            this.labRegisterLength.AutoSize = true;
            this.labRegisterLength.Location = new System.Drawing.Point(329, 140);
            this.labRegisterLength.Name = "labRegisterLength";
            this.labRegisterLength.Size = new System.Drawing.Size(164, 18);
            this.labRegisterLength.TabIndex = 11;
            this.labRegisterLength.Text = "Register Length(HEX)";
            // 
            // txtRegisterAddress
            // 
            this.txtRegisterAddress.Location = new System.Drawing.Point(148, 168);
            this.txtRegisterAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRegisterAddress.Name = "txtRegisterAddress";
            this.txtRegisterAddress.Size = new System.Drawing.Size(169, 29);
            this.txtRegisterAddress.TabIndex = 12;
            this.txtRegisterAddress.Text = "01";
            // 
            // labRegisterAddress
            // 
            this.labRegisterAddress.AutoSize = true;
            this.labRegisterAddress.Location = new System.Drawing.Point(148, 140);
            this.labRegisterAddress.Name = "labRegisterAddress";
            this.labRegisterAddress.Size = new System.Drawing.Size(173, 18);
            this.labRegisterAddress.TabIndex = 11;
            this.labRegisterAddress.Text = "Register Address(HEX)";
            // 
            // txtSlaveAddress
            // 
            this.txtSlaveAddress.Location = new System.Drawing.Point(28, 168);
            this.txtSlaveAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSlaveAddress.Name = "txtSlaveAddress";
            this.txtSlaveAddress.Size = new System.Drawing.Size(109, 29);
            this.txtSlaveAddress.TabIndex = 12;
            this.txtSlaveAddress.Text = "01";
            // 
            // labAddress
            // 
            this.labAddress.AutoSize = true;
            this.labAddress.Location = new System.Drawing.Point(28, 140);
            this.labAddress.Name = "labAddress";
            this.labAddress.Size = new System.Drawing.Size(107, 18);
            this.labAddress.TabIndex = 11;
            this.labAddress.Text = "Slave Address";
            // 
            // labFunctionCode
            // 
            this.labFunctionCode.AutoSize = true;
            this.labFunctionCode.Location = new System.Drawing.Point(24, 38);
            this.labFunctionCode.Name = "labFunctionCode";
            this.labFunctionCode.Size = new System.Drawing.Size(107, 18);
            this.labFunctionCode.TabIndex = 11;
            this.labFunctionCode.Text = "Function Code";
            // 
            // comBFunctionCode
            // 
            this.comBFunctionCode.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comBFunctionCode.FormattingEnabled = true;
            this.comBFunctionCode.Items.AddRange(new object[] {
            "01-Read Coil Status",
            "02-Read Input Status",
            "03-Read Holding Registers ",
            "04-Read Input Registers"});
            this.comBFunctionCode.Location = new System.Drawing.Point(28, 64);
            this.comBFunctionCode.Name = "comBFunctionCode";
            this.comBFunctionCode.Size = new System.Drawing.Size(472, 40);
            this.comBFunctionCode.TabIndex = 10;
            this.comBFunctionCode.Text = "01-Read Coil Status";
            // 
            // btnModbusSend_01
            // 
            this.btnModbusSend_01.Location = new System.Drawing.Point(27, 228);
            this.btnModbusSend_01.Name = "btnModbusSend_01";
            this.btnModbusSend_01.Size = new System.Drawing.Size(473, 129);
            this.btnModbusSend_01.TabIndex = 7;
            this.btnModbusSend_01.Text = "Send";
            this.btnModbusSend_01.UseVisualStyleBackColor = true;
            this.btnModbusSend_01.Click += new System.EventHandler(this.btnModbusSend_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1661, 65);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 106);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabCtrMain
            // 
            this.tabCtrMain.Controls.Add(this.tabPage1);
            this.tabCtrMain.Controls.Add(this.tabPage2);
            this.tabCtrMain.Controls.Add(this.tabPage3);
            this.tabCtrMain.Controls.Add(this.tabPage4);
            this.tabCtrMain.Controls.Add(this.tabPage5);
            this.tabCtrMain.Location = new System.Drawing.Point(468, 12);
            this.tabCtrMain.Name = "tabCtrMain";
            this.tabCtrMain.SelectedIndex = 0;
            this.tabCtrMain.Size = new System.Drawing.Size(558, 728);
            this.tabCtrMain.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.GrpBoxModBus_01);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(550, 696);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.GrpBoxModBus_02);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(550, 696);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.GrpBoxModBus_03);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(550, 696);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.GrpBoxModBus_04);
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(550, 696);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 28);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1112, 677);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // GrpBoxModBus_02
            // 
            this.GrpBoxModBus_02.Controls.Add(this.txtRegisterLength_02);
            this.GrpBoxModBus_02.Controls.Add(this.labRegisterLength_02);
            this.GrpBoxModBus_02.Controls.Add(this.txtRegisterAddress_02);
            this.GrpBoxModBus_02.Controls.Add(this.labRegisterAddress_02);
            this.GrpBoxModBus_02.Controls.Add(this.txtSlaveAddress_02);
            this.GrpBoxModBus_02.Controls.Add(this.labAddress_02);
            this.GrpBoxModBus_02.Controls.Add(this.labFunctionCode_02);
            this.GrpBoxModBus_02.Controls.Add(this.comBFunctionCode_02);
            this.GrpBoxModBus_02.Controls.Add(this.btnModbusSend_02);
            this.GrpBoxModBus_02.Location = new System.Drawing.Point(6, 6);
            this.GrpBoxModBus_02.Name = "GrpBoxModBus_02";
            this.GrpBoxModBus_02.Size = new System.Drawing.Size(538, 659);
            this.GrpBoxModBus_02.TabIndex = 10;
            this.GrpBoxModBus_02.TabStop = false;
            this.GrpBoxModBus_02.Text = "Read";
            // 
            // txtRegisterLength_02
            // 
            this.txtRegisterLength_02.Location = new System.Drawing.Point(334, 168);
            this.txtRegisterLength_02.Margin = new System.Windows.Forms.Padding(4);
            this.txtRegisterLength_02.Name = "txtRegisterLength_02";
            this.txtRegisterLength_02.Size = new System.Drawing.Size(169, 29);
            this.txtRegisterLength_02.TabIndex = 12;
            this.txtRegisterLength_02.Text = "01";
            // 
            // labRegisterLength_02
            // 
            this.labRegisterLength_02.AutoSize = true;
            this.labRegisterLength_02.Location = new System.Drawing.Point(334, 140);
            this.labRegisterLength_02.Name = "labRegisterLength_02";
            this.labRegisterLength_02.Size = new System.Drawing.Size(164, 18);
            this.labRegisterLength_02.TabIndex = 11;
            this.labRegisterLength_02.Text = "Register Length(HEX)";
            // 
            // txtRegisterAddress_02
            // 
            this.txtRegisterAddress_02.Location = new System.Drawing.Point(153, 168);
            this.txtRegisterAddress_02.Margin = new System.Windows.Forms.Padding(4);
            this.txtRegisterAddress_02.Name = "txtRegisterAddress_02";
            this.txtRegisterAddress_02.Size = new System.Drawing.Size(169, 29);
            this.txtRegisterAddress_02.TabIndex = 12;
            this.txtRegisterAddress_02.Text = "01";
            // 
            // labRegisterAddress_02
            // 
            this.labRegisterAddress_02.AutoSize = true;
            this.labRegisterAddress_02.Location = new System.Drawing.Point(153, 140);
            this.labRegisterAddress_02.Name = "labRegisterAddress_02";
            this.labRegisterAddress_02.Size = new System.Drawing.Size(173, 18);
            this.labRegisterAddress_02.TabIndex = 11;
            this.labRegisterAddress_02.Text = "Register Address(HEX)";
            // 
            // txtSlaveAddress_02
            // 
            this.txtSlaveAddress_02.Location = new System.Drawing.Point(33, 168);
            this.txtSlaveAddress_02.Margin = new System.Windows.Forms.Padding(4);
            this.txtSlaveAddress_02.Name = "txtSlaveAddress_02";
            this.txtSlaveAddress_02.Size = new System.Drawing.Size(109, 29);
            this.txtSlaveAddress_02.TabIndex = 12;
            this.txtSlaveAddress_02.Text = "01";
            // 
            // labAddress_02
            // 
            this.labAddress_02.AutoSize = true;
            this.labAddress_02.Location = new System.Drawing.Point(33, 140);
            this.labAddress_02.Name = "labAddress_02";
            this.labAddress_02.Size = new System.Drawing.Size(107, 18);
            this.labAddress_02.TabIndex = 11;
            this.labAddress_02.Text = "Slave Address";
            // 
            // labFunctionCode_02
            // 
            this.labFunctionCode_02.AutoSize = true;
            this.labFunctionCode_02.Location = new System.Drawing.Point(29, 38);
            this.labFunctionCode_02.Name = "labFunctionCode_02";
            this.labFunctionCode_02.Size = new System.Drawing.Size(107, 18);
            this.labFunctionCode_02.TabIndex = 11;
            this.labFunctionCode_02.Text = "Function Code";
            // 
            // comBFunctionCode_02
            // 
            this.comBFunctionCode_02.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comBFunctionCode_02.FormattingEnabled = true;
            this.comBFunctionCode_02.Items.AddRange(new object[] {
            "05-Force Single Coil",
            "06-Preset Single Register"});
            this.comBFunctionCode_02.Location = new System.Drawing.Point(33, 64);
            this.comBFunctionCode_02.Name = "comBFunctionCode_02";
            this.comBFunctionCode_02.Size = new System.Drawing.Size(472, 40);
            this.comBFunctionCode_02.TabIndex = 10;
            this.comBFunctionCode_02.Text = "05-Force Single Coil";
            // 
            // btnModbusSend_02
            // 
            this.btnModbusSend_02.Location = new System.Drawing.Point(32, 228);
            this.btnModbusSend_02.Name = "btnModbusSend_02";
            this.btnModbusSend_02.Size = new System.Drawing.Size(473, 129);
            this.btnModbusSend_02.TabIndex = 7;
            this.btnModbusSend_02.Text = "Send";
            this.btnModbusSend_02.UseVisualStyleBackColor = true;
            this.btnModbusSend_02.Click += new System.EventHandler(this.btnModbusSend_Click);
            // 
            // labSend_00
            // 
            this.labSend_00.AutoSize = true;
            this.labSend_00.Location = new System.Drawing.Point(1038, 40);
            this.labSend_00.Name = "labSend_00";
            this.labSend_00.Size = new System.Drawing.Size(41, 18);
            this.labSend_00.TabIndex = 12;
            this.labSend_00.Text = "Send";
            // 
            // labReceived
            // 
            this.labReceived.AutoSize = true;
            this.labReceived.Location = new System.Drawing.Point(1038, 394);
            this.labReceived.Name = "labReceived";
            this.labReceived.Size = new System.Drawing.Size(72, 18);
            this.labReceived.TabIndex = 12;
            this.labReceived.Text = "Received";
            // 
            // GrpBoxModBus_03
            // 
            this.GrpBoxModBus_03.Controls.Add(this.panel_IO_001);
            this.GrpBoxModBus_03.Controls.Add(this.txtRegisterLength_03);
            this.GrpBoxModBus_03.Controls.Add(this.labRegisterLength_03);
            this.GrpBoxModBus_03.Controls.Add(this.txtRegisterAddress_03);
            this.GrpBoxModBus_03.Controls.Add(this.labRegisterAddress_03);
            this.GrpBoxModBus_03.Controls.Add(this.txtSlaveAddress_03);
            this.GrpBoxModBus_03.Controls.Add(this.labAddress_03);
            this.GrpBoxModBus_03.Controls.Add(this.labFunctionCode_03);
            this.GrpBoxModBus_03.Controls.Add(this.comBFunctionCode_03);
            this.GrpBoxModBus_03.Controls.Add(this.btnModbusSend_03);
            this.GrpBoxModBus_03.Location = new System.Drawing.Point(6, 19);
            this.GrpBoxModBus_03.Name = "GrpBoxModBus_03";
            this.GrpBoxModBus_03.Size = new System.Drawing.Size(538, 659);
            this.GrpBoxModBus_03.TabIndex = 12;
            this.GrpBoxModBus_03.TabStop = false;
            this.GrpBoxModBus_03.Text = "Read";
            // 
            // txtRegisterLength_03
            // 
            this.txtRegisterLength_03.Location = new System.Drawing.Point(334, 168);
            this.txtRegisterLength_03.Margin = new System.Windows.Forms.Padding(4);
            this.txtRegisterLength_03.Name = "txtRegisterLength_03";
            this.txtRegisterLength_03.Size = new System.Drawing.Size(169, 29);
            this.txtRegisterLength_03.TabIndex = 12;
            this.txtRegisterLength_03.Text = "01";
            this.txtRegisterLength_03.Visible = false;
            // 
            // labRegisterLength_03
            // 
            this.labRegisterLength_03.AutoSize = true;
            this.labRegisterLength_03.Location = new System.Drawing.Point(334, 140);
            this.labRegisterLength_03.Name = "labRegisterLength_03";
            this.labRegisterLength_03.Size = new System.Drawing.Size(164, 18);
            this.labRegisterLength_03.TabIndex = 11;
            this.labRegisterLength_03.Text = "Register Length(HEX)";
            this.labRegisterLength_03.Visible = false;
            // 
            // txtRegisterAddress_03
            // 
            this.txtRegisterAddress_03.Location = new System.Drawing.Point(153, 168);
            this.txtRegisterAddress_03.Margin = new System.Windows.Forms.Padding(4);
            this.txtRegisterAddress_03.Name = "txtRegisterAddress_03";
            this.txtRegisterAddress_03.Size = new System.Drawing.Size(169, 29);
            this.txtRegisterAddress_03.TabIndex = 12;
            this.txtRegisterAddress_03.Text = "01";
            // 
            // labRegisterAddress_03
            // 
            this.labRegisterAddress_03.AutoSize = true;
            this.labRegisterAddress_03.Location = new System.Drawing.Point(153, 140);
            this.labRegisterAddress_03.Name = "labRegisterAddress_03";
            this.labRegisterAddress_03.Size = new System.Drawing.Size(173, 18);
            this.labRegisterAddress_03.TabIndex = 11;
            this.labRegisterAddress_03.Text = "Register Address(HEX)";
            // 
            // txtSlaveAddress_03
            // 
            this.txtSlaveAddress_03.Location = new System.Drawing.Point(33, 168);
            this.txtSlaveAddress_03.Margin = new System.Windows.Forms.Padding(4);
            this.txtSlaveAddress_03.Name = "txtSlaveAddress_03";
            this.txtSlaveAddress_03.Size = new System.Drawing.Size(109, 29);
            this.txtSlaveAddress_03.TabIndex = 12;
            this.txtSlaveAddress_03.Text = "01";
            // 
            // labAddress_03
            // 
            this.labAddress_03.AutoSize = true;
            this.labAddress_03.Location = new System.Drawing.Point(33, 140);
            this.labAddress_03.Name = "labAddress_03";
            this.labAddress_03.Size = new System.Drawing.Size(107, 18);
            this.labAddress_03.TabIndex = 11;
            this.labAddress_03.Text = "Slave Address";
            // 
            // labFunctionCode_03
            // 
            this.labFunctionCode_03.AutoSize = true;
            this.labFunctionCode_03.Location = new System.Drawing.Point(29, 38);
            this.labFunctionCode_03.Name = "labFunctionCode_03";
            this.labFunctionCode_03.Size = new System.Drawing.Size(107, 18);
            this.labFunctionCode_03.TabIndex = 11;
            this.labFunctionCode_03.Text = "Function Code";
            // 
            // comBFunctionCode_03
            // 
            this.comBFunctionCode_03.Enabled = false;
            this.comBFunctionCode_03.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comBFunctionCode_03.FormattingEnabled = true;
            this.comBFunctionCode_03.Items.AddRange(new object[] {
            "0F-Write Multiple Coils on Modbus"});
            this.comBFunctionCode_03.Location = new System.Drawing.Point(33, 64);
            this.comBFunctionCode_03.Name = "comBFunctionCode_03";
            this.comBFunctionCode_03.Size = new System.Drawing.Size(472, 40);
            this.comBFunctionCode_03.TabIndex = 10;
            this.comBFunctionCode_03.Text = "0F-Write Multiple Coils on Modbus";
            // 
            // btnModbusSend_03
            // 
            this.btnModbusSend_03.Location = new System.Drawing.Point(33, 209);
            this.btnModbusSend_03.Name = "btnModbusSend_03";
            this.btnModbusSend_03.Size = new System.Drawing.Size(473, 85);
            this.btnModbusSend_03.TabIndex = 7;
            this.btnModbusSend_03.Text = "Send";
            this.btnModbusSend_03.UseVisualStyleBackColor = true;
            this.btnModbusSend_03.Click += new System.EventHandler(this.btnModbusSend_03_Click);
            // 
            // chkIO_Y_0_7
            // 
            this.chkIO_Y_0_7.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkIO_Y_0_7.AutoSize = true;
            this.chkIO_Y_0_7.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkIO_Y_0_7.Location = new System.Drawing.Point(3, 311);
            this.chkIO_Y_0_7.Name = "chkIO_Y_0_7";
            this.chkIO_Y_0_7.Size = new System.Drawing.Size(80, 38);
            this.chkIO_Y_0_7.TabIndex = 25;
            this.chkIO_Y_0_7.Text = "Y0_7";
            this.chkIO_Y_0_7.UseVisualStyleBackColor = true;
            // 
            // chkIO_Y_0_6
            // 
            this.chkIO_Y_0_6.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkIO_Y_0_6.AutoSize = true;
            this.chkIO_Y_0_6.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkIO_Y_0_6.Location = new System.Drawing.Point(3, 267);
            this.chkIO_Y_0_6.Name = "chkIO_Y_0_6";
            this.chkIO_Y_0_6.Size = new System.Drawing.Size(80, 38);
            this.chkIO_Y_0_6.TabIndex = 26;
            this.chkIO_Y_0_6.Text = "Y0_6";
            this.chkIO_Y_0_6.UseVisualStyleBackColor = true;
            // 
            // chkIO_Y_0_5
            // 
            this.chkIO_Y_0_5.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkIO_Y_0_5.AutoSize = true;
            this.chkIO_Y_0_5.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkIO_Y_0_5.Location = new System.Drawing.Point(3, 223);
            this.chkIO_Y_0_5.Name = "chkIO_Y_0_5";
            this.chkIO_Y_0_5.Size = new System.Drawing.Size(80, 38);
            this.chkIO_Y_0_5.TabIndex = 24;
            this.chkIO_Y_0_5.Text = "Y0_5";
            this.chkIO_Y_0_5.UseVisualStyleBackColor = true;
            // 
            // chkIO_Y_0_4
            // 
            this.chkIO_Y_0_4.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkIO_Y_0_4.AutoSize = true;
            this.chkIO_Y_0_4.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkIO_Y_0_4.Location = new System.Drawing.Point(3, 179);
            this.chkIO_Y_0_4.Name = "chkIO_Y_0_4";
            this.chkIO_Y_0_4.Size = new System.Drawing.Size(80, 38);
            this.chkIO_Y_0_4.TabIndex = 23;
            this.chkIO_Y_0_4.Text = "Y0_4";
            this.chkIO_Y_0_4.UseVisualStyleBackColor = true;
            // 
            // chkIO_Y_0_3
            // 
            this.chkIO_Y_0_3.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkIO_Y_0_3.AutoSize = true;
            this.chkIO_Y_0_3.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkIO_Y_0_3.Location = new System.Drawing.Point(3, 135);
            this.chkIO_Y_0_3.Name = "chkIO_Y_0_3";
            this.chkIO_Y_0_3.Size = new System.Drawing.Size(80, 38);
            this.chkIO_Y_0_3.TabIndex = 22;
            this.chkIO_Y_0_3.Text = "Y0_3";
            this.chkIO_Y_0_3.UseVisualStyleBackColor = true;
            // 
            // chkIO_Y_0_2
            // 
            this.chkIO_Y_0_2.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkIO_Y_0_2.AutoSize = true;
            this.chkIO_Y_0_2.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkIO_Y_0_2.Location = new System.Drawing.Point(3, 47);
            this.chkIO_Y_0_2.Name = "chkIO_Y_0_2";
            this.chkIO_Y_0_2.Size = new System.Drawing.Size(80, 38);
            this.chkIO_Y_0_2.TabIndex = 21;
            this.chkIO_Y_0_2.Text = "Y0_2";
            this.chkIO_Y_0_2.UseVisualStyleBackColor = true;
            // 
            // chkIO_Y_0_1
            // 
            this.chkIO_Y_0_1.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkIO_Y_0_1.AutoSize = true;
            this.chkIO_Y_0_1.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkIO_Y_0_1.Location = new System.Drawing.Point(3, 91);
            this.chkIO_Y_0_1.Name = "chkIO_Y_0_1";
            this.chkIO_Y_0_1.Size = new System.Drawing.Size(80, 38);
            this.chkIO_Y_0_1.TabIndex = 20;
            this.chkIO_Y_0_1.Text = "Y0_1";
            this.chkIO_Y_0_1.UseVisualStyleBackColor = true;
            // 
            // chkIO_Y_0_0
            // 
            this.chkIO_Y_0_0.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkIO_Y_0_0.AutoSize = true;
            this.chkIO_Y_0_0.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkIO_Y_0_0.Location = new System.Drawing.Point(3, 3);
            this.chkIO_Y_0_0.Name = "chkIO_Y_0_0";
            this.chkIO_Y_0_0.Size = new System.Drawing.Size(80, 38);
            this.chkIO_Y_0_0.TabIndex = 19;
            this.chkIO_Y_0_0.Text = "Y0_0";
            this.chkIO_Y_0_0.UseVisualStyleBackColor = true;
            // 
            // chkIO_Y_1_7
            // 
            this.chkIO_Y_1_7.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkIO_Y_1_7.AutoSize = true;
            this.chkIO_Y_1_7.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkIO_Y_1_7.Location = new System.Drawing.Point(123, 311);
            this.chkIO_Y_1_7.Name = "chkIO_Y_1_7";
            this.chkIO_Y_1_7.Size = new System.Drawing.Size(80, 38);
            this.chkIO_Y_1_7.TabIndex = 33;
            this.chkIO_Y_1_7.Text = "Y1_7";
            this.chkIO_Y_1_7.UseVisualStyleBackColor = true;
            // 
            // chkIO_Y_1_6
            // 
            this.chkIO_Y_1_6.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkIO_Y_1_6.AutoSize = true;
            this.chkIO_Y_1_6.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkIO_Y_1_6.Location = new System.Drawing.Point(123, 267);
            this.chkIO_Y_1_6.Name = "chkIO_Y_1_6";
            this.chkIO_Y_1_6.Size = new System.Drawing.Size(80, 38);
            this.chkIO_Y_1_6.TabIndex = 34;
            this.chkIO_Y_1_6.Text = "Y1_6";
            this.chkIO_Y_1_6.UseVisualStyleBackColor = true;
            // 
            // chkIO_Y_1_5
            // 
            this.chkIO_Y_1_5.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkIO_Y_1_5.AutoSize = true;
            this.chkIO_Y_1_5.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkIO_Y_1_5.Location = new System.Drawing.Point(123, 223);
            this.chkIO_Y_1_5.Name = "chkIO_Y_1_5";
            this.chkIO_Y_1_5.Size = new System.Drawing.Size(80, 38);
            this.chkIO_Y_1_5.TabIndex = 32;
            this.chkIO_Y_1_5.Text = "Y1_5";
            this.chkIO_Y_1_5.UseVisualStyleBackColor = true;
            // 
            // chkIO_Y_1_4
            // 
            this.chkIO_Y_1_4.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkIO_Y_1_4.AutoSize = true;
            this.chkIO_Y_1_4.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkIO_Y_1_4.Location = new System.Drawing.Point(123, 179);
            this.chkIO_Y_1_4.Name = "chkIO_Y_1_4";
            this.chkIO_Y_1_4.Size = new System.Drawing.Size(80, 38);
            this.chkIO_Y_1_4.TabIndex = 31;
            this.chkIO_Y_1_4.Text = "Y1_4";
            this.chkIO_Y_1_4.UseVisualStyleBackColor = true;
            // 
            // chkIO_Y_1_3
            // 
            this.chkIO_Y_1_3.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkIO_Y_1_3.AutoSize = true;
            this.chkIO_Y_1_3.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkIO_Y_1_3.Location = new System.Drawing.Point(123, 135);
            this.chkIO_Y_1_3.Name = "chkIO_Y_1_3";
            this.chkIO_Y_1_3.Size = new System.Drawing.Size(80, 38);
            this.chkIO_Y_1_3.TabIndex = 30;
            this.chkIO_Y_1_3.Text = "Y1_3";
            this.chkIO_Y_1_3.UseVisualStyleBackColor = true;
            // 
            // chkIO_Y_1_2
            // 
            this.chkIO_Y_1_2.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkIO_Y_1_2.AutoSize = true;
            this.chkIO_Y_1_2.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkIO_Y_1_2.Location = new System.Drawing.Point(123, 47);
            this.chkIO_Y_1_2.Name = "chkIO_Y_1_2";
            this.chkIO_Y_1_2.Size = new System.Drawing.Size(80, 38);
            this.chkIO_Y_1_2.TabIndex = 29;
            this.chkIO_Y_1_2.Text = "Y1_2";
            this.chkIO_Y_1_2.UseVisualStyleBackColor = true;
            // 
            // chkIO_Y_1_1
            // 
            this.chkIO_Y_1_1.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkIO_Y_1_1.AutoSize = true;
            this.chkIO_Y_1_1.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkIO_Y_1_1.Location = new System.Drawing.Point(123, 91);
            this.chkIO_Y_1_1.Name = "chkIO_Y_1_1";
            this.chkIO_Y_1_1.Size = new System.Drawing.Size(80, 38);
            this.chkIO_Y_1_1.TabIndex = 28;
            this.chkIO_Y_1_1.Text = "Y1_1";
            this.chkIO_Y_1_1.UseVisualStyleBackColor = true;
            // 
            // chkIO_Y_1_0
            // 
            this.chkIO_Y_1_0.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkIO_Y_1_0.AutoSize = true;
            this.chkIO_Y_1_0.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkIO_Y_1_0.Location = new System.Drawing.Point(123, 3);
            this.chkIO_Y_1_0.Name = "chkIO_Y_1_0";
            this.chkIO_Y_1_0.Size = new System.Drawing.Size(80, 38);
            this.chkIO_Y_1_0.TabIndex = 27;
            this.chkIO_Y_1_0.Text = "Y1_0";
            this.chkIO_Y_1_0.UseVisualStyleBackColor = true;
            // 
            // chkIO_Y_2_7
            // 
            this.chkIO_Y_2_7.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkIO_Y_2_7.AutoSize = true;
            this.chkIO_Y_2_7.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkIO_Y_2_7.Location = new System.Drawing.Point(245, 311);
            this.chkIO_Y_2_7.Name = "chkIO_Y_2_7";
            this.chkIO_Y_2_7.Size = new System.Drawing.Size(80, 38);
            this.chkIO_Y_2_7.TabIndex = 41;
            this.chkIO_Y_2_7.Text = "Y2_7";
            this.chkIO_Y_2_7.UseVisualStyleBackColor = true;
            // 
            // chkIO_Y_2_6
            // 
            this.chkIO_Y_2_6.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkIO_Y_2_6.AutoSize = true;
            this.chkIO_Y_2_6.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkIO_Y_2_6.Location = new System.Drawing.Point(245, 267);
            this.chkIO_Y_2_6.Name = "chkIO_Y_2_6";
            this.chkIO_Y_2_6.Size = new System.Drawing.Size(80, 38);
            this.chkIO_Y_2_6.TabIndex = 42;
            this.chkIO_Y_2_6.Text = "Y2_6";
            this.chkIO_Y_2_6.UseVisualStyleBackColor = true;
            // 
            // chkIO_Y_2_5
            // 
            this.chkIO_Y_2_5.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkIO_Y_2_5.AutoSize = true;
            this.chkIO_Y_2_5.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkIO_Y_2_5.Location = new System.Drawing.Point(245, 223);
            this.chkIO_Y_2_5.Name = "chkIO_Y_2_5";
            this.chkIO_Y_2_5.Size = new System.Drawing.Size(80, 38);
            this.chkIO_Y_2_5.TabIndex = 40;
            this.chkIO_Y_2_5.Text = "Y2_5";
            this.chkIO_Y_2_5.UseVisualStyleBackColor = true;
            // 
            // chkIO_Y_2_4
            // 
            this.chkIO_Y_2_4.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkIO_Y_2_4.AutoSize = true;
            this.chkIO_Y_2_4.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkIO_Y_2_4.Location = new System.Drawing.Point(245, 179);
            this.chkIO_Y_2_4.Name = "chkIO_Y_2_4";
            this.chkIO_Y_2_4.Size = new System.Drawing.Size(80, 38);
            this.chkIO_Y_2_4.TabIndex = 39;
            this.chkIO_Y_2_4.Text = "Y2_4";
            this.chkIO_Y_2_4.UseVisualStyleBackColor = true;
            // 
            // chkIO_Y_2_3
            // 
            this.chkIO_Y_2_3.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkIO_Y_2_3.AutoSize = true;
            this.chkIO_Y_2_3.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkIO_Y_2_3.Location = new System.Drawing.Point(245, 135);
            this.chkIO_Y_2_3.Name = "chkIO_Y_2_3";
            this.chkIO_Y_2_3.Size = new System.Drawing.Size(80, 38);
            this.chkIO_Y_2_3.TabIndex = 38;
            this.chkIO_Y_2_3.Text = "Y2_3";
            this.chkIO_Y_2_3.UseVisualStyleBackColor = true;
            // 
            // chkIO_Y_2_2
            // 
            this.chkIO_Y_2_2.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkIO_Y_2_2.AutoSize = true;
            this.chkIO_Y_2_2.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkIO_Y_2_2.Location = new System.Drawing.Point(245, 47);
            this.chkIO_Y_2_2.Name = "chkIO_Y_2_2";
            this.chkIO_Y_2_2.Size = new System.Drawing.Size(80, 38);
            this.chkIO_Y_2_2.TabIndex = 37;
            this.chkIO_Y_2_2.Text = "Y2_2";
            this.chkIO_Y_2_2.UseVisualStyleBackColor = true;
            // 
            // chkIO_Y_2_1
            // 
            this.chkIO_Y_2_1.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkIO_Y_2_1.AutoSize = true;
            this.chkIO_Y_2_1.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkIO_Y_2_1.Location = new System.Drawing.Point(245, 91);
            this.chkIO_Y_2_1.Name = "chkIO_Y_2_1";
            this.chkIO_Y_2_1.Size = new System.Drawing.Size(80, 38);
            this.chkIO_Y_2_1.TabIndex = 36;
            this.chkIO_Y_2_1.Text = "Y2_1";
            this.chkIO_Y_2_1.UseVisualStyleBackColor = true;
            // 
            // chkIO_Y_2_0
            // 
            this.chkIO_Y_2_0.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkIO_Y_2_0.AutoSize = true;
            this.chkIO_Y_2_0.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkIO_Y_2_0.Location = new System.Drawing.Point(245, 3);
            this.chkIO_Y_2_0.Name = "chkIO_Y_2_0";
            this.chkIO_Y_2_0.Size = new System.Drawing.Size(80, 38);
            this.chkIO_Y_2_0.TabIndex = 35;
            this.chkIO_Y_2_0.Text = "Y2_0";
            this.chkIO_Y_2_0.UseVisualStyleBackColor = true;
            // 
            // chkIO_Y_3_7
            // 
            this.chkIO_Y_3_7.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkIO_Y_3_7.AutoSize = true;
            this.chkIO_Y_3_7.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkIO_Y_3_7.Location = new System.Drawing.Point(372, 311);
            this.chkIO_Y_3_7.Name = "chkIO_Y_3_7";
            this.chkIO_Y_3_7.Size = new System.Drawing.Size(80, 38);
            this.chkIO_Y_3_7.TabIndex = 49;
            this.chkIO_Y_3_7.Text = "Y3_7";
            this.chkIO_Y_3_7.UseVisualStyleBackColor = true;
            // 
            // chkIO_Y_3_6
            // 
            this.chkIO_Y_3_6.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkIO_Y_3_6.AutoSize = true;
            this.chkIO_Y_3_6.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkIO_Y_3_6.Location = new System.Drawing.Point(372, 267);
            this.chkIO_Y_3_6.Name = "chkIO_Y_3_6";
            this.chkIO_Y_3_6.Size = new System.Drawing.Size(80, 38);
            this.chkIO_Y_3_6.TabIndex = 50;
            this.chkIO_Y_3_6.Text = "Y3_6";
            this.chkIO_Y_3_6.UseVisualStyleBackColor = true;
            // 
            // chkIO_Y_3_5
            // 
            this.chkIO_Y_3_5.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkIO_Y_3_5.AutoSize = true;
            this.chkIO_Y_3_5.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkIO_Y_3_5.Location = new System.Drawing.Point(372, 223);
            this.chkIO_Y_3_5.Name = "chkIO_Y_3_5";
            this.chkIO_Y_3_5.Size = new System.Drawing.Size(80, 38);
            this.chkIO_Y_3_5.TabIndex = 48;
            this.chkIO_Y_3_5.Text = "Y3_5";
            this.chkIO_Y_3_5.UseVisualStyleBackColor = true;
            // 
            // chkIO_Y_3_4
            // 
            this.chkIO_Y_3_4.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkIO_Y_3_4.AutoSize = true;
            this.chkIO_Y_3_4.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkIO_Y_3_4.Location = new System.Drawing.Point(372, 179);
            this.chkIO_Y_3_4.Name = "chkIO_Y_3_4";
            this.chkIO_Y_3_4.Size = new System.Drawing.Size(80, 38);
            this.chkIO_Y_3_4.TabIndex = 47;
            this.chkIO_Y_3_4.Text = "Y3_4";
            this.chkIO_Y_3_4.UseVisualStyleBackColor = true;
            // 
            // chkIO_Y_3_3
            // 
            this.chkIO_Y_3_3.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkIO_Y_3_3.AutoSize = true;
            this.chkIO_Y_3_3.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkIO_Y_3_3.Location = new System.Drawing.Point(372, 135);
            this.chkIO_Y_3_3.Name = "chkIO_Y_3_3";
            this.chkIO_Y_3_3.Size = new System.Drawing.Size(80, 38);
            this.chkIO_Y_3_3.TabIndex = 46;
            this.chkIO_Y_3_3.Text = "Y3_3";
            this.chkIO_Y_3_3.UseVisualStyleBackColor = true;
            // 
            // chkIO_Y_3_2
            // 
            this.chkIO_Y_3_2.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkIO_Y_3_2.AutoSize = true;
            this.chkIO_Y_3_2.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkIO_Y_3_2.Location = new System.Drawing.Point(372, 47);
            this.chkIO_Y_3_2.Name = "chkIO_Y_3_2";
            this.chkIO_Y_3_2.Size = new System.Drawing.Size(80, 38);
            this.chkIO_Y_3_2.TabIndex = 45;
            this.chkIO_Y_3_2.Text = "Y3_2";
            this.chkIO_Y_3_2.UseVisualStyleBackColor = true;
            // 
            // chkIO_Y_3_1
            // 
            this.chkIO_Y_3_1.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkIO_Y_3_1.AutoSize = true;
            this.chkIO_Y_3_1.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkIO_Y_3_1.Location = new System.Drawing.Point(372, 91);
            this.chkIO_Y_3_1.Name = "chkIO_Y_3_1";
            this.chkIO_Y_3_1.Size = new System.Drawing.Size(80, 38);
            this.chkIO_Y_3_1.TabIndex = 44;
            this.chkIO_Y_3_1.Text = "Y3_1";
            this.chkIO_Y_3_1.UseVisualStyleBackColor = true;
            // 
            // chkIO_Y_3_0
            // 
            this.chkIO_Y_3_0.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkIO_Y_3_0.AutoSize = true;
            this.chkIO_Y_3_0.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkIO_Y_3_0.Location = new System.Drawing.Point(372, 3);
            this.chkIO_Y_3_0.Name = "chkIO_Y_3_0";
            this.chkIO_Y_3_0.Size = new System.Drawing.Size(80, 38);
            this.chkIO_Y_3_0.TabIndex = 43;
            this.chkIO_Y_3_0.Text = "Y3_0";
            this.chkIO_Y_3_0.UseVisualStyleBackColor = true;
            // 
            // panel_IO_001
            // 
            this.panel_IO_001.Controls.Add(this.chkIO_Y_3_7);
            this.panel_IO_001.Controls.Add(this.chkIO_Y_0_0);
            this.panel_IO_001.Controls.Add(this.chkIO_Y_3_6);
            this.panel_IO_001.Controls.Add(this.chkIO_Y_0_1);
            this.panel_IO_001.Controls.Add(this.chkIO_Y_3_5);
            this.panel_IO_001.Controls.Add(this.chkIO_Y_0_2);
            this.panel_IO_001.Controls.Add(this.chkIO_Y_3_4);
            this.panel_IO_001.Controls.Add(this.chkIO_Y_0_3);
            this.panel_IO_001.Controls.Add(this.chkIO_Y_3_3);
            this.panel_IO_001.Controls.Add(this.chkIO_Y_0_4);
            this.panel_IO_001.Controls.Add(this.chkIO_Y_3_2);
            this.panel_IO_001.Controls.Add(this.chkIO_Y_0_5);
            this.panel_IO_001.Controls.Add(this.chkIO_Y_3_1);
            this.panel_IO_001.Controls.Add(this.chkIO_Y_0_6);
            this.panel_IO_001.Controls.Add(this.chkIO_Y_3_0);
            this.panel_IO_001.Controls.Add(this.chkIO_Y_0_7);
            this.panel_IO_001.Controls.Add(this.chkIO_Y_2_7);
            this.panel_IO_001.Controls.Add(this.chkIO_Y_1_0);
            this.panel_IO_001.Controls.Add(this.chkIO_Y_2_6);
            this.panel_IO_001.Controls.Add(this.chkIO_Y_1_1);
            this.panel_IO_001.Controls.Add(this.chkIO_Y_2_5);
            this.panel_IO_001.Controls.Add(this.chkIO_Y_1_2);
            this.panel_IO_001.Controls.Add(this.chkIO_Y_2_4);
            this.panel_IO_001.Controls.Add(this.chkIO_Y_1_3);
            this.panel_IO_001.Controls.Add(this.chkIO_Y_2_3);
            this.panel_IO_001.Controls.Add(this.chkIO_Y_1_4);
            this.panel_IO_001.Controls.Add(this.chkIO_Y_2_2);
            this.panel_IO_001.Controls.Add(this.chkIO_Y_1_5);
            this.panel_IO_001.Controls.Add(this.chkIO_Y_2_1);
            this.panel_IO_001.Controls.Add(this.chkIO_Y_1_6);
            this.panel_IO_001.Controls.Add(this.chkIO_Y_2_0);
            this.panel_IO_001.Controls.Add(this.chkIO_Y_1_7);
            this.panel_IO_001.Location = new System.Drawing.Point(32, 300);
            this.panel_IO_001.Name = "panel_IO_001";
            this.panel_IO_001.Size = new System.Drawing.Size(459, 359);
            this.panel_IO_001.TabIndex = 13;
            // 
            // GrpBoxModBus_04
            // 
            this.GrpBoxModBus_04.Controls.Add(this.dataGridView1);
            this.GrpBoxModBus_04.Controls.Add(this.txtRegisterLength_04);
            this.GrpBoxModBus_04.Controls.Add(this.labRegisterLength_04);
            this.GrpBoxModBus_04.Controls.Add(this.txtRegisterAddress_04);
            this.GrpBoxModBus_04.Controls.Add(this.labRegisterAddress_04);
            this.GrpBoxModBus_04.Controls.Add(this.txtSlaveAddress_04);
            this.GrpBoxModBus_04.Controls.Add(this.labAddress_04);
            this.GrpBoxModBus_04.Controls.Add(this.labFunctionCode_04);
            this.GrpBoxModBus_04.Controls.Add(this.comBFunctionCode_04);
            this.GrpBoxModBus_04.Controls.Add(this.btnModbusSend_04);
            this.GrpBoxModBus_04.Location = new System.Drawing.Point(3, 3);
            this.GrpBoxModBus_04.Name = "GrpBoxModBus_04";
            this.GrpBoxModBus_04.Size = new System.Drawing.Size(538, 677);
            this.GrpBoxModBus_04.TabIndex = 12;
            this.GrpBoxModBus_04.TabStop = false;
            this.GrpBoxModBus_04.Text = "Read";
            // 
            // txtRegisterLength_04
            // 
            this.txtRegisterLength_04.Location = new System.Drawing.Point(334, 168);
            this.txtRegisterLength_04.Margin = new System.Windows.Forms.Padding(4);
            this.txtRegisterLength_04.Name = "txtRegisterLength_04";
            this.txtRegisterLength_04.Size = new System.Drawing.Size(169, 29);
            this.txtRegisterLength_04.TabIndex = 12;
            this.txtRegisterLength_04.Text = "01";
            // 
            // labRegisterLength_04
            // 
            this.labRegisterLength_04.AutoSize = true;
            this.labRegisterLength_04.Location = new System.Drawing.Point(334, 140);
            this.labRegisterLength_04.Name = "labRegisterLength_04";
            this.labRegisterLength_04.Size = new System.Drawing.Size(164, 18);
            this.labRegisterLength_04.TabIndex = 11;
            this.labRegisterLength_04.Text = "Register Length(HEX)";
            // 
            // txtRegisterAddress_04
            // 
            this.txtRegisterAddress_04.Location = new System.Drawing.Point(153, 168);
            this.txtRegisterAddress_04.Margin = new System.Windows.Forms.Padding(4);
            this.txtRegisterAddress_04.Name = "txtRegisterAddress_04";
            this.txtRegisterAddress_04.Size = new System.Drawing.Size(169, 29);
            this.txtRegisterAddress_04.TabIndex = 12;
            this.txtRegisterAddress_04.Text = "01";
            // 
            // labRegisterAddress_04
            // 
            this.labRegisterAddress_04.AutoSize = true;
            this.labRegisterAddress_04.Location = new System.Drawing.Point(153, 140);
            this.labRegisterAddress_04.Name = "labRegisterAddress_04";
            this.labRegisterAddress_04.Size = new System.Drawing.Size(173, 18);
            this.labRegisterAddress_04.TabIndex = 11;
            this.labRegisterAddress_04.Text = "Register Address(HEX)";
            // 
            // txtSlaveAddress_04
            // 
            this.txtSlaveAddress_04.Location = new System.Drawing.Point(33, 168);
            this.txtSlaveAddress_04.Margin = new System.Windows.Forms.Padding(4);
            this.txtSlaveAddress_04.Name = "txtSlaveAddress_04";
            this.txtSlaveAddress_04.Size = new System.Drawing.Size(109, 29);
            this.txtSlaveAddress_04.TabIndex = 12;
            this.txtSlaveAddress_04.Text = "01";
            // 
            // labAddress_04
            // 
            this.labAddress_04.AutoSize = true;
            this.labAddress_04.Location = new System.Drawing.Point(33, 140);
            this.labAddress_04.Name = "labAddress_04";
            this.labAddress_04.Size = new System.Drawing.Size(107, 18);
            this.labAddress_04.TabIndex = 11;
            this.labAddress_04.Text = "Slave Address";
            // 
            // labFunctionCode_04
            // 
            this.labFunctionCode_04.AutoSize = true;
            this.labFunctionCode_04.Location = new System.Drawing.Point(29, 38);
            this.labFunctionCode_04.Name = "labFunctionCode_04";
            this.labFunctionCode_04.Size = new System.Drawing.Size(107, 18);
            this.labFunctionCode_04.TabIndex = 11;
            this.labFunctionCode_04.Text = "Function Code";
            // 
            // comBFunctionCode_04
            // 
            this.comBFunctionCode_04.Enabled = false;
            this.comBFunctionCode_04.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comBFunctionCode_04.FormattingEnabled = true;
            this.comBFunctionCode_04.Items.AddRange(new object[] {
            "05-Force Single Coil",
            "06-Preset Single Register"});
            this.comBFunctionCode_04.Location = new System.Drawing.Point(33, 64);
            this.comBFunctionCode_04.Name = "comBFunctionCode_04";
            this.comBFunctionCode_04.Size = new System.Drawing.Size(472, 40);
            this.comBFunctionCode_04.TabIndex = 10;
            this.comBFunctionCode_04.Text = "10-Preset Multiple Registers";
            // 
            // btnModbusSend_04
            // 
            this.btnModbusSend_04.Location = new System.Drawing.Point(281, 228);
            this.btnModbusSend_04.Name = "btnModbusSend_04";
            this.btnModbusSend_04.Size = new System.Drawing.Size(224, 433);
            this.btnModbusSend_04.TabIndex = 7;
            this.btnModbusSend_04.Text = "Send";
            this.btnModbusSend_04.UseVisualStyleBackColor = true;
            this.btnModbusSend_04.Click += new System.EventHandler(this.btnModbusSend_04_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Value});
            this.dataGridView1.Location = new System.Drawing.Point(32, 228);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(223, 433);
            this.dataGridView1.TabIndex = 13;
            // 
            // Value
            // 
            this.Value.HeaderText = "Value(Hex)";
            this.Value.MinimumWidth = 8;
            this.Value.Name = "Value";
            this.Value.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1842, 755);
            this.Controls.Add(this.labReceived);
            this.Controls.Add(this.labSend_00);
            this.Controls.Add(this.tabCtrMain);
            this.Controls.Add(this.button1);
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
            this.GrpBoxModBus_01.ResumeLayout(false);
            this.GrpBoxModBus_01.PerformLayout();
            this.tabCtrMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.GrpBoxModBus_02.ResumeLayout(false);
            this.GrpBoxModBus_02.PerformLayout();
            this.GrpBoxModBus_03.ResumeLayout(false);
            this.GrpBoxModBus_03.PerformLayout();
            this.panel_IO_001.ResumeLayout(false);
            this.panel_IO_001.PerformLayout();
            this.GrpBoxModBus_04.ResumeLayout(false);
            this.GrpBoxModBus_04.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.GroupBox GrpBoxModBus_01;
        private System.Windows.Forms.Button btnModbusSend_01;
        private System.Windows.Forms.Label labFunctionCode;
        private System.Windows.Forms.ComboBox comBFunctionCode;
        private System.Windows.Forms.TextBox txtRegisterLength;
        private System.Windows.Forms.Label labRegisterLength;
        private System.Windows.Forms.TextBox txtRegisterAddress;
        private System.Windows.Forms.Label labRegisterAddress;
        private System.Windows.Forms.TextBox txtSlaveAddress;
        private System.Windows.Forms.Label labAddress;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabCtrMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox GrpBoxModBus_02;
        private System.Windows.Forms.TextBox txtRegisterLength_02;
        private System.Windows.Forms.Label labRegisterLength_02;
        private System.Windows.Forms.TextBox txtRegisterAddress_02;
        private System.Windows.Forms.Label labRegisterAddress_02;
        private System.Windows.Forms.TextBox txtSlaveAddress_02;
        private System.Windows.Forms.Label labAddress_02;
        private System.Windows.Forms.Label labFunctionCode_02;
        private System.Windows.Forms.ComboBox comBFunctionCode_02;
        private System.Windows.Forms.Button btnModbusSend_02;
        private System.Windows.Forms.Label labSend_00;
        private System.Windows.Forms.Label labReceived;
        private System.Windows.Forms.GroupBox GrpBoxModBus_03;
        private System.Windows.Forms.TextBox txtRegisterLength_03;
        private System.Windows.Forms.Label labRegisterLength_03;
        private System.Windows.Forms.TextBox txtRegisterAddress_03;
        private System.Windows.Forms.Label labRegisterAddress_03;
        private System.Windows.Forms.TextBox txtSlaveAddress_03;
        private System.Windows.Forms.Label labAddress_03;
        private System.Windows.Forms.Label labFunctionCode_03;
        private System.Windows.Forms.ComboBox comBFunctionCode_03;
        private System.Windows.Forms.Button btnModbusSend_03;
        private System.Windows.Forms.CheckBox chkIO_Y_0_7;
        private System.Windows.Forms.CheckBox chkIO_Y_0_6;
        private System.Windows.Forms.CheckBox chkIO_Y_0_5;
        private System.Windows.Forms.CheckBox chkIO_Y_0_4;
        private System.Windows.Forms.CheckBox chkIO_Y_0_3;
        private System.Windows.Forms.CheckBox chkIO_Y_0_2;
        private System.Windows.Forms.CheckBox chkIO_Y_0_1;
        private System.Windows.Forms.CheckBox chkIO_Y_0_0;
        private System.Windows.Forms.CheckBox chkIO_Y_1_7;
        private System.Windows.Forms.CheckBox chkIO_Y_1_6;
        private System.Windows.Forms.CheckBox chkIO_Y_1_5;
        private System.Windows.Forms.CheckBox chkIO_Y_1_4;
        private System.Windows.Forms.CheckBox chkIO_Y_1_3;
        private System.Windows.Forms.CheckBox chkIO_Y_1_2;
        private System.Windows.Forms.CheckBox chkIO_Y_1_1;
        private System.Windows.Forms.CheckBox chkIO_Y_1_0;
        private System.Windows.Forms.CheckBox chkIO_Y_2_7;
        private System.Windows.Forms.CheckBox chkIO_Y_2_6;
        private System.Windows.Forms.CheckBox chkIO_Y_2_5;
        private System.Windows.Forms.CheckBox chkIO_Y_2_4;
        private System.Windows.Forms.CheckBox chkIO_Y_2_3;
        private System.Windows.Forms.CheckBox chkIO_Y_2_2;
        private System.Windows.Forms.CheckBox chkIO_Y_2_1;
        private System.Windows.Forms.CheckBox chkIO_Y_2_0;
        private System.Windows.Forms.Panel panel_IO_001;
        private System.Windows.Forms.CheckBox chkIO_Y_3_7;
        private System.Windows.Forms.CheckBox chkIO_Y_3_6;
        private System.Windows.Forms.CheckBox chkIO_Y_3_5;
        private System.Windows.Forms.CheckBox chkIO_Y_3_4;
        private System.Windows.Forms.CheckBox chkIO_Y_3_3;
        private System.Windows.Forms.CheckBox chkIO_Y_3_2;
        private System.Windows.Forms.CheckBox chkIO_Y_3_1;
        private System.Windows.Forms.CheckBox chkIO_Y_3_0;
        private System.Windows.Forms.GroupBox GrpBoxModBus_04;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtRegisterLength_04;
        private System.Windows.Forms.Label labRegisterLength_04;
        private System.Windows.Forms.TextBox txtRegisterAddress_04;
        private System.Windows.Forms.Label labRegisterAddress_04;
        private System.Windows.Forms.TextBox txtSlaveAddress_04;
        private System.Windows.Forms.Label labAddress_04;
        private System.Windows.Forms.Label labFunctionCode_04;
        private System.Windows.Forms.ComboBox comBFunctionCode_04;
        private System.Windows.Forms.Button btnModbusSend_04;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
    }
}

