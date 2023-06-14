using Game;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Buttons
{
    public class YesButtonExitComponent: GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;

        [SerializeField] private Button _button;

        public override void Initialize(GameModel gameModel, GameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;

            _button.onClick.AddListener(OnClickButton);;
        }

        private void OnDestroy()
        {
            _button.onClick.RemoveListener(OnClickButton);
        }

        private void OnClickButton()
        {
            SceneManager.LoadScene("Scenes/Menu");
        }
    }
}