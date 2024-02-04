using System.Runtime.InteropServices.JavaScript;
using System.Text;
using React.Net.Core;
using React.Net.Html.Nodes;

namespace React.Net.Html;

public sealed partial class HtmlRenderer
{
    public async Task Render(Component component, string id)
    {
        var builder = new StringBuilder();
        
        await RenderComponent(component, builder);

        SetBody(id, builder.ToString());
    }

    async Task RenderComponent(Component component, StringBuilder builder)
    {
        var node = await component.Define();
        
        await RenderNode(node, builder);
    }

    async Task RenderNode(INode node, StringBuilder builder)
    {
        switch (node)
        {
            case EmptyNode: return;
            case TextNode textNode:
                builder.Append(textNode.Text);
                return;
            case HtmlNode htmlNode:
                await RenderHtmlNode(htmlNode, builder);
                return;
        }
    }

    async Task RenderHtmlNode(HtmlNode htmlNode, StringBuilder builder)
    {
        builder.Append($"<{htmlNode.Tag}");

        foreach (var (key, value) in htmlNode.Attributes)
        {
            builder.Append($" {key}=\"{value}\"");
        }

        builder.Append('>');

        foreach (var child in htmlNode.Children)
        {
            await RenderNode(child, builder);
        }

        builder.Append($"</{htmlNode.Tag}>");   
    }

    [JSImport("setBody", "./main.js")]
    internal static partial void SetBody(string id, string body);
}
