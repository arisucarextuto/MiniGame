
namespace MiniGame
{
    partial class Frmじゃんけん
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
            this.btnグー = new System.Windows.Forms.Button();
            this.btnパー = new System.Windows.Forms.Button();
            this.btnチョキ = new System.Windows.Forms.Button();
            this.IblReady = new System.Windows.Forms.Label();
            this.pbCPU = new System.Windows.Forms.PictureBox();
            this.Ibl勝敗 = new System.Windows.Forms.Label();
            this.btnスタート = new System.Windows.Forms.Button();
            this.btn戻る = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCPU)).BeginInit();
            this.SuspendLayout();
            // 
            // btnグー
            // 
            this.btnグー.BackColor = System.Drawing.Color.LightGray;
            this.btnグー.BackgroundImage = global::MiniGame.Properties.Resources.グー;
            this.btnグー.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnグー.Location = new System.Drawing.Point(27, 312);
            this.btnグー.Margin = new System.Windows.Forms.Padding(20, 70, 20, 20);
            this.btnグー.Name = "btnグー";
            this.btnグー.Size = new System.Drawing.Size(100, 80);
            this.btnグー.TabIndex = 0;
            this.btnグー.UseVisualStyleBackColor = false;
            this.btnグー.Click += new System.EventHandler(this.btnじゃんけん_Click);
            // 
            // btnパー
            // 
            this.btnパー.BackColor = System.Drawing.Color.LightGray;
            this.btnパー.BackgroundImage = global::MiniGame.Properties.Resources.パー;
            this.btnパー.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnパー.Location = new System.Drawing.Point(307, 312);
            this.btnパー.Margin = new System.Windows.Forms.Padding(20, 70, 20, 20);
            this.btnパー.Name = "btnパー";
            this.btnパー.Size = new System.Drawing.Size(100, 80);
            this.btnパー.TabIndex = 0;
            this.btnパー.UseVisualStyleBackColor = false;
            this.btnパー.Click += new System.EventHandler(this.btnじゃんけん_Click);
            // 
            // btnチョキ
            // 
            this.btnチョキ.BackColor = System.Drawing.Color.LightGray;
            this.btnチョキ.BackgroundImage = global::MiniGame.Properties.Resources.チョキ;
            this.btnチョキ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnチョキ.Location = new System.Drawing.Point(167, 312);
            this.btnチョキ.Margin = new System.Windows.Forms.Padding(20, 70, 20, 5);
            this.btnチョキ.Name = "btnチョキ";
            this.btnチョキ.Size = new System.Drawing.Size(100, 80);
            this.btnチョキ.TabIndex = 0;
            this.btnチョキ.UseVisualStyleBackColor = false;
            this.btnチョキ.Click += new System.EventHandler(this.btnじゃんけん_Click);
            // 
            // IblReady
            // 
            this.IblReady.AutoSize = true;
            this.IblReady.Font = new System.Drawing.Font("MS UI Gothic", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.IblReady.Location = new System.Drawing.Point(52, 109);
            this.IblReady.Margin = new System.Windows.Forms.Padding(3, 100, 3, 0);
            this.IblReady.Name = "IblReady";
            this.IblReady.Size = new System.Drawing.Size(347, 80);
            this.IblReady.TabIndex = 1;
            this.IblReady.Text = "じゃんけん";
            // 
            // pbCPU
            // 
            this.pbCPU.Location = new System.Drawing.Point(118, 90);
            this.pbCPU.Name = "pbCPU";
            this.pbCPU.Size = new System.Drawing.Size(200, 200);
            this.pbCPU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCPU.TabIndex = 2;
            this.pbCPU.TabStop = false;
            // 
            // Ibl勝敗
            // 
            this.Ibl勝敗.AutoSize = true;
            this.Ibl勝敗.Font = new System.Drawing.Font("MS UI Gothic", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Ibl勝敗.ForeColor = System.Drawing.Color.Red;
            this.Ibl勝敗.Location = new System.Drawing.Point(123, 10);
            this.Ibl勝敗.Margin = new System.Windows.Forms.Padding(3, 100, 3, 0);
            this.Ibl勝敗.Name = "Ibl勝敗";
            this.Ibl勝敗.Size = new System.Drawing.Size(149, 67);
            this.Ibl勝敗.TabIndex = 1;
            this.Ibl勝敗.Text = "勝ち";
            // 
            // btnスタート
            // 
            this.btnスタート.Location = new System.Drawing.Point(182, 400);
            this.btnスタート.Name = "btnスタート";
            this.btnスタート.Size = new System.Drawing.Size(75, 23);
            this.btnスタート.TabIndex = 3;
            this.btnスタート.Text = "スタート";
            this.btnスタート.UseVisualStyleBackColor = true;
            this.btnスタート.Click += new System.EventHandler(this.btnスタート_Click);
            // 
            // btn戻る
            // 
            this.btn戻る.Location = new System.Drawing.Point(347, 400);
            this.btn戻る.Name = "btn戻る";
            this.btn戻る.Size = new System.Drawing.Size(75, 23);
            this.btn戻る.TabIndex = 3;
            this.btn戻る.Text = "戻る";
            this.btn戻る.UseVisualStyleBackColor = true;
            this.btn戻る.Click += new System.EventHandler(this.btn戻る_Click);
            // 
            // Frmじゃんけん
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 431);
            this.Controls.Add(this.btn戻る);
            this.Controls.Add(this.btnスタート);
            this.Controls.Add(this.pbCPU);
            this.Controls.Add(this.Ibl勝敗);
            this.Controls.Add(this.IblReady);
            this.Controls.Add(this.btnパー);
            this.Controls.Add(this.btnチョキ);
            this.Controls.Add(this.btnグー);
            this.Name = "Frmじゃんけん";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "じゃんけん";
            this.Load += new System.EventHandler(this.Frmじゃんけん_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCPU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnパー;
        private System.Windows.Forms.Button btnグー;
        private System.Windows.Forms.Button btnチョキ;
        private System.Windows.Forms.Label IblReady;
        private System.Windows.Forms.PictureBox pbCPU;
        private System.Windows.Forms.Label Ibl勝敗;
        private System.Windows.Forms.Button btnスタート;
        private System.Windows.Forms.Button btn戻る;
    }
}