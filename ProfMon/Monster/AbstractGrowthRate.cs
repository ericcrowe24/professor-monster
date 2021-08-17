using ProfMon.Framework;
using ProfMon.Framework.Monster;

namespace ProfMon.Monster {
    public abstract class AbstractGrowthRate : ProfObj, IGrowthRate {
        private AbstractGrowthRate () : base(null) { }

        protected AbstractGrowthRate (IID id) : base(id) { }

        public abstract float CalculateExpRequirment (float level);
    }
}
