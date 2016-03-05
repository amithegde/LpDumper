using LINQPad;
using System.Diagnostics;
using System.IO;

namespace LpDumper
{
    public class LpDumpVisualizer
    {
        /// <summary>
        /// Uses LinqPad's Dump method to render the <see cref="source"/> as HTML file and opens it up on default browser
        /// Supports chaining Dump() method in same expression
        /// </summary>
        /// <typeparam name="T">Type of the object</typeparam>
        /// <param name="source">source object</param>
        /// <param name="title">Title for the Dump</param>
        /// <returns>Returns same object to support method chaining</returns>
        public static T Dump<T>(T source, string title = "")
        {
            var text = Path.GetTempFileName() + ".html";
            using (TextWriter textWriter = Util.CreateXhtmlWriter(true))
            {
                textWriter.Write(source);
                var body = string.IsNullOrWhiteSpace(title)
                    ? textWriter.ToString()
                    : string.Format("<strong>{0}</strong></br>{1}", title, textWriter);

                File.WriteAllText(text, body);
            }

            Process.Start(text);

            return source;
        }
    }
}