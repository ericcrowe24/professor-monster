using ProfMon.Framework.Descriptors;

namespace ProfMon.Framework.Monster {
    public interface ITrait : IName, IDescription {
        public interface ITraitBuilder : IBuilder<ITrait, ITraitBuilder> {
            ITraitBuilder WithName (string name);
            ITraitBuilder WithDescription (string description);
        }
    }
}
