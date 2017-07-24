using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Folder_Flattener
{
    class Program
    {
        static void Main(string[] wplFile)
        {
            StreamReader sr = new StreamReader(wplFile[0]);
            string musicPath = sr.ReadLine();

            XmlDocument xmlDoc = new XmlDocument();
            List<string> musicList = new List<string>();

            try
            {
                string playlistPath = sr.ReadLine();                
                xmlDoc.Load(playlistPath);
            }
            catch (Exception e)
            {
                WriteException(GetException(e));
            }
            XmlNodeList mediaList = xmlDoc.GetElementsByTagName("media");

            if (mediaList.Count > 0)
            {
                for (int i = 0; i < mediaList.Count; i++)
                {
                    string mediaSource = mediaList.Item(i).Attributes.GetNamedItem("src").Value.Replace("..", musicPath);
                    //Console.WriteLine(mediaSource);
                    musicList.Add(mediaSource);
                }
            }

            string baseDestination = sr.ReadLine();
            sr.Close();
            if (!Directory.Exists(baseDestination))
            {
                Directory.CreateDirectory(baseDestination);
            }

            foreach (string file in musicList)
            {
                try
                {
                    int lastFileSlash = file.LastIndexOf('\\');
                    int lastInputSlash = baseDestination.LastIndexOf('\\');


                    string fullDestination = baseDestination + "\\" + file.Substring(lastFileSlash + 1);

                    if (lastFileSlash < file.Length && lastInputSlash < baseDestination.Length)
                    {
                        Console.Write("Writing {0} to {1}...", file.Substring(lastFileSlash + 1), baseDestination.Substring(lastInputSlash + 1));
                    }
                    if (!File.Exists(fullDestination))
                    {
                        File.Copy(file, fullDestination);
                        Console.WriteLine("Done");
                    }
                    else
                    {
                        Console.WriteLine("Cancelled: already exists.");
                    }


                }
                catch (Exception E)
                {
                    WriteException(GetException(E));
                    break;
                }
            }
            Console.WriteLine("Writing Complete");
            Console.ReadKey(true);
        }

        private static string GetException(Exception E)
        {
            if (E.InnerException != null)
            {
                return GetException(E.InnerException);
            }
            else
            {
                return E.Message;
            }
        }

        private static void WriteException(string message)
        {
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine("An error cccurred: {0}", message);
            Console.ForegroundColor = prevColor;
            Console.ReadKey(true);
        }
    }
}
