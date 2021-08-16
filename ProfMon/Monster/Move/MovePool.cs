using ProfMon.Framework.Monster.Move;
using System.Collections.Generic;

namespace ProfMon.Monster.Move {
    public class MovePool : IMovePool {
        public Dictionary<int, IMove> LeveledMoves { get; }

        public List<IMove> BreedMoves { get; }

        public List<IMove> TutoredMoves { get; }
    }
}
