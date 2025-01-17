﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;
using MWG_Ecommerce.Data;
using MWG_Ecommerce.Service;
using MWG_Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MWG_Ecommerce.Helpers;
using MWG_Ecommerce.Libraries;

namespace MWG_Ecommerce.Controllers
{
    public class AuthController : Controller
    {
        private readonly ILogger<AuthController> _logger;
        private readonly ShoppingonlineContext _context;
        private readonly LoginHistoryService loginHistoryService;
        private readonly AccountService accountService;
        LoginHistory loginHistory = new LoginHistory();        

        public AuthController(ILogger<AuthController> logger, ShoppingonlineContext context)
        {
            _logger = logger;
            _context = context;
            accountService = new AccountService(context);
            loginHistoryService = new LoginHistoryService(context);
        }

        public ActionResult Login()
        {
            return View("Views/Login/LoginPage.cshtml");
        }

        // POST: login with username vs password
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(string username, string pass)
        {            
            DateTime datetime = DateTime.Now;
            var user = _context.Users.Where(u => u.Username == username).FirstOrDefault();
            var getuser = accountService.FindUserByUserName(username);
            if(getuser != null)
            {
                var decryptPass = new HashPassword().DecryptString(getuser.Passwword);
                if(decryptPass == pass)
                {
                    // Success
                    return Ok("Success");
                }
            }

            if (user != null)
            {
                bool checkAdmin = user.Role;
                HttpContext.Session.SetString("username", user.Username);
                //HttpContext.Session.SetString("name", user.Name);
                //HttpContext.Session.SetString("email", user.Email);
                //HttpContext.Session.SetString("address", user.Address);
                //HttpContext.Session.SetString("phone", user.Phone);
                if (checkAdmin == false)
                {
                    HttpContext.Session.SetString("role", "ROLE_USER");
                    //HttpContext.Session.Set("user", user);
                    HttpContext.Session.SetInt32("id", user.UserId);
                    int idSession = (int)HttpContext.Session.GetInt32("id");
                    var status = _context.Users.Find(idSession);
                    var savehistorylogin = new LoginHistory();
                    savehistorylogin.UserId = idSession;
                    savehistorylogin.Time = datetime;
                    status.Status = "Online";
                    _context.LoginHistories.Add(savehistorylogin);
                    _context.SaveChanges();
                    return Redirect(Url.Action("Index", "Home"));
                }
                else
                {
                    HttpContext.Session.SetString("role", "ROLE_ADMIN");
                    HttpContext.Session.SetInt32("id", user.UserId);
                    int idSession = (int)HttpContext.Session.GetInt32("id");
                    var status = _context.Users.Find(idSession);
                    var savehistorylogin = new LoginHistory();
                    savehistorylogin.UserId = idSession;
                    savehistorylogin.Time = datetime;
                    status.Status = "Online";
                    _context.LoginHistories.Add(savehistorylogin);
                    _context.SaveChanges();
                    return Redirect(Url.Action("Index", "ProductManager"));
                }             
                
            }
            else
            {
                TempData["ThongBao"] = "Tài khoản hoặc mật khẩu không hợp lệ";
                return RedirectToAction(nameof(Login));
            }

        }

        // Logout
        public ActionResult Logout()
        {           
            int idSession = (int)HttpContext.Session.GetInt32("id");
            var status = _context.Users.Find(idSession);
            status.Status = "Offline";
            _context.SaveChanges();
            HttpContext.Session.Clear();

            return RedirectToAction(nameof(Login));
        }
    }
}
