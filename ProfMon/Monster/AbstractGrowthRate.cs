using ProfMon.Framework;
using ProfMon.Framework.Monster;

namespace ProfMon.Monster {
    public abstract class AbstractGrowthRate : ProfObj, IGrowthRate {
        protected AbstractGrowthRate () : base(null) { }

        public AbstractGrowthRate (IID id) : base(id) { }

        public abstract float CalculateExpRequirment (float level);
    }
}
