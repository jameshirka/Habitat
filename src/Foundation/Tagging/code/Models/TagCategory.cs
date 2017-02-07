using System.Collections.Generic;

namespace Sitecore.Foundation.Tagging.Models
{
    public class TagCategory
    {
        public IList<TagCategory> Categories { get; set; }
        public IList<TagEntry> Tags { get; set; }
    }
}
