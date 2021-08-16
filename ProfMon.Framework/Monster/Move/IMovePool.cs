using System.Collections.Generic;

namespace ProfMon.Framework.Monster.Move {
    public interface IMovePool {
        Dictionary<int, IMove> LeveledMoves { get; }

        List<IMove> BreedMoves { get; }

        List<IMove> TutoredMoves { get; }
    }
}