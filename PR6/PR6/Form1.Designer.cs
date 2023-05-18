namespace PR6
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ToolStripButtonLoadPicture = new System.Windows.Forms.Button();
            this.ofDlg = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // ToolStripButtonLoadPicture
            // 
            this.ToolStripButtonLoadPicture.Location = new System.Drawing.Point(12, 399);
            this.ToolStripButtonLoadPicture.Name = "ToolStripButtonLoadPicture";
            this.ToolStripButtonLoadPicture.Size = new System.Drawing.Size(152, 39);
            this.ToolStripButtonLoadPicture.TabIndex = 0;
            this.ToolStripButtonLoadPicture.Text = "Загрузить картинку";
            this.ToolStripButtonLoadPicture.UseVisualStyleBackColor = true;
            this.ToolStripButtonLoadPicture.Click += new System.EventHandler(this.ToolStripButtonLoadPicture_Click);
            // 
            // ofDlg
            // 
            this.ofDlg.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ToolStripButtonLoadPicture);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ToolStripButtonLoadPicture;
        private System.Windows.Forms.OpenFileDialog ofDlg;
    }
}

