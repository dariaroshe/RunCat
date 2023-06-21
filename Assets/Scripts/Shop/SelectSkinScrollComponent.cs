using System;
using UnityEngine;
using UnityEngine.UI;

namespace Shop
{
    public class SelectSkinScrollComponent : MonoBehaviour
    {
        private ShopModel _shopModel;
        private ShopScene _shopScene;
        private int _skinIndex;

        [SerializeField] private Button _button;

        public void Initialize(ShopModel shopModel, ShopScene shopScene, int skinIndex)
        {
            _shopModel = shopModel;
            _shopScene = shopScene;
            _skinIndex = skinIndex;
            
            _button.onClick.AddListener(OnClicked);
        }

        private void OnDestroy()
        {
            _button.onClick.RemoveListener(OnClicked);
        }

        private void OnClicked()
        {
            _shopModel.CurrentSkin.Value = _skinIndex;
        }
    }
}