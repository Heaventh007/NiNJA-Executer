
namespace NiNJA_Executer
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.Execute = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Inject = new Guna.UI2.WinForms.Guna2ImageButton();
            this.backButton = new Guna.UI2.WinForms.Guna2Button();
            this.siticonePanel1 = new Siticone.UI.WinForms.SiticonePanel();
            this.label2 = new System.Windows.Forms.Label();
            this.siticoneButton1 = new Siticone.UI.WinForms.SiticoneButton();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.RefreshButton = new Guna.UI2.WinForms.Guna2Button();
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.ExecuterTabButton = new Guna.UI2.WinForms.Guna2Button();
            this.ExecuterTab = new Guna.UI2.WinForms.Guna2Panel();
            this.fastColoredTextBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2Panel3.SuspendLayout();
            this.siticonePanel1.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.ExecuterTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).BeginInit();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.guna2Panel3.BorderThickness = 2;
            this.guna2Panel3.Controls.Add(this.Execute);
            this.guna2Panel3.Controls.Add(this.Inject);
            this.guna2Panel3.Location = new System.Drawing.Point(718, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(88, 407);
            this.guna2Panel3.TabIndex = 43;
            // 
            // Execute
            // 
            this.Execute.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Execute.CheckedState.Parent = this.Execute;
            this.Execute.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.Execute.HoverState.Parent = this.Execute;
            this.Execute.Image = global::NiNJA.Properties.Resources._1356625;
            this.Execute.ImageRotate = 0F;
            this.Execute.Location = new System.Drawing.Point(13, 325);
            this.Execute.Name = "Execute";
            this.Execute.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Execute.PressedState.Parent = this.Execute;
            this.Execute.Size = new System.Drawing.Size(64, 70);
            this.Execute.TabIndex = 36;
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // Inject
            // 
            this.Inject.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Inject.CheckedState.Parent = this.Inject;
            this.Inject.Cursor = System.Windows.Forms.Cursors.Default;
            this.Inject.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.Inject.HoverState.Parent = this.Inject;
            this.Inject.Image = ((System.Drawing.Image)(resources.GetObject("Inject.Image")));
            this.Inject.ImageRotate = 0F;
            this.Inject.Location = new System.Drawing.Point(13, 8);
            this.Inject.Name = "Inject";
            this.Inject.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Inject.PressedState.Parent = this.Inject;
            this.Inject.Size = new System.Drawing.Size(64, 54);
            this.Inject.TabIndex = 33;
            this.Inject.Click += new System.EventHandler(this.Inject_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.backButton.BorderRadius = 2;
            this.backButton.CheckedState.Parent = this.backButton;
            this.backButton.CustomImages.Parent = this.backButton;
            this.backButton.FillColor = System.Drawing.Color.Transparent;
            this.backButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.HoverState.FillColor = System.Drawing.Color.MediumPurple;
            this.backButton.HoverState.ForeColor = System.Drawing.Color.White;
            this.backButton.HoverState.Parent = this.backButton;
            this.backButton.Location = new System.Drawing.Point(723, 455);
            this.backButton.Name = "backButton";
            this.backButton.ShadowDecoration.Parent = this.backButton;
            this.backButton.Size = new System.Drawing.Size(75, 52);
            this.backButton.TabIndex = 44;
            this.backButton.Text = "Back";
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.siticonePanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.siticonePanel1.BorderThickness = 2;
            this.siticonePanel1.Controls.Add(this.label2);
            this.siticonePanel1.Controls.Add(this.siticoneButton1);
            this.siticonePanel1.Location = new System.Drawing.Point(1, 0);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.ShadowDecoration.Parent = this.siticonePanel1;
            this.siticonePanel1.Size = new System.Drawing.Size(806, 42);
            this.siticonePanel1.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "NINJA";
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
            this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
            this.siticoneButton1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.HoveredState.Parent = this.siticoneButton1;
            this.siticoneButton1.Location = new System.Drawing.Point(753, 3);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
            this.siticoneButton1.Size = new System.Drawing.Size(48, 34);
            this.siticoneButton1.TabIndex = 34;
            this.siticoneButton1.Text = "X";
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.guna2Panel4.BorderThickness = 2;
            this.guna2Panel4.Controls.Add(this.backButton);
            this.guna2Panel4.Controls.Add(this.guna2Panel5);
            this.guna2Panel4.Controls.Add(this.siticonePanel1);
            this.guna2Panel4.Controls.Add(this.RefreshButton);
            this.guna2Panel4.Location = new System.Drawing.Point(1, 1);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.ShadowDecoration.Parent = this.guna2Panel4;
            this.guna2Panel4.Size = new System.Drawing.Size(807, 514);
            this.guna2Panel4.TabIndex = 43;
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.guna2Panel5.BorderThickness = 2;
            this.guna2Panel5.Controls.Add(this.guna2Panel3);
            this.guna2Panel5.Controls.Add(this.guna2ShadowPanel1);
            this.guna2Panel5.Location = new System.Drawing.Point(1, 42);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.ShadowDecoration.Parent = this.guna2Panel5;
            this.guna2Panel5.Size = new System.Drawing.Size(806, 407);
            this.guna2Panel5.TabIndex = 42;
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.Transparent;
            this.RefreshButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.RefreshButton.BorderRadius = 2;
            this.RefreshButton.CheckedState.Parent = this.RefreshButton;
            this.RefreshButton.CustomImages.Parent = this.RefreshButton;
            this.RefreshButton.FillColor = System.Drawing.Color.Transparent;
            this.RefreshButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshButton.ForeColor = System.Drawing.Color.White;
            this.RefreshButton.HoverState.FillColor = System.Drawing.Color.MediumPurple;
            this.RefreshButton.HoverState.ForeColor = System.Drawing.Color.White;
            this.RefreshButton.HoverState.Parent = this.RefreshButton;
            this.RefreshButton.Location = new System.Drawing.Point(4, 455);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.ShadowDecoration.Parent = this.RefreshButton;
            this.RefreshButton.Size = new System.Drawing.Size(713, 52);
            this.RefreshButton.TabIndex = 41;
            this.RefreshButton.Text = "Refresh ";
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this.siticonePanel1;
            // 
            // ExecuterTabButton
            // 
            this.ExecuterTabButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.ExecuterTabButton.BorderThickness = 1;
            this.ExecuterTabButton.CheckedState.Parent = this.ExecuterTabButton;
            this.ExecuterTabButton.CustomImages.Parent = this.ExecuterTabButton;
            this.ExecuterTabButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.ExecuterTabButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ExecuterTabButton.ForeColor = System.Drawing.Color.White;
            this.ExecuterTabButton.HoverState.Parent = this.ExecuterTabButton;
            this.ExecuterTabButton.Location = new System.Drawing.Point(1, 1);
            this.ExecuterTabButton.Name = "ExecuterTabButton";
            this.ExecuterTabButton.ShadowDecoration.Parent = this.ExecuterTabButton;
            this.ExecuterTabButton.Size = new System.Drawing.Size(105, 27);
            this.ExecuterTabButton.TabIndex = 4;
            this.ExecuterTabButton.Text = "Executer";
            this.ExecuterTabButton.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // ExecuterTab
            // 
            this.ExecuterTab.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.ExecuterTab.BorderThickness = 2;
            this.ExecuterTab.Controls.Add(this.fastColoredTextBox1);
            this.ExecuterTab.Location = new System.Drawing.Point(1, 27);
            this.ExecuterTab.Name = "ExecuterTab";
            this.ExecuterTab.ShadowDecoration.Parent = this.ExecuterTab;
            this.ExecuterTab.Size = new System.Drawing.Size(716, 381);
            this.ExecuterTab.TabIndex = 10;
            // 
            // fastColoredTextBox1
            // 
            this.fastColoredTextBox1.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fastColoredTextBox1.AutoScrollMinSize = new System.Drawing.Size(267, 140);
            this.fastColoredTextBox1.BackBrush = null;
            this.fastColoredTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.fastColoredTextBox1.CharHeight = 14;
            this.fastColoredTextBox1.CharWidth = 8;
            this.fastColoredTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBox1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBox1.ForeColor = System.Drawing.Color.MediumPurple;
            this.fastColoredTextBox1.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.fastColoredTextBox1.IsReplaceMode = false;
            this.fastColoredTextBox1.LineNumberColor = System.Drawing.Color.MediumPurple;
            this.fastColoredTextBox1.Location = new System.Drawing.Point(3, 3);
            this.fastColoredTextBox1.Name = "fastColoredTextBox1";
            this.fastColoredTextBox1.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBox1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBox1.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBox1.ServiceColors")));
            this.fastColoredTextBox1.Size = new System.Drawing.Size(717, 375);
            this.fastColoredTextBox1.TabIndex = 36;
            this.fastColoredTextBox1.Text = "--Welcome to NiNJA!--\r\n\r\n--Updates--\r\n--New UI--\r\n--API Added--\r\n--Rainbow UI--\r\n" +
    "--New Login Screen--\r\n\r\n--By: xXvElitevXx, Heaventh--\r\n";
            this.fastColoredTextBox1.Zoom = 100;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.guna2ShadowPanel1.Controls.Add(this.ExecuterTab);
            this.guna2ShadowPanel1.Controls.Add(this.ExecuterTabButton);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(-1, -1);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowDepth = 0;
            this.guna2ShadowPanel1.ShadowShift = 0;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(724, 408);
            this.guna2ShadowPanel1.TabIndex = 11;
            this.guna2ShadowPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2ShadowPanel1_Paint);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(809, 516);
            this.Controls.Add(this.guna2Panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "NiNJA Settings";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.guna2Panel3.ResumeLayout(false);
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel1.PerformLayout();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel5.ResumeLayout(false);
            this.ExecuterTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).EndInit();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2ImageButton Execute;
        private Guna.UI2.WinForms.Guna2ImageButton Inject;
        private Guna.UI2.WinForms.Guna2Button backButton;
        private Siticone.UI.WinForms.SiticonePanel siticonePanel1;
        private System.Windows.Forms.Label label2;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2Button RefreshButton;
        private Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2Panel ExecuterTab;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox1;
        private Guna.UI2.WinForms.Guna2Button ExecuterTabButton;
    }
}