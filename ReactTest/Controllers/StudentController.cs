using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReactTest.DbContextFile;
using ReactTest.Models;

namespace ReactTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudentDBContext _context;
        public StudentController(StudentDBContext _context)
        {
            this._context = _context;
        }

        [HttpGet(Name = "GetCountry")]
        [Route("getAllCountry")]
        public async Task<IEnumerable<Country>> GetCountry()
        {
            return await _context.Country.ToListAsync();
        }

        [HttpPost(Name = "PostCountry")]
        [Route("postCountry")]
        public async Task<HttpResponseMessage> PostCountry(Country country)
        {
            await _context.Country.AddAsync(country);
            await _context.SaveChangesAsync();
            HttpResponseMessage message = new HttpResponseMessage();
            message.EnsureSuccessStatusCode();
            return message;
        }


    }
}
