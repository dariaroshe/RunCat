using Game;
using UnityEngine;

namespace AccelerationPlayer
{
    public class MoveAccelerationComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;

        [SerializeField] private GameObject _acceleration;

        public override void Initialize(GameModel gameModel, GameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;
        }

        private void FixedUpdate()
        {
            var speed = _gameModel.Speed;
            var gameState = _gameModel.GameState.Value;
            var accelerationPosition = _acceleration.transform.position;

            if (gameState == GameState.Playing)
            {
                var moveX = accelerationPosition.x - speed * Time.deltaTime;
                _acceleration.transform.position = new Vector3(moveX, accelerationPosition.y, accelerationPosition.z);
            }
        }
    }
}