using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemy : MonoBehaviour
{
    void Update()
    {
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Pickle"))
        {
            var particle = GameObject.Find("Particles").GetComponent<PlayParticles>();
            particle.PlayParticle(gameObject.transform.position);

            Destroy(gameObject);

            GameplayController.Instance.IncrementScore();
        }
        else if (collision.collider.CompareTag("Player"))
        {
            // anim player die
            GameplayController.Instance.DecrementLife();
        }
    }
}
