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
        
        [Description("Hint при орле")]
        public string EagleMessage { get; set; } = "<color=yellow><b>Орёл!</b></color>";

        [Description("Hint при решке")]
        public string TailsMessage { get; set; } = "<color=orange><b>Решка!</b></color>";

        [Description("Длительность hint'a (в секундах)")]
        public float HintDuration { get; set; } = 3f;
    }
}