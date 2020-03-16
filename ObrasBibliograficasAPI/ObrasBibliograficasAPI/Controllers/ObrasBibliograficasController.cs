using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ObrasBibliograficasAPI.Models;

namespace ObrasBibliograficasAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObrasBibliograficasController : ControllerBase
    {
        private readonly ObrasBibliograficasAPIContext _context;

        public ObrasBibliograficasController(ObrasBibliograficasAPIContext context)
        {
            _context = context;
        }

        // GET: api/ObrasBibliograficas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ObrasBibliograficas>>> GetObrasBibliograficas()
        {
            return await _context.ObrasBibliograficas.ToListAsync();
        }

        // GET: api/ObrasBibliograficas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ObrasBibliograficas>> GetObrasBibliograficas(int id)
        {
            var obrasBibliograficas = await _context.ObrasBibliograficas.FindAsync(id);

            if (obrasBibliograficas == null)
            {
                return NotFound();
            }

            return obrasBibliograficas;
        }

        // PUT: api/ObrasBibliograficas/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutObrasBibliograficas(int id, ObrasBibliograficas obrasBibliograficas)
        {
            if (id != obrasBibliograficas.Id)
            {
                return BadRequest();
            }

            _context.Entry(obrasBibliograficas).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ObrasBibliograficasExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ObrasBibliograficas
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<ObrasBibliograficas>> PostObrasBibliograficas(ObrasBibliograficas obrasBibliograficas)
        {
            _context.ObrasBibliograficas.Add(obrasBibliograficas);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetObrasBibliograficas", new { id = obrasBibliograficas.Id }, obrasBibliograficas);
        }

        // DELETE: api/ObrasBibliograficas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ObrasBibliograficas>> DeleteObrasBibliograficas(int id)
        {
            var obrasBibliograficas = await _context.ObrasBibliograficas.FindAsync(id);
            if (obrasBibliograficas == null)
            {
                return NotFound();
            }

            _context.ObrasBibliograficas.Remove(obrasBibliograficas);
            await _context.SaveChangesAsync();

            return obrasBibliograficas;
        }

        private bool ObrasBibliograficasExists(int id)
        {
            return _context.ObrasBibliograficas.Any(e => e.Id == id);
        }
    }
}
