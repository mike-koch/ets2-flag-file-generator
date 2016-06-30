using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ets2_flag_file_generator.Templates;

namespace ets2_flag_file_generator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> flags = GetFlags();
            List<string> trucks = GetTrucks();

            // For each flag, go through each truck and build the necessary files, and save them in the correct format. Once for left flag, a second time for right flag.
            // ReSharper disable once LoopCanBePartlyConvertedToQuery
            foreach (string flag in flags) {
                foreach (string truck in trucks) {
                    Process(flag, truck, Direction.Left);
                    Process(flag, truck, Direction.Right);
                }
            }

            TruckAccessorySii sii = new TruckAccessorySii();
            Console.WriteLine(sii.GetTemplate("flagName", "friendlyFlagname", "truckname", Direction.Left));
            Console.WriteLine("garbage");
        }

        private static List<string> GetTrucks() {
            string truckList = ConfigurationManager.AppSettings["TruckIds"];

            return truckList.Split('|').ToList();
        }

        private static List<string> GetFlags() {
            string flagList = ConfigurationManager.AppSettings["FlagNames"];

            return flagList.Split('|').ToList();
        }

        private static void Process(string flag, string truck, Direction direction) {
            
        }
    }
}
