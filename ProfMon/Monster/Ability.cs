using ProfMon.Framework.Descriptors;
using ProfMon.Framework.ID;
using ProfMon.Framework.Monster;

namespace ProfMon.Monster {
    public class Ability : ProfObj, IName, IDescription, IAbility {
        public string Name { get; }

        public string Description { get; }

        private Ability () : base(null) { }

        protected Ability (AbilityConfig config) : base(config.ID) { }

        protected class AbilityConfig {
            public IID ID { get; set; }
        }
    }
}
