using React.Net.Core;

namespace React.Net.Html.Nodes;

public sealed class TextNode(string text) : INode
{
    public Guid Id => Guid.NewGuid();
    public string Text => text;
    public IEnumerable<KeyValuePair<string, string>> Attributes => [];
    public IEnumerable<INode> Children => [];
}
