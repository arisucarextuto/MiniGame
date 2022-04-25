
namespace MiniGame.Screen
{
    partial class Frm設定2
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
            this.btn保存 = new System.Windows.Forms.Button();
            this.dgvImageList = new System.Windows.Forms.DataGridView();
            this.dgvImage = new System.Windows.Forms.DataGridView();
            this.txtフォルダパス = new System.Windows.Forms.TextBox();
            this.btn削除 = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btn追加 = new System.Windows.Forms.Button();
            this.btn参照 = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImageList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btn戻る
            // 
            this.btn戻る.Location = new System.Drawing.Point(656, 405);
            this.btn戻る.Name = "btn戻る";
            this.btn戻る.Size = new System.Drawing.Size(55, 23);
            this.btn戻る.TabIndex = 15;
            this.btn戻る.Text = "戻る";
            this.btn戻る.UseVisualStyleBackColor = true;
            this.btn戻る.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn保存
            // 
            this.btn保存.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn保存.Location = new System.Drawing.Point(717, 405);
            this.btn保存.Name = "btn保存";
            this.btn保存.Size = new System.Drawing.Size(55, 23);
            this.btn保存.TabIndex = 16;
            this.btn保存.Text = "保存";
            this.btn保存.UseVisualStyleBackColor = true;
            this.btn保存.Click += new System.EventHandler(this.btn保存_Click);
            // 
            // dgvImageList
            // 
            this.dgvImageList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImageList.Location = new System.Drawing.Point(401, 42);
            this.dgvImageList.Name = "dgvImageList";
            this.dgvImageList.RowTemplate.Height = 21;
            this.dgvImageList.Size = new System.Drawing.Size(310, 357);
            this.dgvImageList.TabIndex = 13;
            // 
            // dgvImage
            // 
            this.dgvImage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImage.Location = new System.Drawing.Point(13, 42);
            this.dgvImage.Name = "dgvImage";
            this.dgvImage.RowTemplate.Height = 21;
            this.dgvImage.Size = new System.Drawing.Size(310, 357);
            this.dgvImage.TabIndex = 14;
            // 
            // txtフォルダパス
            // 
            this.txtフォルダパス.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtフォルダパス.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtフォルダパス.Location = new System.Drawing.Point(12, 13);
            this.txtフォルダパス.Name = "txtフォルダパス";
            this.txtフォルダパス.Size = new System.Drawing.Size(700, 23);
            this.txtフォルダパス.TabIndex = 12;
            this.txtフォルダパス.TextChanged += new System.EventHandler(this.txtフォルダパス_TextChanged);
            // 
            // btn削除
            // 
            this.btn削除.Location = new System.Drawing.Point(717, 99);
            this.btn削除.Name = "btn削除";
            this.btn削除.Size = new System.Drawing.Size(55, 23);
            this.btn削除.TabIndex = 7;
            this.btn削除.Text = "削除";
            this.btn削除.UseVisualStyleBackColor = true;
            this.btn削除.Click += new System.EventHandler(this.btn削除_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(717, 70);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(55, 23);
            this.btnDown.TabIndex = 8;
            this.btnDown.Text = "↓";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(717, 41);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(55, 23);
            this.btnUp.TabIndex = 9;
            this.btnUp.Text = "↑";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btn追加
            // 
            this.btn追加.Location = new System.Drawing.Point(334, 186);
            this.btn追加.Name = "btn追加";
            this.btn追加.Size = new System.Drawing.Size(55, 23);
            this.btn追加.TabIndex = 10;
            this.btn追加.Text = "追加";
            this.btn追加.UseVisualStyleBackColor = true;
            this.btn追加.Click += new System.EventHandler(this.btn追加_Click);
            // 
            // btn参照
            // 
            this.btn参照.Location = new System.Drawing.Point(717, 12);
            this.btn参照.Name = "btn参照";
            this.btn参照.Size = new System.Drawing.Size(55, 23);
            this.btn参照.TabIndex = 11;
            this.btn参照.Text = "参照";
            this.btn参照.UseVisualStyleBackColor = true;
            this.btn参照.Click += new System.EventHandler(this.btn参照_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "プロジェクトファイル(*.xml)|*.xml";
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // Frm設定2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.btn戻る);
            this.Controls.Add(this.btn保存);
            this.Controls.Add(this.dgvImageList);
            this.Controls.Add(this.dgvImage);
            this.Controls.Add(this.txtフォルダパス);
            this.Controls.Add(this.btn削除);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btn追加);
            this.Controls.Add(this.btn参照);
            this.Name = "Frm設定2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "設定(2/2)";
            ((System.ComponentModel.ISupportInitialize)(this.dgvImageList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn戻る;
        private System.Windows.Forms.Button btn保存;
        private System.Windows.Forms.DataGridView dgvImageList;
        private System.Windows.Forms.DataGridView dgvImage;
        private System.Windows.Forms.TextBox txtフォルダパス;
        private System.Windows.Forms.Button btn削除;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btn追加;
        private System.Windows.Forms.Button btn参照;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}