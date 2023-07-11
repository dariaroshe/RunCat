using UnityEngine;
using UnityEngine.UI;

namespace Shop.SelectBackground.SelectButton
{
    public class SetCurrentBackgroundComponent : ShopComponent
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
            var selectedBackground = _shopModel.SelectedBackground.Value;

            _shopModel.CurrentBackground.Value = selectedBackground;
        }
    }
}