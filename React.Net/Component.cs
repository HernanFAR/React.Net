using React.Net.Core;

namespace React.Net;

public abstract class Component : Node
{
    public Guid Id => Guid.NewGuid();

    public abstract ValueTask<Node> Define();

}
