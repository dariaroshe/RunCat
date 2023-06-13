using Game;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Menu
{
    public class StartButtonComponent : MenuComponent
    {
        private MenuModel _menuModel;
        private MenuScene _menuScene;

        [SerializeField] private Button _button;

        public override void Initialize(MenuModel menuModel, MenuScene menuScene)
        {
            _menuModel = menuModel;
            _menuScene = menuScene;

            _button.onClick.AddListener(OnClickButton);
        }

        private void OnDestroy()
        {
            _button.onClick.RemoveListener(OnClickButton);
        }

        private void OnClickButton()
        {
            SceneManager.LoadScene("Scenes/Game");
        }
    }
}