using TMPro;
using UnityEngine;

namespace Shop
{
    public class MaxGameCurrencyComponent : ShopComponent
    {
        private ShopModel _shopModel;
        private ShopScene _shopScene;

        [SerializeField] private TextMeshProUGUI _textMaxGameCurrency;
        
        public override void Initialize(ShopModel shopModel, ShopScene shopScene)
        {
            _shopModel = shopModel;
            _shopScene = shopScene;

            var maxGameCurrency = PlayerPrefs.GetInt("maxGameCurrency");

            _textMaxGameCurrency.text = $"<rotate=-25><sprite=0></rotate> x{maxGameCurrency}";
        }
    }
}