namespace React.Net.Html.Nodes;

public class HtmlTag(string name)
{
    public string Name { get; } = name;

    public override string ToString() => Name;

    public static readonly HtmlTag Anchor = new("a");
    public static readonly HtmlTag Div = new("div");
    public static readonly HtmlTag Paragraph = new("p");
    public static readonly HtmlTag UnorderedList = new("ul");
    public static readonly HtmlTag ListItem = new("li");
    public static readonly HtmlTag Empty = new(string.Empty);

}
