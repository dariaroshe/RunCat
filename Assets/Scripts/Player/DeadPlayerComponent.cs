using System;
using Game;
using UnityEngine;

namespace Player
{
    public class DeadPlayerComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;

        public override void Initialize(GameModel gameModel, GameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;

            _gameModel.Health.Changed += OnHealthChanged;
        }

        private void OnDestroy()
        {
            _gameModel.Health.Changed -= OnHealthChanged;
        }

        private void OnHealthChanged(int old, int current)
        {
            if (_gameModel.Health.Value == 0)
            {
                // gameState.Value = GameState.GameOver;
            }
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.TryGetComponent<RunPlayerComponent>(out var cat))
            {
               // gameState.Value = GameState.GameOver;
            }
        }
    }
}