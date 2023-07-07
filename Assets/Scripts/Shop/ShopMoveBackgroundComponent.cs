using Shop.SelectCharacter;
using UnityEngine;

namespace Shop
{
    public class ShopMoveBackgroundComponent : ShopComponent
    {
        private ShopModel _shopModel;
        private ShopScene _shopScene;

        [Range(0f, 1f)] [SerializeField] private float _parallaxFactor = 1f;
        [SerializeField] private float _minX;
        [SerializeField] private float _startPlatformPositionX;

        public override void Initialize(ShopModel shopModel, ShopScene shopScene)
        {
            _shopModel = shopModel;
            _shopScene = shopScene;
        }
        
        private void FixedUpdate()
        {
            var speed = _shopScene.BackgroundSpeed;
            
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