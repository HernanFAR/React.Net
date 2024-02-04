using React.Net.Core;
using React.Net.Html.Abstracts;

namespace React.Net.Html.Nodes;

public sealed class ParagraphNode(
    IEnumerable<KeyValuePair<string, string>> attributes,
    IEnumerable<OneOrManyNode> children)
    : HtmlNode(HtmlTag.Paragraph, attributes, children)
{
    public ParagraphNode(IEnumerable<KeyValuePair<string, string>> attributes, params OneOrManyNode[] children)
        : this(attributes, children.AsEnumerable()) { }
}
