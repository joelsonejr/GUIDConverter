using System;
using System.Data;
using GUIDToOracleFormat.Services.Implements;

namespace GUIDToOracleFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            ConversionService _conversion = new ConversionService();

            Console.Write("Type in a GUID: ");

            var input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentNullException();
            }

            string oracleGuid = _conversion.ConvertToOracleGUID(input);

            Console.WriteLine($"Original GUID: {input}");
            Console.WriteLine($"OracleDB compatible GUID: {oracleGuid}");

        }
    }
}
