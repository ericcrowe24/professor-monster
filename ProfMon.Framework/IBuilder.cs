namespace ProfMon.Framework {
    public interface IBuilder<T, TBuilderType> {
        TBuilderType WithID (IID id);

        T Build ();
    }
}
