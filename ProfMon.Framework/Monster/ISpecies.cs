namespace ProfMon.Framework.Monster {
    public interface ISpecies {
        public string Name { get; }

        public string Description { get; }

        public float Health { get; }

        public float PhysicalAttack { get; }

        public float PhysicalDefense { get; }

        public float NonphysicalAttack { get; }

        public float NonphysicalDefense { get; }

        public float Speed { get; }

        public IMovePool Moves { get; }

        public Stat GrowthStat { get; }

        public IGrowthRate GrowthRate { get; }

        public IElement PrimaryElement { get; }

        public IElement SecondaryElement { get; }

        public IAbility[] Abilities { get; }
    }

    public enum Stat {
        Health,
        PhysicalAttack,
        PhysicalDefense,
        NonphysicalAttack,
        NonphysicalDefense,
        Speed
    }
}
