using System.Linq;
using Game;
using UnityEngine;

namespace Menu
{
    public class AddFirstSkinComponent : MenuComponent
    {
        private MenuModel _menuModel;
        private MenuScene _menuScene;

        public override void Initialize(MenuModel menuModel, MenuScene menuScene)
        {
            _menuModel = menuModel;
            _menuScene = menuScene;

            var stringBoughtSkins = PlayerPrefs.GetString(Constants.BoughtSkins);

            if (string.IsNullOrEmpty(stringBoughtSkins))
            {
                PlayerPrefs.SetString(Constants.BoughtSkins, "0");
            }
        }
    }
}