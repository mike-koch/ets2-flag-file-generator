using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ets2_flag_file_generator.Templates
{
    class VehicleUpgradeMat : IMat
    {
        public string GetTemplate(string flagName) {
            const string template = @"material : ""eut2.dif.shadow""
{{
	texture: ""{0}.tobj""

	texture_name: ""texture_base""
}}";

            return string.Format(template, flagName);
        }
    }
}
