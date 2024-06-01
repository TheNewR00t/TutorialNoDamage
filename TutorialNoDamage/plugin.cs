using Exiled.API.Features;
using Exiled.CustomRoles.Events;
using PlayerHandlers = Exiled.Events.Handlers.Player;

namespace TutorialNoDamage
{
    public class plugin : Plugin<Config>
    {
        private EventHandlers eventHandlers;

        public override void OnEnabled()
        {
            eventHandlers = new EventHandlers(this);
            PlayerHandlers.Hurting += eventHandlers.HurtingPlayer;
            base.OnEnabled();
        }

        /// <inheritdoc/>
        public override void OnDisabled()
        {
            PlayerHandlers.Hurting -= eventHandlers.HurtingPlayer;
            eventHandlers = null;
            base.OnDisabled();
        }
    }
}
