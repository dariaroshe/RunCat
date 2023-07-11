using TMPro;
using UnityEngine;

namespace Shop.SelectBackground.BackgroundButton
{
    public class BackgroundButtonSetPriceComponent : MonoBehaviour
    {
        private ShopModel _shopModel;
        private ShopScene _shopScene;
        private int _backgroundIndex;

        [SerializeField] private TextMeshProUGUI _textPrice;

        public void Initialize(ShopModel shopModel, ShopScene shopScene, int backgroundIndex)
        {
            _shopModel = shopModel;
            _shopScene = shopScene;
            _backgroundIndex = backgroundIndex;

            var price = _shopScene.BackgroundCollectionInfo.Backgrounds[_backgroundIndex].Price;
            _textPrice.text = $"<rotate=-25><sprite=0></rotate> x{price}";
        }
    }
}