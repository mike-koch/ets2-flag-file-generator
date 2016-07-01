using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ets2_flag_file_generator.Templates
{
    class MaterialFlagMat : IMat
    {
        public string GetTemplate(string flagName) {
            const string template = @"material : ""ui""
{{
	texture: ""flag_{0}.tobj""

	texture_name: ""texture""
}}";

            return string.Format(template, flagName);
        }
    }
}
