using ProfMon.Framework;
using ProfMon.Framework.Descriptors;
using ProfMon.Framework.Monster;
using System.Collections.Generic;
using static ProfMon.Framework.Monster.IElement;

namespace ProfMon.Monster {
    public abstract class AbstractElement : ProfObj, IName, IDescription, IElement {
        protected string _name { get; }
        protected string _description { get; }

        protected Dictionary<IElement, int> _strengthes { get; }
        protected Dictionary<IElement, int> _weaknesses { get; }

        public abstract string Name { get; }
        public abstract string Description { get; }

        public abstract Dictionary<IElement, int> Strengthes { get; }
        public abstract Dictionary<IElement, int> Weaknesses { get; }

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

            public Dictionary<IElement, int> Strengthes = new Dictionary<IElement, int>();

            public Dictionary<IElement, int> Weaknesses = new Dictionary<IElement, int>();
        }

        public abstract class AbstractElementBuilder : IBuilder<IElement>, IElementBuilder {
            public abstract IElement Build ();
            public abstract IElementBuilder WithName (string name);
            public abstract IElementBuilder WithDescription (string description);

            public abstract IElementBuilder WithStrengths (Dictionary<IElement, int> strengthes);
            public abstract IElementBuilder WithWeaknesses (Dictionary<IElement, int> weaknesses);

            public abstract IBuilder<IElement> WithID (IID id);
        }
    }
}
