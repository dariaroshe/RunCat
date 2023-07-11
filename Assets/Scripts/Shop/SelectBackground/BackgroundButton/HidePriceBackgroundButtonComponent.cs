using TMPro;
using UnityEngine;

namespace Shop.SelectBackground.BackgroundButton
{
    public class HidePriceBackgroundButtonComponent : MonoBehaviour
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

            _shopModel.BoughtBackgrounds.ItemAdded += OnItemAdded;
        }

        private void OnDestroy()
        {
            _shopModel.BoughtBackgrounds.ItemAdded -= OnItemAdded;
        }

        private void OnItemAdded(int addedBackgroundIndex)
        {
            if (addedBackgroundIndex == _backgroundIndex)
            {
                _textPrice.gameObject.SetActive(false);
            }
        }
    }
}