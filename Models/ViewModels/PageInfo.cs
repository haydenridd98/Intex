using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intex.Models.ViewModels
{
    public class PageInfo
    {
        public int TotalNumCrashes {get; set;}
        public int CrashesPerPage { get; set; }
        public int CurrentPage { get; set; }

        // calculate num pages
        public int TotalPages => (int) Math.Ceiling((double) TotalNumCrashes / CrashesPerPage);
    }
}
