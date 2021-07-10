using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearningCoding.Data.Wrapper;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LearningCoding.Controllers
{
    public class HomeController : Controller
    {
        IRepositoryWrapper _repositoryWrapper;

        public HomeController(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }
        public IActionResult Index(string category = "All")
        {
            if (category == "All")
                return View(_repositoryWrapper._repositoryProgramming.FindAll());
            else if (category == "Low-level")
                return View(_repositoryWrapper._repositoryProgramming.
                    FindByCondition(e => e.ProgrammingLanguageCategory == category));
            else
                return View(_repositoryWrapper._repositoryProgramming.
                    FindByCondition(e => e.ProgrammingLanguageCategory == category));
        }

        public IActionResult LanguageInfo(int Id)
        {
            return View(_repositoryWrapper._repositoryProgramming.GetLanguagesWithProsAndCons(Id));
        }
    }
}
