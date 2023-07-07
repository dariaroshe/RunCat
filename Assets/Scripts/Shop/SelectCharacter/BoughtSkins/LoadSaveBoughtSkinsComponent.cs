using Game;
using UnityEngine;

namespace Shop.SelectCharacter.BoughtSkins
{
    public class LoadSaveBoughtSkinsComponent : ShopComponent
    {
        private ShopModel _shopModel;
        private ShopScene _shopScene;

        public override void Initialize(ShopModel shopModel, ShopScene shopScene)
        {
            _shopModel = shopModel;
            _shopScene = shopScene;

            var stringBoughtSkins = PlayerPrefs.GetString(Constants.BoughtSkins).Split(' ');

            for (int i = 0; i < stringBoughtSkins.Length; i++)
            {
                if (int.TryParse(stringBoughtSkins[i], out int element))
                {
                    _shopModel.BoughtSkins.Add(element);
                }
            }
        }
    }
}