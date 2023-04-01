using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 충돌하면 카운터를 증가하고 자신을 지운다 
public class OnCollision_CountAndHide : MonoBehaviour
{
    
    public string targetObjectName;
    public int addValue = 1;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == targetObjectName)
        {
            GameCounter.value = GameCounter.value + addValue;
            gameObject.SetActive(false);
        }
    }
}
