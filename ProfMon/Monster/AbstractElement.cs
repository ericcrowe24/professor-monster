using ProfMon.Framework;
using ProfMon.Framework.Descriptors;
using ProfMon.Framework.Monster;
using System.Collections.Generic;
using static ProfMon.Framework.Monster.IElement;

namespace ProfMon.Monster {
    public abstract class AbstractElement : ProfObj, IName, IDescription, IElement {
        protected string _name { get; }
        protected string _description { get; }

        protected Dictionary<IElement, float> _strengthes { get; }
        protected Dictionary<IElement, float> _weaknesses { get; }

        public abstract string Name { get; }
        public abstract string Description { get; }

        public abstract Dictionary<IElement, float> Strengthes { get; }
        public abstract Dictionary<IElement, float> Weaknesses { get; }

        private AbstractElement () : base(null) { }

        protected AbstractElement (Config config) : base(config.ID) {
            _name = config.Name;
            _description = config.Description;
            _strengthes = config.Strengthes;
            _weaknesses = config.Weaknesses;
        }

        protected class Config {
            public IID ID { get; set; }

            public string Name { get; set; }

            public string Description { get; set; }

            public Dictionary<IElement, float> Strengthes = new Dictionary<IElement, float>();

            public Dictionary<IElement, float> Weaknesses = new Dictionary<IElement, float>();
        }

        public abstract class AbstractElementBuilder : IElementBuilder {
            public abstract IElementBuilder WithID (IID id);

            public abstract IElementBuilder WithName (string name);
            public abstract IElementBuilder WithDescription (string description);

            public abstract IElementBuilder WithStrengths (Dictionary<IElement, float> strengthes);
            public abstract IElementBuilder WithWeaknesses (Dictionary<IElement, float> weaknesses);

            public abstract IElement Build ();
        }
    }
}
