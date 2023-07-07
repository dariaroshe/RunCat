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
            
            var background = backgroundCollectionInfo.Backgrounds[1];

            for (var i = 0; i < background.BackgroundsSprite.Length; i++)
            {
                var sprite = background.BackgroundsSprite[i];
                _spriteRenderers[i].sprite = sprite;
            }
        }
    }
}