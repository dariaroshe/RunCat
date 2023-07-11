using UnityEngine;
using UnityEngine.UI;

namespace Shop.SelectBackground.BuyButtonBackground
{
    public class BuyButtonSpendCurrencyBackgroundComponent : ShopComponent
    {
        private ShopModel _shopModel;
        private ShopScene _shopScene;

        [SerializeField] private Button _button;

        public override void Initialize(ShopModel shopModel, ShopScene shopScene)
        {
            _shopModel = shopModel;
            _shopScene = shopScene;
            
            _button.onClick.AddListener(OnClick);
        }

        private void OnDestroy()
        {
            _button.onClick.RemoveListener(OnClick);
        }

        private void OnClick()
        {
            var currency = _shopModel.GameCurrency.Value;
            var price = _shopScene.BackgroundCollectionInfo.Backgrounds[_shopModel.SelectedBackground.Value].Price;
            var backgroundIndex = _shopModel.SelectedBackground.Value;

            if (currency >= price)
            {
                var spendCurrency = currency - price;

                _shopModel.GameCurrency.Value = spendCurrency;
                _shopModel.BoughtBackgrounds.Add(backgroundIndex);
            }
        }
    }
}