using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VezeetaAutomationClass;
namespace VezeetaTests
{
    [TestClass]
    public class SearchTest1
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }


        [TestMethod]
        public void TestEnglish()
        {
            SearchPage.GoTo("/en/");
            SearchPage.WithSpeciality("Dermatology (Skin)")
                .WithCity("Cairo")
                .WithArea("Shoubra El-Kheima")
                .Search();
            Assert.IsTrue(SearchResults.IsAt("Find the best Dermatologist in Shoubra El-Kheima"), "Failed to Apply Search");
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Driver.Close();
        }

        [TestMethod]
        public void TestArabic()
        {
            SearchPage.GoTo("/ar/");
            SearchPage.WithSpeciality("جلدية")
                .WithCity("القاهرة")
                .WithArea("شبرا الخيمة")
                .Search();
            Assert.IsTrue(SearchResults.IsAt("افضل دكتور جلدية في شبرا الخيمة"), "Failed to Apply Search");
        }

    }
}