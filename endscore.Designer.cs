namespace game
{
    partial class endscore
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtScore = new System.Windows.Forms.TextBox();
            this.BtnCheck = new System.Windows.Forms.Button();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "score";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(406, 166);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 20);
            this.TxtName.TabIndex = 2;
            // 
            // TxtScore
            // 
            this.TxtScore.Location = new System.Drawing.Point(406, 203);
            this.TxtScore.Name = "TxtScore";
            this.TxtScore.Size = new System.Drawing.Size(100, 20);
            this.TxtScore.TabIndex = 3;
            // 
            // BtnCheck
            // 
            this.BtnCheck.Location = new System.Drawing.Point(353, 280);
            this.BtnCheck.Name = "BtnCheck";
            this.BtnCheck.Size = new System.Drawing.Size(75, 23);
            this.BtnCheck.TabIndex = 4;
            this.BtnCheck.Text = "scores";
            this.BtnCheck.UseVisualStyleBackColor = true;
            this.BtnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // BtnQuit
            // 
            this.BtnQuit.Location = new System.Drawing.Point(353, 309);
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Size = new System.Drawing.Size(75, 23);
            this.BtnQuit.TabIndex = 5;
            this.BtnQuit.Text = "quit";
            this.BtnQuit.UseVisualStyleBackColor = true;
            this.BtnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // endscore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnQuit);
            this.Controls.Add(this.BtnCheck);
            this.Controls.Add(this.TxtScore);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "endscore";
            this.Text = "endscore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtScore;
        private System.Windows.Forms.Button BtnCheck;
        private System.Windows.Forms.Button BtnQuit;
    }
}