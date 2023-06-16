using System;
using Game;
using UnityEngine;

namespace Player
{
    public class PlayerDeadAnimationComponent : GameComponent
    {
        private static readonly int Dead = Animator.StringToHash("Dead");

        private GameModel _gameModel;
        private GameScene _gameScene;

        [SerializeField] private Animator _playerAnimator;

        public override void Initialize(GameModel gameModel, GameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;

            _gameModel.GameState.Changed += OnGameStateChanged;
        }

        private void OnDestroy()
        {
            _gameModel.GameState.Changed -= OnGameStateChanged;
        }

        private void OnGameStateChanged()
        {
            var gameState = _gameModel.GameState;

            if (gameState.Value == GameState.GameOver)
            {
                _playerAnimator.SetTrigger(Dead);
            }
        }

    }
}