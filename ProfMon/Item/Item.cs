using ProfMon.Framework;
using ProfMon.Framework.Item;
using ProfMon.Framework.Monster;
using static ProfMon.Framework.Item.IItem;

namespace ProfMon.Item {
    public class Item : AbstractItem {
        public override string Name => _name;
        public override string Description => _description;

        public override float BuyValue => _buyValue;
        public override bool Sellable => _sellable;
        public override float SellValue => _sellValue;

        public override float HealthRestored => _healthRestored;
        public override IStatus StatusRemoved => _statusRemoved;

        public override bool FullHeal => _fullHeal;
        public override bool RemovesAllStatus => _removesAllStatus;
        public override bool RemovesAnyStatus => _removesAnyStatus;

        private Item () : base(null) { }

        protected Item (Config config) : base(config) { }

        public class Builder : AbstractItemBuilder {
            private Config _config;

            public Builder () {
                _config = new Config();
            }

            public override IItemBuilder WithID (IID id) {
                _config.ID = id;
                return this;
            }

            public override IItemBuilder WithName (string name) {
                _config.Name = name;
                return this;
            }

            public override IItemBuilder WithDescription (string Description) {
                _config.Description = Description;
                return this;
            }

            public override IItemBuilder WithBuyValue (float buy) {
                _config.BuyValue = buy;
                return this;
            }

            public override IItemBuilder CanSell (bool option) {
                _config.Sellable = option;
                return this;
            }

            public override IItemBuilder WithSellValue (float sell) {
                _config.SellValue = sell;
                return this;
            }

            public override IItemBuilder WithHealthRestored (float resotred) {
                _config.HealthRestored = resotred;
                return this;
            }

            public override IItemBuilder WithStatusRemoved (IStatus status) {
                _config.StatusRemoved = status;
                return this;
            }

            public override IItemBuilder CanFullHeal (bool option) {
                _config.FullHeal = option;
                return this;
            }

            public override IItemBuilder RemovesAllStatus (bool option) {
                _config.RemovesAllStatus = option;
                return this;
            }

            public override IItemBuilder RemovesAnyStatus (bool option) {
                _config.RemovesAnyStatus = option;
                return this;
            }

            public override IItem Build () {
                return new Item(_config);
            }
        }
    }
}
