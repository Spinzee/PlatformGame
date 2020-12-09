using UnityEngine;

public class PlayParticles : MonoBehaviour
{
    public ParticleSystem explosionParticle;

    public void PlayParticle(Vector3 position)
    {
        transform.position = position;
        explosionParticle.Play();
    }
}
