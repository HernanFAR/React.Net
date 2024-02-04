using React.Net.Core;

namespace React.Net.Html.Nodes.Html;

public sealed class ParagraphNode(
    IEnumerable<KeyValuePair<string, string>> attributes,
    IEnumerable<INode> children)
    : HtmlNode(HtmlTag.Paragraph, attributes, children)
{
    public ParagraphNode(params INode[] children) : this([], children) { }

}
