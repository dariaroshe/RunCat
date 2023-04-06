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

            _gameModel.Health.Changed += OnHealthChanged;
        }

        private void OnDestroy()
        {
            _gameModel.Health.Changed += OnHealthChanged;
        }

        private void OnHealthChanged()
        {
            var gameState = _gameModel.GameState.Value;
            var health = _gameModel.Health.Value;

            while (true)
            {
                if (health == 1 && gameState == GameState.Playing)
                {
                    StartCoroutine(WaitSeconds());
                    
                    var newAdditionalHealth = Instantiate(_additionalHealth, _pointSpawn.transform.position,
                        Quaternion.identity);

                    var additionalHealthMove = newAdditionalHealth.GetComponent<MoveAdditionalHealthComponent>();
                    var additionalHealthTrigger = newAdditionalHealth.GetComponent<TriggerAdditionalHealthComponent>();
                    var additionalHealthAnimation = newAdditionalHealth.GetComponent<AdditionalHealthBarAnimationComponent>();

                    additionalHealthMove.Initialize(_gameModel, _gameScene);
                    additionalHealthTrigger.Initialize(_gameModel, _gameScene);
                    additionalHealthAnimation.Initialize(_gameModel, _gameScene);
                }
            }
        }

        private IEnumerator WaitSeconds()
        {
            yield return new WaitForSeconds(60);
        }
    }
}