namespace ProfMon.Framework.Monster {
    public interface ITrait {
        string Description { get; }
        string Name { get; }

        public interface ITraitBuilder : IBuilder<ITrait, ITraitBuilder> {
            ITraitBuilder WithName (string name);
            ITraitBuilder WithDescription (string description);
        }
    }
}
