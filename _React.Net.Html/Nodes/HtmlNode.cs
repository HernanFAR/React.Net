using React.Net.Core;
using React.Net.Html.Nodes.Html;

namespace React.Net.Html.Nodes;

public class HtmlNode(
    HtmlTag tag,
    IEnumerable<KeyValuePair<string, string>> attributes,
    IEnumerable<INode> children)
    : INode
{
    public Guid Id { get; } = Guid.NewGuid();
    public HtmlTag Tag { get; } = tag;
    public IEnumerable<KeyValuePair<string, string>> Attributes { get; } = attributes;
    public IEnumerable<INode> Children { get; } = children;

}
