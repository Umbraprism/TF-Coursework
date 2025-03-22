namespace Coursework.Extensions
{
    public static class CollectionExtensions
    {
        #region Methods
        public static List<T> Shuffle<T>(this List<T> toShuffle)
        {
            Random rnd = new();

            for (int i = 0; i < toShuffle.Count; i++)
            {
                T store = toShuffle[i];
                int rndNum = rnd.Next(i, toShuffle.Count);

                toShuffle[i] = toShuffle[rndNum];
                toShuffle[rndNum] = store;
            }

            return toShuffle;
        }

        public static T[] Shuffle<T>(this T[] toShuffle)
        {
            Random rnd = new();

            for (int i = 0; i < toShuffle.Length; i++)
            {
                T store = toShuffle[i];
                int rndNum = rnd.Next(i, toShuffle.Length);

                toShuffle[i] = toShuffle[rndNum];
                toShuffle[rndNum] = store;
            }

            return toShuffle.ToArray();
        }
        #endregion
    }
}
