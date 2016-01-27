using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataBindingHomeWork.Models
{
    public class Extra
    {
        public string Name { get; set; }

        public static List<Extra> InitializeExtras(params string[] extrasList)
        {
            List<Extra> extras = new List<Extra>();
            foreach (var extra in extrasList)
            {
                Extra ext = new Extra();
                ext.Name = extra;
                extras.Add(ext);
            }
            return extras;
        }
    }
}