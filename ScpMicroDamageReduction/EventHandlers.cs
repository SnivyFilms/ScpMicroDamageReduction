using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using PlayerRoles;
using PlayerStatsSystem;
using static ScpMicroDamageReduction.Plugin;

namespace ScpMicroDamageReduction
{
    public class EventHandlers
    {
        public Plugin plugin;
        public EventHandlers(Plugin plugin) => this.plugin = plugin;

        public void OnPlayerHurting(HurtingEventArgs ev)
        {
            if (ev.Attacker != ev.Player && ev.DamageHandler.Base is MicroHidDamageHandler &&
                Instance.Config.ScpDamageReduction.Contains(ev.Player.Role))
            {
                ev.Amount /= Instance.Config.ScpDamageReductionValue;
                Log.Debug("SCP is on the list, damage is Micro");
            }
        }
    }
}