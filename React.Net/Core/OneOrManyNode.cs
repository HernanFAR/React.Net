using System.Diagnostics.CodeAnalysis;

namespace React.Net.Core;

public class OneOrManyNode
{
    public Node[]? Nodes { get; set; }
    public Node? Node { get; set; }

    public OneOrManyNode(Node node)
    {
        Node = node;
    }

    public OneOrManyNode(Node[] nodes)
    {
        Nodes = nodes;
    }

    [MemberNotNullWhen(true, nameof(Node))]
    [MemberNotNullWhen(false, nameof(Nodes))]
    public bool JustOne => Nodes == null;

    public static implicit operator OneOrManyNode(Node node) => new(node);
    public static implicit operator OneOrManyNode(Node[] nodes) => new(nodes);
}