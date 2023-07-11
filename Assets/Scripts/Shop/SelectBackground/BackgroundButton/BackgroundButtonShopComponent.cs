using UnityEngine;

namespace Shop.SelectBackground.BackgroundButton
{
    public class BackgroundButtonShopComponent : MonoBehaviour
    {
        private ShopModel _shopModel;
        private ShopScene _shopScene;
        private int _backgroundIndex;

        [SerializeField] private BackgroundButtonSetSpriteComponent _backgroundButtonSetSpriteComponent;
        [SerializeField] private SelectBackgroundScrollComponent _selectBackgroundScrollComponent;
        [SerializeField] private BackgroundButtonSetPriceComponent _backgroundButtonSetPriceComponent;
        [SerializeField] private HidePriceBackgroundButtonComponent _hidePriceBackgroundButtonComponent;
        [SerializeField] private BackgroundButtonSelectionComponent _backgroundButtonSelectionComponent;
        
        public void Initialize(ShopModel shopModel, ShopScene shopScene, int backgroundIndex)
        {
            _shopModel = shopModel;
            _shopScene = shopScene;
            _backgroundIndex = backgroundIndex;
            
            _backgroundButtonSetSpriteComponent.Initialize(_shopModel, _shopScene, _backgroundIndex);
            _selectBackgroundScrollComponent.Initialize(_shopModel, _shopScene, _backgroundIndex);
            _backgroundButtonSetPriceComponent.Initialize(_shopModel, _shopScene, _backgroundIndex);
            _hidePriceBackgroundButtonComponent.Initialize(_shopModel, _shopScene, _backgroundIndex);
            _backgroundButtonSelectionComponent.Initialize(_shopModel, _shopScene, _backgroundIndex);
        }
    }
}