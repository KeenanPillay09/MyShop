
using MyShop.Core.Contracts;
using MyShop.Core.Models;
using MyShop.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyShop.WebUI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class OrderManagerController : Controller
    {
        IOrderService orderService;

        IRepository<Driver> drivers;
        
        

        public OrderManagerController(IOrderService OrderService, IRepository<Driver> driversContext)
        {
            this.orderService = OrderService;
            drivers = driversContext;
        }
        // GET: OrderManager
        public ActionResult Index()
        {
            List<Order> orders = orderService.GetOrderList();

            return View(orders);
        }

        public ActionResult UpdateOrder(string Id)
        {
            ViewBag.StatusList = new List<string>() {
                "Order Created",
                "Payment Processed",
                "Order Shipped",
                "Order Complete"
            };

            //ViewBag.Driver = new List<string>() {
            //    "Driver A",
            //    "Driver B",
            //    "Driver C",
            //    "Driver D"
            //};
           
            Order order = orderService.GetOrder(Id);
            order.Drivers = drivers.Collection();
           // order.Driver = 
            return View(order);
        }

        [HttpPost]
        public ActionResult UpdateOrder(Order updatedOrder, string Id)
        {
            Order order = orderService.GetOrder(Id);

            order.OrderStatus = updatedOrder.OrderStatus;
            order.Driver = updatedOrder.Driver;
            orderService.UpdateOrder(order);

            return RedirectToAction("Index");
        }
    }
}