using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ets2FlagFileGenerator.Templates;

namespace Ets2FlagFileGenerator
{
    internal class Flag
    {
        public string Id { get; set; }
        public string TextureFilenameLeft { get; set; }
        public string TextureFilenameRight { get; set; }
        public string UiTextureFilename { get; set; }
        public string DisplayName { get; set; }
    }
}
