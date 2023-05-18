using Game;
using GameCurrency;
using UnityEngine;

namespace AccelerationPlayer
{
    public class SpawnAccelerationComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;

        [SerializeField] private Transform[] _pointSpawn;
        [SerializeField] private GameObject _acceleration;
        
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
                
                var newGameCurrency = Instantiate(_acceleration, _pointSpawn[randomSpawnPoint].transform.position,
                    Quaternion.identity);

                var moveAcceleration = newGameCurrency.GetComponent<MoveAccelerationComponent>();
                var triggerAcceleration = newGameCurrency.GetComponent<TriggerAccelerationComponent>();
                var animationAcceleration = newGameCurrency.GetComponent<AccelerationAnimationComponent>();

                moveAcceleration.Initialize(_gameModel, _gameScene);
                triggerAcceleration.Initialize(_gameModel, _gameScene);
                animationAcceleration.Initialize(_gameModel, _gameScene);

                _timer = 0f;
            }
            else
            {
                _timer += Time.deltaTime;
            }
        }
    }
}