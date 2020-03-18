using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
namespace VezeetaAutomationClass
{
    public class SearchPage
    {
        public static void GoTo(string url)
        {

            Driver.Instance.Navigate().GoToUrl(Driver.BaseAddress+url);
            var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
            wait.Until(d => d.SwitchTo().ActiveElement().FindElement(By.Id("btnHomeSearch")));
        }
        public static SearchCommand WithSpeciality(string specialty)
        {
            return new SearchCommand(specialty);
        }
    }
    public class SearchCommand
    {
        private readonly string _specialty;
        private string _city;
        private string _area;
        public SearchCommand(string specialty)
        {
            _specialty = specialty;
        }
        public SearchCommand WithCity(string city)
        {
            this._city = city;
            return this;
        }
        public SearchCommand WithArea(string area)
        {
            this._area = area;
            return this;
        }
        public void Search()
        {
            SearchSelector.Select("ddlDoctorSpecialities", _specialty);
            SearchSelector.Select("ddlDoctorCity", _city);
            SearchSelector.SelectWithNavigation("ddlDoctorArea", _area);
            SearchSelector.Submit("btnHomeSearch");
        }
    }
}