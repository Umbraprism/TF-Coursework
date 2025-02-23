namespace Coursework.Extensions
{
    public static class CollectionExtensions
    {
        public static void Shuffle<T>(this List<T> toShuffle)
        {
            Random rnd = new();

            for (int i = 0; i < toShuffle.Count; i++)
            {
                T store = toShuffle[i];
                int rndNum = rnd.Next(i, toShuffle.Count);

                toShuffle[i] = toShuffle[rndNum];
                toShuffle[rndNum] = store;
            }
        }

        public static void Shuffle<T>(this T[] toShuffle)
        {
            Random rnd = new();

            for (int i = 0; i < toShuffle.Length; i++)
            {
                T store = toShuffle[i];
                int rndNum = rnd.Next(i, toShuffle.Length);

                toShuffle[i] = toShuffle[rndNum];
                toShuffle[rndNum] = store;
            }
        }
    }
}
