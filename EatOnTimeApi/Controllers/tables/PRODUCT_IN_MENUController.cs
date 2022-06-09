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
    public class PRODUCT_IN_MENUController : ApiController
    {
        private RDB5Entities db = new RDB5Entities();

        // GET: api/PRODUCT_IN_MENU
        public IQueryable<PRODUCT_IN_MENU> GetPRODUCT_IN_MENU()
        {
            return db.PRODUCT_IN_MENU;
        }

        // GET: api/PRODUCT_IN_MENU/5
        [ResponseType(typeof(PRODUCT_IN_MENU))]
        public IHttpActionResult GetPRODUCT_IN_MENU(string id)
        {
            PRODUCT_IN_MENU pRODUCT_IN_MENU = db.PRODUCT_IN_MENU.Find(id);
            if (pRODUCT_IN_MENU == null)
            {
                return NotFound();
            }

            return Ok(pRODUCT_IN_MENU);
        }

        // PUT: api/PRODUCT_IN_MENU/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPRODUCT_IN_MENU(string id, PRODUCT_IN_MENU pRODUCT_IN_MENU)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pRODUCT_IN_MENU.PRODUCT_CODE)
            {
                return BadRequest();
            }

            db.Entry(pRODUCT_IN_MENU).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PRODUCT_IN_MENUExists(id))
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

        // POST: api/PRODUCT_IN_MENU
        [ResponseType(typeof(PRODUCT_IN_MENU))]
        public IHttpActionResult PostPRODUCT_IN_MENU(PRODUCT_IN_MENU pRODUCT_IN_MENU)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PRODUCT_IN_MENU.Add(pRODUCT_IN_MENU);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (PRODUCT_IN_MENUExists(pRODUCT_IN_MENU.PRODUCT_CODE))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = pRODUCT_IN_MENU.PRODUCT_CODE }, pRODUCT_IN_MENU);
        }

        // DELETE: api/PRODUCT_IN_MENU/5
        [ResponseType(typeof(PRODUCT_IN_MENU))]
        public IHttpActionResult DeletePRODUCT_IN_MENU(string id)
        {
            PRODUCT_IN_MENU pRODUCT_IN_MENU = db.PRODUCT_IN_MENU.Find(id);
            if (pRODUCT_IN_MENU == null)
            {
                return NotFound();
            }

            db.PRODUCT_IN_MENU.Remove(pRODUCT_IN_MENU);
            db.SaveChanges();

            return Ok(pRODUCT_IN_MENU);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PRODUCT_IN_MENUExists(string id)
        {
            return db.PRODUCT_IN_MENU.Count(e => e.PRODUCT_CODE == id) > 0;
        }
    }
}