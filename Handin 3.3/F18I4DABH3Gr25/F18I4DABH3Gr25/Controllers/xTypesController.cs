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
    public class xTypesController : ApiController
    {
        private F18I4DABH3Gr25Context db = new F18I4DABH3Gr25Context();

        // GET: api/xTypes
        public IQueryable<xType> GetxTypes()
        {
            return db.xTypes;
        }

        // GET: api/xTypes/5
        [ResponseType(typeof(xType))]
        public async Task<IHttpActionResult> GetxType(int id)
        {
            xType xType = await db.xTypes.FindAsync(id);
            if (xType == null)
            {
                return NotFound();
            }

            return Ok(xType);
        }

        // PUT: api/xTypes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutxType(int id, xType xType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != xType.TypeID)
            {
                return BadRequest();
            }

            db.Entry(xType).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!xTypeExists(id))
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

        // POST: api/xTypes
        [ResponseType(typeof(xType))]
        public async Task<IHttpActionResult> PostxType(xType xType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.xTypes.Add(xType);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = xType.TypeID }, xType);
        }

        // DELETE: api/xTypes/5
        [ResponseType(typeof(xType))]
        public async Task<IHttpActionResult> DeletexType(int id)
        {
            xType xType = await db.xTypes.FindAsync(id);
            if (xType == null)
            {
                return NotFound();
            }

            db.xTypes.Remove(xType);
            await db.SaveChangesAsync();

            return Ok(xType);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool xTypeExists(int id)
        {
            return db.xTypes.Count(e => e.TypeID == id) > 0;
        }
    }
}