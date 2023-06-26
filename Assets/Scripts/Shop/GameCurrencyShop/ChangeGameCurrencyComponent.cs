using System;
using TMPro;
using UnityEngine;

namespace Shop.GameCurrencyShop
{
    public class ChangeGameCurrencyComponent : ShopComponent
    {
        private ShopModel _shopModel;
        private ShopScene _shopScene;

        [SerializeField] private TextMeshProUGUI _textMaxGameCurrency;
        
        public override void Initialize(ShopModel shopModel, ShopScene shopScene)
        {
            _shopModel = shopModel;
            _shopScene = shopScene;

            var maxGameCurrency = _shopModel.GameCurrency.Value;

            _textMaxGameCurrency.text = $"<rotate=-25><sprite=0></rotate> x{maxGameCurrency}";

            _shopModel.GameCurrency.Changed += OnGameCurrencyChanged;
        }

        private void OnDestroy()
        {
            _shopModel.GameCurrency.Changed -= OnGameCurrencyChanged;
        }

        private void OnGameCurrencyChanged()
        {
            var currentGameCurrency = _shopModel.GameCurrency.Value;
                
            _textMaxGameCurrency.text = $"<rotate=-25><sprite=0></rotate> x{currentGameCurrency}";
        }
    }
}