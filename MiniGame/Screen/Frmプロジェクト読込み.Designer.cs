
namespace MiniGame.Screen
{
    partial class Frmプロジェクト読込み
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
            this.btn次へ = new System.Windows.Forms.Button();
            this.ofdProject = new System.Windows.Forms.OpenFileDialog();
            this.lbFilePath = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn戻る
            // 
            this.btn戻る.Location = new System.Drawing.Point(536, 46);
            this.btn戻る.Name = "btn戻る";
            this.btn戻る.Size = new System.Drawing.Size(55, 23);
            this.btn戻る.TabIndex = 2;
            this.btn戻る.Text = "戻る";
            this.btn戻る.UseVisualStyleBackColor = true;
            this.btn戻る.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn次へ
            // 
            this.btn次へ.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn次へ.Location = new System.Drawing.Point(597, 46);
            this.btn次へ.Name = "btn次へ";
            this.btn次へ.Size = new System.Drawing.Size(55, 23);
            this.btn次へ.TabIndex = 3;
            this.btn次へ.Text = "次へ";
            this.btn次へ.UseVisualStyleBackColor = true;
            this.btn次へ.Click += new System.EventHandler(this.btn_Click);
            // 
            // ofdProject
            // 
            this.ofdProject.FileName = "openFileDialog1";
            this.ofdProject.Filter = "プロジェクトファイル|*.xml";
            // 
            // lbFilePath
            // 
            this.lbFilePath.FormattingEnabled = true;
            this.lbFilePath.ItemHeight = 12;
            this.lbFilePath.Location = new System.Drawing.Point(12, 12);
            this.lbFilePath.Name = "lbFilePath";
            this.lbFilePath.Size = new System.Drawing.Size(640, 28);
            this.lbFilePath.TabIndex = 10;
            this.lbFilePath.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbFilePath_DragDrop);
            this.lbFilePath.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbFilePath_DragEnter);
            // 
            // Frmプロジェクト読込み
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 81);
            this.Controls.Add(this.lbFilePath);
            this.Controls.Add(this.btn戻る);
            this.Controls.Add(this.btn次へ);
            this.Name = "Frmプロジェクト読込み";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frmプロジェクト読込み";
            this.Load += new System.EventHandler(this.Frmプロジェクト読込み_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn戻る;
        private System.Windows.Forms.Button btn次へ;
        private System.Windows.Forms.OpenFileDialog ofdProject;
        private System.Windows.Forms.ListBox lbFilePath;
    }
}