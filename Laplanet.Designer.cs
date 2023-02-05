using System;
using WindowsFormsApp1;
namespace WindowsFormsApp1
{
    public class AsteroidData
    {
        public string name { get; set; }
        public double diameter { get; set; }
        // Etc. pour les autres variables
    }
    partial class Laplanet
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.BtnContact = new FontAwesome.Sharp.IconButton();
            this.Btn3D = new FontAwesome.Sharp.IconButton();
            this.Btn2D = new FontAwesome.Sharp.IconButton();
            this.Btn1D = new FontAwesome.Sharp.IconButton();
            this.BtnHome = new FontAwesome.Sharp.IconButton();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildFrom = new FontAwesome.Sharp.IconPictureBox();
            this.panelPhadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildFrom)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(30)))), ((int)(((byte)(168)))));
            this.panelMenu.Controls.Add(this.BtnContact);
            this.panelMenu.Controls.Add(this.Btn3D);
            this.panelMenu.Controls.Add(this.Btn2D);
            this.panelMenu.Controls.Add(this.Btn1D);
            this.panelMenu.Controls.Add(this.BtnHome);
            this.panelMenu.Controls.Add(this.PanelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 585);
            this.panelMenu.TabIndex = 0;
            // 
            // BtnContact
            // 
            this.BtnContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(30)))), ((int)(((byte)(168)))));
            this.BtnContact.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnContact.FlatAppearance.BorderSize = 0;
            this.BtnContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnContact.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnContact.IconChar = FontAwesome.Sharp.IconChar.Comment;
            this.BtnContact.IconColor = System.Drawing.Color.White;
            this.BtnContact.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnContact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnContact.Location = new System.Drawing.Point(0, 380);
            this.BtnContact.Name = "BtnContact";
            this.BtnContact.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnContact.Size = new System.Drawing.Size(220, 60);
            this.BtnContact.TabIndex = 5;
            this.BtnContact.Text = "Contact";
            this.BtnContact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnContact.UseVisualStyleBackColor = false;
            this.BtnContact.Click += new System.EventHandler(this.BtnContact_Click);
            // 
            // Btn3D
            // 
            this.Btn3D.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(30)))), ((int)(((byte)(168)))));
            this.Btn3D.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn3D.FlatAppearance.BorderSize = 0;
            this.Btn3D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn3D.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn3D.IconChar = FontAwesome.Sharp.IconChar.Rocket;
            this.Btn3D.IconColor = System.Drawing.Color.White;
            this.Btn3D.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn3D.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn3D.Location = new System.Drawing.Point(0, 320);
            this.Btn3D.Name = "Btn3D";
            this.Btn3D.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Btn3D.Size = new System.Drawing.Size(220, 60);
            this.Btn3D.TabIndex = 4;
            this.Btn3D.Text = "3eme Date";
            this.Btn3D.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn3D.UseVisualStyleBackColor = false;
            this.Btn3D.Click += new System.EventHandler(this.Btn3D_Click);
            // 
            // Btn2D
            // 
            this.Btn2D.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(30)))), ((int)(((byte)(168)))));
            this.Btn2D.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn2D.FlatAppearance.BorderSize = 0;
            this.Btn2D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn2D.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn2D.IconChar = FontAwesome.Sharp.IconChar.Rocket;
            this.Btn2D.IconColor = System.Drawing.Color.White;
            this.Btn2D.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn2D.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn2D.Location = new System.Drawing.Point(0, 260);
            this.Btn2D.Name = "Btn2D";
            this.Btn2D.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Btn2D.Size = new System.Drawing.Size(220, 60);
            this.Btn2D.TabIndex = 3;
            this.Btn2D.Text = "2eme Date";
            this.Btn2D.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn2D.UseVisualStyleBackColor = false;
            this.Btn2D.Click += new System.EventHandler(this.Btn2D_Click);
            // 
            // Btn1D
            // 
            this.Btn1D.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(30)))), ((int)(((byte)(168)))));
            this.Btn1D.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn1D.FlatAppearance.BorderSize = 0;
            this.Btn1D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn1D.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn1D.IconChar = FontAwesome.Sharp.IconChar.Rocket;
            this.Btn1D.IconColor = System.Drawing.Color.White;
            this.Btn1D.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn1D.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn1D.Location = new System.Drawing.Point(0, 200);
            this.Btn1D.Name = "Btn1D";
            this.Btn1D.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Btn1D.Size = new System.Drawing.Size(220, 60);
            this.Btn1D.TabIndex = 2;
            this.Btn1D.Text = "1er Date";
            this.Btn1D.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn1D.UseVisualStyleBackColor = false;
            this.Btn1D.Click += new System.EventHandler(this.Btn1D_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(30)))), ((int)(((byte)(168)))));
            this.BtnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnHome.FlatAppearance.BorderSize = 0;
            this.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnHome.IconChar = FontAwesome.Sharp.IconChar.Reacteurope;
            this.BtnHome.IconColor = System.Drawing.Color.White;
            this.BtnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHome.Location = new System.Drawing.Point(0, 140);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnHome.Size = new System.Drawing.Size(220, 60);
            this.BtnHome.TabIndex = 1;
            this.BtnHome.Text = "Home";
            this.BtnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnHome.UseVisualStyleBackColor = false;
            this.BtnHome.Click += new System.EventHandler(this.Home_Click);
            // 
            // PanelLogo
            // 
            this.PanelLogo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelLogo.BackColor = System.Drawing.Color.Transparent;
            this.PanelLogo.Controls.Add(this.pictureBox1);
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(220, 140);
            this.PanelLogo.TabIndex = 1;
            this.PanelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelLogo_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.images__1_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 108);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Visible = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(30)))), ((int)(((byte)(168)))));
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.lblTitleChildForm);
            this.panel1.Controls.Add(this.iconCurrentChildFrom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(220, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 75);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(64, 31);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(35, 13);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildFrom
            // 
            this.iconCurrentChildFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(30)))), ((int)(((byte)(168)))));
            this.iconCurrentChildFrom.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconCurrentChildFrom.IconChar = FontAwesome.Sharp.IconChar.HouseChimneyWindow;
            this.iconCurrentChildFrom.IconColor = System.Drawing.Color.Gainsboro;
            this.iconCurrentChildFrom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildFrom.IconSize = 31;
            this.iconCurrentChildFrom.Location = new System.Drawing.Point(26, 23);
            this.iconCurrentChildFrom.Name = "iconCurrentChildFrom";
            this.iconCurrentChildFrom.Size = new System.Drawing.Size(33, 31);
            this.iconCurrentChildFrom.TabIndex = 0;
            this.iconCurrentChildFrom.TabStop = false;
            // 
            // panelPhadow
            // 
            this.panelPhadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panelPhadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPhadow.Location = new System.Drawing.Point(220, 75);
            this.panelPhadow.Name = "panelPhadow";
            this.panelPhadow.Size = new System.Drawing.Size(1071, 10);
            this.panelPhadow.TabIndex = 7;
            this.panelPhadow.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPhadow_Paint);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(107)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 85);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1071, 500);
            this.panelDesktop.TabIndex = 8;
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(1035, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(36, 27);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.Text = "x";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // Laplanet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(122)))));
            this.ClientSize = new System.Drawing.Size(1291, 585);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelPhadow);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Name = "Laplanet";
            this.Text = "LaPlanet";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.PanelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildFrom)).EndInit();
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private FontAwesome.Sharp.IconButton BtnContact;
        private FontAwesome.Sharp.IconButton Btn3D;
        private FontAwesome.Sharp.IconButton Btn2D;
        private FontAwesome.Sharp.IconButton Btn1D;
        private FontAwesome.Sharp.IconButton BtnHome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildFrom;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelPhadow;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}

