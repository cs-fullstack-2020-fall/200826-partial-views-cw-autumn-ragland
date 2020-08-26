using Microsoft.AspNetCore.Mvc;
using Classwork.ViewModels;
using Classwork.Models;
using System.Linq;

namespace Classwork.Controllers
{
    public class StreamingPlatforms : Controller
    {
        // get method to display landing page for controller
        public IActionResult Index()
        {
            return View(); // return default view
        }
        // define PlatformAndMedia object: instanciated with property platfromList populated with three platforms
        public PlatformAndMedia platformList = new PlatformAndMedia();
        // get method to display associated view passing PlatformAndMedia object
        public IActionResult ViewAll()
        {
            return View(platformList); // pass PlatformAndMedia object to default view
        }
        // get method that accepts one query param to display associated view passing matching Platform object based on query param
        public IActionResult ViewOne(string platformName)
        {
            // LINQ method to return Platform object with matching name property 
            Platform matchingPlatform = platformList.platformList.FirstOrDefault(platform => platform.name == platformName);
            // if matching platform is found
            if(matchingPlatform != null)
            {
                return View(matchingPlatform);  // return default view with
            }
            // if matching platform not found
            else 
            {
                return View("NotFound"); // return view called "NotFound"
            }
        }
        // get method to display associated view passing PlatformAndMedia object 
        public IActionResult ViewPopular()
        {
            return View(platformList); // pass PlatformAndMedia object to default view
        }
        // get method to display associated view passing PlatformAndMedia object 
        public IActionResult ViewUnpopular()
        {
            return View(platformList); // pass PlatformAndMedia object to default view
        }
    }
}