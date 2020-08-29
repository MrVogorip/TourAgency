using System.Web;
using System.Web.Mvc;
using Microsoft.Owin.Security;
using Microsoft.AspNet.Identity.Owin;
using System.Threading.Tasks;
using TourAgency.Web.Models;
using TourAgency.Bll.DTO;
using TourAgency.Bll.Services.Interfaces;
using Microsoft.AspNet.Identity;
using System;

namespace UserStore.Controllers
{
    public class AccountController : Controller
    {
        private IUserService UserService => HttpContext.GetOwinContext().GetUserManager<IUserService>();
        private IAuthenticationManager AuthenticationManager => HttpContext.GetOwinContext().Authentication;

        private readonly ICustomerService _customerService;
        private readonly IManagerService _managerService;
        public AccountController(ICustomerService customer, IManagerService manager)
        {
            _customerService = customer;
            _managerService = manager;
        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var claim = await UserService.Authenticate(model.Email, model.Password);
                if (claim == null)
                {
                    ModelState.AddModelError("", "Wrong login or password.");
                }
                else
                {
                    AuthenticationManager.SignOut();
                    AuthenticationManager.SignIn(new AuthenticationProperties
                    {
                        IsPersistent = true
                    }, claim);
                    return RedirectToAction("Index", "Home");
                }
            }
            return View(model);
        }


        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                var userDto = new ApplicationUserDTO
                {
                    Id = Guid.NewGuid().ToString(),
                    Email = model.Email,
                    UserName = model.Email,
                    PasswordHash = new PasswordHasher().HashPassword(model.Password),
                    SecurityStamp = Guid.NewGuid().ToString("D")
                };
                var customerDto = new CustomerDTO()
                {
                    UserId = userDto.Id,
                    User = userDto,
                    Discount = 0,
                    MaxDiscount = 15,
                    StepDiscount = 2,
                    IsBlock = false,
                    Name = model.Name,
                    Surname = model.Surname,
                };
                _customerService.Register(customerDto);
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }

        [HttpGet]
        [Authorize(Roles = "admin")]
        public ActionResult CreateNewManager()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        [ValidateAntiForgeryToken]
        public ActionResult CreateNewManager(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                var userDto = new ApplicationUserDTO
                {
                    Id = Guid.NewGuid().ToString(),
                    Email = model.Email,
                    UserName = model.Email,
                    PasswordHash = new PasswordHasher().HashPassword(model.Password),
                    SecurityStamp = Guid.NewGuid().ToString("D")
                };
                var managerDTO = new ManagerDTO()
                {
                    UserId = userDto.Id,
                    User = userDto,
                    Name = model.Name,
                    Surname = model.Surname,
                    IsBlock = false,
                };
                _managerService.Register(managerDTO);
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            AuthenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
            return RedirectToAction("Index", "Home");
        }
    }
}