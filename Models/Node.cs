namespace Seo;

public class Node : IEntity, IKey
{
    public Node()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public string Key { get; set; }

    public long ParentId { get; set; }

    public long NodeTypeId { get; set; }

    public dynamic RelatedItems { get; set; }
}
