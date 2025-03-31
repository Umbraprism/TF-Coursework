namespace Coursework.Extensions
{
    public static class BitmapExtensions
    {
        #region Methods
        public static Bitmap Silhoutte(this Bitmap image, Color silhoutteColour)
        {
            Bitmap result = (Bitmap)image.Clone();

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

        public static Bitmap Desaturate(this Bitmap bitmap)
        {
            Bitmap result = (Bitmap)bitmap.Clone();

            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    int[] rgb = [result.GetPixel(x, y).R, result.GetPixel(x, y).G, result.GetPixel(x, y).B];

                    double avg = rgb.Average();

                    result.SetPixel(x, y, Color.FromArgb(result.GetPixel(x, y).A, (int)avg, (int)avg, (int)avg));
                }
            }

            return result;
        }
        #endregion
    }
}
