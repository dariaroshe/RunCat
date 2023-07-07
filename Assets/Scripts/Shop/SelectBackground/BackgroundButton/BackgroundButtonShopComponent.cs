using UnityEngine;

namespace Shop.SelectBackground.BackgroundButton
{
    public class BackgroundButtonShopComponent : MonoBehaviour
    {
        private ShopModel _shopModel;
        private ShopScene _shopScene;
        private int _skinIndex;

        [SerializeField] private BackgroundButtonSetSpriteComponent _backgroundButtonSetSpriteComponent;
        public void Initialize(ShopModel shopModel, ShopScene shopScene, int skinIndex)
        {
            _shopModel = shopModel;
            _shopScene = shopScene;
            _skinIndex = skinIndex;
            
            _backgroundButtonSetSpriteComponent.Initialize(_shopModel, _shopScene, _skinIndex);
        }
    }
}