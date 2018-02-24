using IcoShare.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IcoShare.WebApp.Controllers
{
    public class IcoShareController : Controller
    {
        static List<IcoShareViewModel> sampleData;

        static IcoShareController()
        {
            sampleData = new List<IcoShareViewModel>() {
                new IcoShareViewModel(){
                    TokenScriptName = "RPX",
                    TokenScriptHash = "TODO",
                    TokenScriptWebsite = "TODO",
                    StartTime = DateTime.Now,
                    EndTime = DateTime.Now.AddDays(1),
                    ContributionBundle = 10,
                    MinContribution = 1,
                    MaxContribution = 2,
                    CurrentContribution = 0,
                    IcoShareId = Guid.NewGuid().ToString(),
                    Status = IcoShareStatus.ACTIVE
                },
                new IcoShareViewModel(){
                    TokenScriptName = "SPN",
                    TokenScriptHash = "TODO",
                    TokenScriptWebsite = "TODO",
                    StartTime = DateTime.Now,
                    EndTime = DateTime.Now.AddDays(1),
                    ContributionBundle = 100,
                    MinContribution = 1,
                    MaxContribution = 10,
                    CurrentContribution = 0,
                    IcoShareId = Guid.NewGuid().ToString(),
                    Status = IcoShareStatus.ACTIVE
                }
            };
        }

        [HttpGet]
        public ActionResult CreateNewIcoShare()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateNewIcoShare(IcoShareViewModel icoShare)
        {
            throw new NotImplementedException();
        }

        public ActionResult IcoShareList()
        {
            return View(sampleData);
        }
    }
}