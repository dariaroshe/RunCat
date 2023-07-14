using UnityEngine;
using UnityEngine.UI;

namespace Shop.Screens
{
    public class SetScreenShopComponent : ShopComponent
    {
        private ShopModel _shopModel;
        private ShopScene _shopScene;

        [SerializeField] private Button _button;
        [SerializeField] private ShopScreen _shopScreen;
        
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
            _shopModel.CurrentScreen.Value = _shopScreen;
        }
    }
}