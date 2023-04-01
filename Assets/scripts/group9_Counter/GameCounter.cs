﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// 카운터 본체
public class GameCounter : MonoBehaviour
{

    public static int value; // 공유하는 카운터의 값
    
    public int startCount = 0; // 카운터 초깃값 : Inspector에 지정
    public int endCount = 10;
    public string sceneName;  // 씬 이름 : Inspector에 지정

    void Start()// 처음에 시행한다
    { 
        value = startCount;// 카운터를 리셋
    }

    private void Update()
    {
        if(value >= endCount)
        {
            SceneManager.LoadScene(sceneName);
        }
    }

}
