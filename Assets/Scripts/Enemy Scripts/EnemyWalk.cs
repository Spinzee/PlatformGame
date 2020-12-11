using UnityEngine;

public class EnemyWalk : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;

    private GameObject player;

    void Awake()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (GameplayController.Instance.GameIsActive)
        {
            Walk();
        }

        DestroyEnemyIfTooFarAway();
    }

    private void Walk()
    {
        // TODO change direction of enemy
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }

    private void DestroyEnemyIfTooFarAway()
    {
        if (transform.position.x - player.transform.position.x > 30)
        {
            Destroy(gameObject);
        }
    }
}
