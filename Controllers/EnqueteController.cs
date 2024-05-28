using EnqueteApi.Entities;
using EnqueteApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace EnqueteApi.Controllers
{
    public class EnqueteController : BaseController
    {
      
        public EnqueteController(IEnqueteService enqueteService) : base(enqueteService) { }

        [HttpGet("GetEnquetesAsync")]
        public async Task<IActionResult> GetEnquetesAsync()
        {
            var enquetes = await EnqueteService.GetEnquetesAsync();
            enquetes.Select(x => x.VervoersMiddel == x.VervoersMiddel.Replace("\"", ""));
            if (enquetes is null || enquetes.Count == 0)
            {
                return NotFound("Empty Enquetes.");
            }
          
            return Ok(enquetes);
        }
  
    }
}
