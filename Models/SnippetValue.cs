namespace Seo;

public class SnippetValue : IEntity
{
    public SnippetValue()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public dynamic RelatedItems { get; set; }
}
