using UnityEngine;

namespace Shop.Screens
{
    public class CanvasGroupAnimationComponent : MonoBehaviour
    {
        private float _targetAlpha;
        
        [SerializeField] private CanvasGroup _canvasGroup;
        [SerializeField] private float _speed;
        
        public void SetEnable(bool enable)
        {
            if (enable)
            {
                _targetAlpha = 1f;
                _canvasGroup.interactable = true;
                _canvasGroup.blocksRaycasts = true;
            }
            else
            {
                _targetAlpha = 0f;
                _canvasGroup.interactable = false;
                _canvasGroup.blocksRaycasts = false;
            }
        }

        private void Update()
        {
            _canvasGroup.alpha = Mathf.Lerp(_canvasGroup.alpha, _targetAlpha, _speed * Time.deltaTime);
        }
    }
}