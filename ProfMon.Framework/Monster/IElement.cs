using System.Collections.Generic;

namespace ProfMon.Framework.Monster {
    public interface IElement {
        public string Name { get; }

        public string Description { get; }

        public Dictionary<IElement, int> Strengths { get; }

        public Dictionary<IElement, int> Weaknesses { get; }
    }
}
