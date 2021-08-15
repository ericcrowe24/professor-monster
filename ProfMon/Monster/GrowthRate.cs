using ProfMon.Framework.ID;
using ProfMon.Framework.Monster;

namespace ProfMon.Monster {
    public abstract class GrowthRate : ProfObj, IGrowthRate {
        protected GrowthRate () : base(null) { }

        protected GrowthRate (GrowthRateConfig config) : base(config.ID) { }

        public abstract float CalculateExpRequirment (float level);

        protected class GrowthRateConfig {
            public IID ID { get; set; }
        }
    }
}
