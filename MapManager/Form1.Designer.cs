namespace MapManager
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MapPictureBox = new System.Windows.Forms.PictureBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.AssetPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MapPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssetPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MapPictureBox
            // 
            this.MapPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("MapPictureBox.Image")));
            this.MapPictureBox.Location = new System.Drawing.Point(192, 12);
            this.MapPictureBox.Name = "MapPictureBox";
            this.MapPictureBox.Size = new System.Drawing.Size(823, 764);
            this.MapPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MapPictureBox.TabIndex = 0;
            this.MapPictureBox.TabStop = false;
            this.MapPictureBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.MapPictureBox_DragDrop);
            this.MapPictureBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.MapPictureBox_DragEnter);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 168);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(114, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // AssetPictureBox
            // 
            this.AssetPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("AssetPictureBox.Image")));
            this.AssetPictureBox.Location = new System.Drawing.Point(12, 12);
            this.AssetPictureBox.Name = "AssetPictureBox";
            this.AssetPictureBox.Size = new System.Drawing.Size(114, 150);
            this.AssetPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AssetPictureBox.TabIndex = 3;
            this.AssetPictureBox.TabStop = false;
            this.AssetPictureBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.AssetPictureBox_DragDrop);
            this.AssetPictureBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.AssetPictureBox_DragEnter);
            this.AssetPictureBox.DragOver += new System.Windows.Forms.DragEventHandler(this.AssetPictureBox_DragOver);
            this.AssetPictureBox.DragLeave += new System.EventHandler(this.AssetPictureBox_DragLeave);
            this.AssetPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AssetPictureBox_MouseDown);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 792);
            this.Controls.Add(this.AssetPictureBox);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.MapPictureBox);
            this.Name = "Form1";
            this.Text = "MapManager";
            ((System.ComponentModel.ISupportInitialize)(this.MapPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssetPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MapPictureBox;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.PictureBox AssetPictureBox;
    }
}

