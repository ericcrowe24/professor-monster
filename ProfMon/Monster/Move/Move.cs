using ProfMon.Framework;
using ProfMon.Framework.Monster;
using ProfMon.Framework.Monster.Move;
using static ProfMon.Framework.Monster.Move.IMove;

namespace ProfMon.Monster.Move {
    public class Move : AbstractMove {
        public override string Name => _name;
        public override string Description => _description;

        public override IElement PrimaryElement => _primaryElement;
        public override IElement SecondaryElement => _secondaryElement;

        public override float Power => _power;
        public override float Accurecy => _accurecy;

        public override int StartingUses => _startingUses;
        public override int MaxUses => _maxUses;

        public override float CriticalHitRate => _criticalHitRate;
        public override float CriticalHitMultiplier => _criticalHitMultiplier;

        private Move () : base(null) { }

        protected Move (Config config) : base(config) { }

        public class Builder : AbstractMoveBuilder {
            private Config _config;

            public Builder () {
                _config = new Config();
            }

            public override IBuilder<IMove> WithID (IID id) {
                _config.ID = id;
                return this;
            }

            public override IMoveBuilder WithName (string name) {
                _config.Name = name;
                return this;
            }

            public override IMoveBuilder WithDescription (string description) {
                _config.Description = description;
                return this;
            }

            public override IMoveBuilder WithPrimaryElement (IElement element) {
                _config.PrimaryElement = element;
                return this;

            }

            public override IMoveBuilder WithSecondaryElement (IElement element) {
                _config.SecondaryElement = element;
                return this;
            }

            public override IMoveBuilder WithPower (float power) {
                _config.Power = power;
                return this;
            }

            public override IMoveBuilder WithAccurecy (float accurecy) {
                _config.Accurecy = accurecy;
                return this;
            }

            public override IMoveBuilder WithStartingUses (int uses) {
                _config.StartingUses = uses;
                return this;
            }

            public override IMoveBuilder WithMaxUses (int uses) {
                _config.MaxUses = uses;
                return this;
            }

            public override IMoveBuilder WithCriticalHitRate (float rate) {
                _config.CriticalHitRate = rate;
                return this;
            }

            public override IMoveBuilder WithCriticalHitMulitplier (float multi) {
                _config.CriticalHitMultiplier = multi;
                return this;
            }

            public override IMove Build () {
                return new Move(_config);
            }
        }
    }
}
