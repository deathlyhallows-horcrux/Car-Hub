using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CarHub.Models;
using CarHub.Persistance;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using AutoMapper;

namespace CarHub.Controllers
{
    public class MakesController : Controller
    {
        private readonly CarHubDbContext context;
        private readonly IMapper mapper;
        public MakesController(CarHubDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;

        }

        [HttpGet("api/makes")]
        public async Task<IEnumerable<MakeResource>> GetMakes()
        {
            var makes = await context.Makes.Include(m => m.Models).ToListAsync();
            //mapping source type to destination type
            return mapper.Map<List<Make>, List<MakeResource>>(makes);
        }
    }
}