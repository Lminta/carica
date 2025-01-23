using System.Collections.Generic;
using Carica.Core.Configs;
using Carica.Core.UI;
using Carica.Core.Utility.Interfaces;

namespace Carica.Core.AssetManagement
{
    public interface IStaticDataProvider
    {
        public IUIConfig UIConfig { get; }
    }
}