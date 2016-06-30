using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ets2_flag_file_generator.Templates
{
    interface ITemplate {
        string GetTemplate(string flagName,
            string friendlyFlagName,
            string truckName,
            Direction direction);
    }
}
