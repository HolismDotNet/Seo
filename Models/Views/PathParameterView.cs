namespace Seo;

public class PathParameterView : IEntity
{
    public PathParameterView()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public string Path { get; set; }

    public string PageTitle { get; set; }

    public string MetaTitle { get; set; }

    public string MetaDescription { get; set; }

    public string Keywords { get; set; }

    public string PageDescription { get; set; }

    public dynamic RelatedItems { get; set; }
}
