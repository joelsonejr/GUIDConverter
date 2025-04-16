namespace GUIDToOracleFormat.Services.Interfaces
{
    public interface IConversionService
    {
        string ConvertToOracleGUID(string text);
    }
}