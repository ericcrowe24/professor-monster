using ProfMon.Framework.Monster.Move;

namespace ProfMon.Framework.States {
    public interface IMoveState {
        IMove Move { get; }

        int Slot { get; }

        int CurrentUses { get; }

        int MaxUses { get; }

        int BoostedAmount { get; }

        bool Boostable { get; }

        void Boost (int amount);

        void Use (int uses = 1);

        void Restore (int amt = 1);
    }
}
