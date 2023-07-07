using TMPro;
using UnityEngine;

namespace Shop.SelectCharacter.SkinButton
{
    public class HidePriceComponent : MonoBehaviour
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

            _shopModel.BoughtSkins.ItemAdded += OnItemAdded;
        }

        private void OnDestroy()
        {
            _shopModel.BoughtSkins.ItemAdded -= OnItemAdded;
        }

        private void OnItemAdded(int addedSkinIndex)
        {
            if (addedSkinIndex == _skinIndex)
            {
                _textPrice.gameObject.SetActive(false);
            }
        }
    }
}