using System;
using System.Collections;
using System.Collections.Generic;
using Game;
using Player;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Barriers
{
    public class SpawnBarriersComponent : GameComponent
    {
        [SerializeField] private Transform _pointSpawn;

        private GameModel _gameModel;
        private GameScene _gameScene;

        [SerializeField] private float _distanceSpawnPeriod;
        private float _distance;

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
            
            if (_distance > _distanceSpawnPeriod)
            {
                var barrier = _gameScene.Barriers;
                var randomIndexBarrier = Random.Range(0, barrier.Length);

                var newBarrier = Instantiate(barrier[randomIndexBarrier], _pointSpawn.transform.position,
                    Quaternion.identity);

                var barrierMove = newBarrier.GetComponent<MoveBarriersComponent>();
                var triggerDamageComponent = newBarrier.GetComponent<TriggerDamageComponent>();
                    
                barrierMove.Initialize(_gameModel, _gameScene);
                triggerDamageComponent.Initialize(_gameModel, _gameScene);
                
                _distance = 0f;
            }
            else
            {
                _distance += Time.deltaTime * _gameModel.Speed;
            }
        }
    }
}