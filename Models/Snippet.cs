namespace Seo;

public class Snippet : IEntity, IKey
{
    public Snippet()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public string Key { get; set; }

    public string Title { get; set; }

    public dynamic RelatedItems { get; set; }
}
