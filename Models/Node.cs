namespace Seo;

public class Node : IEntity, IKey, IParent
{
    public Node()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public string Key { get; set; }

    public long? ParentId { get; set; }

    public long NodeTypeId { get; set; }

    public string Value { get; set; }

    public dynamic RelatedItems { get; set; }
}
