using ProfMon.Framework;
using ProfMon.Framework.Monster;
using static ProfMon.Framework.Monster.ITrait;

namespace ProfMon.Monster {
    public class Trait : AbstractTrait {
        public override string Name => _name;
        public override string Description => _description;

        private Trait () : base(null) { }

        protected Trait (Config config) : base(config) { }

        public class Builder : AbstractTraitBuilder {
            private Config _config = new Config();

            public override ITraitBuilder WithID (IID id) {
                _config.ID = id;
                return this;
            }

            public override ITraitBuilder WithName (string name) {
                _config.Name = name;
                return this;
            }

            public override ITraitBuilder WithDescription (string description) {
                _config.Description = description;
                return this;
            }

            public override ITrait Build () {
                return new Trait(_config);
            }
        }
    }
}
