
namespace project_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.health = new System.Windows.Forms.Label();
            this.coins = new System.Windows.Forms.Label();
            this.power = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.HPP = new System.Windows.Forms.PictureBox();
            this.CNP = new System.Windows.Forms.PictureBox();
            this.PWP = new System.Windows.Forms.PictureBox();
            this.playbutton = new System.Windows.Forms.PictureBox();
            this.heading = new System.Windows.Forms.PictureBox();
            this.visual = new System.Windows.Forms.PictureBox();
            this.textbg = new System.Windows.Forms.PictureBox();
            this.text = new System.Windows.Forms.Label();
            this.choosebgr = new System.Windows.Forms.PictureBox();
            this.choosebgl = new System.Windows.Forms.PictureBox();
            this.choosebgcntr = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.HPP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CNP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PWP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playbutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textbg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.choosebgr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.choosebgl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.choosebgcntr)).BeginInit();
            this.SuspendLayout();
            // 
            // health
            // 
            this.health.AutoSize = true;
            this.health.BackColor = System.Drawing.Color.Transparent;
            this.health.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.health.ForeColor = System.Drawing.Color.White;
            this.health.Location = new System.Drawing.Point(77, 49);
            this.health.Name = "health";
            this.health.Size = new System.Drawing.Size(129, 39);
            this.health.TabIndex = 3;
            this.health.Text = "Health";
            this.health.Visible = false;
            this.health.Click += new System.EventHandler(this.health_Click);
            // 
            // coins
            // 
            this.coins.AutoSize = true;
            this.coins.BackColor = System.Drawing.Color.Transparent;
            this.coins.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coins.ForeColor = System.Drawing.Color.White;
            this.coins.Location = new System.Drawing.Point(76, 94);
            this.coins.Name = "coins";
            this.coins.Size = new System.Drawing.Size(127, 44);
            this.coins.TabIndex = 4;
            this.coins.Text = "Coins";
            this.coins.Visible = false;
            // 
            // power
            // 
            this.power.AutoSize = true;
            this.power.BackColor = System.Drawing.Color.Transparent;
            this.power.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.power.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.power.Location = new System.Drawing.Point(77, 140);
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(131, 42);
            this.power.TabIndex = 5;
            this.power.Text = "Power";
            this.power.Visible = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(45, 518);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(540, 180);
            this.button2.TabIndex = 6;
            this.button2.Text = "Fight";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(702, 518);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(540, 180);
            this.button3.TabIndex = 7;
            this.button3.Text = "Run";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitbutton.BackColor = System.Drawing.Color.Red;
            this.exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitbutton.Location = new System.Drawing.Point(1226, 12);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(42, 35);
            this.exitbutton.TabIndex = 10;
            this.exitbutton.Text = "Х";
            this.exitbutton.UseVisualStyleBackColor = false;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // HPP
            // 
            this.HPP.BackColor = System.Drawing.Color.Transparent;
            this.HPP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HPP.BackgroundImage")));
            this.HPP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HPP.Location = new System.Drawing.Point(33, 48);
            this.HPP.Name = "HPP";
            this.HPP.Size = new System.Drawing.Size(41, 40);
            this.HPP.TabIndex = 11;
            this.HPP.TabStop = false;
            this.HPP.Visible = false;
            // 
            // CNP
            // 
            this.CNP.BackColor = System.Drawing.Color.Transparent;
            this.CNP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CNP.BackgroundImage")));
            this.CNP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CNP.Location = new System.Drawing.Point(33, 94);
            this.CNP.Name = "CNP";
            this.CNP.Size = new System.Drawing.Size(41, 40);
            this.CNP.TabIndex = 12;
            this.CNP.TabStop = false;
            this.CNP.Visible = false;
            // 
            // PWP
            // 
            this.PWP.BackColor = System.Drawing.Color.Transparent;
            this.PWP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PWP.BackgroundImage")));
            this.PWP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PWP.Location = new System.Drawing.Point(33, 140);
            this.PWP.Name = "PWP";
            this.PWP.Size = new System.Drawing.Size(41, 40);
            this.PWP.TabIndex = 13;
            this.PWP.TabStop = false;
            this.PWP.Visible = false;
            // 
            // playbutton
            // 
            this.playbutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.playbutton.BackColor = System.Drawing.Color.Transparent;
            this.playbutton.Image = ((System.Drawing.Image)(resources.GetObject("playbutton.Image")));
            this.playbutton.Location = new System.Drawing.Point(556, 622);
            this.playbutton.Name = "playbutton";
            this.playbutton.Size = new System.Drawing.Size(165, 76);
            this.playbutton.TabIndex = 14;
            this.playbutton.TabStop = false;
            this.playbutton.Click += new System.EventHandler(this.playbutton_Click);
            this.playbutton.MouseEnter += new System.EventHandler(this.playbutton_MouseEnter);
            // 
            // heading
            // 
            this.heading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.heading.BackColor = System.Drawing.Color.White;
            this.heading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.heading.Location = new System.Drawing.Point(526, 10);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(239, 37);
            this.heading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heading.TabIndex = 15;
            this.heading.TabStop = false;
            // 
            // visual
            // 
            this.visual.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.visual.Image = ((System.Drawing.Image)(resources.GetObject("visual.Image")));
            this.visual.Location = new System.Drawing.Point(346, 55);
            this.visual.Name = "visual";
            this.visual.Size = new System.Drawing.Size(593, 321);
            this.visual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.visual.TabIndex = 16;
            this.visual.TabStop = false;
            // 
            // textbg
            // 
            this.textbg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textbg.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textbg.Location = new System.Drawing.Point(346, 382);
            this.textbg.Name = "textbg";
            this.textbg.Size = new System.Drawing.Size(593, 145);
            this.textbg.TabIndex = 17;
            this.textbg.TabStop = false;
            // 
            // text
            // 
            this.text.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.text.AutoSize = true;
            this.text.BackColor = System.Drawing.Color.Black;
            this.text.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text.ForeColor = System.Drawing.SystemColors.Control;
            this.text.Location = new System.Drawing.Point(441, 431);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(430, 28);
            this.text.TabIndex = 18;
            this.text.Text = "Тут буде текст який описує ігрову подію";
            // 
            // choosebgr
            // 
            this.choosebgr.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.choosebgr.Location = new System.Drawing.Point(1020, 382);
            this.choosebgr.Name = "choosebgr";
            this.choosebgr.Size = new System.Drawing.Size(100, 50);
            this.choosebgr.TabIndex = 19;
            this.choosebgr.TabStop = false;
            // 
            // choosebgl
            // 
            this.choosebgl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.choosebgl.BackColor = System.Drawing.Color.Transparent;
            this.choosebgl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.choosebgl.Image = ((System.Drawing.Image)(resources.GetObject("choosebgl.Image")));
            this.choosebgl.Location = new System.Drawing.Point(45, 459);
            this.choosebgl.Name = "choosebgl";
            this.choosebgl.Size = new System.Drawing.Size(141, 122);
            this.choosebgl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.choosebgl.TabIndex = 20;
            this.choosebgl.TabStop = false;
            // 
            // choosebgcntr
            // 
            this.choosebgcntr.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.choosebgcntr.Location = new System.Drawing.Point(1020, 442);
            this.choosebgcntr.Name = "choosebgcntr";
            this.choosebgcntr.Size = new System.Drawing.Size(100, 50);
            this.choosebgcntr.TabIndex = 21;
            this.choosebgcntr.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.choosebgcntr);
            this.Controls.Add(this.choosebgl);
            this.Controls.Add(this.choosebgr);
            this.Controls.Add(this.text);
            this.Controls.Add(this.textbg);
            this.Controls.Add(this.visual);
            this.Controls.Add(this.heading);
            this.Controls.Add(this.playbutton);
            this.Controls.Add(this.PWP);
            this.Controls.Add(this.CNP);
            this.Controls.Add(this.HPP);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.power);
            this.Controls.Add(this.coins);
            this.Controls.Add(this.health);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HPP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CNP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PWP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playbutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textbg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.choosebgr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.choosebgl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.choosebgcntr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label health;
        private System.Windows.Forms.Label coins;
        private System.Windows.Forms.Label power;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.PictureBox HPP;
        private System.Windows.Forms.PictureBox CNP;
        private System.Windows.Forms.PictureBox PWP;
        private System.Windows.Forms.PictureBox playbutton;
        private System.Windows.Forms.PictureBox heading;
        private System.Windows.Forms.PictureBox visual;
        private System.Windows.Forms.PictureBox textbg;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.PictureBox choosebgr;
        private System.Windows.Forms.PictureBox choosebgl;
        private System.Windows.Forms.PictureBox choosebgcntr;
    }
}

