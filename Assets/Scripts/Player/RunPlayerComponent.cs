using System;
using Game;
using UnityEngine;

namespace Player
{
    public class RunPlayerComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;

        [SerializeField] private Animator _playerAnimator;

        private static readonly int IsMoving = Animator.StringToHash("IsMoving");

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
            
            if (gameState.Value == GameState.Playing)
            {
                _playerAnimator.SetBool(IsMoving, true);
                _playerAnimator.speed = 1f;
            }
            else
            {
                _playerAnimator.speed = 0f;
            }
        }
    }
}