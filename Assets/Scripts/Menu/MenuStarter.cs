using System;
using UnityEngine;

namespace Menu
{
    public class MenuStarter : MonoBehaviour
    {
        public MenuScene MenuScene;

        private void Start()
        {
            var menuModel = new MenuModel();

            for (int i = 0; i < MenuScene.MenuMoveBackgroundComponent.Length; i++)
            {
                MenuScene.MenuMoveBackgroundComponent[i].Initialize(menuModel, MenuScene);
            }
            
            MenuScene.StartButtonComponent.Initialize(menuModel, MenuScene);
            
            MenuScene.MaxPointsTextComponent.Initialize(menuModel, MenuScene);
        }
    }
}