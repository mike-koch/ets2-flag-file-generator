using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ets2_flag_file_generator.Templates
{
    interface IMat {
        string GetTemplate(string flagName);
    }
}
