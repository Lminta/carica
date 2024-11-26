using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MiniGames.Core.AssetManagement;
using MiniGames.Core.Configs;
using MiniGames.Core.UI;
using MiniGames.Core.Utility.Interfaces;

namespace MiniGames.AssetManagement
{
    public class LocalDataProvider : IStaticDataProvider, IInitializableAsync, IDisposable
    {
        private readonly IAssetProvider _assetProvider;
        private UIConfig _uiConfig;
        
        public IUIConfig UIConfig => _uiConfig;
        
        public LocalDataProvider(IAssetProvider assetProvider)
        {
            _assetProvider = assetProvider;
        }
        
        public async Task InitializeAsync(CancellationToken cancellationToken = default)
        {
            await Task.WhenAll(
                LoadScreenList(cancellationToken)
                );
        }
        
        private async Task LoadScreenList(CancellationToken cancellationToken = default)
        {
            _uiConfig = await _assetProvider.Load<UIConfig>(AssetKeys.ScreenListConfig, cancellationToken);
        }
        
        public void Dispose()
        {
            _assetProvider.Release(AssetKeys.ScreenListConfig);
        }
    }
}