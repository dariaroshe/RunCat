using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Shop.SelectBackground.SelectButton
{
    public class SelectBackgroundButtonChangeTextComponent : ShopComponent
    {
        private ShopModel _shopModel;
        private ShopScene _shopScene;

        [SerializeField] private TextMeshProUGUI _text;
        [SerializeField] private Button _button;

        public override void Initialize(ShopModel shopModel, ShopScene shopScene)
        {
            _shopModel = shopModel;
            _shopScene = shopScene;
            
            UpdateSelectButton();
            
            _shopModel.CurrentBackground.Changed += OnCurrentBackgroundChanged;
            _shopModel.SelectedBackground.Changed += OnSelectedBackgroundChanged;
        }

        private void OnDestroy()
        {
            _shopModel.CurrentBackground.Changed -= OnCurrentBackgroundChanged;
            _shopModel.SelectedBackground.Changed -= OnSelectedBackgroundChanged;
        }

        private void OnSelectedBackgroundChanged()
        {
            UpdateSelectButton();
        }

        private void OnCurrentBackgroundChanged()
        {
            UpdateSelectButton();
        }

        private void UpdateSelectButton()
        {
            if (_shopModel.CurrentBackground.Value == _shopModel.SelectedBackground.Value)
            {
                _text.text = $"ВЫБРАНО";
                _button.interactable = false;
            }
            else
            {
                _text.text = $"ВЫБРАТЬ";
                _button.interactable = true;
            }
        }
    }
}