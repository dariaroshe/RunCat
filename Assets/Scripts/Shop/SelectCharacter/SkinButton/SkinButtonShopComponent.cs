using UnityEngine;

namespace Shop.SelectCharacter.SkinButton
{
    public class SkinButtonShopComponent : MonoBehaviour
    {
        private ShopModel _shopModel;
        private ShopScene _shopScene;
        private int _skinIndex;

        [SerializeField] private SkinButtonSetSpriteComponent _skinButtonSetSpriteComponent;
        [SerializeField] private SelectSkinScrollComponent _selectSkinScrollComponent;
        [SerializeField] private ButtonSelectionComponent _buttonSelectionComponent;
        [SerializeField] private SkinButtonSetPriceComponent _skinButtonSetPriceComponent;
        [SerializeField] private HidePriceSkinButtonComponent HidePriceSkinButtonComponent;

        public void Initialize(ShopModel shopModel, ShopScene shopScene, int skinIndex)
        {
            _shopModel = shopModel;
            _shopScene = shopScene;
            _skinIndex = skinIndex;
            
            _skinButtonSetSpriteComponent.Initialize(_shopModel, _shopScene, _skinIndex);
            _selectSkinScrollComponent.Initialize(_shopModel, _shopScene, _skinIndex);
            _buttonSelectionComponent.Initialize(_shopModel, _shopScene, _skinIndex);
            _skinButtonSetPriceComponent.Initialize(_shopModel, _shopScene, _skinIndex);
            HidePriceSkinButtonComponent.Initialize(_shopModel, _shopScene, _skinIndex);
        }
    }
}