namespace Ets2FlagFileGenerator.Templates
{
    internal interface ITemplate {
        string GetTemplate(string flagId,
            string friendlyFlagName,
            string truckName,
            Direction direction,
            string uiTextureName);
    }
}
