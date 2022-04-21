
namespace MiniGame
{
    partial class Frmパズル
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
            this.btn戻る = new System.Windows.Forms.Button();
            this.btnもう1回 = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btn戻る
            // 
            this.btn戻る.Location = new System.Drawing.Point(296, 442);
            this.btn戻る.Name = "btn戻る";
            this.btn戻る.Size = new System.Drawing.Size(75, 23);
            this.btn戻る.TabIndex = 4;
            this.btn戻る.Text = "戻る";
            this.btn戻る.UseVisualStyleBackColor = true;
            this.btn戻る.Click += new System.EventHandler(this.btn戻る_Click);
            // 
            // btnもう1回
            // 
            this.btnもう1回.Location = new System.Drawing.Point(377, 442);
            this.btnもう1回.Name = "btnもう1回";
            this.btnもう1回.Size = new System.Drawing.Size(75, 23);
            this.btnもう1回.TabIndex = 3;
            this.btnもう1回.Text = "もう1回";
            this.btnもう1回.UseVisualStyleBackColor = true;
            this.btnもう1回.Click += new System.EventHandler(this.btnもう1回_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(32, 16);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(420, 420);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // Frmパズル
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 481);
            this.Controls.Add(this.btn戻る);
            this.Controls.Add(this.btnもう1回);
            this.Controls.Add(this.pictureBox);
            this.Name = "Frmパズル";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frmパズル";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmPuzzle_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn戻る;
        private System.Windows.Forms.Button btnもう1回;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}