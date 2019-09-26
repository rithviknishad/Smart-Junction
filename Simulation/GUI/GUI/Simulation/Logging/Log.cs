using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GUI.Simulation.Logging
{
    public class LogModule
    {

        public string LoggerID { get; private set; } = null;

        public string FilePath = @"D:\";

        public LogModule(string loggerID)
        {
            LoggerID = loggerID;
            FilePath = Properties.Settings.Default.LogPath + @"\logs\" + LoggerID + ".txt";
            //Console.WriteLine(DateTime.Now.TimeOfDay + "  >  @{0}: Logging module initialized.", LoggerID);

            Add(new string[]
            {
                "#",
                "#   S M A R T   J U N C T I O N   -   A D V A N C E D   S I M U L  A T I O N   ( L O G   F I L E )",
                "#",
                "#   Software Generated File",
                "#   Simulation Version: " + Assembly.GetExecutingAssembly().GetName().Version.ToString(),
                "#   Not for redistribution!",
                "#",
            });
        }


        public List<string> buffer_memory = new List<string>();

        
        private void Write(string[] data)
        {
            if (!File.Exists(FilePath))
            {
                new FileInfo(FilePath).Directory.Create();
                TextWriter Writer = new StreamWriter(FilePath);
                Writer.WriteLine("# AUTO-GENERATED FILE");
                Writer.WriteLine("# [Log File Created on" + DateTime.Now.TimeOfDay + "]\n\n");
                Writer.Close();
            }

            if (File.Exists(FilePath))
            {
                TextWriter Writer = new StreamWriter(FilePath, true);
                foreach(string line in data)
                {
                    Writer.WriteLine(line.ToString());
                }
                Writer.Close();
            }

            //Console.WriteLine(DateTime.Now.TimeOfDay + "  @" + LoggerID + "  > Log File Saved to " + FilePath);
        }

        public void Add(string data)
        {
            buffer_memory.Add(DateTime.Now.TimeOfDay + "  @" + LoggerID + "  > " + data);

            if (buffer_memory.Count > 3000)
            {
                FlushBuffer();
                //Console.WriteLine(DateTime.Now.TimeOfDay + "  @" + LoggerID + "  > Autoflushing log buffer memory... buffer overloaded.");
            }
        }

        public void Add(string[] data)
        {
            foreach(string line in data)
            {
                Add(line);
            }
        }

        public void FlushBuffer()
        {
            Write(buffer_memory.ToArray());
            buffer_memory.Clear();
            //Console.WriteLine(DateTime.Now.TimeOfDay + "  @" + LoggerID + "  > Log buffer memory flushed.");
        }


    }
}
