
namespace MiniGame
{
    partial class Frm画像読込み
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
            this.cboN = new System.Windows.Forms.ComboBox();
            this.btn次へ = new System.Windows.Forms.Button();
            this.lbFilePath = new System.Windows.Forms.ListBox();
            this.btn戻る = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "N X N";
            // 
            // cboN
            // 
            this.cboN.FormattingEnabled = true;
            this.cboN.Items.AddRange(new object[] {
            "",
            "2",
            "3",
            "4",
            "5"});
            this.cboN.Location = new System.Drawing.Point(53, 34);
            this.cboN.Name = "cboN";
            this.cboN.Size = new System.Drawing.Size(121, 20);
            this.cboN.TabIndex = 7;
            // 
            // btn次へ
            // 
            this.btn次へ.Location = new System.Drawing.Point(422, 38);
            this.btn次へ.Name = "btn次へ";
            this.btn次へ.Size = new System.Drawing.Size(50, 23);
            this.btn次へ.TabIndex = 5;
            this.btn次へ.Text = "次へ";
            this.btn次へ.UseVisualStyleBackColor = true;
            this.btn次へ.Click += new System.EventHandler(this.btn次へ_Click);
            // 
            // lbFilePath
            // 
            this.lbFilePath.FormattingEnabled = true;
            this.lbFilePath.ItemHeight = 12;
            this.lbFilePath.Location = new System.Drawing.Point(14, 12);
            this.lbFilePath.Name = "lbFilePath";
            this.lbFilePath.Size = new System.Drawing.Size(458, 16);
            this.lbFilePath.TabIndex = 9;
            this.lbFilePath.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbFilePath_DragDrop);
            this.lbFilePath.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbFilePath_DragEnter);
            // 
            // btn戻る
            // 
            this.btn戻る.Location = new System.Drawing.Point(366, 38);
            this.btn戻る.Name = "btn戻る";
            this.btn戻る.Size = new System.Drawing.Size(50, 23);
            this.btn戻る.TabIndex = 5;
            this.btn戻る.Text = "戻る";
            this.btn戻る.UseVisualStyleBackColor = true;
            this.btn戻る.Click += new System.EventHandler(this.btn戻る_Click);
            // 
            // Frm画像読込み
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 71);
            this.Controls.Add(this.lbFilePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboN);
            this.Controls.Add(this.btn戻る);
            this.Controls.Add(this.btn次へ);
            this.Name = "Frm画像読込み";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "画像読込み";
            this.Load += new System.EventHandler(this.Frm画像読込み_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboN;
        private System.Windows.Forms.Button btn次へ;
        private System.Windows.Forms.ListBox lbFilePath;
        private System.Windows.Forms.Button btn戻る;
    }
}