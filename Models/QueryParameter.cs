namespace Seo;

public class QueryParameter : IEntity
{
    public QueryParameter()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public string SortedParameters { get; set; }

    public long ParametersObjectId { get; set; }

    public dynamic RelatedItems { get; set; }
}
