namespace Modbus
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
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
            this.chkIO_Y_3_0 = new System.Windows.Forms.CheckBox();
            this.chkIO_Y_3_1 = new System.Windows.Forms.CheckBox();
            this.chkIO_Y_3_2 = new System.Windows.Forms.CheckBox();
            this.chkIO_Y_3_3 = new System.Windows.Forms.CheckBox();
            this.chkIO_Y_3_4 = new System.Windows.Forms.CheckBox();
            this.chkIO_Y_3_5 = new System.Windows.Forms.CheckBox();
            this.chkIO_Y_3_6 = new System.Windows.Forms.CheckBox();
            this.chkIO_Y_3_7 = new System.Windows.Forms.CheckBox();
            this.GrpBoxModBus_04.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpBoxModBus_04
            // 
            this.GrpBoxModBus_04.Controls.Add(this.txtRegisterLength_04);
            this.GrpBoxModBus_04.Controls.Add(this.labRegisterLength_04);
            this.GrpBoxModBus_04.Controls.Add(this.txtRegisterAddress_04);
            this.GrpBoxModBus_04.Controls.Add(this.labRegisterAddress_04);
            this.GrpBoxModBus_04.Controls.Add(this.txtSlaveAddress_04);
            this.GrpBoxModBus_04.Controls.Add(this.labAddress_04);
            this.GrpBoxModBus_04.Controls.Add(this.labFunctionCode_04);
            this.GrpBoxModBus_04.Controls.Add(this.comBFunctionCode_04);
            this.GrpBoxModBus_04.Controls.Add(this.btnModbusSend_04);
            this.GrpBoxModBus_04.Location = new System.Drawing.Point(67, 115);
            this.GrpBoxModBus_04.Name = "GrpBoxModBus_04";
            this.GrpBoxModBus_04.Size = new System.Drawing.Size(538, 381);
            this.GrpBoxModBus_04.TabIndex = 11;
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
            this.comBFunctionCode_04.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comBFunctionCode_04.FormattingEnabled = true;
            this.comBFunctionCode_04.Items.AddRange(new object[] {
            "05-Force Single Coil",
            "06-Preset Single Register"});
            this.comBFunctionCode_04.Location = new System.Drawing.Point(33, 64);
            this.comBFunctionCode_04.Name = "comBFunctionCode_04";
            this.comBFunctionCode_04.Size = new System.Drawing.Size(472, 40);
            this.comBFunctionCode_04.TabIndex = 10;
            this.comBFunctionCode_04.Text = "05-Force Single Coil";
            // 
            // btnModbusSend_04
            // 
            this.btnModbusSend_04.Location = new System.Drawing.Point(32, 228);
            this.btnModbusSend_04.Name = "btnModbusSend_04";
            this.btnModbusSend_04.Size = new System.Drawing.Size(473, 129);
            this.btnModbusSend_04.TabIndex = 7;
            this.btnModbusSend_04.Text = "Send";
            this.btnModbusSend_04.UseVisualStyleBackColor = true;
            // 
            // chkIO_Y_3_0
            // 
            this.chkIO_Y_3_0.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkIO_Y_3_0.AutoSize = true;
            this.chkIO_Y_3_0.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkIO_Y_3_0.Location = new System.Drawing.Point(926, 274);
            this.chkIO_Y_3_0.Name = "chkIO_Y_3_0";
            this.chkIO_Y_3_0.Size = new System.Drawing.Size(80, 38);
            this.chkIO_Y_3_0.TabIndex = 12;
            this.chkIO_Y_3_0.Text = "Y3_0";
            this.chkIO_Y_3_0.UseVisualStyleBackColor = true;
            // 
            // chkIO_Y_3_1
            // 
            this.chkIO_Y_3_1.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkIO_Y_3_1.AutoSize = true;
            this.chkIO_Y_3_1.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkIO_Y_3_1.Location = new System.Drawing.Point(926, 362);
            this.chkIO_Y_3_1.Name = "chkIO_Y_3_1";
            this.chkIO_Y_3_1.Size = new System.Drawing.Size(80, 38);
            this.chkIO_Y_3_1.TabIndex = 13;
            this.chkIO_Y_3_1.Text = "Y3_1";
            this.chkIO_Y_3_1.UseVisualStyleBackColor = true;
            // 
            // chkIO_Y_3_2
            // 
            this.chkIO_Y_3_2.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkIO_Y_3_2.AutoSize = true;
            this.chkIO_Y_3_2.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkIO_Y_3_2.Location = new System.Drawing.Point(926, 318);
            this.chkIO_Y_3_2.Name = "chkIO_Y_3_2";
            this.chkIO_Y_3_2.Size = new System.Drawing.Size(80, 38);
            this.chkIO_Y_3_2.TabIndex = 14;
            this.chkIO_Y_3_2.Text = "Y3_2";
            this.chkIO_Y_3_2.UseVisualStyleBackColor = true;
            // 
            // chkIO_Y_3_3
            // 
            this.chkIO_Y_3_3.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkIO_Y_3_3.AutoSize = true;
            this.chkIO_Y_3_3.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkIO_Y_3_3.Location = new System.Drawing.Point(926, 406);
            this.chkIO_Y_3_3.Name = "chkIO_Y_3_3";
            this.chkIO_Y_3_3.Size = new System.Drawing.Size(80, 38);
            this.chkIO_Y_3_3.TabIndex = 15;
            this.chkIO_Y_3_3.Text = "Y3_3";
            this.chkIO_Y_3_3.UseVisualStyleBackColor = true;
            // 
            // chkIO_Y_3_4
            // 
            this.chkIO_Y_3_4.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkIO_Y_3_4.AutoSize = true;
            this.chkIO_Y_3_4.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkIO_Y_3_4.Location = new System.Drawing.Point(926, 450);
            this.chkIO_Y_3_4.Name = "chkIO_Y_3_4";
            this.chkIO_Y_3_4.Size = new System.Drawing.Size(80, 38);
            this.chkIO_Y_3_4.TabIndex = 16;
            this.chkIO_Y_3_4.Text = "Y3_4";
            this.chkIO_Y_3_4.UseVisualStyleBackColor = true;
            // 
            // chkIO_Y_3_5
            // 
            this.chkIO_Y_3_5.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkIO_Y_3_5.AutoSize = true;
            this.chkIO_Y_3_5.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkIO_Y_3_5.Location = new System.Drawing.Point(926, 494);
            this.chkIO_Y_3_5.Name = "chkIO_Y_3_5";
            this.chkIO_Y_3_5.Size = new System.Drawing.Size(80, 38);
            this.chkIO_Y_3_5.TabIndex = 17;
            this.chkIO_Y_3_5.Text = "Y3_5";
            this.chkIO_Y_3_5.UseVisualStyleBackColor = true;
            // 
            // chkIO_Y_3_6
            // 
            this.chkIO_Y_3_6.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkIO_Y_3_6.AutoSize = true;
            this.chkIO_Y_3_6.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkIO_Y_3_6.Location = new System.Drawing.Point(926, 538);
            this.chkIO_Y_3_6.Name = "chkIO_Y_3_6";
            this.chkIO_Y_3_6.Size = new System.Drawing.Size(80, 38);
            this.chkIO_Y_3_6.TabIndex = 18;
            this.chkIO_Y_3_6.Text = "Y3_6";
            this.chkIO_Y_3_6.UseVisualStyleBackColor = true;
            // 
            // chkIO_Y_3_7
            // 
            this.chkIO_Y_3_7.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkIO_Y_3_7.AutoSize = true;
            this.chkIO_Y_3_7.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkIO_Y_3_7.Location = new System.Drawing.Point(926, 582);
            this.chkIO_Y_3_7.Name = "chkIO_Y_3_7";
            this.chkIO_Y_3_7.Size = new System.Drawing.Size(80, 38);
            this.chkIO_Y_3_7.TabIndex = 18;
            this.chkIO_Y_3_7.Text = "Y3_7";
            this.chkIO_Y_3_7.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1545, 1137);
            this.Controls.Add(this.chkIO_Y_3_7);
            this.Controls.Add(this.chkIO_Y_3_6);
            this.Controls.Add(this.chkIO_Y_3_5);
            this.Controls.Add(this.chkIO_Y_3_4);
            this.Controls.Add(this.chkIO_Y_3_3);
            this.Controls.Add(this.chkIO_Y_3_2);
            this.Controls.Add(this.chkIO_Y_3_1);
            this.Controls.Add(this.chkIO_Y_3_0);
            this.Controls.Add(this.GrpBoxModBus_04);
            this.Name = "Form2";
            this.Text = "Form2";
            this.GrpBoxModBus_04.ResumeLayout(false);
            this.GrpBoxModBus_04.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpBoxModBus_04;
        private System.Windows.Forms.TextBox txtRegisterLength_04;
        private System.Windows.Forms.Label labRegisterLength_04;
        private System.Windows.Forms.TextBox txtRegisterAddress_04;
        private System.Windows.Forms.Label labRegisterAddress_04;
        private System.Windows.Forms.TextBox txtSlaveAddress_04;
        private System.Windows.Forms.Label labAddress_04;
        private System.Windows.Forms.Label labFunctionCode_04;
        private System.Windows.Forms.ComboBox comBFunctionCode_04;
        private System.Windows.Forms.Button btnModbusSend_04;
        private System.Windows.Forms.CheckBox chkIO_Y_3_0;
        private System.Windows.Forms.CheckBox chkIO_Y_3_1;
        private System.Windows.Forms.CheckBox chkIO_Y_3_2;
        private System.Windows.Forms.CheckBox chkIO_Y_3_3;
        private System.Windows.Forms.CheckBox chkIO_Y_3_4;
        private System.Windows.Forms.CheckBox chkIO_Y_3_5;
        private System.Windows.Forms.CheckBox chkIO_Y_3_6;
        private System.Windows.Forms.CheckBox chkIO_Y_3_7;
    }
}