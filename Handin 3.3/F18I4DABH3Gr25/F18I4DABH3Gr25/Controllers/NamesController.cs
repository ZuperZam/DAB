using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using DokumentDB;
using F18I4DABH3Gr25.Models;

namespace F18I4DABH3Gr25.Controllers
{
    public class NamesController : ApiController
    {
        private F18I4DABH3Gr25Context db = new F18I4DABH3Gr25Context();

        // GET: api/Names
        public IQueryable<Name> GetNames()
        {
            return db.Names;
        }

        // GET: api/Names/5
        [ResponseType(typeof(Name))]
        public async Task<IHttpActionResult> GetName(int id)
        {
            Name name = await db.Names.FindAsync(id);
            if (name == null)
            {
                return NotFound();
            }

            return Ok(name);
        }

        // PUT: api/Names/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutName(int id, Name name)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != name.NameID)
            {
                return BadRequest();
            }

            db.Entry(name).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NameExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Names
        [ResponseType(typeof(Name))]
        public async Task<IHttpActionResult> PostName(Name name)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Names.Add(name);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = name.NameID }, name);
        }

        // DELETE: api/Names/5
        [ResponseType(typeof(Name))]
        public async Task<IHttpActionResult> DeleteName(int id)
        {
            Name name = await db.Names.FindAsync(id);
            if (name == null)
            {
                return NotFound();
            }

            db.Names.Remove(name);
            await db.SaveChangesAsync();

            return Ok(name);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool NameExists(int id)
        {
            return db.Names.Count(e => e.NameID == id) > 0;
        }
    }
}