using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemy : MonoBehaviour
{
    [SerializeField] ParticleSystem smokeFX;
    [SerializeField] AudioClip deathSound;

    EnemyFX enemyFX;

    private void Awake()
    {
        enemyFX = GameObject.Find("Enemy").GetComponent<EnemyFX>();
    }

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
            enemyFX.PlayDeathSound(deathSound);
            GameplayController.Instance.IncrementScore();
            enemyFX.PlayParticle(gameObject.transform.position, smokeFX);
            Destroy(gameObject);
        }
    }
}
