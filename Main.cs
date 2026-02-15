using System;
using Exiled.API.Features;
using PlayerEv = Exiled.Events.Handlers.Player;
    
namespace CoinFlipper
{
    public class Main : Plugin<Config>
    {
        public override string Name { get; } = "CoinFlipper";
        public override string Author { get; } = "Z1her";
        public override Version Version { get; } =  new Version(1, 0, 0);
        
        public override void OnEnabled()
        {
            PlayerEv.FlippingCoin += Handler.OnFlippingCoin;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            PlayerEv.FlippingCoin -= Handler.OnFlippingCoin;
            base.OnDisabled();
        }
    }
}
