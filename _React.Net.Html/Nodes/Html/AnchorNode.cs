using React.Net.Core;

namespace React.Net.Html.Nodes.Html;

public sealed class AnchorNode(
    IEnumerable<KeyValuePair<string, string>> attributes,
    IEnumerable<INode> children)
    : HtmlNode(HtmlTag.Anchor, attributes, children)
{
    public AnchorNode(params KeyValuePair<string, string>[] attributes) : this(attributes, []) { }

    public AnchorNode(IEnumerable<KeyValuePair<string, string>> attributes, params INode[] children)
        : this(attributes, children.AsEnumerable()) { }

}