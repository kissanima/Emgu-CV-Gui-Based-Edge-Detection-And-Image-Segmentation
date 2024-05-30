namespace Emgu_CV_Gui_Based_Edge_Detection_And_Image_Segmentation
{
    internal class InputHandler
    {
        Bitmap image;

        public void SetImage(Bitmap bitmap)
        {
            this.image = bitmap;
        }

        public Bitmap GetImage()
        {
            return image;
        }

    }
}
