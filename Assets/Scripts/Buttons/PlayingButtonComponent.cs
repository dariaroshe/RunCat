using System;
using Game;
using UnityEngine;
using UnityEngine.UI;

namespace Buttons
{
    public class PlayingButtonComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;

        [SerializeField] private Button _button;

        public override void Initialize(GameModel gameModel, GameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;
           
            UpdateInteractable();
            
            _gameModel.GameState.Changed += OnGameStateChanged;
        }

        private void OnDestroy()
        {
            _gameModel.GameState.Changed -= OnGameStateChanged;
        }

        private void OnGameStateChanged()
        {
            UpdateInteractable();
        }

        private void UpdateInteractable()
        {
            var gameState = _gameModel.GameState.Value;

            if (gameState == GameState.Playing)
            {
                _button.interactable = true;
            }
            else
            {
                _button.interactable = false;
            }
        }
    }
}