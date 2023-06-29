using System;
using UnityEngine;
using UnityEngine.UI;

namespace Shop
{
    public class ChangeSkinComponent : ShopComponent
    {
        private ShopModel _shopModel;
        private ShopScene _shopScene;

        [SerializeField] private Image _image;

        public override void Initialize(ShopModel shopModel, ShopScene shopScene)
        {
            _shopModel = shopModel;
            _shopScene = shopScene;
            
            _image.sprite = _shopScene.SkinsCollectionInfo.Skins[_shopModel.SelectedSkin.Value].Icon;

            _shopModel.SelectedSkin.Changed += OnChangedSelectedSkin;
        }
        
        private void OnDestroy()
        {
            _shopModel.SelectedSkin.Changed -= OnChangedSelectedSkin;
        }

        private void OnChangedSelectedSkin()
        {
            _image.sprite = _shopScene.SkinsCollectionInfo.Skins[_shopModel.SelectedSkin.Value].Icon;
        }
    }
}