using React.Net.Core;
using React.Net.Html.Abstracts;

namespace React.Net.Html.Nodes;

public sealed class EmptyNode(
    IEnumerable<OneOrManyNode> children)
    : HtmlNode(HtmlTag.Empty, [], children);