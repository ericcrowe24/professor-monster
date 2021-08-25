using ProfMon.Framework.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfMon.Combat.Framework {
    public interface IMonsterCombatState {
        public IMonsterState Monster { get; }
    }
}
