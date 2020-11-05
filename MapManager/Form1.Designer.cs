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
            this.mapPictureBox = new System.Windows.Forms.PictureBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.assetPictureBox = new System.Windows.Forms.PictureBox();
            this.primaryHorizontalLayout = new System.Windows.Forms.TableLayoutPanel();
            this.primaryVerticalLayout = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mousePosActual = new System.Windows.Forms.Label();
            this.mousePosScaled = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mapPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetPictureBox)).BeginInit();
            this.primaryHorizontalLayout.SuspendLayout();
            this.primaryVerticalLayout.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mapPictureBox
            // 
            this.mapPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("mapPictureBox.Image")));
            this.mapPictureBox.Location = new System.Drawing.Point(215, 3);
            this.mapPictureBox.Name = "mapPictureBox";
            this.mapPictureBox.Size = new System.Drawing.Size(897, 786);
            this.mapPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mapPictureBox.TabIndex = 0;
            this.mapPictureBox.TabStop = false;
            this.mapPictureBox.Click += new System.EventHandler(this.mapPictureBox_Click);
            this.mapPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mapPictureBox_MouseMove);
            this.mapPictureBox.Resize += new System.EventHandler(this.mapPictureBox_Resize);
            // 
            // comboBox2
            // 
            this.comboBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(3, 159);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // assetPictureBox
            // 
            this.assetPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assetPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("assetPictureBox.Image")));
            this.assetPictureBox.Location = new System.Drawing.Point(3, 3);
            this.assetPictureBox.Name = "assetPictureBox";
            this.assetPictureBox.Size = new System.Drawing.Size(200, 150);
            this.assetPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.assetPictureBox.TabIndex = 3;
            this.assetPictureBox.TabStop = false;
            this.assetPictureBox.Click += new System.EventHandler(this.assetPictureBox_Click);
            // 
            // primaryHorizontalLayout
            // 
            this.primaryHorizontalLayout.AutoSize = true;
            this.primaryHorizontalLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.primaryHorizontalLayout.ColumnCount = 2;
            this.primaryHorizontalLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.primaryHorizontalLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.primaryHorizontalLayout.Controls.Add(this.primaryVerticalLayout, 0, 0);
            this.primaryHorizontalLayout.Controls.Add(this.mapPictureBox, 1, 0);
            this.primaryHorizontalLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.primaryHorizontalLayout.Location = new System.Drawing.Point(0, 0);
            this.primaryHorizontalLayout.Name = "primaryHorizontalLayout";
            this.primaryHorizontalLayout.RowCount = 1;
            this.primaryHorizontalLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.primaryHorizontalLayout.Size = new System.Drawing.Size(1029, 792);
            this.primaryHorizontalLayout.TabIndex = 4;
            // 
            // primaryVerticalLayout
            // 
            this.primaryVerticalLayout.AutoSize = true;
            this.primaryVerticalLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.primaryVerticalLayout.ColumnCount = 1;
            this.primaryVerticalLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.primaryVerticalLayout.Controls.Add(this.assetPictureBox, 0, 0);
            this.primaryVerticalLayout.Controls.Add(this.comboBox2, 0, 1);
            this.primaryVerticalLayout.Controls.Add(this.panel1, 0, 2);
            this.primaryVerticalLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.primaryVerticalLayout.Location = new System.Drawing.Point(3, 3);
            this.primaryVerticalLayout.Name = "primaryVerticalLayout";
            this.primaryVerticalLayout.RowCount = 3;
            this.primaryVerticalLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.primaryVerticalLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.primaryVerticalLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.primaryVerticalLayout.Size = new System.Drawing.Size(206, 786);
            this.primaryVerticalLayout.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mousePosScaled);
            this.panel1.Controls.Add(this.mousePosActual);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 186);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 597);
            this.panel1.TabIndex = 4;
            // 
            // mousePosActual
            // 
            this.mousePosActual.AutoSize = true;
            this.mousePosActual.Location = new System.Drawing.Point(7, 4);
            this.mousePosActual.Name = "mousePosActual";
            this.mousePosActual.Size = new System.Drawing.Size(144, 13);
            this.mousePosActual.TabIndex = 0;
            this.mousePosActual.Text = "Mouse Position Actual - X: Y:";
            // 
            // mousePosScaled
            // 
            this.mousePosScaled.AutoSize = true;
            this.mousePosScaled.Location = new System.Drawing.Point(7, 21);
            this.mousePosScaled.Name = "mousePosScaled";
            this.mousePosScaled.Size = new System.Drawing.Size(147, 13);
            this.mousePosScaled.TabIndex = 1;
            this.mousePosScaled.Text = "Mouse Position Scaled - X: Y:";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1029, 792);
            this.Controls.Add(this.primaryHorizontalLayout);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "MapManager";
            ((System.ComponentModel.ISupportInitialize)(this.mapPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetPictureBox)).EndInit();
            this.primaryHorizontalLayout.ResumeLayout(false);
            this.primaryHorizontalLayout.PerformLayout();
            this.primaryVerticalLayout.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mapPictureBox;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.PictureBox assetPictureBox;
        private System.Windows.Forms.TableLayoutPanel primaryHorizontalLayout;
        private System.Windows.Forms.TableLayoutPanel primaryVerticalLayout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label mousePosScaled;
        private System.Windows.Forms.Label mousePosActual;
    }
}

