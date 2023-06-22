using Game;
using UnityEngine;

namespace SaveGame
{
    public class SaveGameCurrencyComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;

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
            if (_gameModel.GameState.Value == GameState.GameOver)
            {
                var gameCurrency = _gameModel.GameCurrency.Value;
                var maxGameCurrency = PlayerPrefs.GetInt("maxGameCurrency", 0);

                var sumGameCurrency = gameCurrency + maxGameCurrency;

                PlayerPrefs.SetInt("maxGameCurrency", sumGameCurrency);
            }
        }
    }
}