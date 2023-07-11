using Game;
using UnityEngine;

namespace Shop.SelectBackground.BoughtBackgrounds
{
    public class LoadSaveBoughtBackgroundsComponent : ShopComponent
    {
        private ShopModel _shopModel;
        private ShopScene _shopScene;

        public override void Initialize(ShopModel shopModel, ShopScene shopScene)
        {
            _shopModel = shopModel;
            _shopScene = shopScene;

            var stringBoughtBackgrounds = PlayerPrefs.GetString(Constants.BoughtBackgrounds).Split(' ');

            for (int i = 0; i < stringBoughtBackgrounds.Length; i++)
            {
                if (int.TryParse(stringBoughtBackgrounds[i], out int element))
                {
                    _shopModel.BoughtBackgrounds.Add(element);
                }
            }
        }
    }
}