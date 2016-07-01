namespace Ets2FlagFileGenerator.Templates
{
    internal class MaterialFlagMat : IMat
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
