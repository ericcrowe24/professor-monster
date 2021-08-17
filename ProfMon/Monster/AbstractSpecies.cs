using ProfMon.Framework;
using ProfMon.Framework.Descriptors;
using ProfMon.Framework.Monster;
using ProfMon.Framework.Monster.Move;
using System.Collections.Generic;
using static ProfMon.Framework.Monster.ISpecies;

namespace ProfMon.Monster {
    public abstract class AbstractSpecies : ProfObj, ISpecies, IName, IDescription {
        protected string _name { get; }
        protected string _description { get; }

        protected float _health { get; }
        protected float _physicalAttack { get; }
        protected float _physicalDefense { get; }
        protected float _nonphysicalAttack { get; }
        protected float _nonphysicalDefense { get; }
        protected float _speed { get; }

        protected IMovePool _moves { get; }

        protected Stat _growthStat { get; }
        protected IGrowthRate _growthRate { get; }

        protected IElement _primaryElement { get; }
        protected IElement _secondaryElement { get; }

        protected ITrait[] _traits { get; }

        protected List<IEvolution> _evolutions { get; }

        public abstract string Name { get; }
        public abstract string Description { get; }

        public abstract float Health { get; }
        public abstract float PhysicalAttack { get; }
        public abstract float PhysicalDefense { get; }
        public abstract float NonphysicalAttack { get; }
        public abstract float NonphysicalDefense { get; }
        public abstract float Speed { get; }

        public abstract IMovePool Moves { get; }

        public abstract Stat GrowthStat { get; }
        public abstract IGrowthRate GrowthRate { get; }

        public abstract IElement PrimaryElement { get; }
        public abstract IElement SecondaryElement { get; }

        public abstract ITrait[] Traits { get; }

        public abstract List<IEvolution> Evolutions { get; }

        protected AbstractSpecies (Config config) : base(config.ID) {
            _name = config.Name;
            _description = config.Description;
            _health = config.Health;
            _physicalAttack = config.PhysicalAttack;
            _physicalDefense = config.PhysicalDefense;
            _nonphysicalAttack = config.NonphysicalAttack;
            _nonphysicalDefense = config.NonphysicalDefense;
            _speed = config.Speed;
            _moves = config.Moves;
            _growthStat = config.GrowthStat;
            _primaryElement = config.PrimaryElement;
            _secondaryElement = config.SecondaryElement;
            _traits = config.Traits;
            _evolutions = config.Evolutions;
        }

        protected class Config {
            public IID ID { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }

            public float Health { get; set; }
            public float PhysicalAttack { get; set; }
            public float PhysicalDefense { get; set; }
            public float NonphysicalAttack { get; set; }
            public float NonphysicalDefense { get; set; }
            public float Speed { get; set; }

            public IMovePool Moves { get; set; }
            public Stat GrowthStat { get; set; }
            public IGrowthRate GrowthRate { get; set; }

            public IElement PrimaryElement { get; set; }
            public IElement SecondaryElement { get; set; }

            public ITrait[] Traits { get; set; }

            public List<IEvolution> Evolutions { get; set; }
        }

        public abstract class AbstractSpeciesBuilder : ISpeciesBuilder {
            public abstract ISpeciesBuilder WithID (IID id);
            public abstract ISpeciesBuilder WithName (string name);
            public abstract ISpeciesBuilder WithDescription (string description);

            public abstract ISpeciesBuilder WithPrimaryElement (IElement element);
            public abstract ISpeciesBuilder WithSecondaryElement (IElement element);

            public abstract ISpeciesBuilder WithMovePool (IMovePool pool);

            public abstract ISpeciesBuilder WithHealth (float health);
            public abstract ISpeciesBuilder WithPhysicalAttack (float attack);
            public abstract ISpeciesBuilder WithPhysicalDefense (float defense);
            public abstract ISpeciesBuilder WithNonphysicalAttack (float attack);
            public abstract ISpeciesBuilder WithNonphysicalDefense (float defense);
            public abstract ISpeciesBuilder WithSpeed (float speed);

            public abstract ISpeciesBuilder WithGrowthRate (IGrowthRate growthRate);
            public abstract ISpeciesBuilder WithGrowthStat (Stat stat);

            public abstract ISpeciesBuilder WithTraits (ITrait[] traits);

            public abstract ISpeciesBuilder WithEvolutions (List<IEvolution> evolutions);

            public abstract ISpecies Build ();
        }
    }
}
