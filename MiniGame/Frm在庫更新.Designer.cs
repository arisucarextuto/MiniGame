
namespace MiniGame
{
    partial class Frm在庫更新
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
            this.btnCsvImport = new System.Windows.Forms.Button();
            this.btn戻る = new System.Windows.Forms.Button();
            this.ofdProject = new System.Windows.Forms.OpenFileDialog();
            this.lbFilePath = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCsvImport
            // 
            this.btnCsvImport.Location = new System.Drawing.Point(12, 34);
            this.btnCsvImport.Name = "btnCsvImport";
            this.btnCsvImport.Size = new System.Drawing.Size(75, 23);
            this.btnCsvImport.TabIndex = 1;
            this.btnCsvImport.Text = "インポート";
            this.btnCsvImport.UseVisualStyleBackColor = true;
            this.btnCsvImport.Click += new System.EventHandler(this.btnCsvImport_Click);
            // 
            // btn戻る
            // 
            this.btn戻る.Location = new System.Drawing.Point(197, 276);
            this.btn戻る.Name = "btn戻る";
            this.btn戻る.Size = new System.Drawing.Size(75, 23);
            this.btn戻る.TabIndex = 2;
            this.btn戻る.Text = "戻る";
            this.btn戻る.UseVisualStyleBackColor = true;
            this.btn戻る.Click += new System.EventHandler(this.btn戻る_Click);
            // 
            // ofdProject
            // 
            this.ofdProject.Filter = "プロジェクトファイル|*.csv";
            this.ofdProject.Title = "プロジェクトファイル読込み";
            // 
            // lbFilePath
            // 
            this.lbFilePath.FormattingEnabled = true;
            this.lbFilePath.ItemHeight = 12;
            this.lbFilePath.Location = new System.Drawing.Point(12, 12);
            this.lbFilePath.Name = "lbFilePath";
            this.lbFilePath.Size = new System.Drawing.Size(260, 16);
            this.lbFilePath.TabIndex = 4;
            this.lbFilePath.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbFilePath_DragDrop);
            this.lbFilePath.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbFilePath_DragEnter);
            // 
            // Frm在庫更新
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 311);
            this.Controls.Add(this.lbFilePath);
            this.Controls.Add(this.btn戻る);
            this.Controls.Add(this.btnCsvImport);
            this.Name = "Frm在庫更新";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "在庫更新";
            this.Load += new System.EventHandler(this.Frm在庫更新_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCsvImport;
        private System.Windows.Forms.Button btn戻る;
        private System.Windows.Forms.OpenFileDialog ofdProject;
        private System.Windows.Forms.ListBox lbFilePath;
    }
}