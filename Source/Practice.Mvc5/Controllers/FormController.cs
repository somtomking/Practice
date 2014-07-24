using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practice.Mvc5.Models;
using FluentValidation.Results;
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

            var success = ModelState.IsValid;
            FormModel.OrderValidator v = new FormModel.OrderValidator();
            var results = v.Validate(order);
            bool validationSucceeded = results.IsValid;
            IList<ValidationFailure> failures = results.Errors;

            return View(order);
        }


        [HttpGet]
        public ActionResult Create2()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create2(List<string> names)
        {



            return View();
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