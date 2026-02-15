using System.ComponentModel;
using Exiled.API.Interfaces;

namespace CoinFlipper
{
    public class Config : IConfig
    {
        [Description("Включен ли плагин?")]
        public bool IsEnabled { get; set; } = true;
        
        [Description("Влючен ли режим отладки?")]
        public bool Debug { get; set; } = false;
    }
}