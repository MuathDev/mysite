using System.Collections.Generic;

namespace Core.Entities
{
   public class PortfolioItem : EntityBase
    {
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public Images images { get; set; }
    }

}
