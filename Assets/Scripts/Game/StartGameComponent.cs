using System.Collections;
using UnityEngine;

namespace Game
{
    public class StartGameComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;

        public override void Initialize(GameModel gameModel, GameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;

            StartCoroutine(StartGame());
        }
        
        private IEnumerator StartGame()
        {
            var countdown = _gameModel.Countdown;
            
            if (_gameModel.GameState.Value == GameState.Start)
            {
                _gameScene.SoundsComponent.CountdownTickSound.Play();
                yield return new WaitForSeconds(1);
                countdown.Value--;
                
                _gameScene.SoundsComponent.CountdownTickSound.Play();
                yield return new WaitForSeconds(1);
                countdown.Value--;
                
                _gameScene.SoundsComponent.CountdownTickSound.Play();
                yield return new WaitForSeconds(1);
                countdown.Value--;
                
                _gameScene.SoundsComponent.CountdownGoSound.Play();
                yield return new WaitForSeconds(0.3f);
                _gameModel.GameState.Value = GameState.Playing;
            }
        }
    }
}