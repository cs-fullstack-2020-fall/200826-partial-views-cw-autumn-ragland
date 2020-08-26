using Microsoft.AspNetCore.Mvc;
using Classwork.ViewModels;
using Classwork.Models;
using System.Linq;
using System.Collections.Generic;

namespace Classwork.Controllers
{
    public class StreamingPlatforms : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PlatformAndMedia platformList = new PlatformAndMedia();
        public IActionResult ViewAll()
        {
            return View(platformList);
        }
        public IActionResult ViewOne(string platformName)
        {
            Platform matchingPlatform = platformList.platformList.FirstOrDefault(platform => platform.name == platformName);

            return View(matchingPlatform);
        }
        public IActionResult ViewPopular()
        {
            return View(platformList);
        }
        public IActionResult ViewUnpopular()
        {
            return View(platformList);
        }
    }
}