
namespace MiniGame
{
    partial class Frm時計
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn戻る = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn戻る
            // 
            this.btn戻る.Location = new System.Drawing.Point(297, 326);
            this.btn戻る.Name = "btn戻る";
            this.btn戻る.Size = new System.Drawing.Size(75, 23);
            this.btn戻る.TabIndex = 0;
            this.btn戻る.Text = "戻る";
            this.btn戻る.UseVisualStyleBackColor = true;
            this.btn戻る.Click += new System.EventHandler(this.btn戻る_Click);
            // 
            // Frm時計
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.btn戻る);
            this.Name = "Frm時計";
            this.Text = "時計";
            this.Load += new System.EventHandler(this.Frm時計_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Frm時計_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn戻る;
    }
}