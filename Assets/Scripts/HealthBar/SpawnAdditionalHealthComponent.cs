using System;
using System.Collections;
using Game;
using UnityEngine;

namespace HealthBar
{
    public class SpawnAdditionalHealthComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;

        [SerializeField] private Transform _pointSpawn;
        [SerializeField] private GameObject _additionalHealth;

        public override void Initialize(GameModel gameModel, GameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;

            StartCoroutine(SpawnAdditionalHealth());
        }

        private IEnumerator SpawnAdditionalHealth()
        {
            while (true)
            {
                var gameState = _gameModel.GameState.Value;

                if (_gameModel.Health.Value == 1 && gameState == GameState.Playing)
                {
                    yield return new WaitForSeconds(5);
                    
                    var newAdditionalHealth = Instantiate(_additionalHealth, _pointSpawn.transform.position,
                        Quaternion.identity);

                    var additionalHealthMove = newAdditionalHealth.GetComponent<MoveAdditionalHealthComponent>();
                    var additionalHealthTrigger = newAdditionalHealth.GetComponent<TriggerAdditionalHealthComponent>();
                    var additionalHealthAnimation = newAdditionalHealth.GetComponent<AdditionalHealthBarAnimationComponent>();

                    additionalHealthMove.Initialize(_gameModel, _gameScene);
                    additionalHealthTrigger.Initialize(_gameModel, _gameScene);
                    additionalHealthAnimation.Initialize(_gameModel, _gameScene);
                }

                yield return null;
            }
        }
    }
}