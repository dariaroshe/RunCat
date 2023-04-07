using UnityEngine;

namespace Game
{
    public class TriggerDestroyComponent : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            Destroy(other.gameObject);
        }
    }
}