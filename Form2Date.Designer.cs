using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    partial class Form2Date
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconToolStripButton1 = new FontAwesome.Sharp.IconToolStripButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 47);
            this.label2.MinimumSize = new System.Drawing.Size(160, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(415, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Decouvre le nom de la planete en cliquant";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(826, 47);
            this.label1.MaximumSize = new System.Drawing.Size(550, 550);
            this.label1.MinimumSize = new System.Drawing.Size(550, 550);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 550);
            this.label1.TabIndex = 1;
            this.label1.Text = "Découvrer la description en cliquant";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // iconToolStripButton1
            // 
            this.iconToolStripButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconToolStripButton1.IconColor = System.Drawing.Color.Black;
            this.iconToolStripButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconToolStripButton1.Name = "iconToolStripButton1";
            this.iconToolStripButton1.Size = new System.Drawing.Size(23, 23);
            this.iconToolStripButton1.Text = "iconToolStripButton1";
            // 
            // Form2Date
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(1442, 630);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Form2Date";
            this.Text = "Form2Date";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private Label label2;
        private Label label1;
        private FontAwesome.Sharp.IconToolStripButton iconToolStripButton1;
    }
}