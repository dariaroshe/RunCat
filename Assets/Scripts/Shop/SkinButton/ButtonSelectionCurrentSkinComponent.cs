using UnityEngine;
using UnityEngine.UI;

namespace Shop.SkinButton
{
    public class ButtonSelectionCurrentSkinComponent : MonoBehaviour
    {
        private ShopModel _shopModel;
        private ShopScene _shopScene;
        private int _skinIndex;

        [SerializeField] private Image _image;
        [SerializeField] private Color _defaultColor;
        [SerializeField] private Color _selectedColor;

        public void Initialize(ShopModel shopModel, ShopScene shopScene, int skinIndex)
        {
            _shopModel = shopModel;
            _shopScene = shopScene;
            _skinIndex = skinIndex;
            
            UpdateColor();
            
            _shopModel.CurrentSkin.Changed += OnChangedCurrentSkin;
        }

        private void OnDestroy()
        {
            _shopModel.CurrentSkin.Changed -= OnChangedCurrentSkin;
        }

        private void OnChangedCurrentSkin()
        {
            UpdateColor();
        }

        private void UpdateColor()
        {
            var selectedSkin = _shopModel.SelectedSkin.Value;
            var currentSkin = _shopModel.CurrentSkin.Value;

            if (selectedSkin == currentSkin)
            {
                _image.color = _selectedColor;
            }
            else
            {
               // _image.color = _defaultColor;
            }
        }
    }
}