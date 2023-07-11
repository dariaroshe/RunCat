using System;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using Image = UnityEngine.UI.Image;

namespace Shop.SelectBackground.BackgroundButton
{
    [Serializable]
    public class BackgroundButtonSetSpriteComponent : MonoBehaviour
    {
        private ShopModel _shopModel;
        private ShopScene _shopScene;
        private int _backgroundIndex;

        [SerializeField] private Image _image;

        public void Initialize(ShopModel shopModel, ShopScene shopScene, int backgroundIndex)
        {
            _shopModel = shopModel;
            _shopScene = shopScene;
            _backgroundIndex = backgroundIndex;

            _image.sprite = _shopScene.BackgroundCollectionInfo.Backgrounds[_backgroundIndex].Icon;
        }
    }
}