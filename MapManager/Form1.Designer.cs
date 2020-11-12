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
            this.assetComboBox = new System.Windows.Forms.ComboBox();
            this.assetPictureBox = new System.Windows.Forms.PictureBox();
            this.primaryHorizontalLayout = new System.Windows.Forms.TableLayoutPanel();
            this.primaryVerticalLayout = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.scaledImageLabel = new System.Windows.Forms.Label();
            this.debugStatus = new System.Windows.Forms.Label();
            this.mousePosScaled = new System.Windows.Forms.Label();
            this.mousePosActual = new System.Windows.Forms.Label();
            this.layersTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.layerPictureBox = new System.Windows.Forms.PictureBox();
            this.layerSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Edit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mapPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetPictureBox)).BeginInit();
            this.primaryHorizontalLayout.SuspendLayout();
            this.primaryVerticalLayout.SuspendLayout();
            this.panel1.SuspendLayout();
            this.layersTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layerPictureBox)).BeginInit();
            this.panel2.SuspendLayout();
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
            // assetComboBox
            // 
            this.assetComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assetComboBox.FormattingEnabled = true;
            this.assetComboBox.Location = new System.Drawing.Point(3, 159);
            this.assetComboBox.Name = "assetComboBox";
            this.assetComboBox.Size = new System.Drawing.Size(200, 21);
            this.assetComboBox.TabIndex = 2;
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
            this.primaryHorizontalLayout.ColumnCount = 3;
            this.primaryHorizontalLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.primaryHorizontalLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.primaryHorizontalLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 233F));
            this.primaryHorizontalLayout.Controls.Add(this.primaryVerticalLayout, 0, 0);
            this.primaryHorizontalLayout.Controls.Add(this.mapPictureBox, 1, 0);
            this.primaryHorizontalLayout.Controls.Add(this.layersTablePanel, 2, 0);
            this.primaryHorizontalLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.primaryHorizontalLayout.Location = new System.Drawing.Point(0, 0);
            this.primaryHorizontalLayout.Name = "primaryHorizontalLayout";
            this.primaryHorizontalLayout.RowCount = 1;
            this.primaryHorizontalLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.primaryHorizontalLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 792F));
            this.primaryHorizontalLayout.Size = new System.Drawing.Size(1348, 792);
            this.primaryHorizontalLayout.TabIndex = 4;
            // 
            // primaryVerticalLayout
            // 
            this.primaryVerticalLayout.AutoSize = true;
            this.primaryVerticalLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.primaryVerticalLayout.ColumnCount = 1;
            this.primaryVerticalLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.primaryVerticalLayout.Controls.Add(this.assetPictureBox, 0, 0);
            this.primaryVerticalLayout.Controls.Add(this.assetComboBox, 0, 1);
            this.primaryVerticalLayout.Controls.Add(this.panel1, 0, 2);
            this.primaryVerticalLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.primaryVerticalLayout.Location = new System.Drawing.Point(3, 3);
            this.primaryVerticalLayout.Name = "primaryVerticalLayout";
            this.primaryVerticalLayout.RowCount = 3;
            this.primaryVerticalLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.primaryVerticalLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.primaryVerticalLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.primaryVerticalLayout.Size = new System.Drawing.Size(206, 786);
            this.primaryVerticalLayout.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.scaledImageLabel);
            this.panel1.Controls.Add(this.debugStatus);
            this.panel1.Controls.Add(this.mousePosScaled);
            this.panel1.Controls.Add(this.mousePosActual);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 186);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 597);
            this.panel1.TabIndex = 4;
            // 
            // scaledImageLabel
            // 
            this.scaledImageLabel.AutoSize = true;
            this.scaledImageLabel.Location = new System.Drawing.Point(7, 66);
            this.scaledImageLabel.Name = "scaledImageLabel";
            this.scaledImageLabel.Size = new System.Drawing.Size(98, 13);
            this.scaledImageLabel.TabIndex = 3;
            this.scaledImageLabel.Text = "Scaled Image Size:";
            this.scaledImageLabel.Click += new System.EventHandler(this.scaledImageLabel_Click);
            // 
            // debugStatus
            // 
            this.debugStatus.AutoSize = true;
            this.debugStatus.Location = new System.Drawing.Point(6, 44);
            this.debugStatus.Name = "debugStatus";
            this.debugStatus.Size = new System.Drawing.Size(61, 13);
            this.debugStatus.TabIndex = 2;
            this.debugStatus.Text = "Edit Mode: ";
            this.debugStatus.Click += new System.EventHandler(this.debugStatus_Click);
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
            // mousePosActual
            // 
            this.mousePosActual.AutoSize = true;
            this.mousePosActual.Location = new System.Drawing.Point(7, 4);
            this.mousePosActual.Name = "mousePosActual";
            this.mousePosActual.Size = new System.Drawing.Size(144, 13);
            this.mousePosActual.TabIndex = 0;
            this.mousePosActual.Text = "Mouse Position Actual - X: Y:";
            // 
            // layersTablePanel
            // 
            this.layersTablePanel.ColumnCount = 1;
            this.layersTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layersTablePanel.Controls.Add(this.layerPictureBox, 0, 0);
            this.layersTablePanel.Controls.Add(this.panel2, 0, 1);
            this.layersTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layersTablePanel.Location = new System.Drawing.Point(1118, 3);
            this.layersTablePanel.Name = "layersTablePanel";
            this.layersTablePanel.RowCount = 2;
            this.layersTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.layersTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layersTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layersTablePanel.Size = new System.Drawing.Size(227, 786);
            this.layersTablePanel.TabIndex = 6;
            // 
            // layerPictureBox
            // 
            this.layerPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layerPictureBox.Location = new System.Drawing.Point(3, 3);
            this.layerPictureBox.Name = "layerPictureBox";
            this.layerPictureBox.Size = new System.Drawing.Size(221, 622);
            this.layerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.layerPictureBox.TabIndex = 0;
            this.layerPictureBox.TabStop = false;
            // 
            // layerSelectionComboBox
            // 
            this.layerSelectionComboBox.FormattingEnabled = true;
            this.layerSelectionComboBox.Location = new System.Drawing.Point(11, 14);
            this.layerSelectionComboBox.Name = "layerSelectionComboBox";
            this.layerSelectionComboBox.Size = new System.Drawing.Size(204, 21);
            this.layerSelectionComboBox.TabIndex = 1;
            this.layerSelectionComboBox.SelectedValueChanged += new System.EventHandler(this.layerSelectionComboBox_SelectedValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Edit);
            this.panel2.Controls.Add(this.layerSelectionComboBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 631);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 152);
            this.panel2.TabIndex = 1;
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(11, 55);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(75, 23);
            this.Edit.TabIndex = 2;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1348, 792);
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
            this.layersTablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layerPictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mapPictureBox;
        private System.Windows.Forms.ComboBox assetComboBox;
        private System.Windows.Forms.PictureBox assetPictureBox;
        private System.Windows.Forms.TableLayoutPanel primaryHorizontalLayout;
        private System.Windows.Forms.TableLayoutPanel primaryVerticalLayout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label mousePosScaled;
        private System.Windows.Forms.Label mousePosActual;
        private System.Windows.Forms.TableLayoutPanel layersTablePanel;
        private System.Windows.Forms.PictureBox layerPictureBox;
        private System.Windows.Forms.Label debugStatus;
        private System.Windows.Forms.Label scaledImageLabel;
        private System.Windows.Forms.ComboBox layerSelectionComboBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Edit;
    }
}

