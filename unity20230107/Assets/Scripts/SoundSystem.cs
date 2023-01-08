using UnityEngine;

namespace JAY
{
    [RequireComponent(typeof(AudioSource))]
    public class SoundSystem : MonoBehaviour
    {
        private AudioSource aud;
        private void Awake()
        {
            aud = GetComponent<AudioSource>();
        }

        /// <summary>
        /// ���񭵼�
        /// </summary>
        /// <param name="sound">�n���񪺭���</param>
        public void PlaySound(AudioClip sound)
        {
            aud.PlayOneShot(sound);
        }
    }
}