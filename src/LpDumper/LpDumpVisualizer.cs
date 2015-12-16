using System.Diagnostics;
using System.IO;

namespace LpDumper
{
    public class LpDumpVisualizer
    {
        /// <summary>
        /// Renders Dump output for the object using LinqPad
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj">source object</param>
        /// <returns></returns>
        private static string GetLpFormattedText<T>(T obj)
        {
            var writer = LINQPad.Util.CreateXhtmlWriter();
            writer.Write(obj);

            return writer.ToString();
        }

        /// <summary>
        /// Writes rendered output to a temp file and opens it up in browser
        /// </summary>
        /// <param name="obj">source object</param>
        internal static T Dump<T>(T sourceObj)
        {
            string filePath = Path.GetTempFileName() + ".htm";
            File.WriteAllText(filePath, GetLpFormattedText(sourceObj));
            Process.Start(filePath);

            return sourceObj;
        }
    }
}