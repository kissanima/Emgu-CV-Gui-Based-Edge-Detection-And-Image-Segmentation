namespace Emgu_CV_Gui_Based_Edge_Detection_And_Image_Segmentation
{
    partial class ImportControlPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ImportImagePanel = new Panel();
            button_ImportImage = new Button();
            ImportImagePanel.SuspendLayout();
            SuspendLayout();
            // 
            // ImportImagePanel
            // 
            ImportImagePanel.Controls.Add(button_ImportImage);
            ImportImagePanel.Location = new Point(88, 120);
            ImportImagePanel.Name = "ImportImagePanel";
            ImportImagePanel.Size = new Size(369, 335);
            ImportImagePanel.TabIndex = 0;
            // 
            // button_ImportImage
            // 
            button_ImportImage.Location = new Point(76, 42);
            button_ImportImage.Name = "button_ImportImage";
            button_ImportImage.Size = new Size(230, 175);
            button_ImportImage.TabIndex = 0;
            button_ImportImage.UseVisualStyleBackColor = true;
            button_ImportImage.Click += button1_Click;
            // 
            // ImportControlPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            Controls.Add(ImportImagePanel);
            Name = "ImportControlPanel";
            Size = new Size(1189, 626);
            ImportImagePanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel ImportImagePanel;
        private Button button_ImportImage;
    }
}
