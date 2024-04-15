using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioSource audio;

    public void PlayAudio()
    {
        audio.Play();
    }

    public void OffAudio()
    {
        audio.Stop();
    }
}
