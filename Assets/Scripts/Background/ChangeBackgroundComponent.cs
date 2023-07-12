using Game;
using Shop.SelectBackground.Backgrounds;
using UnityEngine;

namespace Background
{
    public class ChangeBackgroundComponent : MonoBehaviour
    {
        private SpriteRenderer[] _spriteRenderers;
        
        public void Initialize(SpriteRenderer[] spriteRenderers, BackgroundCollectionInfo backgroundCollectionInfo)
        {
            _spriteRenderers = spriteRenderers;

            var currentBackgroundIndex = PlayerPrefs.GetInt(Constants.CurrentBackgroundKey, 0);
            
            var background = backgroundCollectionInfo.Backgrounds[currentBackgroundIndex];

            for (var i = 0; i < background.BackgroundsSprite.Length; i++)
            {
                var sprite = background.BackgroundsSprite[i];
                _spriteRenderers[i].sprite = sprite;
            }
        }
    }
}