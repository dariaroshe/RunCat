using UnityEngine;

namespace Shop
{
    public class SkinButtonShopComponent : MonoBehaviour
    {
        private ShopModel _shopModel;
        private ShopScene _shopScene;
        private int _skinIndex;

        [SerializeField] private SkinButtonSetSpriteComponent _skinButtonSetSpriteComponent;

        public void Initialize(ShopModel shopModel, ShopScene shopScene, int skinIndex)
        {
            _shopModel = shopModel;
            _shopScene = shopScene;
            _skinIndex = skinIndex;
            
            _skinButtonSetSpriteComponent.Initialize(_shopModel, _shopScene, _skinIndex);
        }
    }
}