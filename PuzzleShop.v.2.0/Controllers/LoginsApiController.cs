﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using PuzzleShop.v._2._0.Models;

namespace PuzzleShop.v._2._0.Controllers
{
    public class LoginsApiController : ApiController
    {
        private PuzzleShopEntities db = new PuzzleShopEntities();

        // GET: api/LoginsApi
        [HttpGet]
        public IQueryable<Login> users()
        {
            return db.Login;
        }

        // GET: api/LoginsApi/5
        [ResponseType(typeof(Login))]
        public IHttpActionResult GetLogin(int id)
        {
            Login login = db.Login.Find(id);
            if (login == null)
            {
                return NotFound();
            }

            return Ok(login);
        }

        // PUT: api/LoginsApi/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutLogin(int id, Login login)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != login.Id)
            {
                return BadRequest();
            }

            db.Entry(login).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LoginExists(id))
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

        // POST: api/LoginsApi
        [ResponseType(typeof(Login))]
        public IHttpActionResult PostLogin(Login login)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Login.Add(login);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = login.Id }, login);
        }

        // DELETE: api/LoginsApi/5
        [ResponseType(typeof(Login))]
        public IHttpActionResult DeleteLogin(int id)
        {
            Login login = db.Login.Find(id);
            if (login == null)
            {
                return NotFound();
            }

            db.Login.Remove(login);
            db.SaveChanges();

            return Ok(login);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LoginExists(int id)
        {
            return db.Login.Count(e => e.Id == id) > 0;
        }
    }
}