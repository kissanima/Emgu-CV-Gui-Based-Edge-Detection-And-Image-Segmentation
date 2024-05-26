namespace Emgu_CV_Gui_Based_Edge_Detection_And_Image_Segmentation
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
            topBorder = new Panel();
            exit = new Button();
            maximize = new Button();
            hide = new Button();
            topBorder.SuspendLayout();
            SuspendLayout();
            // 
            // topBorder
            // 
            topBorder.BackColor = Color.FromArgb(30, 30, 30);
            topBorder.Controls.Add(hide);
            topBorder.Controls.Add(maximize);
            topBorder.Controls.Add(exit);
            topBorder.Dock = DockStyle.Top;
            topBorder.Location = new Point(0, 0);
            topBorder.Name = "topBorder";
            topBorder.Size = new Size(1152, 36);
            topBorder.TabIndex = 0;
            // 
            // exit
            // 
            exit.Dock = DockStyle.Right;
            exit.FlatAppearance.BorderSize = 0;
            exit.FlatStyle = FlatStyle.Flat;
            exit.Location = new Point(1104, 0);
            exit.Name = "exit";
            exit.Size = new Size(48, 36);
            exit.TabIndex = 1;
            exit.Text = "X";
            exit.UseVisualStyleBackColor = true;
            // 
            // maximize
            // 
            maximize.Dock = DockStyle.Right;
            maximize.FlatAppearance.BorderSize = 0;
            maximize.FlatStyle = FlatStyle.Flat;
            maximize.Location = new Point(1056, 0);
            maximize.Name = "maximize";
            maximize.Size = new Size(48, 36);
            maximize.TabIndex = 2;
            maximize.Text = "X";
            maximize.UseVisualStyleBackColor = true;
            // 
            // hide
            // 
            hide.Dock = DockStyle.Right;
            hide.FlatAppearance.BorderSize = 0;
            hide.FlatStyle = FlatStyle.Flat;
            hide.Location = new Point(1008, 0);
            hide.Name = "hide";
            hide.Size = new Size(48, 36);
            hide.TabIndex = 3;
            hide.Text = "__";
            hide.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            ClientSize = new Size(1152, 568);
            Controls.Add(topBorder);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            topBorder.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel topBorder;
        private Button exit;
        private Button hide;
        private Button maximize;
    }
}
