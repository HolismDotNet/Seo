namespace Seo;

public class NodeBusiness : TreeBusiness<NodeView, Node>
{
    protected override Read<NodeView> Read => Repository.NodeView;

    protected override Write<Node> Write => Repository.Node;
}