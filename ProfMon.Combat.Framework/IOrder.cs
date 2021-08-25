using System.Collections.Generic;

namespace ProfMon.Combat.Framework {
    public interface IOrder {
        public int Priority { get; }

        public IMonsterCombatState User { get; }

        public List<IMonsterCombatState> Targets { get; }

        IResult Execute (ICombatState state);
    }
}
