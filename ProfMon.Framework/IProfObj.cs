namespace ProfMon.Framework {
    public interface IProfObj {
        IID ID { get; }

        bool Equals (object obj);

        int GetHashCode ();
    }
}