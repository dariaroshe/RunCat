using UnityEngine;
using UnityEngine.UI;

namespace Shop.SelectBackground.BackgroundButton
{
    public class BackgroundButtonSelectionComponent : MonoBehaviour
    {
        private ShopModel _shopModel;
        private ShopScene _shopScene;
        private int _backgroundIndex;

        [SerializeField] private Image _image;
        [SerializeField] private Color _defaultColor;
        [SerializeField] private Color _selectedColor;
        [SerializeField] private Color _currentColor;

        public void Initialize(ShopModel shopModel, ShopScene shopScene, int backgroundIndex)
        {
            _shopModel = shopModel;
            _shopScene = shopScene;
            _backgroundIndex = backgroundIndex;

            UpdateColor();

            _shopModel.SelectedBackground.Changed += OnChangedSelectedBackground;
            _shopModel.CurrentBackground.Changed += OnChangedCurrentBackground;
        }

        private void OnDestroy()
        {
            _shopModel.SelectedBackground.Changed -= OnChangedSelectedBackground;
            _shopModel.CurrentBackground.Changed -= OnChangedCurrentBackground;
        }

        private void OnChangedSelectedBackground()
        {
            UpdateColor();
        }

        private void OnChangedCurrentBackground()
        {
            UpdateColor();
        }

        private void UpdateColor()
        {
            var selectedBackground = _shopModel.SelectedBackground.Value;
            var currentBackground = _shopModel.CurrentBackground.Value;

            if (selectedBackground == _backgroundIndex)
            {
                _image.color = _selectedColor;
            }
            else if (currentBackground == _backgroundIndex)
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