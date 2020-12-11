using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public int enemyCount;
    public GameObject[] enemyPrefab;
    public GameObject player;

    void Update()
    {
        enemyCount = FindObjectsOfType<EnemyWalk>().Length;

        if (enemyCount == 0 && GameplayController.Instance.GameIsActive)
        {
            var enemy = GenerateRandomEnemy();
            Instantiate(enemy, GenerateSpawnPosition(), enemy.transform.rotation);
            //enemy.GetComponent<AudioSource>().FadeIn(3);
            //StartCoroutine(PlayWakeUpSound(enemy));
        }
    }

    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(25, 50);
        return new Vector3(player.transform.position.x + spawnPosX, 10, 0.5f);
    }

    private GameObject GenerateRandomEnemy()
    {
        int i = Random.Range(0, enemyPrefab.Length);
        return enemyPrefab[i];
    }
}
