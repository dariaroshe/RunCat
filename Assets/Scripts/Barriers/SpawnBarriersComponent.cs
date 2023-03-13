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

        public override void Initialize(GameModel gameModel, GameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;

            StartCoroutine(SpawnBarriers());
        }

        private IEnumerator SpawnBarriers()
        {
            while (true)
            {
                var gameState = _gameModel.GameState;
                var barrier = _gameScene.Barriers;

                var randomIndexBarrier = Random.Range(0, barrier.Length);

                if (gameState.Value == GameState.Playing)
                {
                    var newBarrier = Instantiate(barrier[randomIndexBarrier], _pointSpawn.transform.position,
                        Quaternion.identity);

                    var barrierMove = newBarrier.GetComponent<MoveBarriersComponent>();
                    var barrierDeadTrigger = newBarrier.GetComponent<TriggerDeadCatComponent>();
                    
                    barrierMove.Initialize(_gameModel, _gameScene);
                    barrierDeadTrigger.Initialize(_gameModel, _gameScene);
                }

                yield return new WaitForSeconds(4f);
            }
        }
    }
}