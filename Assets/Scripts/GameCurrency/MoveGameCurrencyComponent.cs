using Game;
using UnityEngine;

namespace GameCurrency
{
    public class MoveGameCurrencyComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;

        [SerializeField] private GameObject _gameCurrency;

        public override void Initialize(GameModel gameModel, GameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;
        }

        private void FixedUpdate()
        {
            var speed = _gameModel.Speed;
            var gameState = _gameModel.GameState.Value;
            var gameCurrencyPosition = _gameCurrency.transform.position;

            if (gameState == GameState.Playing)
            {
                var moveX = gameCurrencyPosition.x - speed * Time.deltaTime;
                _gameCurrency.transform.position = new Vector3(moveX, gameCurrencyPosition.y, gameCurrencyPosition.z);
            }
        }
    }
}