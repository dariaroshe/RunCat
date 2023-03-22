using Game;
using UnityEngine;

namespace Background
{
    public class MoveBackgroundComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;

        [Range(-1f, 1f)] [SerializeField] private float _parallaxFactor;
        [SerializeField] private Material _material;
        [SerializeField] private float _speedReduce = 15f;

        private float _offset;
        
        private static readonly int MainTex = Shader.PropertyToID("_MainTex");

        public override void Initialize(GameModel gameModel, GameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;
        }

        private void Update()
        {
            var speed = _gameModel.Speed;
            var gameState = _gameModel.GameState.Value;

            if (gameState == GameState.Playing)
            {
                _offset += (_parallaxFactor * speed * Time.deltaTime) / _speedReduce;
                _material.SetTextureOffset(MainTex, new Vector2(_offset, 0));
            }
        }
    }
}