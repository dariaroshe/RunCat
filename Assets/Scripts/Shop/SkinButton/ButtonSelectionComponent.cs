using UnityEngine;
using Image = UnityEngine.UI.Image;

namespace Shop.SkinButton
{
    public class ButtonSelectionComponent : MonoBehaviour
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
            
            _shopModel.SelectedSkin.Changed += OnChangedSelectedSkin;
        }

        private void OnDestroy()
        {
            _shopModel.SelectedSkin.Changed -= OnChangedSelectedSkin;
        }

        private void OnChangedSelectedSkin()
        {
            UpdateColor();
        }

        private void UpdateColor()
        {
            var selectedSkin = _shopModel.SelectedSkin.Value;

            if (selectedSkin == _skinIndex)
            {
                _image.color = _selectedColor;
            }
            else
            {
                _image.color = _defaultColor;
            }
        }
    }
}