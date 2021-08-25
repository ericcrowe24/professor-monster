using ProfMon.Framework.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfMon.Combat.Framework {
    public interface ICombatState {
        void AddTeam (List<IMonsterState> team);
    }
}
