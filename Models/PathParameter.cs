namespace Seo;

public class PathParameter : IEntity
{
    public PathParameter()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public string Path { get; set; }

    public long ParametersObjectId { get; set; }

    public dynamic RelatedItems { get; set; }
}
