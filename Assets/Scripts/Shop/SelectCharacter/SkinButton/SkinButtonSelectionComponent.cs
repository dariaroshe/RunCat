using UnityEngine;
using Image = UnityEngine.UI.Image;

namespace Shop.SelectCharacter.SkinButton
{
    public class SkinButtonSelectionComponent : MonoBehaviour
    {
        private ShopModel _shopModel;
        private ShopScene _shopScene;
        private int _skinIndex;

        [SerializeField] private Image _image;
        [SerializeField] private Color _defaultColor;
        [SerializeField] private Color _selectedColor;
        [SerializeField] private Color _currentColor;

        public void Initialize(ShopModel shopModel, ShopScene shopScene, int skinIndex)
        {
            _shopModel = shopModel;
            _shopScene = shopScene;
            _skinIndex = skinIndex;

            UpdateColor();

            _shopModel.SelectedSkin.Changed += OnChangedSelectedSkin;
            _shopModel.CurrentSkin.Changed += OnChangedCurrentSkin;
        }

        private void OnDestroy()
        {
            _shopModel.SelectedSkin.Changed -= OnChangedSelectedSkin;
            _shopModel.CurrentSkin.Changed -= OnChangedCurrentSkin;
        }

        private void OnChangedSelectedSkin()
        {
            UpdateColor();
        }

        private void OnChangedCurrentSkin()
        {
            UpdateColor();
        }

        private void UpdateColor()
        {
            var selectedSkin = _shopModel.SelectedSkin.Value;
            var currentSkin = _shopModel.CurrentSkin.Value;

            if (selectedSkin == _skinIndex)
            {
                _image.color = _selectedColor;
            }
            else if (currentSkin == _skinIndex)
            {
                _image.color = _currentColor;
            }
            else
            {
                _image.color = _defaultColor;
            }
        }
    }
}