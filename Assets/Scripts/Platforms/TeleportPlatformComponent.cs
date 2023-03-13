using Game;
using UnityEngine;

namespace Platforms
{
    public class TeleportPlatformComponent : GameComponent
    {
        [SerializeField] private float _minX;
        [SerializeField] private float _startPlatformPositionX;
        
        private GameModel _gameModel;
        private GameScene _gameScene;

        public override void Initialize(GameModel gameModel, GameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;
        }

        private void FixedUpdate()
        {
            var platform = _gameScene.Platforms;

            for (int i = 0; i < platform.Length; i++)
            {
                if (platform[i].position.x < _minX)
                {
                    var newPlatformPosition = new Vector3(_startPlatformPositionX, platform[i].position.y, platform[i].position.z);
                    platform[i].position = newPlatformPosition;
                }
            }
        }
    }
}