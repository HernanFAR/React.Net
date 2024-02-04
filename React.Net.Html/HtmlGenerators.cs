using React.Net.Core;
using React.Net.Html.Nodes;
// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming

namespace React.Net.Html;


public static class HtmlGenerators
{
    public static AnchorNode a(
        IEnumerable<KeyValuePair<string, string>> attributes,
        params OneOrManyNode[] children)
        => new(attributes, children);

    public static ButtonNode btn(
        IEnumerable<KeyValuePair<string, string>> attributes,
        params OneOrManyNode[] children)
        => new(attributes, children);

    public static EmptyNode e(params OneOrManyNode[] children)
        => new(children);

    public static DivNode div(
        IEnumerable<KeyValuePair<string, string>> attributes,
        params OneOrManyNode[] children)
        => new(attributes, children);

    public static ParagraphNode p(
        IEnumerable<KeyValuePair<string, string>> attributes,
        params OneOrManyNode[] children)
        => new(attributes, children);

    public static UnorderedListNode ul(
        IEnumerable<KeyValuePair<string, string>> attributes,
        params OneOrManyNode[] children)
        => new(attributes, children);

    public static ListItemNode li(
        IEnumerable<KeyValuePair<string, string>> attributes,
        params OneOrManyNode[] children)
        => new(attributes, children);

    public static TextNode t(string text) => new(text);
}
