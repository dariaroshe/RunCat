using System;
using Game;
using UnityEngine;

namespace Barriers
{
    public class TriggerDestroyBarriersComponent : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            Destroy(other.gameObject);
        }
    }
}