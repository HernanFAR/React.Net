using React.Net.Html.Abstracts;

namespace React.Net.Html.Nodes;

public sealed class TextNode(string text) : HtmlNode(HtmlTag.Empty, [], [])
{
    public string Text => text;

}
