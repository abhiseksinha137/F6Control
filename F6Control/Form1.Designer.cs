namespace F6Control
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblShutter = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShutterClose = new System.Windows.Forms.Button();
            this.btnShutterOpen = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbxDelay = new System.Windows.Forms.TextBox();
            this.btnStageRight = new System.Windows.Forms.Button();
            this.btnStageLeft = new System.Windows.Forms.Button();
            this.btnStageBack = new System.Windows.Forms.Button();
            this.btnStageFwd = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCam2Stop = new System.Windows.Forms.Button();
            this.cmbxCam2 = new System.Windows.Forms.ComboBox();
            this.picCam2 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblGeigerData = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnCam1Stop = new System.Windows.Forms.Button();
            this.cmbxCam1 = new System.Windows.Forms.ComboBox();
            this.picCam1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbxLog = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.commGeiger = new customControl.comboSerial();
            this.connStage = new customControl.comboSerial();
            this.conn3 = new customControl.comboSerial();
            this.connShutter = new customControl.comboSerial();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCam2)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCam1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblShutter);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnShutterClose);
            this.panel1.Controls.Add(this.btnShutterOpen);
            this.panel1.Controls.Add(this.connShutter);
            this.panel1.Location = new System.Drawing.Point(12, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 176);
            this.panel1.TabIndex = 0;
            // 
            // lblShutter
            // 
            this.lblShutter.AutoSize = true;
            this.lblShutter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShutter.ForeColor = System.Drawing.Color.Black;
            this.lblShutter.Location = new System.Drawing.Point(203, 125);
            this.lblShutter.Name = "lblShutter";
            this.lblShutter.Size = new System.Drawing.Size(14, 18);
            this.lblShutter.TabIndex = 4;
            this.lblShutter.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Shutter is : ";
            // 
            // btnShutterClose
            // 
            this.btnShutterClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShutterClose.Location = new System.Drawing.Point(216, 71);
            this.btnShutterClose.Name = "btnShutterClose";
            this.btnShutterClose.Size = new System.Drawing.Size(75, 31);
            this.btnShutterClose.TabIndex = 2;
            this.btnShutterClose.Text = "Close";
            this.btnShutterClose.UseVisualStyleBackColor = true;
            this.btnShutterClose.Click += new System.EventHandler(this.btnShutterClose_Click);
            // 
            // btnShutterOpen
            // 
            this.btnShutterOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShutterOpen.Location = new System.Drawing.Point(120, 71);
            this.btnShutterOpen.Name = "btnShutterOpen";
            this.btnShutterOpen.Size = new System.Drawing.Size(75, 31);
            this.btnShutterOpen.TabIndex = 1;
            this.btnShutterOpen.Text = "Open";
            this.btnShutterOpen.UseVisualStyleBackColor = true;
            this.btnShutterOpen.Click += new System.EventHandler(this.btnShutterOpen_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.conn3);
            this.panel2.Location = new System.Drawing.Point(1026, 333);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 176);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtbxDelay);
            this.panel3.Controls.Add(this.btnStageRight);
            this.panel3.Controls.Add(this.btnStageLeft);
            this.panel3.Controls.Add(this.btnStageBack);
            this.panel3.Controls.Add(this.btnStageFwd);
            this.panel3.Controls.Add(this.connStage);
            this.panel3.Location = new System.Drawing.Point(523, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(348, 176);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Delay";
            // 
            // txtbxDelay
            // 
            this.txtbxDelay.Location = new System.Drawing.Point(3, 147);
            this.txtbxDelay.Name = "txtbxDelay";
            this.txtbxDelay.Size = new System.Drawing.Size(77, 20);
            this.txtbxDelay.TabIndex = 6;
            this.txtbxDelay.TextChanged += new System.EventHandler(this.txtbxDelay_TextChanged);
            // 
            // btnStageRight
            // 
            this.btnStageRight.Image = global::F6Control.Properties.Resources.right;
            this.btnStageRight.Location = new System.Drawing.Point(220, 71);
            this.btnStageRight.Name = "btnStageRight";
            this.btnStageRight.Size = new System.Drawing.Size(75, 34);
            this.btnStageRight.TabIndex = 5;
            this.btnStageRight.Tag = "R";
            this.btnStageRight.UseVisualStyleBackColor = true;
            this.btnStageRight.Click += new System.EventHandler(this.btnStage_Click);
            this.btnStageRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnStageRight_MouseDown);
            this.btnStageRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnStage_MouseUp);
            // 
            // btnStageLeft
            // 
            this.btnStageLeft.Image = global::F6Control.Properties.Resources.left;
            this.btnStageLeft.Location = new System.Drawing.Point(96, 71);
            this.btnStageLeft.Name = "btnStageLeft";
            this.btnStageLeft.Size = new System.Drawing.Size(75, 34);
            this.btnStageLeft.TabIndex = 4;
            this.btnStageLeft.Tag = "L";
            this.btnStageLeft.UseVisualStyleBackColor = true;
            this.btnStageLeft.Click += new System.EventHandler(this.btnStage_Click);
            this.btnStageLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnStageLeft_MouseDown);
            this.btnStageLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnStage_MouseUp);
            // 
            // btnStageBack
            // 
            this.btnStageBack.Image = global::F6Control.Properties.Resources.down;
            this.btnStageBack.Location = new System.Drawing.Point(177, 102);
            this.btnStageBack.Name = "btnStageBack";
            this.btnStageBack.Size = new System.Drawing.Size(37, 65);
            this.btnStageBack.TabIndex = 3;
            this.btnStageBack.Tag = "D";
            this.btnStageBack.UseVisualStyleBackColor = true;
            this.btnStageBack.Click += new System.EventHandler(this.btnStage_Click);
            this.btnStageBack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnStageBack_MouseDown);
            this.btnStageBack.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnStage_MouseUp);
            // 
            // btnStageFwd
            // 
            this.btnStageFwd.Image = global::F6Control.Properties.Resources.up;
            this.btnStageFwd.Location = new System.Drawing.Point(177, 12);
            this.btnStageFwd.Name = "btnStageFwd";
            this.btnStageFwd.Size = new System.Drawing.Size(37, 65);
            this.btnStageFwd.TabIndex = 2;
            this.btnStageFwd.Tag = "F";
            this.btnStageFwd.UseVisualStyleBackColor = true;
            this.btnStageFwd.Click += new System.EventHandler(this.btnStage_Click);
            this.btnStageFwd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnStageFwd_MouseDown);
            this.btnStageFwd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnStage_MouseUp);
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnCam2Stop);
            this.panel4.Controls.Add(this.cmbxCam2);
            this.panel4.Controls.Add(this.picCam2);
            this.panel4.Location = new System.Drawing.Point(516, 333);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(480, 314);
            this.panel4.TabIndex = 4;
            // 
            // btnCam2Stop
            // 
            this.btnCam2Stop.Location = new System.Drawing.Point(139, 1);
            this.btnCam2Stop.Name = "btnCam2Stop";
            this.btnCam2Stop.Size = new System.Drawing.Size(75, 23);
            this.btnCam2Stop.TabIndex = 6;
            this.btnCam2Stop.Text = "Stop";
            this.btnCam2Stop.UseVisualStyleBackColor = true;
            this.btnCam2Stop.Click += new System.EventHandler(this.btnCam2Stop_Click);
            // 
            // cmbxCam2
            // 
            this.cmbxCam2.FormattingEnabled = true;
            this.cmbxCam2.Location = new System.Drawing.Point(3, 3);
            this.cmbxCam2.Name = "cmbxCam2";
            this.cmbxCam2.Size = new System.Drawing.Size(130, 21);
            this.cmbxCam2.TabIndex = 2;
            this.cmbxCam2.SelectedIndexChanged += new System.EventHandler(this.cmbxCam2_SelectedIndexChanged);
            this.cmbxCam2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbxCam2_MouseClick);
            // 
            // picCam2
            // 
            this.picCam2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.picCam2.ErrorImage = null;
            this.picCam2.Location = new System.Drawing.Point(6, 30);
            this.picCam2.Name = "picCam2";
            this.picCam2.Size = new System.Drawing.Size(473, 279);
            this.picCam2.TabIndex = 5;
            this.picCam2.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lblGeigerData);
            this.panel5.Controls.Add(this.commGeiger);
            this.panel5.Location = new System.Drawing.Point(1026, 47);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(329, 176);
            this.panel5.TabIndex = 3;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // lblGeigerData
            // 
            this.lblGeigerData.AutoSize = true;
            this.lblGeigerData.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeigerData.Location = new System.Drawing.Point(93, 68);
            this.lblGeigerData.Name = "lblGeigerData";
            this.lblGeigerData.Size = new System.Drawing.Size(153, 29);
            this.lblGeigerData.TabIndex = 6;
            this.lblGeigerData.Text = "Geiger Data";
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.btnCam1Stop);
            this.panel6.Controls.Add(this.cmbxCam1);
            this.panel6.Controls.Add(this.picCam1);
            this.panel6.Location = new System.Drawing.Point(12, 333);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(435, 314);
            this.panel6.TabIndex = 2;
            // 
            // btnCam1Stop
            // 
            this.btnCam1Stop.Location = new System.Drawing.Point(140, -1);
            this.btnCam1Stop.Name = "btnCam1Stop";
            this.btnCam1Stop.Size = new System.Drawing.Size(75, 23);
            this.btnCam1Stop.TabIndex = 7;
            this.btnCam1Stop.Text = "Stop";
            this.btnCam1Stop.UseVisualStyleBackColor = true;
            this.btnCam1Stop.Click += new System.EventHandler(this.btnCam1Stop_Click);
            // 
            // cmbxCam1
            // 
            this.cmbxCam1.FormattingEnabled = true;
            this.cmbxCam1.Location = new System.Drawing.Point(3, -1);
            this.cmbxCam1.Name = "cmbxCam1";
            this.cmbxCam1.Size = new System.Drawing.Size(130, 21);
            this.cmbxCam1.TabIndex = 1;
            this.cmbxCam1.SelectedIndexChanged += new System.EventHandler(this.cmbxCam1_SelectedIndexChanged);
            this.cmbxCam1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbxCam1_MouseClick);
            // 
            // picCam1
            // 
            this.picCam1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picCam1.Location = new System.Drawing.Point(3, 28);
            this.picCam1.Name = "picCam1";
            this.picCam1.Size = new System.Drawing.Size(431, 278);
            this.picCam1.TabIndex = 0;
            this.picCam1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Shutter";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(664, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Stage";
            // 
            // txtbxLog
            // 
            this.txtbxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxLog.Location = new System.Drawing.Point(1022, 653);
            this.txtbxLog.Multiline = true;
            this.txtbxLog.Name = "txtbxLog";
            this.txtbxLog.Size = new System.Drawing.Size(333, 53);
            this.txtbxLog.TabIndex = 7;
            this.txtbxLog.TextChanged += new System.EventHandler(this.txtbxLog_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(150, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cam 1";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(698, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Cam 2";
            // 
            // commGeiger
            // 
            this.commGeiger.Location = new System.Drawing.Point(3, 3);
            this.commGeiger.Name = "commGeiger";
            this.commGeiger.Size = new System.Drawing.Size(102, 72);
            this.commGeiger.TabIndex = 5;
            this.commGeiger.Load += new System.EventHandler(this.commGeiger_Load);
            // 
            // connStage
            // 
            this.connStage.Location = new System.Drawing.Point(3, 5);
            this.connStage.Name = "connStage";
            this.connStage.Size = new System.Drawing.Size(102, 72);
            this.connStage.TabIndex = 1;
            // 
            // conn3
            // 
            this.conn3.Location = new System.Drawing.Point(3, 5);
            this.conn3.Name = "conn3";
            this.conn3.Size = new System.Drawing.Size(102, 72);
            this.conn3.TabIndex = 2;
            // 
            // connShutter
            // 
            this.connShutter.Location = new System.Drawing.Point(3, 5);
            this.connShutter.Name = "connShutter";
            this.connShutter.Size = new System.Drawing.Size(102, 72);
            this.connShutter.TabIndex = 0;
            this.connShutter.Load += new System.EventHandler(this.conn1_Load);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1146, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Radiation";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 706);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbxLog);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "F6Control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCam2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCam1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private customControl.comboSerial connShutter;
        private System.Windows.Forms.Label label1;
        private customControl.comboSerial conn3;
        private customControl.comboSerial connStage;
        private customControl.comboSerial commGeiger;
        private System.Windows.Forms.PictureBox picCam1;
        private System.Windows.Forms.ComboBox cmbxCam1;
        private System.Windows.Forms.PictureBox picCam2;
        private System.Windows.Forms.ComboBox cmbxCam2;
        private System.Windows.Forms.Button btnCam2Stop;
        private System.Windows.Forms.Button btnCam1Stop;
        private System.Windows.Forms.Button btnShutterOpen;
        private System.Windows.Forms.Button btnShutterClose;
        private System.Windows.Forms.Label lblShutter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStageRight;
        private System.Windows.Forms.Button btnStageLeft;
        private System.Windows.Forms.Button btnStageBack;
        private System.Windows.Forms.Button btnStageFwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbxLog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbxDelay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblGeigerData;
        private System.Windows.Forms.Label label7;
    }
}

