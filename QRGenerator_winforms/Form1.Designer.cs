﻿namespace QRGenerator_winforms
{
    partial class Form1
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
            panel1 = new Panel();
            LinkTextBox = new RichTextBox();
            GenerateButton = new Button();
            QRPictureBox = new PictureBox();
            ClearButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)QRPictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(ClearButton);
            panel1.Controls.Add(LinkTextBox);
            panel1.Controls.Add(GenerateButton);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(803, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(239, 611);
            panel1.TabIndex = 0;
            // 
            // LinkTextBox
            // 
            LinkTextBox.Dock = DockStyle.Top;
            LinkTextBox.Location = new Point(0, 0);
            LinkTextBox.Name = "LinkTextBox";
            LinkTextBox.Size = new Size(239, 96);
            LinkTextBox.TabIndex = 2;
            LinkTextBox.Text = "";
            // 
            // GenerateButton
            // 
            GenerateButton.Dock = DockStyle.Bottom;
            GenerateButton.Location = new Point(0, 553);
            GenerateButton.Name = "GenerateButton";
            GenerateButton.Size = new Size(239, 58);
            GenerateButton.TabIndex = 0;
            GenerateButton.Text = "Сгенерировать";
            GenerateButton.UseVisualStyleBackColor = true;
            GenerateButton.Click += GenerateButton_Click;
            // 
            // QRPictureBox
            // 
            QRPictureBox.Dock = DockStyle.Fill;
            QRPictureBox.Location = new Point(0, 0);
            QRPictureBox.Name = "QRPictureBox";
            QRPictureBox.Size = new Size(803, 611);
            QRPictureBox.TabIndex = 1;
            QRPictureBox.TabStop = false;
            // 
            // ClearButton
            // 
            ClearButton.Dock = DockStyle.Bottom;
            ClearButton.Location = new Point(0, 495);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(239, 58);
            ClearButton.TabIndex = 3;
            ClearButton.Text = "Очистить";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 611);
            Controls.Add(QRPictureBox);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)QRPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button GenerateButton;
        private PictureBox QRPictureBox;
        private RichTextBox LinkTextBox;
        private Button ClearButton;
    }
}
