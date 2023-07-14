using UnityEngine;

namespace Shop.Screens
{
    public class ShowScreenComponent : ShopComponent
    {
        private ShopModel _shopModel;
        private ShopScene _shopScene;

        [SerializeField] private CanvasGroupAnimationComponent[] _canvasGroups;
        
        public override void Initialize(ShopModel shopModel, ShopScene shopScene)
        {
            _shopModel = shopModel;
            _shopScene = shopScene;
            
            UpdateScreen();
            
            _shopModel.CurrentScreen.Changed += OnCurrentScreenChanged;
        }

        private void OnDestroy()
        {
            _shopModel.CurrentScreen.Changed -= OnCurrentScreenChanged;
        }

        private void OnCurrentScreenChanged()
        {
            UpdateScreen();
        }

        private void UpdateScreen()
        {
            foreach (var canvasGroup in _canvasGroups)
            {
                canvasGroup.SetEnable(false);
            }

            var currentScreenIndex = (int)_shopModel.CurrentScreen.Value;
            
            _canvasGroups[currentScreenIndex].SetEnable(true);
        }
    }
}