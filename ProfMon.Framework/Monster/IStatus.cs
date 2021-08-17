using ProfMon.Framework.Descriptors;

namespace ProfMon.Framework.Monster {
    public interface IStatus : IName, IDescription {
        int MaxDuration { get; }

        float RestoreChance { get; }

        float TurnEndDamage { get; }

        bool StopsAction { get; }

        bool StopsSwitch { get; }

        public interface IStatusBuilder : IBuilder<IStatus, IStatusBuilder> {
            IStatusBuilder WithName (string name);
            IStatusBuilder WithDescription (string description);

            IStatusBuilder WithMaxDuration (int i);

            IStatusBuilder WithRestoreChance (float chance);

            IStatusBuilder WithTurnEndDamage (float dmage);

            IStatusBuilder StopsAction (bool option);

            IStatusBuilder StopsSwitch (bool option);
        }
    }
}
