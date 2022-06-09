using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using EatOnTimeApi;

namespace EatOnTimeApi.Controllers.tables
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class RTABLESController : ApiController
    {
        private RDB5Entities db = new RDB5Entities();

        // GET: api/RTABLES
        public IQueryable<RTABLES> GetRTABLES()
        {
            return db.RTABLES;
        }

        // GET: api/RTABLES/5
        [ResponseType(typeof(RTABLES))]
        public IHttpActionResult GetRTABLES(int id)
        {
            RTABLES rTABLES = db.RTABLES.Find(id);
            if (rTABLES == null)
            {
                return NotFound();
            }

            return Ok(rTABLES);
        }

        // PUT: api/RTABLES/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutRTABLES(int id, RTABLES rTABLES)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != rTABLES.TABLE_ID)
            {
                return BadRequest();
            }

            db.Entry(rTABLES).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RTABLESExists(id))
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

        // POST: api/RTABLES
        [ResponseType(typeof(RTABLES))]
        public IHttpActionResult PostRTABLES(RTABLES rTABLES)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.RTABLES.Add(rTABLES);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = rTABLES.TABLE_ID }, rTABLES);
        }

        // DELETE: api/RTABLES/5
        [ResponseType(typeof(RTABLES))]
        public IHttpActionResult DeleteRTABLES(int id)
        {
            RTABLES rTABLES = db.RTABLES.Find(id);
            if (rTABLES == null)
            {
                return NotFound();
            }

            db.RTABLES.Remove(rTABLES);
            db.SaveChanges();

            return Ok(rTABLES);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RTABLESExists(int id)
        {
            return db.RTABLES.Count(e => e.TABLE_ID == id) > 0;
        }
    }
}