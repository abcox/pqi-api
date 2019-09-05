using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pqi.Data.Contexts;

namespace pqi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblPriceBookMainsController : ControllerBase
    {
        private readonly QuoteContext _context;

        public TblPriceBookMainsController(QuoteContext context)
        {
            _context = context;
        }

        // GET: api/TblPriceBookMains
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TblPriceBookMain>>> GetTblPriceBookMain()
        {
            return await _context.TblPriceBookMain.ToListAsync();
        }

        // GET: api/TblPriceBookMains/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblPriceBookMain>> GetTblPriceBookMain(int id)
        {
            var tblPriceBookMain = await _context.TblPriceBookMain.FindAsync(id);

            if (tblPriceBookMain == null)
            {
                return NotFound();
            }

            return tblPriceBookMain;
        }

        // PUT: api/TblPriceBookMains/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblPriceBookMain(int id, TblPriceBookMain tblPriceBookMain)
        {
            if (id != tblPriceBookMain.PartId)
            {
                return BadRequest();
            }

            _context.Entry(tblPriceBookMain).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblPriceBookMainExists(id))
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

        // POST: api/TblPriceBookMains
        [HttpPost]
        public async Task<ActionResult<TblPriceBookMain>> PostTblPriceBookMain(TblPriceBookMain tblPriceBookMain)
        {
            _context.TblPriceBookMain.Add(tblPriceBookMain);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTblPriceBookMain", new { id = tblPriceBookMain.PartId }, tblPriceBookMain);
        }

        // DELETE: api/TblPriceBookMains/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TblPriceBookMain>> DeleteTblPriceBookMain(int id)
        {
            var tblPriceBookMain = await _context.TblPriceBookMain.FindAsync(id);
            if (tblPriceBookMain == null)
            {
                return NotFound();
            }

            _context.TblPriceBookMain.Remove(tblPriceBookMain);
            await _context.SaveChangesAsync();

            return tblPriceBookMain;
        }

        private bool TblPriceBookMainExists(int id)
        {
            return _context.TblPriceBookMain.Any(e => e.PartId == id);
        }
    }
}
