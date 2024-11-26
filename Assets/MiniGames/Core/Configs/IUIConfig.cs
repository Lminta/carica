using System.Collections.Generic;
using MiniGames.Core.UI;

namespace MiniGames.Core.Configs
{
    public interface IUIConfig
    {
        public Dictionary<ScreenID, string>  ScreenReference { get; }
        public bool LazyLoad { get; }
        public bool ReUse { get; }
    }
}