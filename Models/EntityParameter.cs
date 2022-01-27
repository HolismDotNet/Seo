namespace Seo;

public class EntityParameter : IEntity
{
    public EntityParameter()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public Guid EntityTypeGuid { get; set; }

    public Guid EntityGuid { get; set; }

    public long ParametersObjectId { get; set; }

    public dynamic RelatedItems { get; set; }
}
