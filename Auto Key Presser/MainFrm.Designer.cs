namespace Auto_Key_Presser
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.IntervalPanel = new System.Windows.Forms.Panel();
            this.IntervalSaveBtn = new System.Windows.Forms.Button();
            this.OffsetTxtBox = new System.Windows.Forms.TextBox();
            this.IntervalTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PressTypePanel = new System.Windows.Forms.Panel();
            this.KeyTxtBox = new System.Windows.Forms.TextBox();
            this.RightMouseRdBtn = new System.Windows.Forms.RadioButton();
            this.LeftMouseRdBtn = new System.Windows.Forms.RadioButton();
            this.KeyRdBtn = new System.Windows.Forms.RadioButton();
            this.IntervalProgressBar = new System.Windows.Forms.ProgressBar();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MaxProgressLbl = new System.Windows.Forms.Label();
            this.IntervalPanel.SuspendLayout();
            this.PressTypePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(159, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 11000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Interval";
            // 
            // IntervalPanel
            // 
            this.IntervalPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IntervalPanel.Controls.Add(this.IntervalSaveBtn);
            this.IntervalPanel.Controls.Add(this.OffsetTxtBox);
            this.IntervalPanel.Controls.Add(this.IntervalTxtBox);
            this.IntervalPanel.Controls.Add(this.label3);
            this.IntervalPanel.Controls.Add(this.label5);
            this.IntervalPanel.Controls.Add(this.label4);
            this.IntervalPanel.Controls.Add(this.label1);
            this.IntervalPanel.Location = new System.Drawing.Point(12, 12);
            this.IntervalPanel.Name = "IntervalPanel";
            this.IntervalPanel.Size = new System.Drawing.Size(260, 62);
            this.IntervalPanel.TabIndex = 3;
            // 
            // IntervalSaveBtn
            // 
            this.IntervalSaveBtn.Location = new System.Drawing.Point(162, 13);
            this.IntervalSaveBtn.Name = "IntervalSaveBtn";
            this.IntervalSaveBtn.Size = new System.Drawing.Size(85, 32);
            this.IntervalSaveBtn.TabIndex = 3;
            this.IntervalSaveBtn.Text = "Save";
            this.IntervalSaveBtn.UseVisualStyleBackColor = true;
            this.IntervalSaveBtn.Click += new System.EventHandler(this.IntervalSaveBtn_Click);
            // 
            // OffsetTxtBox
            // 
            this.OffsetTxtBox.Location = new System.Drawing.Point(61, 33);
            this.OffsetTxtBox.Name = "OffsetTxtBox";
            this.OffsetTxtBox.Size = new System.Drawing.Size(71, 20);
            this.OffsetTxtBox.TabIndex = 2;
            this.OffsetTxtBox.Text = "0";
            this.toolTip1.SetToolTip(this.OffsetTxtBox, "A random offset in milliseconds between 0 and your offset that gets added on to y" +
        "our total interval. Use this in games and applications if you are woried about b" +
        "eing detected for botting.");
            // 
            // IntervalTxtBox
            // 
            this.IntervalTxtBox.Location = new System.Drawing.Point(61, 7);
            this.IntervalTxtBox.Name = "IntervalTxtBox";
            this.IntervalTxtBox.Size = new System.Drawing.Size(71, 20);
            this.IntervalTxtBox.TabIndex = 1;
            this.IntervalTxtBox.Text = "10000";
            this.toolTip1.SetToolTip(this.IntervalTxtBox, "The interval in milliseconds that each key press will take place.");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Add Rand";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "ms";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "ms";
            // 
            // PressTypePanel
            // 
            this.PressTypePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PressTypePanel.Controls.Add(this.KeyTxtBox);
            this.PressTypePanel.Controls.Add(this.RightMouseRdBtn);
            this.PressTypePanel.Controls.Add(this.LeftMouseRdBtn);
            this.PressTypePanel.Controls.Add(this.KeyRdBtn);
            this.PressTypePanel.Location = new System.Drawing.Point(12, 81);
            this.PressTypePanel.Name = "PressTypePanel";
            this.PressTypePanel.Size = new System.Drawing.Size(260, 78);
            this.PressTypePanel.TabIndex = 4;
            // 
            // KeyTxtBox
            // 
            this.KeyTxtBox.Location = new System.Drawing.Point(65, 6);
            this.KeyTxtBox.Name = "KeyTxtBox";
            this.KeyTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.KeyTxtBox.Size = new System.Drawing.Size(182, 20);
            this.KeyTxtBox.TabIndex = 7;
            this.KeyTxtBox.Text = "{ENTER}";
            // 
            // RightMouseRdBtn
            // 
            this.RightMouseRdBtn.AutoSize = true;
            this.RightMouseRdBtn.Location = new System.Drawing.Point(6, 52);
            this.RightMouseRdBtn.Name = "RightMouseRdBtn";
            this.RightMouseRdBtn.Size = new System.Drawing.Size(119, 17);
            this.RightMouseRdBtn.TabIndex = 6;
            this.RightMouseRdBtn.Text = "Right Mouse Button";
            this.RightMouseRdBtn.UseVisualStyleBackColor = true;
            this.RightMouseRdBtn.CheckedChanged += new System.EventHandler(this.RightMouseRdBtn_CheckedChanged);
            // 
            // LeftMouseRdBtn
            // 
            this.LeftMouseRdBtn.AutoSize = true;
            this.LeftMouseRdBtn.Location = new System.Drawing.Point(6, 29);
            this.LeftMouseRdBtn.Name = "LeftMouseRdBtn";
            this.LeftMouseRdBtn.Size = new System.Drawing.Size(112, 17);
            this.LeftMouseRdBtn.TabIndex = 5;
            this.LeftMouseRdBtn.Text = "Left Mouse Button";
            this.LeftMouseRdBtn.UseVisualStyleBackColor = true;
            this.LeftMouseRdBtn.CheckedChanged += new System.EventHandler(this.LeftMouseRdBtn_CheckedChanged);
            // 
            // KeyRdBtn
            // 
            this.KeyRdBtn.AutoSize = true;
            this.KeyRdBtn.Checked = true;
            this.KeyRdBtn.Location = new System.Drawing.Point(6, 6);
            this.KeyRdBtn.Name = "KeyRdBtn";
            this.KeyRdBtn.Size = new System.Drawing.Size(53, 17);
            this.KeyRdBtn.TabIndex = 4;
            this.KeyRdBtn.TabStop = true;
            this.KeyRdBtn.Text = "Key/s";
            this.KeyRdBtn.UseVisualStyleBackColor = true;
            this.KeyRdBtn.CheckedChanged += new System.EventHandler(this.KeyRdBtn_CheckedChanged);
            // 
            // IntervalProgressBar
            // 
            this.IntervalProgressBar.Location = new System.Drawing.Point(12, 190);
            this.IntervalProgressBar.Name = "IntervalProgressBar";
            this.IntervalProgressBar.Size = new System.Drawing.Size(260, 23);
            this.IntervalProgressBar.TabIndex = 5;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(258, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "v1.1";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.DoubleClick += new System.EventHandler(this.label2_DoubleClick);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(-2, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Hotkey: CRTL + O";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "0s";
            // 
            // MaxProgressLbl
            // 
            this.MaxProgressLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MaxProgressLbl.AutoEllipsis = true;
            this.MaxProgressLbl.Location = new System.Drawing.Point(231, 171);
            this.MaxProgressLbl.Name = "MaxProgressLbl";
            this.MaxProgressLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MaxProgressLbl.Size = new System.Drawing.Size(48, 13);
            this.MaxProgressLbl.TabIndex = 11;
            this.MaxProgressLbl.Text = "0";
            this.MaxProgressLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.MaxProgressLbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IntervalProgressBar);
            this.Controls.Add(this.PressTypePanel);
            this.Controls.Add(this.IntervalPanel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.Text = "Auto Key Presser";
            this.IntervalPanel.ResumeLayout(false);
            this.IntervalPanel.PerformLayout();
            this.PressTypePanel.ResumeLayout(false);
            this.PressTypePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel IntervalPanel;
        private System.Windows.Forms.Button IntervalSaveBtn;
        private System.Windows.Forms.TextBox OffsetTxtBox;
        private System.Windows.Forms.TextBox IntervalTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel PressTypePanel;
        private System.Windows.Forms.RadioButton RightMouseRdBtn;
        private System.Windows.Forms.RadioButton LeftMouseRdBtn;
        private System.Windows.Forms.RadioButton KeyRdBtn;
        private System.Windows.Forms.TextBox KeyTxtBox;
        private System.Windows.Forms.ProgressBar IntervalProgressBar;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label MaxProgressLbl;
    }
}

