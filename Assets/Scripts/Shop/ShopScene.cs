using Shop.SelectCharacter;
using Shop.SelectCharacter.BoughtSkins;
using Shop.SelectCharacter.BuyButton;
using Shop.SelectCharacter.GameCurrencyShop;
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

        public SpawnButtonsShopComponent SpawnButtonsShopComponent;

        public ChangeSkinComponent ChangeSkinComponent;

        public SaveCurrentSkinComponent SaveCurrentSkinComponent;
        public SetCurrentSkinComponent SetCurrentSkinComponent;
        
        public ShopSaveCurrencyComponent ShopSaveCurrencyComponent;
        public ChangeGameCurrencyComponent ChangeGameCurrencyComponent;

        public BuyButtonSpendCurrencyComponent BuyButtonSpendCurrencyComponent;
        public ShowBuyButtonComponent ShowBuyButtonComponent;

        public SaveBoughtSkinsComponent SaveBoughtSkinsComponent;
        public LoadSaveBoughtSkinsComponent LoadSaveBoughtSkinsComponent;

        public SelectButtonChangedTextComponent SelectButtonChangedTextComponent;

        public float BackgroundSpeed;
    }
}