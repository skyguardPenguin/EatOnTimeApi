using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using EatOnTimeApi;

namespace EatOnTimeApi.Controllers.tables
{
    public class PRODUCT_DETAILController : ApiController
    {
        private RDB5Entities db = new RDB5Entities();

        // GET: api/PRODUCT_DETAIL
        public IQueryable<PRODUCT_DETAIL> GetPRODUCT_DETAIL()
        {
            return db.PRODUCT_DETAIL;
        }

        // GET: api/PRODUCT_DETAIL/5
        [ResponseType(typeof(PRODUCT_DETAIL))]
        public IHttpActionResult GetPRODUCT_DETAIL(string id)
        {
            PRODUCT_DETAIL pRODUCT_DETAIL = db.PRODUCT_DETAIL.Find(id);
            if (pRODUCT_DETAIL == null)
            {
                return NotFound();
            }

            return Ok(pRODUCT_DETAIL);
        }

        // PUT: api/PRODUCT_DETAIL/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPRODUCT_DETAIL(string id, PRODUCT_DETAIL pRODUCT_DETAIL)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pRODUCT_DETAIL.PRODUCT_CODE)
            {
                return BadRequest();
            }

            db.Entry(pRODUCT_DETAIL).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PRODUCT_DETAILExists(id))
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

        // POST: api/PRODUCT_DETAIL
        [ResponseType(typeof(PRODUCT_DETAIL))]
        public IHttpActionResult PostPRODUCT_DETAIL(PRODUCT_DETAIL pRODUCT_DETAIL)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PRODUCT_DETAIL.Add(pRODUCT_DETAIL);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (PRODUCT_DETAILExists(pRODUCT_DETAIL.PRODUCT_CODE))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = pRODUCT_DETAIL.PRODUCT_CODE }, pRODUCT_DETAIL);
        }

        // DELETE: api/PRODUCT_DETAIL/5
        [ResponseType(typeof(PRODUCT_DETAIL))]
        public IHttpActionResult DeletePRODUCT_DETAIL(string id)
        {
            PRODUCT_DETAIL pRODUCT_DETAIL = db.PRODUCT_DETAIL.Find(id);
            if (pRODUCT_DETAIL == null)
            {
                return NotFound();
            }

            db.PRODUCT_DETAIL.Remove(pRODUCT_DETAIL);
            db.SaveChanges();

            return Ok(pRODUCT_DETAIL);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PRODUCT_DETAILExists(string id)
        {
            return db.PRODUCT_DETAIL.Count(e => e.PRODUCT_CODE == id) > 0;
        }
    }
}