using Game;
using UnityEngine;

namespace Shop.SelectBackground
{
    public class SaveCurrentBackgroundComponent : ShopComponent
    {
        private ShopModel _shopModel;
        private ShopScene _shopScene;

        public override void Initialize(ShopModel shopModel, ShopScene shopScene)
        {
            _shopModel = shopModel;
            _shopScene = shopScene;

            _shopModel.CurrentBackground.Value = PlayerPrefs.GetInt(Constants.CurrentBackgroundKey, 0);
            
            _shopModel.CurrentBackground.Changed += OnChangedCurrentBackground;
        }

        private void OnDestroy()
        {
            _shopModel.CurrentBackground.Changed -= OnChangedCurrentBackground;

        }

        private void OnChangedCurrentBackground()
        {
            PlayerPrefs.SetInt(Constants.CurrentBackgroundKey, _shopModel.CurrentBackground.Value);
        }
    }
}