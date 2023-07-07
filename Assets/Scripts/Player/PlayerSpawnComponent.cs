using Game;
using UnityEngine;

namespace Player
{
    public class PlayerSpawnComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;

        public override void Initialize(GameModel gameModel, GameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;

            var skinIndex = PlayerPrefs.GetInt(Constants.CurrentSkinKey, 0);
            var skinInfo = _gameScene.SkinsCollectionInfo.Skins[skinIndex];
            var prefab = skinInfo.Prefab;

            var player = Instantiate(prefab, _gameScene.PlayerPosition, Quaternion.identity);
            player.Initialize(_gameModel, _gameScene);
        }
    }
}