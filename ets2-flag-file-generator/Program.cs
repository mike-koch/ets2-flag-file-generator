using System;
using System.Collections.Generic;
using System.Configuration;
using System.Configuration.Internal;
using System.Diagnostics;
using System.IO;
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
            string outputDirectory = ConfigurationManager.AppSettings["SaveLocation"];
            List<string> flags = GetFlags();
            List<string> friendlyFlagNames = GetFriendlyFlagNames();
            string[] vanillaTrucks = { "daf.xf", "daf.xf_euro6", "iveco.hiway", "iveco.stralis", "man.tgs", "mercedes.actros", "mercedes.actros2014", "renault.magnum",
                "renault.premium", "scania.r", "scania.streamline", "volvo.fh16", "volvo.fh16_2012" };
            List<string> modTrucks = GetTrucks();
            if (modTrucks[0] == "") {
                modTrucks.Remove(modTrucks[0]);
            }
            var trucks = new List<string>(modTrucks);
            trucks.AddRange(vanillaTrucks.ToList());

            // For each flag, go through each truck and build the necessary files, and save them in the correct format. Once for left flag, a second time for right flag.
            // ReSharper disable once LoopCanBePartlyConvertedToQuery
            for (int i = 0; i < flags.Count; i++) {
                foreach (string truck in trucks) {
                    Process(flags[i], friendlyFlagNames[i], truck, Direction.Left, outputDirectory, false);
                    Process(flags[i], friendlyFlagNames[i], truck, Direction.Right, outputDirectory, true);
                }
            }

            OutputFinalInstructions();
        }

        private static List<string> GetTrucks() {
            string truckList = ConfigurationManager.AppSettings["TruckIds"];

            return truckList.Split('|').ToList();
        }

        private static List<string> GetFlags() {
            string flagList = ConfigurationManager.AppSettings["FlagNames"];

            return flagList.Split('|').ToList();
        }

        private static List<string> GetFriendlyFlagNames() {
            string friendlyNames = ConfigurationManager.AppSettings["FriendlyFlagNames"];

            return friendlyNames.Split('|').ToList();
        }

        private static void Process(string flag, string friendlyFlagName, string truck, Direction direction, string outputDirectory, bool excludeDirectionlessFiles) {
            Console.WriteLine($"Processing flag {friendlyFlagName} for truck {truck}, on the {direction} side");

            // /def/vehicle/truck/*/accessory/{flag_l|flag_r}/*.sii (TruckAccessorySii)
            string truckAccessorySii = new TruckAccessorySii().GetTemplate(flag, friendlyFlagName, truck, direction);
            string materialFlagMat = new MaterialFlagMat().GetTemplate(flag);
            string vehicleUpgradeMat = new VehicleUpgradeMat().GetTemplate(flag);
            string outputFile;

            if (excludeDirectionlessFiles) {
                // material\ui\accessory\flag holds the materialFlagMat file (where the UI texture lives)
                string flagMatDirectory = outputDirectory + @"\material\ui\accessory\flag";
                Directory.CreateDirectory(flagMatDirectory);
                outputFile = BuildOutputFilePath(flagMatDirectory, flag, "mat", true);
                File.WriteAllText(outputFile, materialFlagMat);

                // vehicle\truck\upgrade\flag holds the vehicleUpgradeMat (where the actual flag texture lives)
                string upgradeMatDirectory = outputDirectory + @"\vehicle\truck\upgrade\flag";
                Directory.CreateDirectory(upgradeMatDirectory);
                outputFile = BuildOutputFilePath(upgradeMatDirectory, flag, "mat", false);
                File.WriteAllText(outputFile, vehicleUpgradeMat);
            }

            // def\vehicle\truck\{truck_name}\accessory\{flag_l|flag_r} holds the SII file
            string accessorySiiDirectory = outputDirectory +
                                        $@"\def\vehicle\truck\{truck}\accessory\flag_{(char) direction}";
            Directory.CreateDirectory(accessorySiiDirectory);
            outputFile = BuildOutputFilePath(accessorySiiDirectory, flag, "sii", false);
            File.WriteAllText(outputFile, truckAccessorySii);
        }

        private static string BuildOutputFilePath(string flagMatDirectory, string flag, string extension, bool includePrefix) {
            string fileName = includePrefix 
                ? "flag_" + flag 
                : flag;

            return $@"{flagMatDirectory}\{fileName}.{extension}";
        }

        private static void OutputFinalInstructions() {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.WriteLine(@"
Final Instructions
====================
1. Your DDS files will need to be manually copied over to the output directory.
2. TOBJ files currently cannot be generated.                                   
   To solve this, download and/or open ETS2 Studio, and use the TOBJ editor.   
   You will need a TOBJ for:                                                   
      - \material\ui\accessory\flag\{flag name}.dds                            
      - \vehicle\truck\upgrade\flag\{flag name}.dds   

Press any key to exit...                         
");
            Console.ReadKey();
        }
    }
}
