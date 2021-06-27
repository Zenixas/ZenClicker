
namespace ZenClicker
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
            this.checkBox1 = new Siticone.UI.WinForms.SiticoneCheckBox();
            this.CheckKeyRight = new System.Windows.Forms.Timer(this.components);
            this.CheckKeyLeft = new System.Windows.Forms.Timer(this.components);
            this.SelfDestruct = new Siticone.UI.WinForms.SiticoneButton();
            this.HideInTaskbar = new Siticone.UI.WinForms.SiticoneButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LeftMinCPS = new Siticone.UI.WinForms.SiticoneMetroTrackBar();
            this.LeftMaxCPS = new Siticone.UI.WinForms.SiticoneMetroTrackBar();
            this.RightMinCPS = new Siticone.UI.WinForms.SiticoneMetroTrackBar();
            this.RightMaxCPS = new Siticone.UI.WinForms.SiticoneMetroTrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MinimizeButton = new Siticone.UI.WinForms.SiticoneButton();
            this.CloseButton = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneImageButton1 = new Siticone.UI.WinForms.SiticoneImageButton();
            this.siticoneLabel1 = new Siticone.UI.WinForms.SiticoneLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBox1.CheckedState.BorderRadius = 0;
            this.checkBox1.CheckedState.BorderThickness = 0;
            this.checkBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBox1.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(13, 39);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(173, 26);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Enable auto clicker";
            this.checkBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkBox1.UncheckedState.BorderRadius = 0;
            this.checkBox1.UncheckedState.BorderThickness = 0;
            this.checkBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // CheckKeyRight
            // 
            this.CheckKeyRight.Interval = 150;
            this.CheckKeyRight.Tick += new System.EventHandler(this.CheckKeyRight_Tick);
            // 
            // CheckKeyLeft
            // 
            this.CheckKeyLeft.Interval = 150;
            this.CheckKeyLeft.Tick += new System.EventHandler(this.CheckKeyLeft_Tick);
            // 
            // SelfDestruct
            // 
            this.SelfDestruct.CheckedState.Parent = this.SelfDestruct;
            this.SelfDestruct.CustomImages.Parent = this.SelfDestruct;
            this.SelfDestruct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.SelfDestruct.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelfDestruct.ForeColor = System.Drawing.Color.White;
            this.SelfDestruct.HoveredState.Parent = this.SelfDestruct;
            this.SelfDestruct.Location = new System.Drawing.Point(182, 223);
            this.SelfDestruct.Name = "SelfDestruct";
            this.SelfDestruct.ShadowDecoration.Parent = this.SelfDestruct;
            this.SelfDestruct.Size = new System.Drawing.Size(132, 34);
            this.SelfDestruct.TabIndex = 1;
            this.SelfDestruct.Text = "Self Destruct";
            this.SelfDestruct.Click += new System.EventHandler(this.SelfDestruct_Click);
            // 
            // HideInTaskbar
            // 
            this.HideInTaskbar.CheckedState.Parent = this.HideInTaskbar;
            this.HideInTaskbar.CustomImages.Parent = this.HideInTaskbar;
            this.HideInTaskbar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.HideInTaskbar.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HideInTaskbar.ForeColor = System.Drawing.Color.White;
            this.HideInTaskbar.HoveredState.Parent = this.HideInTaskbar;
            this.HideInTaskbar.Location = new System.Drawing.Point(320, 223);
            this.HideInTaskbar.Name = "HideInTaskbar";
            this.HideInTaskbar.ShadowDecoration.Parent = this.HideInTaskbar;
            this.HideInTaskbar.Size = new System.Drawing.Size(132, 34);
            this.HideInTaskbar.TabIndex = 2;
            this.HideInTaskbar.Text = "Hide in taskbar";
            this.HideInTaskbar.Click += new System.EventHandler(this.HideInTaskbar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Alef", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(243, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 19);
            this.label9.TabIndex = 25;
            this.label9.Text = "Key Down:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Alef", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(243, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 19);
            this.label7.TabIndex = 24;
            this.label7.Text = "Min cps:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Alef", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(242, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 19);
            this.label8.TabIndex = 23;
            this.label8.Text = "Max cps";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(361, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 22);
            this.label6.TabIndex = 22;
            this.label6.Text = "Right Click";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Alef", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(9, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "Key Down:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Alef", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(9, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Made by Zenix";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Alef", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(13, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Max cps:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Alef", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(13, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Min cps:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 22);
            this.label1.TabIndex = 21;
            this.label1.Text = "Left Click";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LeftMinCPS
            // 
            this.LeftMinCPS.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.LeftMinCPS.HoveredState.Parent = this.LeftMinCPS;
            this.LeftMinCPS.IndicateFocus = false;
            this.LeftMinCPS.Location = new System.Drawing.Point(13, 101);
            this.LeftMinCPS.Maximum = 30;
            this.LeftMinCPS.Minimum = 1;
            this.LeftMinCPS.Name = "LeftMinCPS";
            this.LeftMinCPS.Size = new System.Drawing.Size(206, 23);
            this.LeftMinCPS.TabIndex = 26;
            this.LeftMinCPS.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.LeftMinCPS.Value = 1;
            this.LeftMinCPS.Scroll += new System.Windows.Forms.ScrollEventHandler(this.LeftMinCPS_Scroll);
            // 
            // LeftMaxCPS
            // 
            this.LeftMaxCPS.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.LeftMaxCPS.HoveredState.Parent = this.LeftMaxCPS;
            this.LeftMaxCPS.IndicateFocus = false;
            this.LeftMaxCPS.Location = new System.Drawing.Point(13, 152);
            this.LeftMaxCPS.Maximum = 30;
            this.LeftMaxCPS.Minimum = 1;
            this.LeftMaxCPS.Name = "LeftMaxCPS";
            this.LeftMaxCPS.Size = new System.Drawing.Size(206, 23);
            this.LeftMaxCPS.TabIndex = 27;
            this.LeftMaxCPS.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.LeftMaxCPS.Value = 1;
            this.LeftMaxCPS.Scroll += new System.Windows.Forms.ScrollEventHandler(this.LeftMaxCPS_Scroll);
            // 
            // RightMinCPS
            // 
            this.RightMinCPS.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.RightMinCPS.HoveredState.Parent = this.RightMinCPS;
            this.RightMinCPS.IndicateFocus = false;
            this.RightMinCPS.Location = new System.Drawing.Point(246, 101);
            this.RightMinCPS.Maximum = 30;
            this.RightMinCPS.Minimum = 1;
            this.RightMinCPS.Name = "RightMinCPS";
            this.RightMinCPS.Size = new System.Drawing.Size(206, 23);
            this.RightMinCPS.TabIndex = 28;
            this.RightMinCPS.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.RightMinCPS.Value = 1;
            this.RightMinCPS.Scroll += new System.Windows.Forms.ScrollEventHandler(this.RightMinCPS_Scroll);
            // 
            // RightMaxCPS
            // 
            this.RightMaxCPS.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.RightMaxCPS.HoveredState.Parent = this.RightMaxCPS;
            this.RightMaxCPS.IndicateFocus = false;
            this.RightMaxCPS.Location = new System.Drawing.Point(246, 152);
            this.RightMaxCPS.Maximum = 30;
            this.RightMaxCPS.Minimum = 1;
            this.RightMaxCPS.Name = "RightMaxCPS";
            this.RightMaxCPS.Size = new System.Drawing.Size(206, 23);
            this.RightMaxCPS.TabIndex = 29;
            this.RightMaxCPS.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.RightMaxCPS.Value = 1;
            this.RightMaxCPS.Scroll += new System.Windows.Forms.ScrollEventHandler(this.RightMaxCPS_Scroll);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.siticoneLabel1);
            this.panel1.Controls.Add(this.MinimizeButton);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 33);
            this.panel1.TabIndex = 30;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.CheckedState.Parent = this.MinimizeButton;
            this.MinimizeButton.CustomImages.Parent = this.MinimizeButton;
            this.MinimizeButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.MinimizeButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeButton.ForeColor = System.Drawing.Color.White;
            this.MinimizeButton.HoveredState.Parent = this.MinimizeButton;
            this.MinimizeButton.Location = new System.Drawing.Point(412, -3);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.ShadowDecoration.Parent = this.MinimizeButton;
            this.MinimizeButton.Size = new System.Drawing.Size(25, 36);
            this.MinimizeButton.TabIndex = 34;
            this.MinimizeButton.Text = "-";
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.CheckedState.Parent = this.CloseButton;
            this.CloseButton.CustomImages.Parent = this.CloseButton;
            this.CloseButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.CloseButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.HoveredState.Parent = this.CloseButton;
            this.CloseButton.Location = new System.Drawing.Point(434, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.ShadowDecoration.Parent = this.CloseButton;
            this.CloseButton.Size = new System.Drawing.Size(29, 36);
            this.CloseButton.TabIndex = 33;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // siticoneImageButton1
            // 
            this.siticoneImageButton1.CheckedState.Parent = this.siticoneImageButton1;
            this.siticoneImageButton1.HoveredState.Parent = this.siticoneImageButton1;
            this.siticoneImageButton1.Image = global::ZenClicker.Properties.Resources.logo;
            this.siticoneImageButton1.ImageRotate = 0F;
            this.siticoneImageButton1.IndicateFocus = false;
            this.siticoneImageButton1.Location = new System.Drawing.Point(140, 223);
            this.siticoneImageButton1.Name = "siticoneImageButton1";
            this.siticoneImageButton1.PressedState.Parent = this.siticoneImageButton1;
            this.siticoneImageButton1.Size = new System.Drawing.Size(36, 32);
            this.siticoneImageButton1.TabIndex = 31;
            this.siticoneImageButton1.Click += new System.EventHandler(this.siticoneImageButton1_Click);
            // 
            // siticoneLabel1
            // 
            this.siticoneLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel1.ForeColor = System.Drawing.Color.White;
            this.siticoneLabel1.Location = new System.Drawing.Point(12, 5);
            this.siticoneLabel1.Name = "siticoneLabel1";
            this.siticoneLabel1.Size = new System.Drawing.Size(84, 25);
            this.siticoneLabel1.TabIndex = 35;
            this.siticoneLabel1.Text = "ZenClicker";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 266);
            this.Controls.Add(this.siticoneImageButton1);
            this.Controls.Add(this.RightMaxCPS);
            this.Controls.Add(this.RightMinCPS);
            this.Controls.Add(this.LeftMaxCPS);
            this.Controls.Add(this.LeftMinCPS);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HideInTaskbar);
            this.Controls.Add(this.SelfDestruct);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneCheckBox checkBox1;
        private System.Windows.Forms.Timer CheckKeyRight;
        private System.Windows.Forms.Timer CheckKeyLeft;
        private Siticone.UI.WinForms.SiticoneButton SelfDestruct;
        private Siticone.UI.WinForms.SiticoneButton HideInTaskbar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Siticone.UI.WinForms.SiticoneMetroTrackBar LeftMinCPS;
        private Siticone.UI.WinForms.SiticoneMetroTrackBar LeftMaxCPS;
        private Siticone.UI.WinForms.SiticoneMetroTrackBar RightMinCPS;
        private Siticone.UI.WinForms.SiticoneMetroTrackBar RightMaxCPS;
        private System.Windows.Forms.Panel panel1;
        private Siticone.UI.WinForms.SiticoneButton CloseButton;
        private Siticone.UI.WinForms.SiticoneButton MinimizeButton;
        private Siticone.UI.WinForms.SiticoneImageButton siticoneImageButton1;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel1;
    }
}