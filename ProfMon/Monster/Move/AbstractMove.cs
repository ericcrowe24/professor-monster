using ProfMon.Framework;
using ProfMon.Framework.Descriptors;
using ProfMon.Framework.Monster;
using ProfMon.Framework.Monster.Move;
using static ProfMon.Framework.Monster.Move.IMove;

namespace ProfMon.Monster.Move {
    public abstract class AbstractMove : ProfObj, IName, IDescription, IMove {
        protected string _name { get; }
        protected string _description { get; }

        protected IElement _primaryElement { get; }
        protected IElement _secondaryElement { get; }

        protected float _power { get; }
        protected float _accurecy { get; }

        protected int _startingUses { get; }
        protected int _maxUses { get; }

        protected float _criticalHitRate { get; }
        protected float _criticalHitMultiplier { get; }

        public abstract string Name { get; }
        public abstract string Description { get; }

        public abstract IElement PrimaryElement { get; }
        public abstract IElement SecondaryElement { get; }

        public abstract float Power { get; }
        public abstract float Accurecy { get; }

        public abstract int StartingUses { get; }
        public abstract int MaxUses { get; }

        public abstract float CriticalHitRate { get; }
        public abstract float CriticalHitMultiplier { get; }

        private AbstractMove () : base(null) { }

        protected AbstractMove (Config config) : base(config.ID) {
            _name = config.Name;
            _description = config.Description;

            _primaryElement = config.PrimaryElement;
            _secondaryElement = config.SecondaryElement;

            _power = config.Power;
            _accurecy = config.Accurecy;

            _startingUses = config.StartingUses;
            _maxUses = config.MaxUses;

            _criticalHitRate = config.CriticalHitRate;
            _criticalHitMultiplier = config.CriticalHitMultiplier;
        }

        protected class Config {
            public IID ID { get; set; }

            public string Name { get; set; }
            public string Description { get; set; }

            public IElement PrimaryElement { get; set; }
            public IElement SecondaryElement { get; set; }

            public float Power { get; set; }
            public float Accurecy { get; set; }

            public int StartingUses { get; set; }
            public int MaxUses { get; set; }

            public float CriticalHitRate { get; set; }
            public float CriticalHitMultiplier { get; set; }
        }

        public abstract class AbstractMoveBuilder : IMoveBuilder {
            public abstract IMoveBuilder WithID (IID id);
            public abstract IMoveBuilder WithName (string name);
            public abstract IMoveBuilder WithDescription (string description);

            public abstract IMoveBuilder WithPrimaryElement (IElement element);
            public abstract IMoveBuilder WithSecondaryElement (IElement element);

            public abstract IMoveBuilder WithPower (float power);
            public abstract IMoveBuilder WithAccurecy (float accurecy);

            public abstract IMoveBuilder WithStartingUses (int uses);
            public abstract IMoveBuilder WithMaxUses (int uses);

            public abstract IMoveBuilder WithCriticalHitRate (float rate);
            public abstract IMoveBuilder WithCriticalHitMulitplier (float multi);

            public abstract IMove Build ();
        }
    }
}
