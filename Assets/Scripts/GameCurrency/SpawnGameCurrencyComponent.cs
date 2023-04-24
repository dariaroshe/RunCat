using System;
using System.Collections;
using System.Collections.Generic;
using Game;
using HealthBar;
using UnityEngine;
using Random = UnityEngine.Random;

namespace GameCurrency
{
    public class SpawnGameCurrencyComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;

        [SerializeField] private Transform[] _pointSpawn;
        [SerializeField] private GameObject _gameCurrency;
        
        [SerializeField] private float _spawnPeriod;
        private float _timer;

        public override void Initialize(GameModel gameModel, GameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;
        }

        private void Update()
        {
            var gameState = _gameModel.GameState.Value;

            if (gameState != GameState.Playing)
            {
                return;
            }
            
            if (_timer > _spawnPeriod)
            {
                var randomSpawnPoint = Random.Range(0, _pointSpawn.Length);

                
                    var newGameCurrency = Instantiate(_gameCurrency, _pointSpawn[randomSpawnPoint].transform.position,
                        Quaternion.identity);

                    var moveGameCurrency = newGameCurrency.GetComponent<MoveGameCurrencyComponent>();
                    var triggerGameCurrency = newGameCurrency.GetComponent<TriggerGameCurrencyComponent>();
                    var animationGameCurrency = newGameCurrency.GetComponent<GameCurrencyAnimationComponent>();

                    moveGameCurrency.Initialize(_gameModel, _gameScene);
                    triggerGameCurrency.Initialize(_gameModel, _gameScene);
                    animationGameCurrency.Initialize(_gameModel, _gameScene);
                

                _timer = 0f;
            }
            else
            {
                _timer += Time.deltaTime;
            }
        }
    }
}