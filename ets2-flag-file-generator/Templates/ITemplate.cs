namespace Ets2FlagFileGenerator.Templates
{
    internal interface ITemplate {
        string GetTemplate(string flagName,
            string friendlyFlagName,
            string truckName,
            Direction direction);
    }
}
