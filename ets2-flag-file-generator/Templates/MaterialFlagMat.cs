namespace Ets2FlagFileGenerator.Templates
{
    internal class MaterialFlagMat : IMat
    {
        public string GetTemplate(string uiTextureName) {
            const string template = @"material : ""ui""
{{
	texture: ""{0}.tobj""

	texture_name: ""texture""
}}";

            return string.Format(template, uiTextureName);
        }
    }
}
