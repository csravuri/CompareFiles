namespace CompareFiles
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
            this.compareButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.file2Label = new System.Windows.Forms.Label();
            this.file1Lable = new System.Windows.Forms.Label();
            this.vsLoactionlabel = new System.Windows.Forms.Label();
            this.vsPathTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // compareButton
            // 
            this.compareButton.Location = new System.Drawing.Point(351, 401);
            this.compareButton.Name = "compareButton";
            this.compareButton.Size = new System.Drawing.Size(95, 30);
            this.compareButton.TabIndex = 0;
            this.compareButton.Text = "Compare";
            this.compareButton.UseVisualStyleBackColor = true;
            this.compareButton.Click += new System.EventHandler(this.compareButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.file2Label, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.file1Lable, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 35);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(792, 360);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // file2Label
            // 
            this.file2Label.AllowDrop = true;
            this.file2Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.file2Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.file2Label.Location = new System.Drawing.Point(399, 0);
            this.file2Label.Name = "file2Label";
            this.file2Label.Size = new System.Drawing.Size(390, 360);
            this.file2Label.TabIndex = 1;
            this.file2Label.Text = "File 2";
            this.file2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.file2Label.DragDrop += new System.Windows.Forms.DragEventHandler(this.file2Label_DragDrop);
            this.file2Label.DragOver += new System.Windows.Forms.DragEventHandler(this.file2Label_DragOver);
            // 
            // file1Lable
            // 
            this.file1Lable.AllowDrop = true;
            this.file1Lable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.file1Lable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.file1Lable.Location = new System.Drawing.Point(3, 0);
            this.file1Lable.Name = "file1Lable";
            this.file1Lable.Size = new System.Drawing.Size(390, 360);
            this.file1Lable.TabIndex = 0;
            this.file1Lable.Text = "File 1";
            this.file1Lable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.file1Lable.DragDrop += new System.Windows.Forms.DragEventHandler(this.file1Lable_DragDrop);
            this.file1Lable.DragOver += new System.Windows.Forms.DragEventHandler(this.file1Lable_DragOver);
            // 
            // vsLoactionlabel
            // 
            this.vsLoactionlabel.AutoSize = true;
            this.vsLoactionlabel.Location = new System.Drawing.Point(0, 7);
            this.vsLoactionlabel.Name = "vsLoactionlabel";
            this.vsLoactionlabel.Size = new System.Drawing.Size(123, 17);
            this.vsLoactionlabel.TabIndex = 2;
            this.vsLoactionlabel.Text = "Visual Studio Path";
            // 
            // vsPathTextBox
            // 
            this.vsPathTextBox.Location = new System.Drawing.Point(130, 7);
            this.vsPathTextBox.Name = "vsPathTextBox";
            this.vsPathTextBox.Size = new System.Drawing.Size(658, 22);
            this.vsPathTextBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 433);
            this.Controls.Add(this.vsPathTextBox);
            this.Controls.Add(this.vsLoactionlabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.compareButton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compare Files";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button compareButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label file2Label;
        private System.Windows.Forms.Label file1Lable;
        private System.Windows.Forms.Label vsLoactionlabel;
        private System.Windows.Forms.TextBox vsPathTextBox;
    }
}

