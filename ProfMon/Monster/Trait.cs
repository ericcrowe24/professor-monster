using ProfMon.Framework.Descriptors;
using ProfMon.Framework.ID;
using ProfMon.Framework.Monster;

namespace ProfMon.Monster {
    public class Trait : ProfObj, IName, IDescription, IAbility {
        public string Name { get; }

        public string Description { get; }

        private Trait () : base(null) { }

        protected Trait (Config config) : base(config.ID) { }

        protected class Config {
            public IID ID { get; set; }
        }
    }
}
