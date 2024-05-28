using EnqueteApi.Entities;
using EnqueteApi.Services.Interfaces;

namespace EnqueteApi.Services.Classes
{
    public class EnqueteService : IEnqueteService
    {
        public async Task<List<Enquete>> GetEnquetesAsync()
        {
            var filePath = Path.Combine(Environment.CurrentDirectory,"Enquete.txt");
            var readFile = await File.ReadAllLinesAsync(filePath);
            if (!File.Exists(filePath)) return new List<Enquete>();
            var list = new List<Enquete>();
            foreach (var line in readFile) 
            {
                var splitter = line.Split(',');
                list.Add(new Enquete() 
                {
                    Geslacht = splitter[0] ,
                    GeboorteJaar = int.Parse(splitter[1]),
                    VervoersMiddel = splitter[2]
                });
            }
            return list;
        }
    }
}
