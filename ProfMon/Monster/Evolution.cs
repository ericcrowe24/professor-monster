using ProfMon.Framework;
using ProfMon.Framework.Item;
using ProfMon.Framework.Monster;
using ProfMon.Framework.World;
using static ProfMon.Framework.Monster.IEvolution;

namespace ProfMon.Monster {
    public class Evolution : AbstractEvolution {
        public override ISpecies Target => _target;

        public override int LevelRequired => _levelRequired;

        public override IItem ItemRequired => _itemRequired;

        public override IWeather WeatherRequired => _weatherRequired;

        public override ISpecies TeamMateRequired => _teamMateRequired;

        private Evolution () : base(null) { }

        protected Evolution (Config config) : base(config) { }

        public class Builder : AbstractEvolutionBuilder {
            private Config _config;

            public Builder () {
                _config = new Config();
            }

            public override IEvolutionBuilder WithID (IID id) {
                _config.ID = id;
                return this;
            }

            public override IEvolutionBuilder WithTarget (ISpecies species) {
                _config.Target = species;
                return this;
            }

            public override IEvolutionBuilder WithLevelRequired (int level) {
                _config.LevelRequired = level;
                return this;
            }

            public override IEvolutionBuilder WithItemRequired (IItem item) {
                _config.ItemRequired = item;
                return this;
            }

            public override IEvolutionBuilder WithTeamMateRequired (ISpecies tm) {
                _config.TeamMateRequired = tm;
                return this;
            }

            public override IEvolutionBuilder WithWeatherRequired (IWeather weather) {
                _config.WeatherRequired = weather;
                return this;
            }

            public override IEvolution Build () {
                return new Evolution(_config);
            }
        }
    }
}
