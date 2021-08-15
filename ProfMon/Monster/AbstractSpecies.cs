using ProfMon.Framework.Descriptors;
using ProfMon.Framework.ID;
using ProfMon.Framework.Monster;

namespace ProfMon.Monster {
    public abstract class AbstractSpecies : ProfObj, ISpecies, IName, IDescription {
        protected string _name;
        protected string _description;

        protected float _health;
        protected float _physicalAttack;
        protected float _physicalDefense;
        protected float _nonphysicalAttack;
        protected float _nonphysicalDefense;
        protected float _speed;

        protected IMovePool _moves;

        protected Stat _growthStat;
        protected IGrowthRate _growthRate;

        protected IElement _primaryElement;
        protected IElement _secondaryElement;

        protected IAbility[] _abilities;

        public abstract string Name { get; }
        public abstract string Description { get; }

        public abstract float Health { get; }
        public abstract float PhysicalAttack { get; }
        public abstract float PhysicalDefense { get; }
        public abstract float NonphysicalAttack { get; }
        public abstract float NonphysicalDefense { get; }
        public abstract float Speed { get; }

        public abstract IMovePool Moves { get; }

        public abstract Stat GrowthStat { get; }
        public abstract IGrowthRate GrowthRate { get; }

        public abstract IElement PrimaryElement { get; }
        public abstract IElement SecondaryElement { get; }

        public abstract IAbility[] Abilities { get; }

        protected AbstractSpecies (Config config) : base(config.ID) {
            _name = config.Name;
            _description = config.Description;
            _health = config.Health;
            _physicalAttack = config.PhysicalAttack;
            _physicalDefense = config.PhysicalDefense;
            _nonphysicalAttack = config.NonphysicalAttack;
            _nonphysicalDefense = config.NonphysicalDefense;
            _speed = config.Speed;
            _moves = config.Moves;
            _growthStat = config.GrowthStat;
            _primaryElement = config.PrimaryElement;
            _secondaryElement = config.SecondaryElement;
            _abilities = config.Abilities;
        }

        protected class Config {
            public IID ID { get; set; }

            public string Name { get; set; }

            public string Description { get; set; }

            public float Health { get; set; }

            public float PhysicalAttack { get; set; }

            public float PhysicalDefense { get; set; }

            public float NonphysicalAttack { get; set; }

            public float NonphysicalDefense { get; set; }

            public float Speed { get; set; }

            public IMovePool Moves { get; set; }

            public Stat GrowthStat { get; set; }

            public IGrowthRate GrowthRate { get; set; }

            public IElement PrimaryElement { get; set; }

            public IElement SecondaryElement { get; set; }

            public IAbility[] Abilities { get; set; }
        }

    }
}
