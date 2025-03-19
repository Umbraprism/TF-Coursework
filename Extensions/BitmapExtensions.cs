namespace Coursework.Extensions
{
    public static class BitmapExtensions
    {
        public static Bitmap Silhoutte(this Bitmap image, Color silhoutteColour)
        {
            Bitmap result = image;

            // Iterates through each pixel
            for (int x = 0; x < result.Width; x++)
            {
                for (int y = 0; y < result.Height; y++)
                {
                    // Preserves alpha value of pixel
                    Color silhoutteAlpha = Color.FromArgb(result.GetPixel(x, y).A, silhoutteColour);

                    // Sets the colour to the specified silhouette colour with the alpha value of the original pixel still intact
                    if (result.GetPixel(x, y).A != 0)
                    {
                        result.SetPixel(x, y, silhoutteAlpha);
                    }
                }
            }

            return result;
        }
    }
}
