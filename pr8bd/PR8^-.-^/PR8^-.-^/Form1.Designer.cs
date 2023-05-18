namespace PR8__.__
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
            this.dataGridView_Base = new System.Windows.Forms.DataGridView();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.labelFname = new System.Windows.Forms.Label();
            this.labelLname = new System.Windows.Forms.Label();
            this.button_Insert = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Base)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Base
            // 
            this.dataGridView_Base.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Base.Location = new System.Drawing.Point(13, 334);
            this.dataGridView_Base.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_Base.Name = "dataGridView_Base";
            this.dataGridView_Base.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Base.Size = new System.Drawing.Size(1044, 390);
            this.dataGridView_Base.TabIndex = 2;
            this.dataGridView_Base.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Base_CellEnter);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(209, 33);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxID.Multiline = true;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(284, 62);
            this.textBoxID.TabIndex = 1;
            // 
            // textBoxFName
            // 
            this.textBoxFName.Location = new System.Drawing.Point(209, 130);
            this.textBoxFName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFName.Multiline = true;
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(284, 62);
            this.textBoxFName.TabIndex = 2;
            // 
            // textBoxLName
            // 
            this.textBoxLName.Location = new System.Drawing.Point(209, 230);
            this.textBoxLName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxLName.Multiline = true;
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(284, 62);
            this.textBoxLName.TabIndex = 3;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(77, 51);
            this.labelID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(36, 25);
            this.labelID.TabIndex = 4;
            this.labelID.Text = "ID";
            // 
            // labelFname
            // 
            this.labelFname.AutoSize = true;
            this.labelFname.Location = new System.Drawing.Point(47, 149);
            this.labelFname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFname.Name = "labelFname";
            this.labelFname.Size = new System.Drawing.Size(104, 25);
            this.labelFname.TabIndex = 5;
            this.labelFname.Text = "FirstName";
            // 
            // labelLname
            // 
            this.labelLname.AutoSize = true;
            this.labelLname.Location = new System.Drawing.Point(49, 244);
            this.labelLname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLname.Name = "labelLname";
            this.labelLname.Size = new System.Drawing.Size(98, 25);
            this.labelLname.TabIndex = 6;
            this.labelLname.Text = "LastName";
            // 
            // button_Insert
            // 
            this.button_Insert.Location = new System.Drawing.Point(543, 33);
            this.button_Insert.Name = "button_Insert";
            this.button_Insert.Size = new System.Drawing.Size(159, 51);
            this.button_Insert.TabIndex = 7;
            this.button_Insert.Text = "INSERT";
            this.button_Insert.UseVisualStyleBackColor = true;
            this.button_Insert.Click += new System.EventHandler(this.button_Insert_Click);
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(722, 130);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(159, 51);
            this.button_Update.TabIndex = 8;
            this.button_Update.Text = "UPDATE";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(902, 230);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(159, 51);
            this.button_Delete.TabIndex = 9;
            this.button_Delete.Text = "DELETE";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1073, 737);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_Insert);
            this.Controls.Add(this.labelLname);
            this.Controls.Add(this.labelFname);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxLName);
            this.Controls.Add(this.textBoxFName);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.dataGridView_Base);
            this.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "^.._..^";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Base)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Base;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.TextBox textBoxLName;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelFname;
        private System.Windows.Forms.Label labelLname;
        private System.Windows.Forms.Button button_Insert;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Delete;
    }
}

