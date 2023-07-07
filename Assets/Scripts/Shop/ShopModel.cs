using Service;

namespace Shop
{
    public class ShopModel
    {
        public readonly Field<int> SelectedSkin = new Field<int>();
        public readonly Field<int> CurrentSkin = new Field<int>();
        
        public readonly  Field<int> SelectedBackground = new Field<int>();
        public readonly  Field<int> CurrentBackground = new Field<int>();
        
        public readonly Field<int> GameCurrency = new Field<int>();

        public ObservableHashSet<int> BoughtSkins = new ObservableHashSet<int>();
        public ObservableHashSet<int> BoughtBackgrounds = new ObservableHashSet<int>();
    }
}