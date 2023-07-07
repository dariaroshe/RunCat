using System;
using Game;
using UnityEngine;

namespace Shop.SelectCharacter.BoughtSkins
{
    public class SaveBoughtSkinsComponent : ShopComponent
    {
        private ShopModel _shopModel;
        private ShopScene _shopScene;

        public override void Initialize(ShopModel shopModel, ShopScene shopScene)
        {
            _shopModel = shopModel;
            _shopScene = shopScene;

            _shopModel.BoughtSkins.ItemAdded += OnItemAdded;
        }

        private void OnDestroy()
        {
            _shopModel.BoughtSkins.ItemAdded -= OnItemAdded;
        }

        private void OnItemAdded(int obj)
        {
            var stringBoughtSkins = String.Join(" ", _shopModel.BoughtSkins);
            
            PlayerPrefs.SetString(Constants.BoughtSkins, stringBoughtSkins);
        }
    }
}