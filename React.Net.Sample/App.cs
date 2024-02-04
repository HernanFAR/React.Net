using System.Threading.Tasks;
using React.Net.Core;
using React.Net.Html.Nodes;
using React.Net.Html.Nodes.Html;

namespace React.Net.Sample;

public class App : Component
{
    public override async ValueTask<INode> Define()
    {
        return new ParagraphNode(new TextNode("Hola mundo!"));
    }
}
