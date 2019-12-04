using System;
using System.IO;
using System.Linq;
using CsvHelper;

namespace Laba5
{
    public class FileExtensions
    {
        public string Text { get; set; }

        public static string[] Get()
        {
            try
            {
                using (var reader = new StreamReader(@"..\..\..\Text.csv"))
                using (var csv = new CsvReader(reader))
                {
                    var records = csv.GetRecords<FileExtensions>();

                    return records.Select(item => item.Text).ToArray();
                }
            }
            catch (Exception massage)
            {
                Console.WriteLine(massage);
                return null;
            }
        }
    }
}
