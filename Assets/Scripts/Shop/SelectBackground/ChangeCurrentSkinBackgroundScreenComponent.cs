using UnityEngine;
using UnityEngine.UI;

namespace Shop.SelectBackground
{
    public class ChangeCurrentSkinBackgroundScreenComponent : ShopComponent
    {
        private ShopModel _shopModel;
        private ShopScene _shopScene;

        [SerializeField] private Image _image;

        public override void Initialize(ShopModel shopModel, ShopScene shopScene)
        {
            _shopModel = shopModel;
            _shopScene = shopScene;
            
            _image.sprite = _shopScene.SkinsCollectionInfo.Skins[_shopModel.CurrentSkin.Value].Icon;

            _shopModel.CurrentSkin.Changed += OnChangedCurrentSkin;
        }
        
        private void OnDestroy()
        {
            _shopModel.CurrentSkin.Changed -= OnChangedCurrentSkin;
        }

        private void OnChangedCurrentSkin()
        {
            _image.sprite = _shopScene.SkinsCollectionInfo.Skins[_shopModel.CurrentSkin.Value].Icon;
        }
    }
}