using UnityEngine;
using UnityEngine.UI;

namespace Shop.SelectBackground.BuyButtonBackground
{
    public class ShowBuyButtonBackgroundComponent : ShopComponent
    {
        private ShopModel _shopModel;
        private ShopScene _shopScene;

        [SerializeField] private Button _buttonBuy;
        [SerializeField] private Button _buttonSelect;

        public override void Initialize(ShopModel shopModel, ShopScene shopScene)
        {
            _shopModel = shopModel;
            _shopScene = shopScene;

            UpdateVisible();

            _shopModel.SelectedBackground.Changed += OnChangedSelectedBackground;
            _shopModel.BoughtBackgrounds.ItemAdded += OnItemAdded;
        }

        private void OnDestroy()
        {
            _shopModel.SelectedBackground.Changed -= OnChangedSelectedBackground;
            _shopModel.BoughtBackgrounds.ItemAdded -= OnItemAdded;
        }

        private void OnItemAdded(int obj)
        {
            UpdateVisible();
        }

        private void OnChangedSelectedBackground()
        {
            UpdateVisible();
        }

        private void UpdateVisible()
        {
            var currentSkin = _shopModel.SelectedBackground.Value;

            if (_shopModel.BoughtBackgrounds.Contains(currentSkin))
            {
                _buttonBuy.gameObject.SetActive(false);
                _buttonSelect.gameObject.SetActive(true);
            }
            else
            {
                _buttonBuy.gameObject.SetActive(true);
                _buttonSelect.gameObject.SetActive(false);
            }
        }
    }
}