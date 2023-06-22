using Skins;
using UnityEngine;

namespace Shop
{
    public class ShopScene : MonoBehaviour
    {
        public ShopMoveBackgroundComponent[] ShopMoveBackgroundComponent;

        public SkinsCollectionInfo SkinsCollectionInfo;

        public SpawnButtonsShopComponent SpawnButtonsShopComponent;

        public ChangeSkinComponent ChangeSkinComponent;

        public SaveCurrentSkinComponent SaveCurrentSkinComponent;

        public MaxGameCurrencyComponent MaxGameCurrencyComponent;
        
        public float BackgroundSpeed;
    }
}