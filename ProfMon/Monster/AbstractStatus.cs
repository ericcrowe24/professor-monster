using ProfMon.Framework;
using ProfMon.Framework.Monster;
using static ProfMon.Framework.Monster.IStatus;

namespace ProfMon.Monster {
    public abstract class AbstractStatus : ProfObj, IStatus {
        protected string _name { get; }
        protected string _description { get; }

        protected int _maxDuration { get; }

        protected float _restoreChance { get; }

        protected float _turnEndDamage { get; }

        protected bool _stopsAction { get; }

        protected bool _stopsSwitch { get; }

        public abstract string Name { get; }
        public abstract string Description { get; }

        public abstract int MaxDuration { get; }

        public abstract float RestoreChance { get; }

        public abstract float TurnEndDamage { get; }

        public abstract bool StopsAction { get; }

        public abstract bool StopsSwitch { get; }

        private AbstractStatus () : base(null) { }

        protected AbstractStatus (Config config) : base(config.ID) {
            _name = config.Name;
            _description = config.Description;

            _maxDuration = config.MaxDuration;

            _restoreChance = config.RestoreChance;

            _turnEndDamage = config.TurnEndDamage;

            _stopsAction = config.StopsAction;

            _stopsSwitch = config.StopsSwitch;
        }

        protected class Config {
            public IID ID { get; set; }

            public string Name { get; set; }
            public string Description { get; set; }

            public int MaxDuration { get; set; }

            public float RestoreChance { get; set; }

            public float TurnEndDamage { get; set; }

            public bool StopsAction { get; set; }

            public bool StopsSwitch { get; set; }
        }

        public abstract class AbstractStatusBuilder : IStatusBuilder {
            public abstract IStatusBuilder WithID (IID id);
            public abstract IStatusBuilder WithName (string name);
            public abstract IStatusBuilder WithDescription (string description);

            public abstract IStatusBuilder WithMaxDuration (int i);

            public abstract IStatusBuilder WithRestoreChance (float chance);

            public abstract IStatusBuilder WithTurnEndDamage (float dmage);

            public abstract IStatusBuilder StopsAction (bool option);

            public abstract IStatusBuilder StopsSwitch (bool option);

            public abstract IStatus Build ();
        }
    }
}
