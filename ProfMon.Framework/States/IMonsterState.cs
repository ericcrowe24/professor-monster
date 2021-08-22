using ProfMon.Framework.Item;
using ProfMon.Framework.Monster;

namespace ProfMon.Framework.States {
    public interface IMonsterState {
        public ISpecies Species { get; }

        public int Level { get; }
        public float Experience { get; }
        public bool CanLevelUp { get; }

        public ITrait[] Traits { get; }

        public string Nickname { get; }
        public bool CanBeRenamed { get; }

        public float MaxHealth { get; }
        public float CurrentHealth { get; }

        public float PhysicalAttack { get; }
        public float PhyiscalDefense { get; }
        public float NonphysicalAttack { get; }
        public float NonphysicalDefense { get; }
        public float Speed { get; }

        public IStatus[] Statuses { get; }

        public IItem HeldItem { get; }

        public IMoveState[] Moves { get; }

        void Rename (string newName);

        void GiveItem (IItem item);

        IItem RemoveItem ();

        void Heal (float amount);

        void Damage (float amount);

        void GiveStatus (IStatus status);

        void RemoveStatus ();

        void UseMove (int slot, int amount);

        void RestoreMove (int slot, int amount);

        void Evolve (ISpecies target);
    }
}
