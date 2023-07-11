using System;
using Game;
using UnityEngine;

namespace Shop.SelectBackground.BoughtBackgrounds
{
    public class SaveBoughtBackgroundsComponent : ShopComponent
    {
        private ShopModel _shopModel;
        private ShopScene _shopScene;

        public override void Initialize(ShopModel shopModel, ShopScene shopScene)
        {
            _shopModel = shopModel;
            _shopScene = shopScene;

            _shopModel.BoughtBackgrounds.ItemAdded += OnItemAdded;
        }

        private void OnDestroy()
        {
            _shopModel.BoughtBackgrounds.ItemAdded -= OnItemAdded;
        }

        private void OnItemAdded(int obj)
        {
            var stringBoughtBackgrounds = String.Join(" ", _shopModel.BoughtBackgrounds);

            PlayerPrefs.SetString(Constants.BoughtBackgrounds, stringBoughtBackgrounds);
        }
    }
}