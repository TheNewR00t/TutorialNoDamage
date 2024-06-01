using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;

namespace TutorialNoDamage
{
    internal class EventHandlers
    {
        private readonly plugin plugin;
        public EventHandlers(plugin plugin) => this.plugin = plugin;
        public void HurtingPlayer(HurtingEventArgs e)
        {
            if (e.Attacker == null) return;

            if (e.Player.IsTutorial)
            {

                if (e.Attacker.IsScp)
                {
                    e.IsAllowed = false;
                    e.Player.DisableAllEffects();
                }
            }
        }
    }
}
