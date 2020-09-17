namespace game
{
    partial class FrmHighScores
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lstBoxName = new System.Windows.Forms.ListBox();
            this.lstBoxScore = new System.Windows.Forms.ListBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "score";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "players score";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "players name";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(186, 337);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(33, 13);
            this.lblPlayerName.TabIndex = 6;
            this.lblPlayerName.Text = "name";
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.Location = new System.Drawing.Point(186, 374);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(33, 13);
            this.lblPlayerScore.TabIndex = 7;
            this.lblPlayerScore.Text = "score";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(291, 351);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.Text = "return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lstBoxName
            // 
            this.lstBoxName.FormattingEnabled = true;
            this.lstBoxName.Location = new System.Drawing.Point(103, 79);
            this.lstBoxName.Name = "lstBoxName";
            this.lstBoxName.Size = new System.Drawing.Size(120, 225);
            this.lstBoxName.TabIndex = 9;
            // 
            // lstBoxScore
            // 
            this.lstBoxScore.FormattingEnabled = true;
            this.lstBoxScore.Location = new System.Drawing.Point(236, 79);
            this.lstBoxScore.Name = "lstBoxScore";
            this.lstBoxScore.Size = new System.Drawing.Size(120, 225);
            this.lstBoxScore.TabIndex = 10;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(458, 155);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(69, 13);
            this.lblMessage.TabIndex = 11;
            this.lblMessage.Text = "players name";
            // 
            // FrmHighScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lstBoxScore);
            this.Controls.Add(this.lstBoxName);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblPlayerScore);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmHighScores";
            this.Text = "FrmHighScores";
            this.Load += new System.EventHandler(this.FrmHighScores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ListBox lstBoxName;
        private System.Windows.Forms.ListBox lstBoxScore;
        private System.Windows.Forms.Label lblMessage;
    }
}