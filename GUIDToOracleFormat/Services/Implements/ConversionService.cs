using GUIDToOracleFormat.Services.Interfaces;

namespace GUIDToOracleFormat.Services.Implements
{
    public class ConversionService : IConversionService
    {

        public string ConvertToOracleGUID(string guidAsText)
        {
            Guid guid = Guid.Parse(guidAsText);

            return Convert.ToHexString(guid.ToByteArray());
        }
    }
}


