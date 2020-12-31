using System.Collections.Generic;
using UnityEngine;

public class GoOffScreen : MonoBehaviour
{
    public List<GameObject> MoveObjects;

    public void MoveOffScreen()
    {
        foreach (GameObject obj in MoveObjects)
        {
            obj.GetComponent<Animator>().SetBool("onScreen", false);
        }
    }

    public void MoveOnScreen()
    {
        foreach (GameObject obj in MoveObjects)
        {
            obj.GetComponent<Animator>().SetBool("onScreen", true);
        }
    }
}