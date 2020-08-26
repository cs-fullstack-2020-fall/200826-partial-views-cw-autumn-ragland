using System.Collections.Generic;
namespace Classwork.Models
{
    // provided model
    public class Platform
    {
        public string name;
        public List<Media> availableMedia = new List<Media>();
        public Platform(string name, List<Media> availableMedia)
        {
            this.name = name;
            this.availableMedia = availableMedia;
        }
    }
}