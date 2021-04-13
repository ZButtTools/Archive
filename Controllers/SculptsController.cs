using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Archive.Models;
using Archive.Data;

namespace Archive.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SculptsController : ControllerBase{

        private readonly ArchiveContext _context;

        public SculptsController(ArchiveContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<Sculpt>> GetAll() =>
            _context.Sculpts.ToList();
    }
    
}