using System.Threading;

namespace watch
{
    public interface IReflector<T,L> {
        void Run(CancellationToken c);

    }
}

