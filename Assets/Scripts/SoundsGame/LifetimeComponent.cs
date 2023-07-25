using System.Collections;
using UnityEngine;

namespace SoundsGame
{
    public class LifetimeComponent : MonoBehaviour
    {
        [SerializeField] private float _lifetime;
        
        private IEnumerator Start()
        {
            yield return new WaitForSeconds(_lifetime);
            Destroy(gameObject);
        }
    }
}