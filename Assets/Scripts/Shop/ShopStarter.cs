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
            ShopScene.SpawnButtonsBackgroundsComponent.Initialize(shopModel, ShopScene);
            
            ShopScene.ChangeSkinComponent.Initialize(shopModel, ShopScene);
            ShopScene.ChangeCurrentSkinBackgroundScreenComponent.Initialize(shopModel, ShopScene);
            
            ShopScene.SaveCurrentSkinComponent.Initialize(shopModel, ShopScene);
            ShopScene.SetCurrentSkinComponent.Initialize(shopModel, ShopScene);
            
            ShopScene.SaveCurrentBackgroundComponent.Initialize(shopModel, ShopScene);
            ShopScene.SetCurrentBackgroundComponent.Initialize(shopModel, ShopScene);

            for (int i = 0; i < ShopScene.ChangeGameCurrencyComponent.Length; i++)
            {
                ShopScene.ChangeGameCurrencyComponent[i].Initialize(shopModel, ShopScene);
            }

            ShopScene.BuyButtonSpendCurrencyComponent.Initialize(shopModel, ShopScene);
            ShopScene.ShowBuyButtonComponent.Initialize(shopModel, ShopScene);
            
            ShopScene.ShopSaveCurrencyComponent.Initialize(shopModel, ShopScene);
            
            ShopScene.SaveBoughtSkinsComponent.Initialize(shopModel, ShopScene);
            ShopScene.LoadSaveBoughtSkinsComponent.Initialize(shopModel, ShopScene);
            
            ShopScene.SaveBoughtBackgroundsComponent.Initialize(shopModel, ShopScene);
            ShopScene.LoadSaveBoughtBackgroundsComponent.Initialize(shopModel, ShopScene);
            
            ShopScene.SelectSkinButtonChangeTextComponent.Initialize(shopModel, ShopScene);
            
            ShopScene.SelectBackgroundButtonChangeTextComponent.Initialize(shopModel, ShopScene);
            
            ShopScene.BuyButtonSpendCurrencyBackgroundComponent.Initialize(shopModel, ShopScene);
            ShopScene.ShowBuyButtonBackgroundComponent.Initialize(shopModel, ShopScene);
        }
    }
}