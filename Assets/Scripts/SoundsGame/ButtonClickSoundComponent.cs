using UnityEngine;
using UnityEngine.UI;

namespace SoundsGame
{
    public class ButtonClickSoundComponent : MonoBehaviour
    {
        [SerializeField] private Button _button;
        [SerializeField] private AudioSource _clickSoundPrefab;

        private void Start()
        {
            _button.onClick.AddListener(OnClick);
        }

        private void OnDestroy()
        {
            _button.onClick.RemoveListener(OnClick);
        }

        private void OnClick()
        {
            var sound = Instantiate(_clickSoundPrefab);
            DontDestroyOnLoad(sound.gameObject);
        }
    }
}