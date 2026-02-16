using Exiled.Events.EventArgs.Player;

namespace CoinFlipper
{
    public static class Handler
    {
        public static void OnFlippingCoin(FlippingCoinEventArgs ev)
        {
            var cfg = Main.Cfg;
            var message = ev.IsTails ? cfg.EagleMessage : cfg.TailsMessage;
            ev.Player.ShowHint(message, cfg.HintDuration);
        }
    }
}