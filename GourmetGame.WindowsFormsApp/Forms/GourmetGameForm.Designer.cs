namespace GourmetGame.WindowsFormsApp.Forms
{
    partial class GourmetGameForm
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
            this.LbInitialMessage = new System.Windows.Forms.Label();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbInitialMessage
            // 
            this.LbInitialMessage.AutoSize = true;
            this.LbInitialMessage.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbInitialMessage.Location = new System.Drawing.Point(63, 9);
            this.LbInitialMessage.Name = "LbInitialMessage";
            this.LbInitialMessage.Size = new System.Drawing.Size(109, 17);
            this.LbInitialMessage.TabIndex = 0;
            this.LbInitialMessage.Text = "lbInitialMessage";
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(122, 66);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(75, 23);
            this.btnStartGame.TabIndex = 1;
            this.btnStartGame.Text = "Ok";
            this.btnStartGame.UseVisualStyleBackColor = true;
            // 
            // GourmetGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 101);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.LbInitialMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GourmetGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbInitialMessage;
        private System.Windows.Forms.Button btnStartGame;
    }
}

