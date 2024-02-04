using React.Net.Core;

namespace React.Net.Html.Nodes.Html;

public sealed class DivNode(
    IEnumerable<KeyValuePair<string, string>> attributes,
    IEnumerable<INode> children)
    : HtmlNode(HtmlTag.Div, attributes, children)
{
    public DivNode(params KeyValuePair<string, string>[] attributes) : this(attributes, []) { }

    public DivNode(IEnumerable<KeyValuePair<string, string>> attributes, params INode[] children)
        : this(attributes, children.AsEnumerable()) { }

}
