
namespace MiniGame.Screen
{
    partial class Frm設定1
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
            this.gb自動設定 = new System.Windows.Forms.GroupBox();
            this.gb画像表示間隔 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt画像表示間隔 = new System.Windows.Forms.TextBox();
            this.gb画像切替 = new System.Windows.Forms.GroupBox();
            this.rdo自動 = new System.Windows.Forms.RadioButton();
            this.rdo手動 = new System.Windows.Forms.RadioButton();
            this.gb自動設定.SuspendLayout();
            this.gb画像切替.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn戻る
            // 
            this.btn戻る.Location = new System.Drawing.Point(156, 226);
            this.btn戻る.Name = "btn戻る";
            this.btn戻る.Size = new System.Drawing.Size(55, 23);
            this.btn戻る.TabIndex = 6;
            this.btn戻る.Text = "戻る";
            this.btn戻る.UseVisualStyleBackColor = true;
            this.btn戻る.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn次へ
            // 
            this.btn次へ.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn次へ.Location = new System.Drawing.Point(217, 226);
            this.btn次へ.Name = "btn次へ";
            this.btn次へ.Size = new System.Drawing.Size(55, 23);
            this.btn次へ.TabIndex = 7;
            this.btn次へ.Text = "次へ";
            this.btn次へ.UseVisualStyleBackColor = true;
            this.btn次へ.Click += new System.EventHandler(this.btn_Click);
            // 
            // gb自動設定
            // 
            this.gb自動設定.Controls.Add(this.gb画像表示間隔);
            this.gb自動設定.Controls.Add(this.label1);
            this.gb自動設定.Controls.Add(this.txt画像表示間隔);
            this.gb自動設定.Location = new System.Drawing.Point(12, 58);
            this.gb自動設定.Name = "gb自動設定";
            this.gb自動設定.Size = new System.Drawing.Size(260, 60);
            this.gb自動設定.TabIndex = 4;
            this.gb自動設定.TabStop = false;
            this.gb自動設定.Text = "自動設定";
            // 
            // gb画像表示間隔
            // 
            this.gb画像表示間隔.AutoSize = true;
            this.gb画像表示間隔.Location = new System.Drawing.Point(6, 25);
            this.gb画像表示間隔.Name = "gb画像表示間隔";
            this.gb画像表示間隔.Size = new System.Drawing.Size(101, 12);
            this.gb画像表示間隔.TabIndex = 1;
            this.gb画像表示間隔.Text = "画像表示間隔 (秒)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "秒";
            // 
            // txt画像表示間隔
            // 
            this.txt画像表示間隔.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt画像表示間隔.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt画像表示間隔.Location = new System.Drawing.Point(115, 19);
            this.txt画像表示間隔.Name = "txt画像表示間隔";
            this.txt画像表示間隔.Size = new System.Drawing.Size(50, 23);
            this.txt画像表示間隔.TabIndex = 1;
            this.txt画像表示間隔.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gb画像切替
            // 
            this.gb画像切替.Controls.Add(this.rdo自動);
            this.gb画像切替.Controls.Add(this.rdo手動);
            this.gb画像切替.Location = new System.Drawing.Point(12, 12);
            this.gb画像切替.Name = "gb画像切替";
            this.gb画像切替.Size = new System.Drawing.Size(260, 40);
            this.gb画像切替.TabIndex = 5;
            this.gb画像切替.TabStop = false;
            this.gb画像切替.Text = "画像切替";
            // 
            // rdo自動
            // 
            this.rdo自動.AutoSize = true;
            this.rdo自動.Location = new System.Drawing.Point(59, 18);
            this.rdo自動.Name = "rdo自動";
            this.rdo自動.Size = new System.Drawing.Size(47, 16);
            this.rdo自動.TabIndex = 1;
            this.rdo自動.TabStop = true;
            this.rdo自動.Text = "自動";
            this.rdo自動.UseVisualStyleBackColor = true;
            // 
            // rdo手動
            // 
            this.rdo手動.AutoSize = true;
            this.rdo手動.Location = new System.Drawing.Point(6, 18);
            this.rdo手動.Name = "rdo手動";
            this.rdo手動.Size = new System.Drawing.Size(47, 16);
            this.rdo手動.TabIndex = 1;
            this.rdo手動.TabStop = true;
            this.rdo手動.Text = "手動";
            this.rdo手動.UseVisualStyleBackColor = true;
            this.rdo手動.CheckedChanged += new System.EventHandler(this.rdo手動_CheckedChanged);
            // 
            // Frm設定1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn戻る);
            this.Controls.Add(this.btn次へ);
            this.Controls.Add(this.gb自動設定);
            this.Controls.Add(this.gb画像切替);
            this.Name = "Frm設定1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "設定(1/2)";
            this.gb自動設定.ResumeLayout(false);
            this.gb自動設定.PerformLayout();
            this.gb画像切替.ResumeLayout(false);
            this.gb画像切替.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn戻る;
        private System.Windows.Forms.Button btn次へ;
        private System.Windows.Forms.GroupBox gb自動設定;
        private System.Windows.Forms.Label gb画像表示間隔;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt画像表示間隔;
        private System.Windows.Forms.GroupBox gb画像切替;
        private System.Windows.Forms.RadioButton rdo自動;
        private System.Windows.Forms.RadioButton rdo手動;
    }
}