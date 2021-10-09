using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.ViewModels;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        IUnitOfWork<Owner> _owner;
        IUnitOfWork<PortfolioItem> _portfolio;
        IUnitOfWork<FrontEndSkills> _frontskills;
        IUnitOfWork<BackEndSkills> _backskills;
        IUnitOfWork<Images> _Image;
        public HomeController(
            IUnitOfWork<Owner> owner,
            IUnitOfWork<PortfolioItem> portfolio,
            IUnitOfWork<FrontEndSkills> frontskills,
            IUnitOfWork<BackEndSkills> backskills,
            IUnitOfWork<Images> Image)
        {
            _owner = owner;
            _portfolio = portfolio;
            _frontskills = frontskills;
            _backskills = backskills;
            _Image = Image;
        }
        public IActionResult Index()
        {
            var home = new HomeViewModel
            {
                Owner = _owner.Entity.GetAll(new[]{ "images" }).FirstOrDefault(),
                PortfolioItems = _portfolio.Entity.GetAll(new[] { "images" }).ToList(),
                FrontSkills = _frontskills.Entity.GetAll(new[] { "images" }).ToList(),
                BackSkills = _backskills.Entity.GetAll(new[] { "images" }).ToList()
            };
            return View(home);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
