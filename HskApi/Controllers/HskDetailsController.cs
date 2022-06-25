using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HskApi.Models;
using Hski.Models;

namespace HskApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HskDetailsController : ControllerBase
    {
        private readonly Hski.Models.HskContext _context;

        public HskDetailsController(Hski.Models.HskContext context)
        {
            _context = context;
        }

        // GET: api/HskDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HskDetails>>> GetHskDetails()
        {
          if (_context.HskDetails == null)
          {
              return NotFound();
          }
            return await _context.HskDetails.ToListAsync();
        }

        // GET: api/HskDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HskDetails>> GetHskDetails(int id)
        {
          if (_context.HskDetails == null)
          {
              return NotFound();
          }
            var hskDetails = await _context.HskDetails.FindAsync(id);

            if (hskDetails == null)
            {
                return NotFound();
            }

            return hskDetails;
        }

        [HttpGet]
        [Route("HskByLevel/{level}")]
        public async Task<ActionResult<IEnumerable<HskDetails>>> GetHskDetailsByLevel(int level)
        {
            var hskDetails = await _context.HskDetails.Where(l => l.HskLevel == level).ToListAsync();

            if (hskDetails == null)
            {
                return NotFound();
            }
            return hskDetails;
        }
        private bool HskDetailsExists(int id)
        {
            return (_context.HskDetails?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
