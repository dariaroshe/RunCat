using Game;
using UnityEngine;

namespace Shop.SelectCharacter.GameCurrencyShop
{
    public class ShopSaveCurrencyComponent : ShopComponent
    {
        private ShopModel _shopModel;
        private ShopScene _shopScene;

        public override void Initialize(ShopModel shopModel, ShopScene shopScene)
        {
            _shopModel = shopModel;
            _shopScene = shopScene;

            _shopModel.GameCurrency.Changed += OnGameCurrencyChanged;
        }

        private void OnDestroy()
        {
            _shopModel.GameCurrency.Changed += OnGameCurrencyChanged;
        }

        private void OnGameCurrencyChanged()
        {
            PlayerPrefs.SetInt(Constants.GameCurrency, _shopModel.GameCurrency.Value);
        }
    }
}