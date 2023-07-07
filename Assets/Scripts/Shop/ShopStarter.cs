using Game;
using UnityEngine;

namespace Shop
{
    public class ShopStarter : MonoBehaviour
    {
        public ShopScene ShopScene;

        private void Start()
        {
            var shopModel = new ShopModel();

            shopModel.GameCurrency.Value = PlayerPrefs.GetInt(Constants.GameCurrency);

            for (int i = 0; i < ShopScene.ShopMoveBackgroundComponent.Length; i++)
            {
                ShopScene.ShopMoveBackgroundComponent[i].Initialize(shopModel, ShopScene);
            }
            
            ShopScene.SpawnButtonsShopComponent.Initialize(shopModel, ShopScene);
            
            ShopScene.ChangeSkinComponent.Initialize(shopModel, ShopScene);
            
            ShopScene.SaveCurrentSkinComponent.Initialize(shopModel, ShopScene);
            ShopScene.SetCurrentSkinComponent.Initialize(shopModel, ShopScene);
            
            ShopScene.ChangeGameCurrencyComponent.Initialize(shopModel, ShopScene);
            
            ShopScene.BuyButtonSpendCurrencyComponent.Initialize(shopModel, ShopScene);
            ShopScene.ShowBuyButtonComponent.Initialize(shopModel, ShopScene);
            
            ShopScene.ShopSaveCurrencyComponent.Initialize(shopModel, ShopScene);
            
            ShopScene.SaveBoughtSkinsComponent.Initialize(shopModel, ShopScene);
            ShopScene.LoadSaveBoughtSkinsComponent.Initialize(shopModel, ShopScene);
            
            ShopScene.SelectButtonChangedTextComponent.Initialize(shopModel, ShopScene);
        }
    }
}