using Game;
using UnityEngine;

namespace Background
{
    public class MoveBackgroundComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;
        
        [Range(0f, 1f)]
        [SerializeField] private float _parallaxFactor = 1f;
        [SerializeField] private float _minX;
        [SerializeField] private float _startPlatformPositionX;

        public override void Initialize(GameModel gameModel, GameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;
        }

        private void FixedUpdate()
        {
            var speed = _gameModel.Speed;
            var gameState = _gameModel.GameState.Value;

            if (gameState == GameState.Playing)
            {
                transform.position += Vector3.left * (_parallaxFactor * speed * Time.deltaTime);

                if (transform.position.x <= _minX)
                {
                    var position = transform.position;

                    var offset = _startPlatformPositionX - (_minX - position.x);
                    transform.position = new Vector3(offset, position.y, position.z);
                }
            }
        }
    }
}