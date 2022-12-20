
using System.Collections.Generic;

namespace KleeMains
{
    partial class CharSelection
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
            this.charPanel = new System.Windows.Forms.FlowLayoutPanel();

            //ALL CHARS BUTTONS
            for(int i = 0; i < Program.characters.Count; i++)
            {
                this.buttons.Add(new System.Windows.Forms.Button());
            }
            

            //end


            this.charPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // charPanel
            // 
            this.charPanel.AutoScroll = true;
            this.charPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            for (int i = 0; i < Program.characters.Count; i++)
            {
                this.charPanel.Controls.Add(this.buttons[i]);
            }
            
            this.charPanel.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.charPanel.Location = new System.Drawing.Point(12, 12);
            this.charPanel.Name = "charPanel";
            this.charPanel.Size = new System.Drawing.Size(776, 424);
            this.charPanel.TabIndex = 0;
            // 
            // setting configs for buttons
            // 
            int buttoncount = 0;
            for (int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    if (buttoncount == Program.characters.Count)
                    {
                       
                        continue; //failsafe
                    }

                    this.buttons[buttoncount].Location = new System.Drawing.Point(3 , 3);
                    this.buttons[buttoncount].Name = "button"+buttoncount.ToString();
                    this.buttons[buttoncount].Size = new System.Drawing.Size(91, 106);
                    this.buttons[buttoncount].TabIndex = buttoncount;
                    this.buttons[buttoncount].Text = Program.characters[buttoncount].getName();
                    this.buttons[buttoncount].UseVisualStyleBackColor = true;
                    this.buttons[buttoncount].Click += new System.EventHandler(this.selectChar);
                    //add char card
                    //this.buttons[buttoncount].Image = 
                    buttoncount++;
                    
                }
                
            }

            



   
      

            // 
            // CharSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.charPanel);
            this.Name = "CharSelection";
            this.Text = "Form1";
            this.charPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel charPanel;
        private List<System.Windows.Forms.Button> buttons =  new List<System.Windows.Forms.Button>();
    }
}