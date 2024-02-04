using React.Net;
using React.Net.Core;
using System.Threading.Tasks;
using Tests.Components;
using Tests.Models;
using static React.Net.Html.HtmlGenerators;

namespace Tests;

public class App : Component
{
    public override async ValueTask<Node> Define()
    {
        var humans = new Human[]
        {
            new("Juan", 20),
            new("Pedro", 30),
            new("Maria", 40)
        };

        return e(
            p([], t("Tenemos registrados los siguientes humanos:")),
            new HumanList(new HumanListProps(humans)),
            btn([], t("¿Quieres vaciar la lista de humanos?"))
        );
    }
}
