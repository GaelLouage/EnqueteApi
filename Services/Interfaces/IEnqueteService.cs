using EnqueteApi.Entities;

namespace EnqueteApi.Services.Interfaces
{
    public interface IEnqueteService
    {
        Task<List<Enquete>> GetEnquetesAsync();
    }
}
