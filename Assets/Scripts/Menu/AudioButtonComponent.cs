using System;
using Game;
using UnityEngine;
using UnityEngine.UI;

namespace Menu
{
    public class AudioButtonComponent : MenuComponent
    {
        private MenuModel _menuModel;
        private MenuScene _menuScene;

        [SerializeField] private Button _buttonOff;
        [SerializeField] private Button _buttonOn;

        public override void Initialize(MenuModel menuModel, MenuScene menuScene)
        {
            _menuModel = menuModel;
            _menuScene = menuScene;

            var audio = PlayerPrefs.GetInt(Constants.Audio, 1);
            
            if (audio == 1)
            {
                _buttonOff.gameObject.SetActive(true);
                _buttonOn.gameObject.SetActive(false);
            }
            else if(audio == 0)
            {
                _buttonOff.gameObject.SetActive(false);
                _buttonOn.gameObject.SetActive(true);
            }

            _buttonOff.onClick.AddListener(OnClickButtonOff);
            _buttonOn.onClick.AddListener(OnClickButtonOn);
        }

        private void OnDestroy()
        {
            _buttonOff.onClick.RemoveListener(OnClickButtonOff);
            _buttonOn.onClick.RemoveListener(OnClickButtonOn);
        }

        private void OnClickButtonOff()
        {
            AudioListener.volume = 0f;
            PlayerPrefs.SetInt(Constants.Audio, 0);
            _buttonOn.gameObject.SetActive(true);
            _buttonOff.gameObject.SetActive(false);
        }
        
        private void OnClickButtonOn()
        {
            AudioListener.volume = 1f;
            PlayerPrefs.SetInt(Constants.Audio, 1);
            _buttonOn.gameObject.SetActive(false);
            _buttonOff.gameObject.SetActive(true);
        }
    }
}