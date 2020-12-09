using System.Collections;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private GameObject pickle;

    private void Awake()
    {
        pickle = GameObject.Find("Pickle");
        pickle.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        PickleWeapon();
    }

    private void PickleWeapon()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            pickle.SetActive(true);
            StartCoroutine(ShowPickleRoutine());
        }
    }

    IEnumerator ShowPickleRoutine()
    {
        yield return new WaitForSeconds(1);
        pickle.SetActive(false);
    }
}
