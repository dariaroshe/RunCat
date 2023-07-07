using TMPro;
using UnityEngine;

namespace Shop.SelectCharacter.SkinButton
{
    public class SkinButtonSetPriceComponent : MonoBehaviour
    {
        private ShopModel _shopModel;
        private ShopScene _shopScene;
        private int _skinIndex;

        [SerializeField] private TextMeshProUGUI _textPrice;

        public void Initialize(ShopModel shopModel, ShopScene shopScene, int skinIndex)
        {
            _shopModel = shopModel;
            _shopScene = shopScene;
            _skinIndex = skinIndex;

            var price = _shopScene.SkinsCollectionInfo.Skins[_skinIndex].Price;
            _textPrice.text = $"<rotate=-25><sprite=0></rotate> x{price}";
        }
    }
}