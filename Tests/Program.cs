using React.Net.Html;
using System.Runtime.InteropServices.JavaScript;
using Tests;


var htmlRenderer = new HtmlRenderer(PlaceHolder.SetHtml);

await htmlRenderer.Render(new App(), "root");

internal partial class PlaceHolder
{
    [JSImport("setHtml", "main.js")]
    internal static partial void SetHtml(string id, string body);
}