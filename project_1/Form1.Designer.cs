
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
            this.label1 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.HPP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CNP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PWP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playbutton)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(482, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAGIC DREAMS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.button2.Location = new System.Drawing.Point(33, 519);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(482, 189);
            this.button2.TabIndex = 6;
            this.button2.Text = "Fight";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(766, 519);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(482, 189);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1280, 720);
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
            this.Controls.Add(this.label1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
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
    }
}

