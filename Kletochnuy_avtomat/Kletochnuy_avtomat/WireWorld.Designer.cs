
namespace Kletochnuy_avtomat
{
    partial class WireWorld
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
            this.button_void = new System.Windows.Forms.Button();
            this.button_wire = new System.Windows.Forms.Button();
            this.button_head = new System.Windows.Forms.Button();
            this.button_tail = new System.Windows.Forms.Button();
            this.button_menu = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_void
            // 
            this.button_void.BackColor = System.Drawing.Color.Black;
            this.button_void.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_void.FlatAppearance.BorderColor = System.Drawing.Color.Violet;
            this.button_void.FlatAppearance.BorderSize = 3;
            this.button_void.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_void.ForeColor = System.Drawing.Color.Black;
            this.button_void.Location = new System.Drawing.Point(901, 12);
            this.button_void.Name = "button_void";
            this.button_void.Size = new System.Drawing.Size(50, 50);
            this.button_void.TabIndex = 2;
            this.button_void.UseVisualStyleBackColor = false;
            this.button_void.Click += new System.EventHandler(this.button_void_Click);
            // 
            // button_wire
            // 
            this.button_wire.BackColor = System.Drawing.Color.Orange;
            this.button_wire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_wire.FlatAppearance.BorderColor = System.Drawing.Color.Violet;
            this.button_wire.FlatAppearance.BorderSize = 3;
            this.button_wire.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_wire.Location = new System.Drawing.Point(1015, 12);
            this.button_wire.Name = "button_wire";
            this.button_wire.Size = new System.Drawing.Size(50, 50);
            this.button_wire.TabIndex = 3;
            this.button_wire.UseVisualStyleBackColor = false;
            this.button_wire.Click += new System.EventHandler(this.button_wire_Click);
            // 
            // button_head
            // 
            this.button_head.BackColor = System.Drawing.Color.Cyan;
            this.button_head.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_head.FlatAppearance.BorderColor = System.Drawing.Color.Violet;
            this.button_head.FlatAppearance.BorderSize = 3;
            this.button_head.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_head.Location = new System.Drawing.Point(1127, 12);
            this.button_head.Name = "button_head";
            this.button_head.Size = new System.Drawing.Size(50, 50);
            this.button_head.TabIndex = 4;
            this.button_head.UseVisualStyleBackColor = false;
            this.button_head.Click += new System.EventHandler(this.button_head_Click);
            // 
            // button_tail
            // 
            this.button_tail.BackColor = System.Drawing.Color.Red;
            this.button_tail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_tail.FlatAppearance.BorderColor = System.Drawing.Color.Violet;
            this.button_tail.FlatAppearance.BorderSize = 3;
            this.button_tail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_tail.Location = new System.Drawing.Point(1237, 12);
            this.button_tail.Name = "button_tail";
            this.button_tail.Size = new System.Drawing.Size(50, 50);
            this.button_tail.TabIndex = 5;
            this.button_tail.UseVisualStyleBackColor = false;
            this.button_tail.Click += new System.EventHandler(this.button_tail_Click);
            // 
            // button_menu
            // 
            this.button_menu.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button_menu.Font = new System.Drawing.Font("Sylfaen", 10.2F, System.Drawing.FontStyle.Bold);
            this.button_menu.Location = new System.Drawing.Point(60, 12);
            this.button_menu.Name = "button_menu";
            this.button_menu.Size = new System.Drawing.Size(142, 44);
            this.button_menu.TabIndex = 7;
            this.button_menu.Text = "=)(Главная)";
            this.button_menu.UseVisualStyleBackColor = false;
            this.button_menu.Click += new System.EventHandler(this.button_menu_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button2.Font = new System.Drawing.Font("Sylfaen", 10.2F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(256, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 44);
            this.button2.TabIndex = 8;
            this.button2.Text = "Сброс";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(12, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1296, 633);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // WireWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kletochnuy_avtomat.Properties.Resources._1635895271_3_phonoteka_org_p_fon_dlya_kompyutera_odnotonnii_temnii_kras_3;
            this.ClientSize = new System.Drawing.Size(1321, 711);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_menu);
            this.Controls.Add(this.button_tail);
            this.Controls.Add(this.button_head);
            this.Controls.Add(this.button_wire);
            this.Controls.Add(this.button_void);
            this.Name = "WireWorld";
            this.Text = "WireWorld";
            this.Load += new System.EventHandler(this.WireWorld_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_void;
        private System.Windows.Forms.Button button_wire;
        private System.Windows.Forms.Button button_head;
        private System.Windows.Forms.Button button_tail;
        private System.Windows.Forms.Button button_menu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}