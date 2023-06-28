using UnityEngine;

namespace Menu
{
    public class MenuScene : MonoBehaviour
    {
        public AddFirstSkinComponent AddFirstSkinComponent;
        
        public MenuMoveBackgroundComponent[] MenuMoveBackgroundComponent;

        public StartButtonComponent StartButtonComponent;
        public ShopButtonComponent ShopButtonComponent;

        public MaxPointsTextComponent MaxPointsTextComponent;

        public float BackgroundSpeed;
    }
}