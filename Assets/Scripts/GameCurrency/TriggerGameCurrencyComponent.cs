using Game;
using Player;
using UnityEngine;

namespace GameCurrency
{
    public class TriggerGameCurrencyComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;

        public override void Initialize(GameModel gameModel, GameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.TryGetComponent<RunPlayerComponent>(out var cat))
            {
                _gameModel.GameCurrency.Value++;
                Destroy(gameObject);
            }
        }
    }
}