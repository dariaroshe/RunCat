using Game;
using UnityEngine;

namespace Barriers
{
    public class MoveBarriersComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;

        [SerializeField] private GameObject _barrier;

        public override void Initialize(GameModel gameModel, GameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;
        }

        private void FixedUpdate()
        {
            var speed = _gameModel.Speed;
            var gameState = _gameModel.GameState.Value;
            var barrierPosition = _barrier.transform.position;
            
            if (gameState == GameState.Playing)
            {
                var moveX = barrierPosition.x - speed * Time.deltaTime;
                _barrier.transform.position = new Vector3(moveX, barrierPosition.y, barrierPosition.z);
            }
        }
    }
}