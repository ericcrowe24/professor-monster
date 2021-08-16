using ProfMon.Framework;
using ProfMon.Framework.Monster;
using ProfMon.Framework.Monster.Move;
using static ProfMon.Framework.Monster.ISpecies;

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

        public override Framework.Monster.IElement PrimaryElement => _primaryElement;
        public override Framework.Monster.IElement SecondaryElement => _secondaryElement;

        public override ITrait[] Traits => _traits;

        private Species () : base(null) { }

        protected Species (Config config) : base(config) { }

        public class Builder : AbstractSpeciesBuilder {
            private Config _config;

            public Builder () {
                _config = new Config();
            }

            public override IBuilder<ISpecies> WithID (IID id) {
                _config.ID = id;
                return this;
            }

            public override ISpeciesBuilder WithName (string name) {
                _config.Name = name;
                return this;
            }

            public override ISpeciesBuilder WithDescription (string description) {
                _config.Description = description;
                return this;
            }

            public override ISpeciesBuilder WithHealth (float health) {
                _config.Health = health;
                return this;
            }

            public override ISpeciesBuilder WithPhysicalAttack (float attack) {
                _config.PhysicalAttack = attack;
                return this;
            }

            public override ISpeciesBuilder WithPhysicalDefense (float defense) {
                _config.PhysicalDefense = defense;
                return this;
            }

            public override ISpeciesBuilder WithNonphysicalAttack (float attack) {
                _config.NonphysicalAttack = attack;
                return this;
            }

            public override ISpeciesBuilder WithNonphysicalDefense (float defense) {
                _config.NonphysicalDefense = defense;
                return this;
            }

            public override ISpeciesBuilder WithSpeed (float speed) {
                _config.Speed = speed;
                return this;
            }

            public override ISpeciesBuilder WithMovePool (IMovePool pool) {
                _config.Moves = pool;
                return this;
            }

            public override ISpeciesBuilder WithGrowthStat (Stat stat) {
                _config.GrowthStat = stat;
                return this;
            }

            public override ISpeciesBuilder WithGrowthRate (IGrowthRate growthRate) {
                _config.GrowthRate = growthRate;
                return this;
            }

            public override ISpeciesBuilder WithPrimaryElement (Framework.Monster.IElement element) {
                _config.PrimaryElement = element;
                return this;
            }

            public override ISpeciesBuilder WithSecondaryElement (Framework.Monster.IElement element) {
                _config.SecondaryElement = element;
                return this;
            }

            public override ISpeciesBuilder WithTraits (ITrait[] traits) {
                _config.Traits = traits;
                return this;
            }

            public override ISpecies Build () {
                return new Species(_config);
            }
        }
    }
}
