using Game;
using UnityEngine;

namespace Menu
{
    public class MenuMoveBackgroundComponent : MenuComponent
    {
        private MenuModel _menuModel;
        private MenuScene _menuScene;

        [Range(0f, 1f)] [SerializeField] private float _parallaxFactor = 1f;
        [SerializeField] private float _minX;
        [SerializeField] private float _startPlatformPositionX;

        public override void Initialize(MenuModel menuModel, MenuScene menuScene)
        {
            _menuModel = menuModel;
            _menuScene = menuScene;
        }
        
        private void FixedUpdate()
        {
            var speed = _menuScene.BackgroundSpeed;
            
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