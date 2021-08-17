using ProfMon.Framework;
using ProfMon.Framework.Monster;
using ProfMon.Framework.World;
using System.Collections.Generic;
using static ProfMon.Framework.World.IWeather;

namespace ProfMon.World {
    public abstract class AbstractWeather : ProfObj, IWeather {
        protected string _name { get; }
        protected string _description { get; }

        protected int _duration { get; }

        protected Dictionary<IElement, float> _elementModifiers { get; }

        public abstract string Name { get; }
        public abstract string Description { get; }

        public abstract int Duration { get; }

        public abstract Dictionary<IElement, float> ElementModifiers { get; }

        private AbstractWeather () : base(null) { }

        protected AbstractWeather (Config config) : base(config.ID) {
            _name = config.Name;
            _description = config.Description;

            _duration = config.Duration;

            _elementModifiers = config.ElementModifiers;
        }

        protected class Config {
            public IID ID { get; set; }

            public string Name { get; set; }
            public string Description { get; set; }

            public int Duration { get; set; }

            public Dictionary<IElement, float> ElementModifiers { get; set; }
        }

        public abstract class AbstractWeatherBuilder : IWeatherBuilder {
            public abstract IWeatherBuilder WithID (IID id);

            public abstract IWeatherBuilder WithDuration (int dur);

            public abstract IWeatherBuilder WithElementModifiers (Dictionary<IElement, float> mods);

            public abstract IWeather Build ();
        }
    }
}
