using Game;

namespace Player
{
    public class PlayerComponent : GameComponent
    {
        public RunPlayerComponent RunPlayerComponent;
        public JumpPlayerComponent JumpPlayerComponent;
        public PlayerDeadAnimationComponent PlayerDeadAnimationComponent;
        public PlayerJumpAnimationComponent PlayerJumpAnimationComponent;
        public PlayerDamageAnimationComponent PlayerDamageAnimationComponent;
        
        private GameModel _gameModel;
        private GameScene _gameScene;

        public override void Initialize(GameModel gameModel, GameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;
            
            RunPlayerComponent.Initialize(_gameModel, _gameScene);
            JumpPlayerComponent.Initialize(_gameModel, _gameScene);
            PlayerDamageAnimationComponent.Initialize(_gameModel, _gameScene);
            PlayerDeadAnimationComponent.Initialize(_gameModel, _gameScene);
            PlayerJumpAnimationComponent.Initialize(_gameModel, _gameScene);
        }
    }
}