using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Shop.SelectCharacter.SelectButton
{
    public class SelectSkinButtonChangeTextComponent : ShopComponent
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
            
            _shopModel.CurrentSkin.Changed += OnCurrentSkinChanged;
            _shopModel.SelectedSkin.Changed += OnSelectedSkinChanged;
        }

        private void OnDestroy()
        {
            _shopModel.CurrentSkin.Changed -= OnCurrentSkinChanged;
            _shopModel.SelectedSkin.Changed -= OnSelectedSkinChanged;
        }

        private void OnSelectedSkinChanged()
        {
            UpdateSelectButton();
        }

        private void OnCurrentSkinChanged()
        {
            UpdateSelectButton();
        }

        private void UpdateSelectButton()
        {
            if (_shopModel.CurrentSkin.Value == _shopModel.SelectedSkin.Value)
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