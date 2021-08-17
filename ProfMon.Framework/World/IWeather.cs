using ProfMon.Framework.Descriptors;
using ProfMon.Framework.Monster;
using System.Collections.Generic;

namespace ProfMon.Framework.World {
    public interface IWeather : IName, IDescription {
        int Duration { get; }

        Dictionary<IElement, float> ElementModifiers { get; }
    }
}
