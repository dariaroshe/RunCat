using System;
using UnityEngine;

namespace Game
{
    public class AudioActiveComponent : MonoBehaviour
    {
        private void Start()
        {
            var audio = PlayerPrefs.GetInt(Constants.Audio, 1);

            if (audio == 1)
            {
                AudioListener.volume = 1;
            }
            else if (audio == 0)
            {
                AudioListener.volume = 0;
            }
        }
    }
}