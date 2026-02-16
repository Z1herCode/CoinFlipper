using System;
using Exiled.API.Features;
using PlayerEv = Exiled.Events.Handlers.Player;
    
namespace CoinFlipper
{
    public class Main : Plugin<Config>
    {
        public override string Name { get; } = "CoinFlipper";
        public override string Author { get; } = "Z1her";
        public override Version Version { get; } =  new Version(1, 1, 1);
        
        public static Config Cfg { get; private set; }       
        
        public override void OnEnabled()
        {
            Cfg = Config;
            PlayerEv.FlippingCoin += Handler.OnFlippingCoin;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Cfg = null;
            PlayerEv.FlippingCoin -= Handler.OnFlippingCoin;
            base.OnDisabled();
        }
    }
}
