namespace coven
{
    partial class home
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
            this.PnlGame = new System.Windows.Forms.Panel();
            this.characterBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtName = new System.Windows.Forms.Label();
            this.lblPlay = new System.Windows.Forms.Label();
            this.tmrIntersect = new System.Windows.Forms.Timer(this.components);
            this.PnlGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.characterBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlGame
            // 
            this.PnlGame.Controls.Add(this.characterBox);
            this.PnlGame.Controls.Add(this.pictureBox1);
            this.PnlGame.Controls.Add(this.pictureBox2);
            this.PnlGame.Location = new System.Drawing.Point(21, 58);
            this.PnlGame.Name = "PnlGame";
            this.PnlGame.Size = new System.Drawing.Size(1142, 685);
            this.PnlGame.TabIndex = 1;
            // 
            // characterBox
            // 
            this.characterBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.characterBox.Location = new System.Drawing.Point(0, 587);
            this.characterBox.Name = "characterBox";
            this.characterBox.Size = new System.Drawing.Size(100, 98);
            this.characterBox.TabIndex = 2;
            this.characterBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBox1.Location = new System.Drawing.Point(460, 174);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 175);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(474, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(164, 685);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(453, 18);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(203, 37);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "player name";
            // 
            // lblPlay
            // 
            this.lblPlay.AutoSize = true;
            this.lblPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlay.Location = new System.Drawing.Point(1240, 491);
            this.lblPlay.Name = "lblPlay";
            this.lblPlay.Size = new System.Drawing.Size(56, 25);
            this.lblPlay.TabIndex = 3;
            this.lblPlay.Text = "play";
            this.lblPlay.Click += new System.EventHandler(this.lblPlay_Click);
            // 
            // tmrIntersect
            // 
            this.tmrIntersect.Enabled = true;
            this.tmrIntersect.Tick += new System.EventHandler(this.tmrIntersect_Tick);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.lblPlay);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.PnlGame);
            this.Name = "home";
            this.Text = "home";
            this.Load += new System.EventHandler(this.home_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.home_KeyDown);
            this.PnlGame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.characterBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlGame;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPlay;
        private System.Windows.Forms.PictureBox characterBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer tmrIntersect;
    }
}