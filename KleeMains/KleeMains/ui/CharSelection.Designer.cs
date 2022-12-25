using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace KleeMains
{
    partial class CharSelection
    {

        private System.ComponentModel.IContainer components = null;



        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.charPanel = new System.Windows.Forms.FlowLayoutPanel();
    
            

            //ALL CHARS BUTTONS
            for(int i = 0; i < Program.characters.Count; i++)
            {
                this.buttons.Add(new System.Windows.Forms.Button());
            }
            

   


            this.charPanel.SuspendLayout();
            this.SuspendLayout();
        
            this.charPanel.AutoScroll = true;    
            this.charPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            for (int i = 0; i < Program.characters.Count; i++)
            {
                this.charPanel.Controls.Add(this.buttons[i]);
            }
            
            this.charPanel.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.charPanel.Location = new System.Drawing.Point(12, 12);
            this.charPanel.Name = "charPanel";
            this.charPanel.Size = new System.Drawing.Size(690, 424);
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
                    this.buttons[buttoncount].Size = new System.Drawing.Size(109, 127); //91,106
                    this.buttons[buttoncount].TabIndex = buttoncount;
                    this.buttons[buttoncount].UseVisualStyleBackColor = true;
                    this.buttons[buttoncount].Click += new System.EventHandler(this.selectChar);
                    this.buttons[buttoncount].BackgroundImageLayout = ImageLayout.Stretch;
                    this.buttons[buttoncount].BackgroundImage = System.Drawing.Image.FromFile(System.IO.Path.GetDirectoryName(Application.ExecutablePath) +
               @"/Resources/Characters/" + Program.characters[buttoncount].getName() + "/" + Program.characters[buttoncount].getName() + "_Thumb.png");
                    if (Program.characters[buttoncount].getRarity())
                    {
                        this.buttons[buttoncount].BackColor = System.Drawing.Color.DarkGoldenrod;
                    }
                    else
                    {
                        this.buttons[buttoncount].BackColor = System.Drawing.Color.MediumPurple;
                    }
                    buttoncount++;
                    
                }
                
            }

            



   
      

            // 
            // CharSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(715, 450);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(this.charPanel);
            this.Name = "CharSelection";
            this.Text = "Form1";
            this.charPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        private System.Windows.Forms.FlowLayoutPanel charPanel;
        private List<System.Windows.Forms.Button> buttons =  new List<System.Windows.Forms.Button>();
    }
}