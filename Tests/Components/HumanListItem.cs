using React.Net;
using React.Net.Core;
using System.Threading.Tasks;
using Tests.Models;
using static React.Net.Html.HtmlGenerators;

namespace Tests.Components;

public class HumanListItem(Human props) : Component
{
    public override async ValueTask<Node> Define()
    {
        return li([], 
            t($"Nombre: {props.Name} y edad: {props.Age}")
        );
    }
}