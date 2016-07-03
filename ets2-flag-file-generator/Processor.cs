using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Ets2FlagFileGenerator.Templates;

namespace Ets2FlagFileGenerator
{
    internal class Processor
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        public static void Process(List<string> truckIds, List<Flag> flags, string outputDirectory) {
            // Add the default trucks to the list of truckIds
            string[] vanillaTrucks = { "daf.xf", "daf.xf_euro6", "iveco.hiway", "iveco.stralis", "man.tgs", "mercedes.actros", "mercedes.actros2014", "renault.magnum",
                "renault.premium", "scania.r", "scania.streamline", "volvo.fh16", "volvo.fh16_2012" };
            truckIds.AddRange(vanillaTrucks.ToList());

            // ReSharper disable once LoopCanBePartlyConvertedToQuery
            foreach (string truck in truckIds) {
                foreach (Flag flag in flags) {
                        Process(flag.Id, flag.TextureFilenameLeft, flag.UiTextureFilename, flag.DisplayName, truck, Direction.Left, outputDirectory, false);
                        Process(flag.Id, flag.TextureFilenameRight, flag.UiTextureFilename, flag.DisplayName, truck, Direction.Right, outputDirectory, true);
                }
            }
        }

        private static void Process(string id, string textureName, string uiTextureName, string friendlyFlagName, string truck, Direction direction, string outputDirectory, bool excludeDirectionlessFiles) {
            Console.WriteLine($"Processing flag {friendlyFlagName} for truck {truck}, on the {direction} side");

            string truckAccessorySii = new TruckAccessorySii().GetTemplate(id, friendlyFlagName, truck, direction,
                uiTextureName);
            string materialFlagMat = new MaterialFlagMat().GetTemplate(uiTextureName);
            string vehicleUpgradeMat = new VehicleUpgradeMat().GetTemplate(textureName);
            string outputFile;

            if (excludeDirectionlessFiles) {
                // material\ui\accessory\flag holds the materialFlagMat file (where the UI texture lives)
                string flagMatDirectory = outputDirectory + @"\material\ui\accessory\flag";
                Directory.CreateDirectory(flagMatDirectory);
                outputFile = BuildOutputFilePath(flagMatDirectory, uiTextureName, "mat");
                File.WriteAllText(outputFile, materialFlagMat);
            }

            // vehicle\truck\upgrade\flag holds the vehicleUpgradeMat (where the actual flag texture lives)
            string upgradeMatDirectory = outputDirectory + @"\vehicle\truck\upgrade\flag";
            Directory.CreateDirectory(upgradeMatDirectory);
            outputFile = BuildOutputFilePath(upgradeMatDirectory, textureName, "mat");
            File.WriteAllText(outputFile, vehicleUpgradeMat);

            // def\vehicle\truck\{truck_name}\accessory\{flag_l|flag_r} holds the SII file
            string accessorySiiDirectory = outputDirectory +
                                        $@"\def\vehicle\truck\{truck}\accessory\flag_{(char) direction}";
            Directory.CreateDirectory(accessorySiiDirectory);
            outputFile = BuildOutputFilePath(accessorySiiDirectory, id, "sii");
            File.WriteAllText(outputFile, truckAccessorySii);
        }

        private static string BuildOutputFilePath(string directory, string name, string extension) {
            return $@"{directory}\{name}.{extension}";
        }
    }
}
