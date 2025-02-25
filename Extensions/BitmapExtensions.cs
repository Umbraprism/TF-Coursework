namespace Coursework.Extensions
{
    public static class BitmapExtensions
    {
        public static Bitmap Silhoutte(this Bitmap image, Color silhoutteColour)
        {
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    if (image.GetPixel(x, y).A != 0)
                    {
                        image.SetPixel(x, y, silhoutteColour);
                    }
                }
            }

            return image;
        }
    }
}
