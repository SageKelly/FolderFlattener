﻿using System;
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
        private static List<string> ExceptionList = new List<string>();

        static void Main(string[] zplFile)
        {
            StreamReader sr = new StreamReader(zplFile[0]);

            XmlDocument xmlDoc = new XmlDocument();
            List<string> musicList = new List<string>();

            try
            {
                string playlistPath = sr.ReadLine(); //2nd ReadLine
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
                    string mediaSource = mediaList.Item(i).Attributes.GetNamedItem("src").Value;
                    if (!musicList.Contains(mediaSource))
                        musicList.Add(mediaSource);
                }
            }

            string baseDestination = sr.ReadLine(); //3rd ReadLine
            sr.Close();

            if (musicList.Count > 0)
            {

                DriveInfo di = new DriveInfo(Directory.GetDirectoryRoot(baseDestination));

                if (di.IsReady)
                {

                    if (!Directory.Exists(baseDestination))
                    {
                        Directory.CreateDirectory(baseDestination);
                    }
                    foreach (string file in musicList)
                    {
                        string fullDestination = "";
                        try
                        {
                            if (!File.Exists(file))
                            {
                                SaveMissingFiles(file);
                                continue;
                            }
                            int lastFileSlash = file.LastIndexOf('\\');
                            int lastInputSlash = baseDestination.LastIndexOf('\\');


                            fullDestination = baseDestination + "\\" + file.Substring(lastFileSlash + 1);

                            if (lastFileSlash < file.Length && lastInputSlash < baseDestination.Length)
                            {
                                Console.Write("Writing {0} to {1}...", file.Substring(lastFileSlash + 1), baseDestination.Substring(lastInputSlash + 1));
                            }
                            if (!File.Exists(fullDestination))
                            {
                                File.Copy(file, fullDestination);
                                WriteColoredMessage("Done", ConsoleColor.Green);
                            }
                            else
                            {
                                WriteColoredMessage("Cancelled: already exists.",ConsoleColor.Yellow);
                            }


                        }
                        catch (Exception E)
                        {
                            WriteException(GetException(E), fullDestination);
                            break;
                        }
                    }
                    Console.WriteLine("Writing Complete");
                    WriteMissingFiles();
                }
                else
                {
                    WriteException("I don't think you're using the right drive:", baseDestination);
                }
            }
            else
            {
                Console.WriteLine("Hmm...doesn't look like you had any music written. Are you sure you got the right playlist?");
            }
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

        private static void SaveMissingFiles(string filePath)
        {
            ExceptionList.Add(filePath);
        }

        private static void WriteColoredMessage(string message, ConsoleColor color, bool newLine = true)
        {
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write("{0}{1}", message, newLine ? "\n" : "");
            Console.ForegroundColor = prevColor;
        }

        private static void WriteMissingFiles()
        {
            if (ExceptionList.Count > 0)
            {
                ConsoleColor origColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine("I couldn't find some of your files. You might want to take a look at these:");
                Console.ForegroundColor = ConsoleColor.Red;
                foreach (string filePath in ExceptionList)
                {
                    Console.WriteLine("• {0}", filePath);
                }

                Console.ForegroundColor = origColor;
            }
        }

        private static void WriteException(string message, string lastAttemptedDestination = null)
        {
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine("An error cccurred: {0}", message);
            if (!string.IsNullOrEmpty(lastAttemptedDestination))
            {
                Console.WriteLine("Last attempted directory: {0}", lastAttemptedDestination);
            }

            Console.ForegroundColor = prevColor;
            Console.ReadKey(true);
        }
    }
}
