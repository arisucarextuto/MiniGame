
namespace MiniGame
{
    partial class Frmスロット
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
            this.IblMsg = new System.Windows.Forms.Label();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.btnStop1 = new System.Windows.Forms.Button();
            this.btnStop3 = new System.Windows.Forms.Button();
            this.btnStop2 = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btn戻る = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            this.SuspendLayout();
            // 
            // IblMsg
            // 
            this.IblMsg.AutoSize = true;
            this.IblMsg.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.IblMsg.ForeColor = System.Drawing.Color.Red;
            this.IblMsg.Location = new System.Drawing.Point(204, 59);
            this.IblMsg.Name = "IblMsg";
            this.IblMsg.Size = new System.Drawing.Size(77, 27);
            this.IblMsg.TabIndex = 10;
            this.IblMsg.Text = "当たり";
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(72, 102);
            this.pb1.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(100, 100);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1.TabIndex = 7;
            this.pb1.TabStop = false;
            // 
            // pb3
            // 
            this.pb3.Location = new System.Drawing.Point(312, 102);
            this.pb3.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(100, 100);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb3.TabIndex = 8;
            this.pb3.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(192, 102);
            this.pb2.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(100, 100);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb2.TabIndex = 9;
            this.pb2.TabStop = false;
            // 
            // btnStop1
            // 
            this.btnStop1.Location = new System.Drawing.Point(72, 215);
            this.btnStop1.Margin = new System.Windows.Forms.Padding(10, 10, 10, 100);
            this.btnStop1.Name = "btnStop1";
            this.btnStop1.Size = new System.Drawing.Size(100, 23);
            this.btnStop1.TabIndex = 3;
            this.btnStop1.Text = "ストップ";
            this.btnStop1.UseVisualStyleBackColor = true;
            this.btnStop1.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStop3
            // 
            this.btnStop3.Location = new System.Drawing.Point(312, 215);
            this.btnStop3.Margin = new System.Windows.Forms.Padding(10, 10, 10, 100);
            this.btnStop3.Name = "btnStop3";
            this.btnStop3.Size = new System.Drawing.Size(100, 23);
            this.btnStop3.TabIndex = 4;
            this.btnStop3.Text = "ストップ";
            this.btnStop3.UseVisualStyleBackColor = true;
            this.btnStop3.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStop2
            // 
            this.btnStop2.Location = new System.Drawing.Point(192, 215);
            this.btnStop2.Margin = new System.Windows.Forms.Padding(10, 10, 10, 100);
            this.btnStop2.Name = "btnStop2";
            this.btnStop2.Size = new System.Drawing.Size(100, 23);
            this.btnStop2.TabIndex = 5;
            this.btnStop2.Text = "ストップ";
            this.btnStop2.UseVisualStyleBackColor = true;
            this.btnStop2.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(192, 22);
            this.btnStart.Margin = new System.Windows.Forms.Padding(200, 25, 3, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "スタート";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btn戻る
            // 
            this.btn戻る.Location = new System.Drawing.Point(372, 12);
            this.btn戻る.Name = "btn戻る";
            this.btn戻る.Size = new System.Drawing.Size(100, 23);
            this.btn戻る.TabIndex = 6;
            this.btn戻る.Text = "戻る";
            this.btn戻る.UseVisualStyleBackColor = true;
            this.btn戻る.Click += new System.EventHandler(this.btn戻る_Click);
            // 
            // Frmスロット
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.IblMsg);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.btnStop1);
            this.Controls.Add(this.btnStop3);
            this.Controls.Add(this.btnStop2);
            this.Controls.Add(this.btn戻る);
            this.Controls.Add(this.btnStart);
            this.Name = "Frmスロット";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSlot";
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IblMsg;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.Button btnStop1;
        private System.Windows.Forms.Button btnStop3;
        private System.Windows.Forms.Button btnStop2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btn戻る;
    }
}