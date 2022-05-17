
namespace MiniGame
{
    partial class Frm在庫検索
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
            this.gb条件 = new System.Windows.Forms.GroupBox();
            this.btn検索 = new System.Windows.Forms.Button();
            this.lblコード = new System.Windows.Forms.Label();
            this.lbl商品名 = new System.Windows.Forms.Label();
            this.txt商品名 = new System.Windows.Forms.TextBox();
            this.txtコード = new System.Windows.Forms.TextBox();
            this.dgv結果 = new System.Windows.Forms.DataGridView();
            this.btn戻る = new System.Windows.Forms.Button();
            this.gb条件.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv結果)).BeginInit();
            this.SuspendLayout();
            // 
            // gb条件
            // 
            this.gb条件.Controls.Add(this.btn検索);
            this.gb条件.Controls.Add(this.lblコード);
            this.gb条件.Controls.Add(this.lbl商品名);
            this.gb条件.Controls.Add(this.txt商品名);
            this.gb条件.Controls.Add(this.txtコード);
            this.gb条件.Location = new System.Drawing.Point(17, 13);
            this.gb条件.Name = "gb条件";
            this.gb条件.Size = new System.Drawing.Size(470, 70);
            this.gb条件.TabIndex = 6;
            this.gb条件.TabStop = false;
            this.gb条件.Text = "条件";
            // 
            // btn検索
            // 
            this.btn検索.Location = new System.Drawing.Point(380, 32);
            this.btn検索.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.btn検索.Name = "btn検索";
            this.btn検索.Size = new System.Drawing.Size(75, 23);
            this.btn検索.TabIndex = 4;
            this.btn検索.Text = "検索";
            this.btn検索.UseVisualStyleBackColor = true;
            this.btn検索.Click += new System.EventHandler(this.btn検索_Click);
            // 
            // lblコード
            // 
            this.lblコード.AutoSize = true;
            this.lblコード.Location = new System.Drawing.Point(36, 37);
            this.lblコード.Margin = new System.Windows.Forms.Padding(3, 40, 3, 0);
            this.lblコード.Name = "lblコード";
            this.lblコード.Size = new System.Drawing.Size(32, 12);
            this.lblコード.TabIndex = 2;
            this.lblコード.Text = "コード";
            // 
            // lbl商品名
            // 
            this.lbl商品名.AutoSize = true;
            this.lbl商品名.Location = new System.Drawing.Point(200, 37);
            this.lbl商品名.Margin = new System.Windows.Forms.Padding(20, 40, 3, 0);
            this.lbl商品名.Name = "lbl商品名";
            this.lbl商品名.Size = new System.Drawing.Size(41, 12);
            this.lbl商品名.TabIndex = 2;
            this.lbl商品名.Text = "商品名";
            // 
            // txt商品名
            // 
            this.txt商品名.Location = new System.Drawing.Point(247, 34);
            this.txt商品名.Name = "txt商品名";
            this.txt商品名.Size = new System.Drawing.Size(100, 19);
            this.txt商品名.TabIndex = 3;
            // 
            // txtコード
            // 
            this.txtコード.Location = new System.Drawing.Point(77, 34);
            this.txtコード.Name = "txtコード";
            this.txtコード.Size = new System.Drawing.Size(100, 19);
            this.txtコード.TabIndex = 3;
            // 
            // dgv結果
            // 
            this.dgv結果.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv結果.Location = new System.Drawing.Point(17, 89);
            this.dgv結果.Name = "dgv結果";
            this.dgv結果.RowTemplate.Height = 21;
            this.dgv結果.Size = new System.Drawing.Size(470, 250);
            this.dgv結果.TabIndex = 5;
            // 
            // btn戻る
            // 
            this.btn戻る.Location = new System.Drawing.Point(412, 346);
            this.btn戻る.Name = "btn戻る";
            this.btn戻る.Size = new System.Drawing.Size(75, 23);
            this.btn戻る.TabIndex = 8;
            this.btn戻る.Text = "戻る";
            this.btn戻る.UseVisualStyleBackColor = true;
            this.btn戻る.Click += new System.EventHandler(this.btn戻る_Click);
            // 
            // Frm在庫検索
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 381);
            this.Controls.Add(this.btn戻る);
            this.Controls.Add(this.gb条件);
            this.Controls.Add(this.dgv結果);
            this.Name = "Frm在庫検索";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "在庫検索";
            this.gb条件.ResumeLayout(false);
            this.gb条件.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv結果)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gb条件;
        private System.Windows.Forms.Button btn検索;
        private System.Windows.Forms.Label lblコード;
        private System.Windows.Forms.Label lbl商品名;
        private System.Windows.Forms.TextBox txt商品名;
        private System.Windows.Forms.TextBox txtコード;
        private System.Windows.Forms.DataGridView dgv結果;
        private System.Windows.Forms.Button btn戻る;
    }
}