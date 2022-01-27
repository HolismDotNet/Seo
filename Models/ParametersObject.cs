namespace Seo;

public class ParametersObject : IEntity
{
    public ParametersObject()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public string PageTitle { get; set; }

    public string MetaTitle { get; set; }

    public string MetaDescription { get; set; }

    public string Keywords { get; set; }

    public string PageDescription { get; set; }

    public string ExtraData { get; set; }

    public dynamic RelatedItems { get; set; }
}
