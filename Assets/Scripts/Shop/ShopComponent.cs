using UnityEngine;

namespace Shop
{
    public abstract class ShopComponent : MonoBehaviour
    {
        public abstract void Initialize(ShopModel shopModel, ShopScene shopScene);
    }
}