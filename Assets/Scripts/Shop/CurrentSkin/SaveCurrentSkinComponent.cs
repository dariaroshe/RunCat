using UnityEngine;

namespace Shop.CurrentSkin
{
    public class SaveCurrentSkinComponent : ShopComponent
    {
        private ShopModel _shopModel;
        private ShopScene _shopScene;

        public override void Initialize(ShopModel shopModel, ShopScene shopScene)
        {
            _shopModel = shopModel;
            _shopScene = shopScene;

            _shopModel.CurrentSkin.Value = PlayerPrefs.GetInt("CurrentSkin", 0);
            
            _shopModel.CurrentSkin.Changed += OnChangedCurrentSkin;
        }

        private void OnDestroy()
        {
            _shopModel.CurrentSkin.Changed -= OnChangedCurrentSkin;

        }

        private void OnChangedCurrentSkin()
        {
            PlayerPrefs.SetInt("CurrentSkin", _shopModel.CurrentSkin.Value);
        }
    }
}