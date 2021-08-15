using ProfMon.Framework.Descriptors;
using ProfMon.Framework.ID;

namespace ProfMon.Monster.Move {
    public class Move : ProfObj, IName, IDescription {
        public string Name { get; }

        public string Description { get; }

        public Element Element { get; }

        public float Power { get; }

        public float Accurecy { get; }

        public int StartingUses { get; }

        public int MaxUses { get; }

        public float CriticalHitRate { get; }

        public float CriticalHitMultiplier { get; }

        private Move () : base(null) { }

        protected Move (MoveConfig config) : base(config.ID) {
            Name = config.Name;
            Description = config.Description;
            Element = config.Element;
            Power = config.Power;
            Accurecy = config.Accurecy;
            StartingUses = config.StartingUses;
            MaxUses = config.MaxUses;
            CriticalHitRate = config.CriticalHitRate;
            CriticalHitMultiplier = config.CriticalHitMultiplier;
        }

        protected class MoveConfig {
            public IID ID { get; set; }

            public string Name { get; }

            public string Description { get; }

            public Element Element { get; }

            public float Power { get; }

            public float Accurecy { get; }

            public int StartingUses { get; }

            public int MaxUses { get; }

            public float CriticalHitRate { get; }

            public float CriticalHitMultiplier { get; }

        }
    }
}
