using ProfMon.Framework;
using ProfMon.Framework.Item;
using ProfMon.Framework.Monster;
using ProfMon.Framework.World;
using static ProfMon.Framework.Monster.IEvolution;

namespace ProfMon.Monster {
    public abstract class AbstractEvolution : ProfObj, IEvolution {
        protected ISpecies _target { get; }

        protected int _levelRequired { get; }

        protected IItem _itemRequired { get; }

        protected IWeather _weatherRequired { get; }

        protected ISpecies _teamMateRequired { get; }

        public abstract ISpecies Target { get; }

        public abstract int LevelRequired { get; }

        public abstract IItem ItemRequired { get; }

        public abstract IWeather WeatherRequired { get; }

        public abstract ISpecies TeamMateRequired { get; }

        private AbstractEvolution () : base(null) { }

        protected AbstractEvolution (Config config) : base(config.ID) {
            _target = config.Target;

            _levelRequired = config.LevelRequired;

            _itemRequired = config.ItemRequired;

            _weatherRequired = config.WeatherRequired;

            _teamMateRequired = config.TeamMateRequired;
        }

        protected class Config {
            public IID ID { get; set; }

            public ISpecies Target { get; set; }

            public int LevelRequired { get; set; }

            public IItem ItemRequired { get; set; }

            public IWeather WeatherRequired { get; set; }

            public ISpecies TeamMateRequired { get; set; }
        }

        public abstract class AbstractEvolutionBuilder : IEvolutionBuilder {
            public abstract IEvolutionBuilder WithID (IID id);
            public abstract IEvolutionBuilder WithTarget (ISpecies species);
            public abstract IEvolutionBuilder WithLevelRequired (int level);
            public abstract IEvolutionBuilder WithItemRequired (IItem item);
            public abstract IEvolutionBuilder WithTeamMateRequired (ISpecies tm);
            public abstract IEvolutionBuilder WithWeatherRequired (IWeather weather);
            public abstract IEvolution Build ();
        }
    }
}
