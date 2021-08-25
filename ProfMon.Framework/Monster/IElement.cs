using ProfMon.Framework.Descriptors;
using System.Collections.Generic;

namespace ProfMon.Framework.Monster {
    public interface IElement : IName, IDescription {
        public Dictionary<IElement, float> Strengthes { get; }
        public Dictionary<IElement, float> Weaknesses { get; }

        public interface IElementBuilder : IBuilder<IElement, IElementBuilder> {
            IElementBuilder WithName (string name);
            IElementBuilder WithDescription (string description);

            IElementBuilder WithStrengths (Dictionary<IElement, float> strengthes);
            IElementBuilder WithWeaknesses (Dictionary<IElement, float> weaknesses);
        }
    }
}
