namespace Ets2FlagFileGenerator.Templates
{
    internal class VehicleUpgradeMat : IMat
    {
        public string GetTemplate(string textureName) {
            const string template = @"material : ""eut2.dif.shadow""
{{
	texture: ""{0}.tobj""

	texture_name: ""texture_base""
}}";

            return string.Format(template, textureName);
        }
    }
}
