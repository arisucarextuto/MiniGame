
namespace MiniGame.Cls
{
    partial class Frmスライドショー
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
            this.btn終了 = new System.Windows.Forms.Button();
            this.btn開始 = new System.Windows.Forms.Button();
            this.btn停止 = new System.Windows.Forms.Button();
            this.btn戻る = new System.Windows.Forms.Button();
            this.pb画像 = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb画像)).BeginInit();
            this.SuspendLayout();
            // 
            // btn終了
            // 
            this.btn終了.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn終了.Location = new System.Drawing.Point(417, 422);
            this.btn終了.Name = "btn終了";
            this.btn終了.Size = new System.Drawing.Size(55, 23);
            this.btn終了.TabIndex = 3;
            this.btn終了.Text = "終了";
            this.btn終了.UseVisualStyleBackColor = true;
            this.btn終了.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn開始
            // 
            this.btn開始.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn開始.Location = new System.Drawing.Point(234, 422);
            this.btn開始.Name = "btn開始";
            this.btn開始.Size = new System.Drawing.Size(55, 23);
            this.btn開始.TabIndex = 4;
            this.btn開始.Text = "開始";
            this.btn開始.UseVisualStyleBackColor = true;
            this.btn開始.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn停止
            // 
            this.btn停止.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn停止.Location = new System.Drawing.Point(295, 422);
            this.btn停止.Name = "btn停止";
            this.btn停止.Size = new System.Drawing.Size(55, 23);
            this.btn停止.TabIndex = 5;
            this.btn停止.Text = "停止";
            this.btn停止.UseVisualStyleBackColor = true;
            this.btn停止.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn戻る
            // 
            this.btn戻る.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn戻る.Location = new System.Drawing.Point(356, 422);
            this.btn戻る.Name = "btn戻る";
            this.btn戻る.Size = new System.Drawing.Size(55, 23);
            this.btn戻る.TabIndex = 6;
            this.btn戻る.Text = "戻る";
            this.btn戻る.UseVisualStyleBackColor = true;
            this.btn戻る.Click += new System.EventHandler(this.btn_Click);
            // 
            // pb画像
            // 
            this.pb画像.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb画像.Location = new System.Drawing.Point(12, 16);
            this.pb画像.Name = "pb画像";
            this.pb画像.Size = new System.Drawing.Size(460, 400);
            this.pb画像.TabIndex = 2;
            this.pb画像.TabStop = false;
            this.pb画像.SizeChanged += new System.EventHandler(this.pb画像_SizeChanged);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Frmスライドショー
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.btn終了);
            this.Controls.Add(this.btn開始);
            this.Controls.Add(this.btn停止);
            this.Controls.Add(this.btn戻る);
            this.Controls.Add(this.pb画像);
            this.Name = "Frmスライドショー";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "スライドショー";
            ((System.ComponentModel.ISupportInitialize)(this.pb画像)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn終了;
        private System.Windows.Forms.Button btn開始;
        private System.Windows.Forms.Button btn停止;
        private System.Windows.Forms.Button btn戻る;
        private System.Windows.Forms.PictureBox pb画像;
        private System.Windows.Forms.Timer timer;
    }
}