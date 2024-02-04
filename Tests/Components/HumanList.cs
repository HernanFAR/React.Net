using React.Net;
using React.Net.Core;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tests.Models;
using static React.Net.Html.HtmlGenerators;

namespace Tests.Components;

public record HumanListProps(IEnumerable<Human> Humans);
public class HumanList(HumanListProps props) : Component
{
    public override async ValueTask<Node> Define()
    {
        return ul([], 
        e(
            props.Humans.Any()
                ? props.Humans.Select(u => new HumanListItem(u)).ToArray()
                : li([], t("Lo siento, no hay humanos"))
        ));
    }
}
