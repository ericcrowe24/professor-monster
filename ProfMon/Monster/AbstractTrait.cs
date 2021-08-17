using ProfMon.Framework;
using ProfMon.Framework.Descriptors;
using ProfMon.Framework.Monster;
using static ProfMon.Framework.Monster.ITrait;

namespace ProfMon.Monster {
    public abstract class AbstractTrait : ProfObj, IName, IDescription, ITrait {
        protected string _name;
        protected string _description;

        public abstract string Name { get; }
        public abstract string Description { get; }

        private AbstractTrait () : base(null) { }

        protected AbstractTrait (Config config) : base(config.ID) {
            _name = config.Name;
            _description = config.Description;
        }

        protected class Config {
            public IID ID { get; set; }

            public string Name { get; set; }
            public string Description { get; set; }
        }

        public abstract class AbstractTraitBuilder : ITraitBuilder {
            public abstract ITraitBuilder WithID (IID id);

            public abstract ITraitBuilder WithDescription (string description);
            public abstract ITraitBuilder WithName (string name);

            public abstract ITrait Build ();
        }
    }
}
