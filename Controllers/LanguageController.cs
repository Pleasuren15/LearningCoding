using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearningCoding.Data.Wrapper;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LearningCoding.Controllers
{
    public class LanguageController : Controller
    {
        IRepositoryWrapper _repositoryWrapper;

        public LanguageController(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public IActionResult Index(int Id)
        {
            return View(_repositoryWrapper._repositoryProgramming.GetLanguagesWithProsAndCons(Id));
        }
    }
}
