using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatWidth;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //if (player.transform.position.x < startPos.x - repeatWidth)
        //{
        //    transform.position = startPos;
        //}
    }
}
