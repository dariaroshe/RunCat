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
        private int _skinIndex;

        [SerializeField] private Image _image;

        public void Initialize(ShopModel shopModel, ShopScene shopScene, int skinIndex)
        {
            _shopModel = shopModel;
            _shopScene = shopScene;
            _skinIndex = skinIndex;

            _image.sprite = _shopScene.BackgroundCollectionInfo.Backgrounds[_skinIndex].Icon;
        }
    }
}