﻿using PuzzleShop.v._2._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PuzzleShop.v._2._0.Controllers
{
    public class LoginApiController : ApiController
    {
        private PuzzleShopEntities db = new PuzzleShopEntities();

        [HttpGet]
        public IHttpActionResult GetTest(object user)
        {
            return Ok();
        }
        [HttpPost]
        public IHttpActionResult PostRegistration(Login data, object role)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}
            //Login user = new Login();
            
            //db.Login.Add(data);
            //db.SaveChanges();
            
            return Ok();
        }

        //    [HttpPost]
        //    public IHttpActionResult PostLogin(object user)
        //    {
        //        db.Configuration.ProxyCreationEnabled = false;
        //        //int subId = 0;

        //        List<ItemsTable> subItems = new List<ItemsTable>();
        //        //    //subId = subName.Id;
        //        //foreach (var item2 in db.ItemsTables)
        //        //{
        //        //    if (item2.SubcategoryId == subId)
        //        //    {
        //        //        subItems.Add(item2);
        //        //    }
        //        //}
        //        return Ok(subItems);
        //    }
        //}
    }
}

