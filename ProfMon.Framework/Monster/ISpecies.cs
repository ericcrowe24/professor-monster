using ProfMon.Framework.Monster.Move;

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

        public ITrait[] Traits { get; }

        public interface ISpeciesBuilder {
            IBuilder<ISpecies> WithID (IID id);
            ISpeciesBuilder WithName (string name);
            ISpeciesBuilder WithDescription (string description);

            ISpeciesBuilder WithPrimaryElement (IElement element);
            ISpeciesBuilder WithSecondaryElement (IElement element);

            ISpeciesBuilder WithMovePool (IMovePool pool);

            ISpeciesBuilder WithHealth (float health);
            ISpeciesBuilder WithPhysicalAttack (float attack);
            ISpeciesBuilder WithPhysicalDefense (float defense);
            ISpeciesBuilder WithNonphysicalAttack (float attack);
            ISpeciesBuilder WithNonphysicalDefense (float defense);
            ISpeciesBuilder WithSpeed (float speed);

            ISpeciesBuilder WithGrowthRate (IGrowthRate growthRate);
            ISpeciesBuilder WithGrowthStat (Stat stat);
            ISpeciesBuilder WithTraits (ITrait[] traits);
            ISpecies Build ();
        }
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
