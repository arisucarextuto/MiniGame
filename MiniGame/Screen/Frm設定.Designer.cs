
namespace MiniGame
{
    partial class Frm設定
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
            this.btn閉じる = new System.Windows.Forms.Button();
            this.btn実行 = new System.Windows.Forms.Button();
            this.btn設定 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn閉じる
            // 
            this.btn閉じる.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn閉じる.Location = new System.Drawing.Point(12, 127);
            this.btn閉じる.Name = "btn閉じる";
            this.btn閉じる.Size = new System.Drawing.Size(190, 51);
            this.btn閉じる.TabIndex = 6;
            this.btn閉じる.Text = "閉じる";
            this.btn閉じる.UseVisualStyleBackColor = true;
            this.btn閉じる.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn実行
            // 
            this.btn実行.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn実行.Location = new System.Drawing.Point(12, 70);
            this.btn実行.Name = "btn実行";
            this.btn実行.Size = new System.Drawing.Size(190, 51);
            this.btn実行.TabIndex = 5;
            this.btn実行.Text = "実行";
            this.btn実行.UseVisualStyleBackColor = true;
            this.btn実行.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn設定
            // 
            this.btn設定.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn設定.Location = new System.Drawing.Point(12, 13);
            this.btn設定.Name = "btn設定";
            this.btn設定.Size = new System.Drawing.Size(190, 51);
            this.btn設定.TabIndex = 4;
            this.btn設定.Text = "設定";
            this.btn設定.UseVisualStyleBackColor = true;
            this.btn設定.Click += new System.EventHandler(this.btn_Click);
            // 
            // Frm設定
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 191);
            this.Controls.Add(this.btn閉じる);
            this.Controls.Add(this.btn実行);
            this.Controls.Add(this.btn設定);
            this.Name = "Frm設定";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm設定";
            this.Load += new System.EventHandler(this.Frm設定_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn閉じる;
        private System.Windows.Forms.Button btn実行;
        private System.Windows.Forms.Button btn設定;
    }
}