using ProfMon.Framework.Descriptors;
using ProfMon.Framework.Monster;
using System.Collections.Generic;

namespace ProfMon.Framework.World {
    public interface IWeather : IName, IDescription {
        int Duration { get; }

        Dictionary<IElement, float> ElementModifiers { get; }

        public interface IWeatherBuilder : IBuilder<IWeather, IWeatherBuilder> {
            IWeatherBuilder WithDuration (int dur);

            IWeatherBuilder WithElementModifiers (Dictionary<IElement, float> mods);
        }
    }
}
