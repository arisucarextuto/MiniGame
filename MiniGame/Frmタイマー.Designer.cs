
namespace MiniGame
{
    partial class Frmタイマー
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
            this.lblTime = new System.Windows.Forms.Label();
            this.btnM = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnreset = new System.Windows.Forms.Button();
            this.lbFilePath = new System.Windows.Forms.ListBox();
            this.btn戻る = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("MS UI Gothic", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTime.Location = new System.Drawing.Point(12, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(142, 53);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "00:00";
            // 
            // btnM
            // 
            this.btnM.Location = new System.Drawing.Point(160, 12);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(35, 23);
            this.btnM.TabIndex = 1;
            this.btnM.Text = "分";
            this.btnM.UseVisualStyleBackColor = true;
            this.btnM.Click += new System.EventHandler(this.btnMS_Clicked);
            // 
            // btnS
            // 
            this.btnS.Location = new System.Drawing.Point(160, 41);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(35, 23);
            this.btnS.TabIndex = 1;
            this.btnS.Text = "秒";
            this.btnS.UseVisualStyleBackColor = true;
            this.btnS.Click += new System.EventHandler(this.btnMS_Clicked);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(201, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "開始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(201, 70);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(75, 23);
            this.btnreset.TabIndex = 1;
            this.btnreset.Text = "リセット";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // lbFilePath
            // 
            this.lbFilePath.FormattingEnabled = true;
            this.lbFilePath.ItemHeight = 12;
            this.lbFilePath.Location = new System.Drawing.Point(282, 12);
            this.lbFilePath.Name = "lbFilePath";
            this.lbFilePath.Size = new System.Drawing.Size(40, 52);
            this.lbFilePath.TabIndex = 2;
            this.lbFilePath.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbFilePath_DragDrop);
            this.lbFilePath.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbFilePath_DragEnter);
            // 
            // btn戻る
            // 
            this.btn戻る.Location = new System.Drawing.Point(282, 70);
            this.btn戻る.Name = "btn戻る";
            this.btn戻る.Size = new System.Drawing.Size(40, 23);
            this.btn戻る.TabIndex = 1;
            this.btn戻る.Text = "戻る";
            this.btn戻る.UseVisualStyleBackColor = true;
            this.btn戻る.Click += new System.EventHandler(this.btn戻る_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(201, 41);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // Frmタイマー
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 101);
            this.Controls.Add(this.lbFilePath);
            this.Controls.Add(this.btn戻る);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.btnM);
            this.Controls.Add(this.lblTime);
            this.Name = "Frmタイマー";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "タイマー";
            this.Load += new System.EventHandler(this.Frmタイマー_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.ListBox lbFilePath;
        private System.Windows.Forms.Button btn戻る;
        private System.Windows.Forms.Button btnStop;
    }
}