using Core.Entities;
using System.Collections.Generic;

namespace WebUI.ViewModels
{
    public class HomeViewModel
    {
        public Owner Owner { get; set; }

        public List<PortfolioItem> PortfolioItems { get; set; }

        public List<FrontEndSkills> FrontSkills { get; set; }
        public List<BackEndSkills> BackSkills { get; set; }
    }
}
