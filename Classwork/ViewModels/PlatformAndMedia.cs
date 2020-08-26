using System.Collections.Generic;
using Classwork.Models;
namespace Classwork.ViewModels
{
    public class PlatformAndMedia
    {
        public List<Platform> platformList = new List<Platform>();
        public PlatformAndMedia()
        {
            platformList.Add(
                new Platform("Netflix", new List<Media>(){
                    new Media("Media One", "This is Media One"),
                    new Media("Media Two", "This is Media Two"),
                    })
                );
            platformList.Add(
                new Platform("Hulu", new List<Media>(){
                    new Media("Media One", "This is Media One"),
                    })
                );
            platformList.Add(
            new Platform("Disney +", new List<Media>(){
                new Media("Media One", "This is Media One"),
                new Media("Media Two", "This is Media Two"),
                new Media("Media Three", "This is Media Three"),
                })
            );
        }
    }
}