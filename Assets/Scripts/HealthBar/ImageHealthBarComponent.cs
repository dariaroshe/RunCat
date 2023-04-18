using System;
using Game;
using UnityEngine;
using UnityEngine.UI;

namespace HealthBar
{
    public class ImageHealthBarComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;

        [SerializeField] private Image[] _images;
        
        public override void Initialize(GameModel gameModel, GameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;
            
            UpdateHealthBar();
            
            _gameModel.Health.Changed += OnHealthChanged;
        }

        private void OnDestroy()
        {
            _gameModel.Health.Changed -= OnHealthChanged;
        }

        private void OnHealthChanged(int old, int current)
        {
            UpdateHealthBar();
        }

        private void UpdateHealthBar()
        {
            var currentHealth = _gameModel.Health.Value;
            
            for (int i = 0; i < _images.Length; i++)
            {
                if (i < currentHealth)
                {
                    _images[i].enabled = true;
                }
                else
                {
                    _images[i].enabled = false;
                }
            }
        }
    }
}