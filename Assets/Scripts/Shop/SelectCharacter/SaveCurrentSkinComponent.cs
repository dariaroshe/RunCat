using Game;
using UnityEngine;

namespace Shop.SelectCharacter
{
    public class SaveCurrentSkinComponent : ShopComponent
    {
        private ShopModel _shopModel;
        private ShopScene _shopScene;

        public override void Initialize(ShopModel shopModel, ShopScene shopScene)
        {
            _shopModel = shopModel;
            _shopScene = shopScene;

            _shopModel.CurrentSkin.Value = PlayerPrefs.GetInt(Constants.CurrentSkinKey, 0);
            
            _shopModel.CurrentSkin.Changed += OnChangedCurrentSkin;
        }

        private void OnDestroy()
        {
            _shopModel.CurrentSkin.Changed -= OnChangedCurrentSkin;

        }

        private void OnChangedCurrentSkin()
        {
            PlayerPrefs.SetInt(Constants.CurrentSkinKey, _shopModel.CurrentSkin.Value);
        }
    }
}