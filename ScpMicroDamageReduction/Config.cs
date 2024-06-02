using System.ComponentModel;
using Exiled.API.Interfaces;
using PlayerRoles;

namespace ScpMicroDamageReduction
{
    public class Config : IConfig
    {
        [Description("Is the plugin enabled?")]
        public bool IsEnabled { get; set; } = true;

        [Description("Debug printouts?")] 
        public bool Debug { get; set; } = false;

        [Description("SCPs that get the damage reduction from Micro")]
        public RoleTypeId[] ScpDamageReduction { get; set; } =
        {
            RoleTypeId.Scp096,
        };

        [Description("The reduced damage that the Micro does (divided by, so 2 is by half)")]
        public float ScpDamageReductionValue { get; set; } = 2.0f;
    }
}