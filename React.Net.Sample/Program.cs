using React.Net.Html;
using React.Net.Sample;
using System;

Console.WriteLine("Hello, Browser!");

var htmlRenderer = new HtmlRenderer();

await htmlRenderer.Render(new App(), "root");