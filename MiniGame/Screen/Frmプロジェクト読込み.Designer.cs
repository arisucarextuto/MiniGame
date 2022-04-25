
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
            this.txtフォルダパス = new System.Windows.Forms.TextBox();
            this.btn戻る = new System.Windows.Forms.Button();
            this.btn次へ = new System.Windows.Forms.Button();
            this.btn参照 = new System.Windows.Forms.Button();
            this.ofdProject = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // txtフォルダパス
            // 
            this.txtフォルダパス.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtフォルダパス.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtフォルダパス.Location = new System.Drawing.Point(12, 11);
            this.txtフォルダパス.Name = "txtフォルダパス";
            this.txtフォルダパス.Size = new System.Drawing.Size(579, 23);
            this.txtフォルダパス.TabIndex = 5;
            // 
            // btn戻る
            // 
            this.btn戻る.Location = new System.Drawing.Point(536, 38);
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
            this.btn次へ.Location = new System.Drawing.Point(597, 38);
            this.btn次へ.Name = "btn次へ";
            this.btn次へ.Size = new System.Drawing.Size(55, 23);
            this.btn次へ.TabIndex = 3;
            this.btn次へ.Text = "次へ";
            this.btn次へ.UseVisualStyleBackColor = true;
            this.btn次へ.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn参照
            // 
            this.btn参照.Location = new System.Drawing.Point(597, 9);
            this.btn参照.Name = "btn参照";
            this.btn参照.Size = new System.Drawing.Size(55, 23);
            this.btn参照.TabIndex = 4;
            this.btn参照.Text = "参照";
            this.btn参照.UseVisualStyleBackColor = true;
            this.btn参照.Click += new System.EventHandler(this.btn参照_Click);
            // 
            // ofdProject
            // 
            this.ofdProject.FileName = "openFileDialog1";
            this.ofdProject.Filter = "プロジェクトファイル|*.xml";
            // 
            // Frmプロジェクト読込み
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 71);
            this.Controls.Add(this.txtフォルダパス);
            this.Controls.Add(this.btn戻る);
            this.Controls.Add(this.btn次へ);
            this.Controls.Add(this.btn参照);
            this.Name = "Frmプロジェクト読込み";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frmプロジェクト読込み";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtフォルダパス;
        private System.Windows.Forms.Button btn戻る;
        private System.Windows.Forms.Button btn次へ;
        private System.Windows.Forms.Button btn参照;
        private System.Windows.Forms.OpenFileDialog ofdProject;
    }
}