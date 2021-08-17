using System.Collections.Generic;

namespace ProfMon.Framework.Monster {
    public interface IElement {
        public string Name { get; }

        public string Description { get; }

        public Dictionary<IElement, int> Strengthes { get; }
        public Dictionary<IElement, int> Weaknesses { get; }

        public interface IElementBuilder : IBuilder<IElement, IElementBuilder> {
            IElementBuilder WithName (string name);
            IElementBuilder WithDescription (string description);

            IElementBuilder WithStrengths (Dictionary<IElement, int> strengthes);
            IElementBuilder WithWeaknesses (Dictionary<IElement, int> weaknesses);
        }
    }
}
