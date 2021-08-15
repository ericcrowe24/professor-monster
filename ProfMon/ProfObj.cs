using ProfMon.Framework;
using ProfMon.Framework.ID;

namespace ProfMon {
    public class ProfObj : IProfObj {
        public IID ID { get; }

        private ProfObj () { }

        public ProfObj (IID id) {
            ID = id;
        }

        public override bool Equals (object obj) {
            return ID.Equals(obj);
        }

        public override int GetHashCode () {
            return ID.GetHashCode();
        }
    }
}
