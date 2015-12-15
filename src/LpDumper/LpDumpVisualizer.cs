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
        /// Loads Viewer with rendered object data
        /// </summary>
        /// <param name="obj">source object</param>
        internal static void Dump(dynamic obj)
        {
            new Viewer { VisualizerValue = GetLpFormattedText(obj) }.ShowDialog();
        }

        /// <summary>
        /// Writes rendered output to a temp file and opens it up in browser
        /// </summary>
        /// <param name="obj">source boject</param>
        internal static void DumpFile(dynamic obj)
        {
            string filePath = Path.GetTempFileName() + ".htm";
            File.WriteAllText(filePath, GetLpFormattedText(obj));
            Process.Start(filePath);
        }
    }
}