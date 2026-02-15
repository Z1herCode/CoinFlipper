using Exiled.Events.EventArgs.Player;

namespace CoinFlipper
{
    public static class Handler
    { 
        public static void OnFlippingCoin(FlippingCoinEventArgs ev)
        {
            ev.Player.ShowHint(ev.IsTails ? "<color=yellow><b>🦅 Орёл!</b></color>" : "<color=orange><b>🪙 Решка!</b></color>");
        }
    }
}
