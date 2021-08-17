namespace ProfMon.Framework.Monster.Move {
    public interface IMove {
        string Name { get; }
        string Description { get; }
        IElement PrimaryElement { get; }

        float Accurecy { get; }
        float Power { get; }

        int StartingUses { get; }
        int MaxUses { get; }

        float CriticalHitMultiplier { get; }
        float CriticalHitRate { get; }

        public interface IMoveBuilder : IBuilder<IMove, IMoveBuilder> {
            IMoveBuilder WithName (string name);
            IMoveBuilder WithDescription (string description);

            IMoveBuilder WithPrimaryElement (IElement element);
            IMoveBuilder WithSecondaryElement (IElement element);

            IMoveBuilder WithPower (float power);
            IMoveBuilder WithAccurecy (float accurecy);

            IMoveBuilder WithMaxUses (int uses);
            IMoveBuilder WithStartingUses (int uses);

            IMoveBuilder WithCriticalHitRate (float rate);
            IMoveBuilder WithCriticalHitMulitplier (float multi);
        }
    }
}