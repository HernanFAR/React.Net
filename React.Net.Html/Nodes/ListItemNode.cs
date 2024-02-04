using React.Net.Core;
using React.Net.Html.Abstracts;

namespace React.Net.Html.Nodes;

public sealed class ListItemNode(
    IEnumerable<KeyValuePair<string, string>> attributes,
    IEnumerable<OneOrManyNode> children)
    : HtmlNode(HtmlTag.ListItem, attributes, children);
