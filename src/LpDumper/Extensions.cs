using LINQPad;
using System.Diagnostics;
using System.IO;

namespace LpDumper
{
    public static class Extensions
    {
        /// <summary>
        /// makes Dump method available for all objects and loads result in browser
        /// </summary>
        /// <param name="source"></param>
        public static T Dump<T>(this T source)
        {
            return LpDumpVisualizer.Dump(source);
        }
    }
}