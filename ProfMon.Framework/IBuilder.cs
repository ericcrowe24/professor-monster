namespace ProfMon.Framework {
    public interface IBuilder<T> {
        IBuilder<T> WithID (IID id);

        T Build ();
    }
}
