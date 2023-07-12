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
            
            MenuScene.AddFirstSkinComponent.Initialize(menuModel, MenuScene);
            MenuScene.AddFirstBackgroundComponent.Initialize(menuModel, MenuScene);

            for (int i = 0; i < MenuScene.MenuMoveBackgroundComponent.Length; i++)
            {
                MenuScene.MenuMoveBackgroundComponent[i].Initialize(menuModel, MenuScene);
            }
            
            MenuScene.StartButtonComponent.Initialize(menuModel, MenuScene);
            MenuScene.ShopButtonComponent.Initialize(menuModel, MenuScene);
            
            MenuScene.MaxPointsTextComponent.Initialize(menuModel, MenuScene);
            
            MenuScene.ChangeBackgroundComponent.Initialize(MenuScene.Backgrounds, MenuScene.BackgroundCollectionInfo);
        }
    }
}