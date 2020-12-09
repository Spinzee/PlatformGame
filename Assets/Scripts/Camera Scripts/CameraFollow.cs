using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;

    private float minX = 0f, maxX = 195f;

    void Awake()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        FollowPlayer();
    }

    private void FollowPlayer()
    {
        //if (playerScore.isAlive)
        //{
        Vector3 temp = transform.position;
        temp.x = player.transform.position.x + 11;

        if (temp.x < minX)
        {
            temp.x = minX;
        }

        if (temp.x > maxX)
        {
            temp.x = maxX;
        }

        temp.y = 5f;

        transform.position = temp;

        //}
    }

}
