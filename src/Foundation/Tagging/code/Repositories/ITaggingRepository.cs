using Sitecore.Foundation.Tagging.Models;

namespace Sitecore.Foundation.Tagging.Repositories
{

    public interface ITaggingRepository
    {
        TagCategory GetTagHierarchy();
    }
}
