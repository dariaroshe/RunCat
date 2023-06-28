using Shop.BoughtSkins;
using Shop.BuyButton;
using Shop.GameCurrencyShop;
using Shop.SkinButton;
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
        public ShopSaveCurrencyComponent ShopSaveCurrencyComponent;

        public ChangeGameCurrencyComponent ChangeGameCurrencyComponent;

        public BuyButtonSpendCurrencyComponent BuyButtonSpendCurrencyComponent;

        public SaveBoughtSkinsComponent SaveBoughtSkinsComponent;
        public LoadSaveBoughtSkinsComponent LoadSaveBoughtSkinsComponent;

        public float BackgroundSpeed;
    }
}