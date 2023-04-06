using Game;
using Player;
using UnityEngine;

namespace Barriers
{
    public class TriggerDamageComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;

        public override void Initialize(GameModel gameModel, GameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent<RunPlayerComponent>(out var barrier))
            {
                _gameModel.Health.Value--;
            }
        }
    }
}