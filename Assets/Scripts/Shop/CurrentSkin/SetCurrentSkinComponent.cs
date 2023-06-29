using UnityEngine;
using UnityEngine.UI;

namespace Shop.CurrentSkin
{
    public class SetCurrentSkinComponent : ShopComponent
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
            var selectedSkin = _shopModel.SelectedSkin.Value;

            _shopModel.CurrentSkin.Value = selectedSkin;
        }
    }
}