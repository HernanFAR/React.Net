namespace React.Net.Html.Nodes.Html;

public sealed class HtmlTag(string name)
{
    public string Name { get; } = name;

    public static readonly HtmlTag Anchor = new("a");
    public static readonly HtmlTag Div = new("div");
    public static readonly HtmlTag Paragraph = new("p");
}
