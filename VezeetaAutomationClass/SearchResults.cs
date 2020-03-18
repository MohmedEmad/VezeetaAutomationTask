using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace VezeetaAutomationClass
{
    public class SearchResults
    {
        public static bool IsAt(string header)
        {
            var h1 = Driver.Instance.FindElements(By.Id("vms1-lh"));
            if (h1.Count > 0)
                return h1[0].Text == header;
            return false;
        }
    }

}
