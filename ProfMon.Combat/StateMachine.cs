using ProfMon.Combat.Framework;
using ProfMon.Framework.States;
using System.Collections.Generic;
using System.Linq;

namespace ProfMon.Combat {
    public class StateMachine : IStateMachine {
        private List<IOrder> _roundOrders;
        private List<IResult> _orderResults;

        public ICombatState CombatState { get; private set; }

        public StateMachine () {
            _orderResults = new List<IResult>();
        }

        public void AddTeam (List<IMonsterState> team) {
            CombatState.AddTeam(team);
        }

        public void AddOrder (IOrder order) {
            _roundOrders.Add(order);
        }

        public List<IResult> ExecuteOrders () {
            var sorted = _roundOrders.OrderByDescending(o => o.Priority).ThenByDescending(o => o.User.Monster.Speed).ToList();
            bool running = true;
            IResult result;


            do {
                result = ExecuteOrder(sorted);

                var trimmed = sorted.GetRange(1, sorted.Count - 1);

                sorted = SortOrders(trimmed);

                if (trimmed.Count == 1) {
                    running = false;
                }
            }
            while (running);

            ExecuteOrder(sorted);

            return _orderResults;

            #region Local functions
            static List<IOrder> SortOrders(List<IOrder> list) => list.OrderByDescending(o => o.Priority)
                                                                    .ThenByDescending(o => o.User.Monster.Speed)
                                                                    .ToList();

            IResult ExecuteOrder (List<IOrder> sorted) {
                IResult result = sorted[0].Execute(CombatState);

                _orderResults.Add(result);

                return result;
            }
            #endregion
        }
    }
}
