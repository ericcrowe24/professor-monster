using ProfMon.Framework;
using ProfMon.Framework.Monster;
using System.Collections.Generic;
using static ProfMon.Framework.Monster.IElement;

namespace ProfMon.Monster {
    public class Element : AbstractElement {
        public override string Name => _name;
        public override string Description => _description;

        public override Dictionary<IElement, int> Strengthes => _strengthes;
        public override Dictionary<IElement, int> Weaknesses => _weaknesses;

        private Element () : base(null) { }

        protected Element (Config config) : base(config) { }

        public class Builder : AbstractElementBuilder {
            private Config config;

            public Builder () {
                config = new Config();
            }

            public override IElementBuilder WithID (IID id) {
                config.ID = id;
                return this;
            }

            public override IElementBuilder WithName (string name) {
                config.Name = name;
                return this;
            }

            public override IElementBuilder WithDescription (string description) {
                config.Description = description;
                return this;
            }

            public override IElementBuilder WithWeaknesses (Dictionary<IElement, int> weaknesses) {
                config.Weaknesses = weaknesses;
                return this;
            }

            public override IElementBuilder WithStrengths (Dictionary<IElement, int> strengthes) {
                config.Strengthes = strengthes;
                return this;
            }

            public override IElement Build () {
                return new Element(config);
            }
        }
    }
}
