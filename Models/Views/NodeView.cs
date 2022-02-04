namespace Seo;

public class NodeView : IEntity, IKey
{
    public NodeView()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public string Key { get; set; }

    public long? ParentId { get; set; }

    public long NodeTypeId { get; set; }

    public string Value { get; set; }

    public string NodeTypeKey { get; set; }

    public dynamic RelatedItems { get; set; }
}
