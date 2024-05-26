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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            topBorder = new Panel();
            hide = new Button();
            maximize = new Button();
            exit = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            button1 = new Button();
            label2 = new Label();
            topBorder.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
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
            // hide
            // 
            hide.BackgroundImage = (Image)resources.GetObject("hide.BackgroundImage");
            hide.BackgroundImageLayout = ImageLayout.Center;
            hide.Dock = DockStyle.Right;
            hide.FlatAppearance.BorderSize = 0;
            hide.FlatStyle = FlatStyle.Flat;
            hide.Location = new Point(1008, 0);
            hide.Name = "hide";
            hide.Size = new Size(48, 36);
            hide.TabIndex = 3;
            hide.UseVisualStyleBackColor = true;
            // 
            // maximize
            // 
            maximize.BackgroundImage = (Image)resources.GetObject("maximize.BackgroundImage");
            maximize.BackgroundImageLayout = ImageLayout.Center;
            maximize.Dock = DockStyle.Right;
            maximize.FlatAppearance.BorderSize = 0;
            maximize.FlatStyle = FlatStyle.Flat;
            maximize.Location = new Point(1056, 0);
            maximize.Name = "maximize";
            maximize.Size = new Size(48, 36);
            maximize.TabIndex = 2;
            maximize.UseVisualStyleBackColor = true;
            // 
            // exit
            // 
            exit.BackgroundImage = (Image)resources.GetObject("exit.BackgroundImage");
            exit.BackgroundImageLayout = ImageLayout.Center;
            exit.Dock = DockStyle.Right;
            exit.FlatAppearance.BorderSize = 0;
            exit.FlatStyle = FlatStyle.Flat;
            exit.Location = new Point(1104, 0);
            exit.Name = "exit";
            exit.Size = new Size(48, 36);
            exit.TabIndex = 1;
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(212, 532);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(61, 61, 61);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(212, 30);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(72, 3);
            label1.Name = "label1";
            label1.Size = new Size(63, 21);
            label1.TabIndex = 0;
            label1.Text = "ToolBox";
            label1.Click += label1_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(button1);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(218, 42);
            panel3.Name = "panel3";
            panel3.Size = new Size(922, 514);
            panel3.TabIndex = 2;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(31, 31, 31);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(349, 165);
            button1.Name = "button1";
            button1.Size = new Size(218, 106);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(396, 274);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 0;
            label2.Text = "Click to Import Image";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            ClientSize = new Size(1152, 568);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(topBorder);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            topBorder.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel topBorder;
        private Button exit;
        private Button hide;
        private Button maximize;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private Button button1;
    }
}
