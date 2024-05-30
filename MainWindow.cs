namespace Emgu_CV_Gui_Based_Edge_Detection_And_Image_Segmentation
{
    public partial class MainWindow : Form
    {
        //ImageHandler imageHandler = new ImageHandler();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void importImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image file (*.bmp; *.png; *.jpg)| *.bmp; *.png; *.jpg";
            if (DialogResult.OK == ofd.ShowDialog())
            {
                //imageHandler.SetImage(new Bitmap(ofd.FileName));

                //close import image panel
                //ImportImagePanel.Visible = false;
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
