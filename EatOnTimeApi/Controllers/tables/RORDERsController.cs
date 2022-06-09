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
    public class RORDERsController : ApiController
    {
        private RDB5Entities db = new RDB5Entities();

        // GET: api/RORDERs
        public IQueryable<RORDER> GetRORDER()
        {
            return db.RORDER;
        }

        // GET: api/RORDERs/5
        [ResponseType(typeof(RORDER))]
        public IHttpActionResult GetRORDER(int id)
        {
            RORDER rORDER = db.RORDER.Find(id);
            if (rORDER == null)
            {
                return NotFound();
            }

            return Ok(rORDER);
        }

        // PUT: api/RORDERs/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutRORDER(int id, RORDER rORDER)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != rORDER.ORDER_ID)
            {
                return BadRequest();
            }

            db.Entry(rORDER).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RORDERExists(id))
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

        // POST: api/RORDERs
        [ResponseType(typeof(RORDER))]
        public IHttpActionResult PostRORDER(RORDER rORDER)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.RORDER.Add(rORDER);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (RORDERExists(rORDER.ORDER_ID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = rORDER.ORDER_ID }, rORDER);
        }

        // DELETE: api/RORDERs/5
        [ResponseType(typeof(RORDER))]
        public IHttpActionResult DeleteRORDER(int id)
        {
            RORDER rORDER = db.RORDER.Find(id);
            if (rORDER == null)
            {
                return NotFound();
            }

            db.RORDER.Remove(rORDER);
            db.SaveChanges();

            return Ok(rORDER);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RORDERExists(int id)
        {
            return db.RORDER.Count(e => e.ORDER_ID == id) > 0;
        }
    }
}