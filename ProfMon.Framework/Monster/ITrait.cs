namespace ProfMon.Framework.Monster {
    public interface ITrait {
        string Description { get; }
        string Name { get; }

        public interface ITraitBuilder {
            IBuilder<ITrait> WithID (IID id);

            ITraitBuilder WithName (string name);
            ITraitBuilder WithDescription (string description);

            ITrait Build ();
        }
    }
}
