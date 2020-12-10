using UnityEngine;

public class EnemyFX : MonoBehaviour
{
    AudioSource audio;

    private void Awake()
    {
        audio = GetComponent<AudioSource>();
    }

    public void PlayParticle(Vector3 position, ParticleSystem smokeFX)
    {
        transform.position = position;
        smokeFX.Play();
    }

    public void PlayDeathSound(AudioClip sound)
    {
        audio.PlayOneShot(sound);
    }
}
