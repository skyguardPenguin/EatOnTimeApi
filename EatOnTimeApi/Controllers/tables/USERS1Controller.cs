﻿using System;
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
    public class USERS1Controller : ApiController
    {
        private RDB5Entities db = new RDB5Entities();

        // GET: api/USERS1
        public IQueryable<USERS> GetUSERS()
        {
            return db.USERS;
        }

        // GET: api/USERS1/5
        [ResponseType(typeof(USERS))]
        public IHttpActionResult GetUSERS(int id)
        {
            USERS uSERS = db.USERS.Find(id);
            if (uSERS == null)
            {
                return NotFound();
            }

            return Ok(uSERS);
        }

        // PUT: api/USERS1/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutUSERS(int id, USERS uSERS)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != uSERS.R_USER_ID)
            {
                return BadRequest();
            }

            db.Entry(uSERS).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!USERSExists(id))
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

        // POST: api/USERS1
        [ResponseType(typeof(USERS))]
        public IHttpActionResult PostUSERS(USERS uSERS)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.USERS.Add(uSERS);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = uSERS.R_USER_ID }, uSERS);
        }

        // DELETE: api/USERS1/5
        [ResponseType(typeof(USERS))]
        public IHttpActionResult DeleteUSERS(int id)
        {
            USERS uSERS = db.USERS.Find(id);
            if (uSERS == null)
            {
                return NotFound();
            }

            db.USERS.Remove(uSERS);
            db.SaveChanges();

            return Ok(uSERS);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool USERSExists(int id)
        {
            return db.USERS.Count(e => e.R_USER_ID == id) > 0;
        }
    }
}