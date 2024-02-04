using React.Net.Core;
using React.Net.Html.Abstracts;
using React.Net.Html.Nodes;
using System.Text;

namespace React.Net.Html;

public sealed class HtmlRenderer(Action<string, string> renderFunction)
{
    readonly Action<string, string> _renderFunction = renderFunction;

    public async Task Render(Component component, string id)
    {
        var builder = new StringBuilder();

        await RenderComponent(component, builder);

        _renderFunction(id, builder.ToString());
    }

    async Task RenderNode(Node node, StringBuilder builder)
    {
        switch (node)
        {
            case TextNode textNode:
                builder.Append(textNode.Text);
                return;
            case HtmlNode htmlNode:
                await RenderHtmlNode(htmlNode, builder);
                return;
            case Component component:
                await RenderComponent(component, builder);
                return;
        }
    }

    async Task RenderComponent(Component component, StringBuilder builder)
    {
        await RenderNode(await component.Define(), builder);
    }

    async Task RenderHtmlNode(HtmlNode htmlNode, StringBuilder builder)
    {
        if (htmlNode is not EmptyNode)
        {
            builder.Append($"<{htmlNode.Tag}");

            foreach (var (key, value) in htmlNode.Attributes)
            {
                builder.Append($" {key}=\"{value}\"");
            }

            builder.Append('>');
        }

        foreach (var child in htmlNode.Children)
        {
            if (child.JustOne)
            {
                await RenderNode(child.Node, builder);

                continue;
            }

            foreach (var childNode in child.Nodes)
            {
                await RenderNode(childNode, builder);
            }
        }

        if (htmlNode is not EmptyNode)
        {
            builder.Append($"</{htmlNode.Tag}>");
        }
    }
}
