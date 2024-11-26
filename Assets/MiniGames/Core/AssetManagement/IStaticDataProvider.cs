using System.Collections.Generic;
using MiniGames.Core.Configs;
using MiniGames.Core.UI;
using MiniGames.Core.Utility.Interfaces;

namespace MiniGames.Core.AssetManagement
{
    public interface IStaticDataProvider
    {
        public IUIConfig UIConfig { get; }
    }
}