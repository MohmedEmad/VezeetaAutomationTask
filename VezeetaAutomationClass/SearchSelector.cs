using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace VezeetaAutomationClass
{
   public class SearchSelector
    {
        public static void Select(string topLevelMenuId, string subMenuLinkText)
        {
            Driver.Instance.FindElement(By.ClassName(topLevelMenuId)).Click();
            Driver.Instance.FindElement(By.LinkText(subMenuLinkText)).Click();
        }

        public static void SelectWithNavigation(string topLevelMenuId, string subMenuLinkText)
        {
            Driver.Instance.FindElement(By.ClassName(topLevelMenuId)).Click();
            Driver.Instance.FindElement(By.Id("nextAreaBtn")).Click();
            Driver.Instance.FindElement(By.LinkText(subMenuLinkText)).Click();
        }
        public static void Submit(string searchSubmit)
        {
            Driver.Instance.FindElement(By.Id(searchSubmit)).Click();
        }


    }
}
