using UnityEngine;
using UnityEngine.UI;

namespace Shop
{
    public class SkinButtonSetSpriteComponent : MonoBehaviour
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

            _image.sprite = _shopScene.SkinsCollectionInfo.Skins[_skinIndex].Icon;
        }
    }
}