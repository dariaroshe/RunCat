using Shop.SelectBackground;
using Shop.SelectBackground.BackgroundButton;
using Shop.SelectBackground.Backgrounds;
using Shop.SelectBackground.BoughtBackgrounds;
using Shop.SelectBackground.BuyButtonBackground;
using Shop.SelectBackground.SelectButton;
using Shop.SelectCharacter;
using Shop.SelectCharacter.BoughtSkins;
using Shop.SelectCharacter.BuyButton;
using Shop.SelectCharacter.SelectButton;
using Shop.SelectCharacter.SkinButton;
using Shop.SelectCharacter.Skins;
using UnityEngine;

namespace Shop
{
    public class ShopScene : MonoBehaviour
    {
        public ShopMoveBackgroundComponent[] ShopMoveBackgroundComponent;

        public SkinsCollectionInfo SkinsCollectionInfo;
        public BackgroundCollectionInfo BackgroundCollectionInfo;

        public SpawnButtonsShopComponent SpawnButtonsShopComponent;
        public SpawnButtonsBackgroundsComponent SpawnButtonsBackgroundsComponent;

        public ChangeSkinComponent ChangeSkinComponent;
        public ChangeCurrentSkinBackgroundScreenComponent ChangeCurrentSkinBackgroundScreenComponent;

        public SaveCurrentSkinComponent SaveCurrentSkinComponent;
        public SetCurrentSkinComponent SetCurrentSkinComponent;

        public SaveCurrentBackgroundComponent SaveCurrentBackgroundComponent;
        public SetCurrentBackgroundComponent SetCurrentBackgroundComponent;
        
        public ShopSaveCurrencyComponent ShopSaveCurrencyComponent;
        public ChangeGameCurrencyComponent[] ChangeGameCurrencyComponent;

        public BuyButtonSpendCurrencyComponent BuyButtonSpendCurrencyComponent;
        public ShowBuyButtonComponent ShowBuyButtonComponent;

        public SaveBoughtSkinsComponent SaveBoughtSkinsComponent;
        public LoadSaveBoughtSkinsComponent LoadSaveBoughtSkinsComponent;

        public SaveBoughtBackgroundsComponent SaveBoughtBackgroundsComponent;
        public LoadSaveBoughtBackgroundsComponent LoadSaveBoughtBackgroundsComponent;

        public SelectSkinButtonChangeTextComponent SelectSkinButtonChangeTextComponent;

        public SelectBackgroundButtonChangeTextComponent SelectBackgroundButtonChangeTextComponent;

        public BuyButtonSpendCurrencyBackgroundComponent BuyButtonSpendCurrencyBackgroundComponent;
        public ShowBuyButtonBackgroundComponent ShowBuyButtonBackgroundComponent;

        public float BackgroundSpeed;
    }
}