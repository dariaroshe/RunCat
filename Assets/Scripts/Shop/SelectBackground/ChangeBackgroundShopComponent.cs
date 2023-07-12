using System;
using Game;
using Shop.SelectBackground.Backgrounds;
using UnityEngine;
using UnityEngine.UI;

namespace Shop.SelectBackground
{
    public class ChangeBackgroundShopComponent : MonoBehaviour
    {
        private SpriteRenderer[] _spriteRenderers;
        private BackgroundCollectionInfo _backgroundCollectionInfo;
        private ShopModel _shopModel;

        public void Initialize(ShopModel shopModel, SpriteRenderer[] spriteRenderers, BackgroundCollectionInfo backgroundCollectionInfo)
        {
            _spriteRenderers = spriteRenderers;
            _backgroundCollectionInfo = backgroundCollectionInfo;
            _shopModel = shopModel;
            
            UpdateBackground();

            _shopModel.SelectedBackground.Changed += OnSelectedBackgroundChanged;
        }

        private void OnDestroy()
        {
            _shopModel.SelectedBackground.Changed -= OnSelectedBackgroundChanged;
        }

        private void OnSelectedBackgroundChanged()
        {
           UpdateBackground();
        }

        private void UpdateBackground()
        {
            var currentBackgroundIndex = _shopModel.SelectedBackground.Value;
            
            var background = _backgroundCollectionInfo.Backgrounds[currentBackgroundIndex];

            for (var i = 0; i < background.BackgroundsSprite.Length; i++)
            {
                var sprite = background.BackgroundsSprite[i];
                _spriteRenderers[i].sprite = sprite;
            }
        }
    }
}