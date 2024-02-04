using React.Net.Core;
using React.Net.Html.Abstracts;

namespace React.Net.Html.Nodes;

public sealed class UnorderedListNode(
    IEnumerable<KeyValuePair<string, string>> attributes,
    IEnumerable<OneOrManyNode> children)
    : HtmlNode(HtmlTag.UnorderedList, attributes, children)
{
    public UnorderedListNode(IEnumerable<KeyValuePair<string, string>> attributes, params OneOrManyNode[] children)
        : this(attributes, children.AsEnumerable()) { }
}
