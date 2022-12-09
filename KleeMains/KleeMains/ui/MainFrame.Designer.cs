
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
            this.pictureBox1.Location = new System.Drawing.Point(558, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 575);
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
            // MainFrame
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1117, 638);
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
    }
}

