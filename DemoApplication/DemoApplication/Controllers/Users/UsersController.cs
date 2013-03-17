﻿namespace DemoApplication.Controllers.Users
{
    #region

    using System.Web.Mvc;
    using Core.Interfaces.Service;

    #endregion

    public partial class UsersController : Controller
    {
        protected readonly IUserService UserService;

        public UsersController(IUserService userService)
        {
            UserService = userService;
        }

        public ActionResult Index()
        {
            return View();
        }

    }
}
