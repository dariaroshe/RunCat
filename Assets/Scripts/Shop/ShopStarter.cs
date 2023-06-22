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

            for (int i = 0; i < ShopScene.ShopMoveBackgroundComponent.Length; i++)
            {
                ShopScene.ShopMoveBackgroundComponent[i].Initialize(shopModel, ShopScene);
            }
            
            ShopScene.SpawnButtonsShopComponent.Initialize(shopModel, ShopScene);
            
            ShopScene.ChangeSkinComponent.Initialize(shopModel, ShopScene);
            
            ShopScene.SaveCurrentSkinComponent.Initialize(shopModel, ShopScene);
            
            ShopScene.MaxGameCurrencyComponent.Initialize(shopModel, ShopScene);
        }
    }
}