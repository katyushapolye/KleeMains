
namespace KleeMains
{

    partial class MainFrame
    {

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            this.C0_Button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.C1_Button = new System.Windows.Forms.Button();
            this.C2_Button = new System.Windows.Forms.Button();
            this.C3_Button = new System.Windows.Forms.Button();
            this.ToolBar = new System.Windows.Forms.PictureBox();
            this.charNameUIText = new System.Windows.Forms.Label();
            this.charTitleUIText = new System.Windows.Forms.Label();
            this.C0_Switch = new System.Windows.Forms.Button();
            this.C1_Switch = new System.Windows.Forms.Button();
            this.C2_Switch = new System.Windows.Forms.Button();
            this.C3_Switch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToolBar)).BeginInit();
            this.SuspendLayout();
            // 
            // C0_Button
            // 
            this.C0_Button.BackColor = System.Drawing.Color.Firebrick;
            this.C0_Button.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.C0_Button.Location = new System.Drawing.Point(923, 12);
            this.C0_Button.Name = "C0_Button";
            this.C0_Button.Size = new System.Drawing.Size(140, 140);
            this.C0_Button.TabIndex = 0;
            this.C0_Button.Text = "DPS";
            this.C0_Button.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.BackgroundImage = global::KleeMains.Properties.Resources.Character_Klee_Card;
            this.pictureBox1.Image = global::KleeMains.Properties.Resources.Character_Klee_Card;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(582, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 519);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // C1_Button
            // 
            this.C1_Button.BackColor = System.Drawing.Color.Firebrick;
            this.C1_Button.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.C1_Button.Location = new System.Drawing.Point(923, 167);
            this.C1_Button.Name = "C1_Button";
            this.C1_Button.Size = new System.Drawing.Size(140, 140);
            this.C1_Button.TabIndex = 5;
            this.C1_Button.Text = "SUB-DPS";
            this.C1_Button.UseVisualStyleBackColor = false;
            // 
            // C2_Button
            // 
            this.C2_Button.BackColor = System.Drawing.Color.Firebrick;
            this.C2_Button.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.C2_Button.Location = new System.Drawing.Point(923, 326);
            this.C2_Button.Name = "C2_Button";
            this.C2_Button.Size = new System.Drawing.Size(140, 140);
            this.C2_Button.TabIndex = 6;
            this.C2_Button.Text = "EM Battery";
            this.C2_Button.UseVisualStyleBackColor = false;
            // 
            // C3_Button
            // 
            this.C3_Button.BackColor = System.Drawing.Color.Firebrick;
            this.C3_Button.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.C3_Button.Location = new System.Drawing.Point(923, 486);
            this.C3_Button.Name = "C3_Button";
            this.C3_Button.Size = new System.Drawing.Size(140, 140);
            this.C3_Button.TabIndex = 7;
            this.C3_Button.Text = "Healer";
            this.C3_Button.UseVisualStyleBackColor = false;
            // 
            // ToolBar
            // 
            this.ToolBar.BackgroundImage = global::KleeMains.Properties.Resources.blackbar;
            this.ToolBar.InitialImage = global::KleeMains.Properties.Resources.blackbar;
            this.ToolBar.Location = new System.Drawing.Point(-6, 0);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Size = new System.Drawing.Size(1140, 10);
            this.ToolBar.TabIndex = 8;
            this.ToolBar.TabStop = false;
            this.ToolBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ToolBar_MouseDown);
            this.ToolBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ToolBar_MouseMove);
            this.ToolBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ToolBar_MouseUp);
            // 
            // charNameUIText
            // 
            this.charNameUIText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.charNameUIText.BackColor = System.Drawing.Color.Transparent;
            this.charNameUIText.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.charNameUIText.ForeColor = System.Drawing.Color.MintCream;
            this.charNameUIText.Location = new System.Drawing.Point(582, 13);
            this.charNameUIText.Name = "charNameUIText";
            this.charNameUIText.Size = new System.Drawing.Size(266, 44);
            this.charNameUIText.TabIndex = 9;
            this.charNameUIText.Text = "Sangonomia Kokomi";
            this.charNameUIText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // charTitleUIText
            // 
            this.charTitleUIText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.charTitleUIText.BackColor = System.Drawing.Color.Transparent;
            this.charTitleUIText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.charTitleUIText.ForeColor = System.Drawing.Color.Snow;
            this.charTitleUIText.Location = new System.Drawing.Point(582, 57);
            this.charTitleUIText.Name = "charTitleUIText";
            this.charTitleUIText.Size = new System.Drawing.Size(266, 22);
            this.charTitleUIText.TabIndex = 10;
            this.charTitleUIText.Text = "The Princess Of Watatsumi";
            this.charTitleUIText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // C0_Switch
            // 
            this.C0_Switch.BackColor = System.Drawing.Color.LightCoral;
            this.C0_Switch.Location = new System.Drawing.Point(891, 13);
            this.C0_Switch.Name = "C0_Switch";
            this.C0_Switch.Size = new System.Drawing.Size(26, 140);
            this.C0_Switch.TabIndex = 11;
            this.C0_Switch.Text = "SwitchC0";
            this.C0_Switch.UseVisualStyleBackColor = false;
            this.C0_Switch.Click += new System.EventHandler(this.C0_Switch_Click);
            // 
            // C1_Switch
            // 
            this.C1_Switch.BackColor = System.Drawing.Color.LightCoral;
            this.C1_Switch.Location = new System.Drawing.Point(891, 167);
            this.C1_Switch.Name = "C1_Switch";
            this.C1_Switch.Size = new System.Drawing.Size(26, 140);
            this.C1_Switch.TabIndex = 12;
            this.C1_Switch.Text = "SwitchC1";
            this.C1_Switch.UseVisualStyleBackColor = false;
            // 
            // C2_Switch
            // 
            this.C2_Switch.BackColor = System.Drawing.Color.LightCoral;
            this.C2_Switch.Location = new System.Drawing.Point(891, 326);
            this.C2_Switch.Name = "C2_Switch";
            this.C2_Switch.Size = new System.Drawing.Size(26, 140);
            this.C2_Switch.TabIndex = 13;
            this.C2_Switch.Text = "SwitchC1";
            this.C2_Switch.UseVisualStyleBackColor = false;
            // 
            // C3_Switch
            // 
            this.C3_Switch.BackColor = System.Drawing.Color.LightCoral;
            this.C3_Switch.Location = new System.Drawing.Point(891, 486);
            this.C3_Switch.Name = "C3_Switch";
            this.C3_Switch.Size = new System.Drawing.Size(26, 140);
            this.C3_Switch.TabIndex = 14;
            this.C3_Switch.Text = "SwitchC1";
            this.C3_Switch.UseVisualStyleBackColor = false;
            // 
            // MainFrame
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1117, 638);
            this.Controls.Add(this.C3_Switch);
            this.Controls.Add(this.C2_Switch);
            this.Controls.Add(this.C1_Switch);
            this.Controls.Add(this.C0_Switch);
            this.Controls.Add(this.charTitleUIText);
            this.Controls.Add(this.charNameUIText);
            this.Controls.Add(this.ToolBar);
            this.Controls.Add(this.C3_Button);
            this.Controls.Add(this.C2_Button);
            this.Controls.Add(this.C1_Button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.C0_Button);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.OrangeRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainFrame";
            this.Text = "KleeMains";
            this.Load += new System.EventHandler(this.MainFrame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToolBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button C0_Button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button C1_Button;
        private System.Windows.Forms.Button C2_Button;
        private System.Windows.Forms.Button C3_Button;
        private System.Windows.Forms.PictureBox ToolBar;
        private System.Windows.Forms.Label charNameUIText;
        private System.Windows.Forms.Label charTitleUIText;
        private System.Windows.Forms.Button C0_Switch;
        private System.Windows.Forms.Button C1_Switch;
        private System.Windows.Forms.Button C2_Switch;
        private System.Windows.Forms.Button C3_Switch;
    }
}

