using ProfMon.Framework.Item;
using ProfMon.Framework.World;

namespace ProfMon.Framework.Monster {
    public interface IEvolution {
        ISpecies Target { get; }

        int LevelRequired { get; }

        IItem ItemRequired { get; }

        IWeather WeatherRequired { get; }

        ISpecies TeamMateRequired { get; }

        public interface IEvolutionBuilder : IBuilder<IEvolution, IEvolutionBuilder> {
            IEvolutionBuilder WithTarget (ISpecies species);

            IEvolutionBuilder WithLevelRequired (int level);

            IEvolutionBuilder WithItemRequired (IItem item);

            IEvolutionBuilder WithWeatherRequired (IWeather weather);

            IEvolutionBuilder WithTeamMateRequired (ISpecies tm);
        }
    }
}
