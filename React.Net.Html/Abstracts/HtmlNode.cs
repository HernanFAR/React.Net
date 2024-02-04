using React.Net.Core;
using React.Net.Html.Nodes;

namespace React.Net.Html.Abstracts;


public abstract class HtmlNode(
    HtmlTag tag,
    IEnumerable<KeyValuePair<string, string>> attributes,
    IEnumerable<OneOrManyNode> children)
    : Node
{
    public Guid Id => Guid.NewGuid();
    public HtmlTag Tag => tag;
    public IEnumerable<KeyValuePair<string, string>> Attributes => attributes;
    public IEnumerable<OneOrManyNode> Children => children;

}
