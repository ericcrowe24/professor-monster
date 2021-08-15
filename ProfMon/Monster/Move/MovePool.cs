using System.Collections.Generic;

namespace ProfMon.Monster.Move {
    public class MovePool {
        public Dictionary<int, Move> LeveledMoves { get; }

        public List<Move> BreedMoves { get; }

        public List<Move> TutoredMoves { get; }
    }
}
