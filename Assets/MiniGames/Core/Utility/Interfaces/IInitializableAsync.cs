using System.Threading;
using System.Threading.Tasks;

namespace MiniGames.Core.Utility.Interfaces
{
    public interface IInitializableAsync
    {
        Task InitializeAsync(CancellationToken cancellationToken = default);
    }
}