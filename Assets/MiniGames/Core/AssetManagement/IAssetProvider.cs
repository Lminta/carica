using System.Threading;
using System.Threading.Tasks;
using UnityEngine.ResourceManagement.ResourceProviders;

namespace MiniGames.Core.AssetManagement
{
    public interface IAssetProvider
    {
        public Task<T> Load<T>(string key, CancellationToken cancellationToken = default) where T : class;
        public Task<SceneInstance> LoadScene(string sceneName, CancellationToken cancellationToken = default);
        public void Release(string key);
        public void Cleanup();
    }
}