using ProfMon.Framework;
using ProfMon.Framework.Monster;
using ProfMon.Framework.World;
using System.Collections.Generic;
using static ProfMon.Framework.World.IWeather;

namespace ProfMon.World {
    public class Weather : AbstractWeather {
        public override string Name => _name;

        public override string Description => _description;

        public override int Duration => _duration;

        public override Dictionary<IElement, float> ElementModifiers => _elementModifiers;

        private Weather () : base(null) { }

        protected Weather (Config config) : base(config) { }

        public class Builder : AbstractWeatherBuilder {
            private Config _config;

            public Builder () {
                _config = new Config();
            }

            public override IWeatherBuilder WithID (IID id) {
                _config.ID = id;
                return this;
            }

            public override IWeatherBuilder WithDuration (int dur) {
                _config.Duration = dur;
                return this;
            }

            public override IWeatherBuilder WithElementModifiers (Dictionary<IElement, float> mods) {
                _config.ElementModifiers = mods;
                return this;
            }

            public override IWeather Build () {
                return new Weather(_config);
            }
        }
    }
}
