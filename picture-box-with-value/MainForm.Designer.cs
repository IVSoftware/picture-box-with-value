namespace picture_box_with_value
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSetImage = new System.Windows.Forms.Button();
            this.buttonSetValue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.Location = new System.Drawing.Point(21, 35);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(150, 150);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // buttonImage
            // 
            this.buttonSetImage.Location = new System.Drawing.Point(102, 208);
            this.buttonSetImage.Name = "buttonImage";
            this.buttonSetImage.Size = new System.Drawing.Size(75, 23);
            this.buttonSetImage.TabIndex = 1;
            this.buttonSetImage.Text = "Set Image";
            this.buttonSetImage.UseVisualStyleBackColor = true;
            // 
            // buttonSetValue
            // 
            this.buttonSetValue.Location = new System.Drawing.Point(21, 208);
            this.buttonSetValue.Name = "buttonSetValue";
            this.buttonSetValue.Size = new System.Drawing.Size(75, 23);
            this.buttonSetValue.TabIndex = 1;
            this.buttonSetValue.Text = "Set Value";
            this.buttonSetValue.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonSetValue);
            this.Controls.Add(this.buttonSetImage);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel;
        private Button buttonSetImage;
        private Button buttonSetValue;
    }
}