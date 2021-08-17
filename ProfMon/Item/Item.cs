using ProfMon.Framework.Monster;

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
    }
}
