namespace Seo;

public class EntityTypeParameter : IEntity
{
    public EntityTypeParameter()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public Guid EntityTypeGuid { get; set; }

    public long ParametersObjectId { get; set; }

    public dynamic RelatedItems { get; set; }
}
