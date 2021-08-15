using ProfMon.Framework;
using ProfMon.Framework.ID;
using ProfMon.Framework.Monster;

namespace ProfMon.Monster {
    public partial class Species : AbstractSpecies {
        public override string Name => _name;
        public override string Description => _description;

        public override float Health => _health;
        public override float PhysicalAttack => _physicalAttack;
        public override float PhysicalDefense => _physicalDefense;
        public override float NonphysicalAttack => _nonphysicalAttack;
        public override float NonphysicalDefense => _nonphysicalDefense;
        public override float Speed => _speed;

        public override IMovePool Moves => _moves;

        public override Stat GrowthStat => _growthStat;
        public override IGrowthRate GrowthRate => _growthRate;

        public override IElement PrimaryElement => _primaryElement;
        public override IElement SecondaryElement => _secondaryElement;

        public override IAbility[] Abilities => _abilities;

        private Species () : base(null) { }

        protected Species (Config config) : base(config) { }

        public class Builder : IBuilder<Species> {
            private Config _config;

            public Builder () {
                _config = new Config();
            }

            public IBuilder<Species> WithID (IID id) {
                _config.ID = id;
                return this;
            }

            public IBuilder<Species> WithName (string name) {
                _config.Name = name;
                return this;
            }

            public IBuilder<Species> WithDescription (string description) {
                _config.Description = description;
                return this;
            }

            public IBuilder<Species> WithHealth (float health) {
                _config.Health = health;
                return this;
            }

            public IBuilder<Species> WithPhysicalAttack (float attack) {
                _config.PhysicalAttack = attack;
                return this;
            }

            public IBuilder<Species> WithPhysicalDefense (float defense) {
                _config.PhysicalDefense = defense;
                return this;
            }

            public IBuilder<Species> WithNonphysicalAttack (float attack) {
                _config.NonphysicalAttack = attack;
                return this;
            }

            public IBuilder<Species> WithNonphysicalDefense (float defense) {
                _config.NonphysicalDefense = defense;
                return this;
            }

            public IBuilder<Species> WithSpeed (float speed) {
                _config.Speed = speed;
                return this;
            }

            public IBuilder<Species> WithMovePool (IMovePool pool) {
                _config.Moves = pool;
                return this;
            }

            public IBuilder<Species> WithGrowthStat (Stat stat) {
                _config.GrowthStat = stat;
                return this;
            }

            public IBuilder<Species> WithGrowthRate (IGrowthRate growthRate) {
                _config.GrowthRate = growthRate;
                return this;
            }

            public IBuilder<Species> WithPrimaryElement (IElement element) {
                _config.PrimaryElement = element;
                return this;
            }

            public IBuilder<Species> WithSecondaryElement (IElement element) {
                _config.SecondaryElement = element;
                return this;
            }

            public IBuilder<Species> WithAbilities (IAbility[] abilities) {
                _config.Abilities = abilities;
                return this;
            }

            public Species Build () {
                return new Species(_config);
            }
        }
    }
}
