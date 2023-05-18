using System.Collections;
using Game;
using Player;
using UnityEngine;

namespace AccelerationPlayer
{
    public class TriggerAccelerationComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;

        [SerializeField] private float _additionalSpeed;

        public override void Initialize(GameModel gameModel, GameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.TryGetComponent<RunPlayerComponent>(out var cat))
            {
                Destroy(gameObject);

                StartCoroutine(ChangeSpeed());
            }
        }
        
        private IEnumerator ChangeSpeed()
        {
            _gameModel.Speed += _additionalSpeed;
            
            yield return new WaitForSeconds(15);

            _gameModel.Speed -= _additionalSpeed;
        }
    }
}