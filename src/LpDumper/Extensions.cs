namespace LpDumper
{
    public static class Extensions
    {
        /// <summary>
        /// makes Dump method available for all objects and loads result in a Viewer
        /// </summary>
        /// <param name="obj"></param>
        public static void Dump(this object obj)
        {
            LpDumpVisualizer.Dump(obj);
        }

        /// <summary>
        /// makes Dump method available for all objects, writes result to a temp file and opens it in browser
        /// </summary>
        /// <param name="obj"></param>
        public static void DumpFile(this object obj)
        {
            LpDumpVisualizer.DumpFile(obj);
        }
    }
}