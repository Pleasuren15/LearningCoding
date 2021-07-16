using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearningCoding.Data.Wrapper;
using LearningCoding.Models;
using LearningCoding.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LearningCoding.Controllers
{
    public class AccountController : Controller
    {
        IRepositoryWrapper _repositoryWrapper { get; }
        UserManager<IdentityUser> _userManager { get; }
        SignInManager<IdentityUser> _signInManager { get; }
        const int ITEMS_PER_PAGE = 5;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, IRepositoryWrapper repositoryWrapper)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _repositoryWrapper = repositoryWrapper;
        }

        // GET: /<controller>/
        [HttpGet]
        public async Task<IActionResult> Index(int currentPage = 1)
        {
            await Logout();
            return View(new AdminViewModel()
            {
                _books = _repositoryWrapper._repositoryBook.FindAll(),
                _programmingLanguages = _repositoryWrapper._repositoryProgramming.FindAll(),
                _users = _userManager.Users,
                _pagingInfoModel = new PagingInfo()
                {
                    CurrentPage = currentPage,
                    ItemsPerPage = ITEMS_PER_PAGE,
                    TotalItems = _repositoryWrapper._repositoryFeedback.FindAll().Count()
                },
                _feedbacks = _repositoryWrapper._repositoryFeedback.FindAll().
                            Skip(ITEMS_PER_PAGE * (currentPage - 1)).Take(ITEMS_PER_PAGE)
            });
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel loginModel)
        {
            if (ModelState.IsValid)
            {
                IdentityUser user = await _userManager.FindByEmailAsync(loginModel.Email);
                if (user != null)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, loginModel.Password, false, false);
                    if (result.Succeeded)
                        return RedirectToAction("Index", "Account");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid email or password");
                }
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Account");
        }
    }
}
