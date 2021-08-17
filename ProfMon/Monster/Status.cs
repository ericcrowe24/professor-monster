using ProfMon.Framework;
using ProfMon.Framework.Monster;
using static ProfMon.Framework.Monster.IStatus;

namespace ProfMon.Monster {
    public class Status : AbstractStatus {
        public override string Name => _name;

        public override string Description => _description;

        public override int MaxDuration => _maxDuration;

        public override float RestoreChance => _restoreChance;

        public override float TurnEndDamage => _turnEndDamage;

        public override bool StopsAction => _stopsAction;

        public override bool StopsSwitch => _stopsSwitch;

        private Status () : base(null) { }

        protected Status (Config config) : base(config) { }

        public class Builder : AbstractStatusBuilder {
            private Config _config;

            public Builder () {
                _config = new Config();
            }

            public override IStatusBuilder WithID (IID id) {
                _config.ID = id;
                return this;
            }

            public override IStatusBuilder WithName (string name) {
                _config.Name = name;
                return this;
            }

            public override IStatusBuilder WithDescription (string description) {
                _config.Description = description;
                return this;
            }

            public override IStatusBuilder WithMaxDuration (int i) {
                _config.MaxDuration = i;
                return this;
            }

            public override IStatusBuilder WithRestoreChance (float chance) {
                _config.RestoreChance = chance;
                return this;
            }

            public override IStatusBuilder WithTurnEndDamage (float damage) {
                _config.TurnEndDamage = damage;
                return this;
            }

            public override IStatusBuilder StopsSwitch (bool option) {
                _config.StopsSwitch = option;
                return this;
            }

            public override IStatusBuilder StopsAction (bool option) {
                _config.StopsAction = option;
                return this;
            }

            public override IStatus Build () {
                return new Status(_config);
            }
        }
    }
}
