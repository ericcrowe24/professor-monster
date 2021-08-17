using ProfMon.Framework.Descriptors;
using ProfMon.Framework.Monster;

namespace ProfMon.Framework.Item {
    public interface IItem : IName, IDescription {
        float BuyValue { get; }
        bool Sellable { get; }
        float SellValue { get; }

        float HealthRestored { get; }
        IStatus StatusRemoved { get; }

        bool FullHeal { get; }
        bool RemovesAllStatus { get; }
        bool RemovesAnyStatus { get; }

        public interface IItemBuilder : IBuilder<IItem, IItemBuilder> {
            IItemBuilder WithName (string name);
            IItemBuilder WithDescription (string Description);

            IItemBuilder WithBuyValue (float buy);
            IItemBuilder CanSell (bool option);
            IItemBuilder WithSellValue (float sell);

            IItemBuilder WithHealthRestored (float resotred);
            IItemBuilder WithStatusRemoved (IStatus status);

            IItemBuilder CanFullHeal (bool option);
            IItemBuilder RemovesAnyStatus (bool option);
            IItemBuilder RemovesAllStatus (bool option);

        }
    }
}
