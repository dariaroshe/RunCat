using Background;
using Shop.SelectBackground.Backgrounds;
using UnityEngine;

namespace Menu
{
    public class MenuScene : MonoBehaviour
    {
        public BackgroundCollectionInfo BackgroundCollectionInfo;

        public AddFirstSkinComponent AddFirstSkinComponent;
        public AddFirstBackgroundComponent AddFirstBackgroundComponent;
        
        public MenuMoveBackgroundComponent[] MenuMoveBackgroundComponent;

        public StartButtonComponent StartButtonComponent;
        public ShopButtonComponent ShopButtonComponent;

        public MaxPointsTextComponent MaxPointsTextComponent;

        public float BackgroundSpeed;
        
        public SpriteRenderer[] Backgrounds;
        public ChangeBackgroundComponent ChangeBackgroundComponent;
    }
}