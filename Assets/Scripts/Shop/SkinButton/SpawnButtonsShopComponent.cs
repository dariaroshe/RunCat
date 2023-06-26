using UnityEngine;

namespace Shop.SkinButton
{
    public class SpawnButtonsShopComponent : ShopComponent
    {
        private ShopModel _shopModel;
        private ShopScene _shopScene;

        [SerializeField] private SkinButtonShopComponent _prefab;
        [SerializeField] private Transform _spawnTransform;

        public override void Initialize(ShopModel shopModel, ShopScene shopScene)
        {
            _shopModel = shopModel;
            _shopScene = shopScene;

            for (int i = 0; i < _shopScene.SkinsCollectionInfo.Skins.Count; i++)
            {
                var button = Instantiate(_prefab,_spawnTransform);
                button.Initialize(_shopModel, _shopScene, i);
            }
        }
    }
}