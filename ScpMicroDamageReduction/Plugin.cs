using Exiled.API.Features;
using Player = Exiled.Events.Handlers.Player;
using System;
using Version = System.Version;

namespace ScpMicroDamageReduction
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin Instance;
        public override string Name { get; } = "SCP Micro Damage Reduction";
        public override string Author { get; } = "Vicious Vikki";
        public override string Prefix { get; } = "SMDR";
        public override Version Version { get; } = new Version(1, 0, 1);
        public override Version RequiredExiledVersion { get; } = new Version(8, 9, 2);

        public EventHandlers eventHandlers;

        public override void OnEnabled()
        {
            Instance = this;
            eventHandlers = new EventHandlers(this);
            Player.Hurting += eventHandlers.OnPlayerHurting;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Instance = null;
            Player.Hurting -= eventHandlers.OnPlayerHurting;
            eventHandlers = null;
            base.OnDisabled();
        }
    }
}