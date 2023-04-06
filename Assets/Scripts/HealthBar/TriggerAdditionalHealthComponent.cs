using System;
using Game;
using Player;
using UnityEngine;

namespace HealthBar
{
    public class TriggerAdditionalHealthComponent : GameComponent
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
            if (other.TryGetComponent<RunPlayerComponent>(out var cat))
            {
                _gameModel.Health.Value++;
                Destroy(gameObject);
            }
        }
    }
}