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
            try
            {
                LpDumpVisualizer.Dump(obj);
            }
            catch (System.Exception)
            {
                LpDumpVisualizer.DumpFile(obj);
            }
        }
    }
}