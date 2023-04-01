using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Show_RandomAfterStart : MonoBehaviour
{
    void Start()
    {
        gameObject.SetActive(false);
        Invoke("ShowSelf", Random.Range(5f, 10f));
    }

    void ShowSelf()
    {
        gameObject.SetActive(true);
    }
}
