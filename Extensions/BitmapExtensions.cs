namespace Coursework.Extensions
{
    public static class BitmapExtensions
    {
        public static Bitmap Silhoutte(this Bitmap image, Color silhoutteColour)
        {
            Bitmap result = image;

            for (int x = 0; x < result.Width; x++)
            {
                for (int y = 0; y < result.Height; y++)
                {
                    if (result.GetPixel(x, y).A != 0)
                    {
                        result.SetPixel(x, y, silhoutteColour);
                    }
                }
            }

            return result;
        }
    }
}
