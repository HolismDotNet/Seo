namespace Seo;

public class EntityParameterView : IEntity
{
    public EntityParameterView()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public Guid EntityTypeGuid { get; set; }

    public Guid EntityGuid { get; set; }

    public string PageTitle { get; set; }

    public string MetaTitle { get; set; }

    public string MetaDescription { get; set; }

    public string Keywords { get; set; }

    public string PageDescription { get; set; }

    public dynamic RelatedItems { get; set; }
}
