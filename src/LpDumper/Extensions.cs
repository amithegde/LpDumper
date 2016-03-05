namespace LpDumper
{
    public static class Extensions
    {
        /// <summary>
        /// makes Dump method available for all objects and loads result in browser
        /// </summary>
        /// <param name="source"></param>
        /// <param name="title"></param>
        public static T Dump<T>(this T source, string title = "")
        {
            return LpDumpVisualizer.Dump(source, title);
        }
    }
}