﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practice.Mvc5.Models;
namespace Practice.Mvc5.Controllers
{
    public class FormController : Controller
    {
        [HttpGet]
        public ActionResult Create()
        {
            var order = new FormModel.Order();
            order.Items.Add(new FormModel.OrderItem { Name = "test", Price = 20 });
            return View(order);
        }
        [HttpPost]
        public ActionResult Create(FormModel.Order order)
        {
            var dp= base.CreateTempDataProvider();
      
            
            return View(order);
        }

        [HttpGet]
        public ActionResult List()
        {
            var order = new FormModel.Order();
            order.Items.Add(new FormModel.OrderItem { Name = "test", Price = 20 });
            return View(order);
        }

        [HttpPost]
        public ActionResult List(FormModel.Order order)
        {
            return View(order);
        }

        
    }
}