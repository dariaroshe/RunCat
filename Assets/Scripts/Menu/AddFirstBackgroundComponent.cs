using Game;
using UnityEngine;

namespace Menu
{
    public class AddFirstBackgroundComponent : MenuComponent
    {
        private MenuModel _menuModel;
        private MenuScene _menuScene;

        public override void Initialize(MenuModel menuModel, MenuScene menuScene)
        {
            _menuModel = menuModel;
            _menuScene = menuScene;

            var stringBoughtBackground = PlayerPrefs.GetString(Constants.BoughtBackgrounds);

            if (string.IsNullOrEmpty(stringBoughtBackground))
            {
                PlayerPrefs.SetString(Constants.BoughtBackgrounds, "0");
            }
        }
    }
}