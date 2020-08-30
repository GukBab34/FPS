using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Destroy_Effect : MonoBehaviour
{
    // 제거시간 변수
    public float destroyTime = 1.5f;
    // 경과 시간 측정용 변수
    float currentTime = 0;

    void Update()
    {
        // 1. 경과시간을 누적한다
        currentTime += Time.deltaTime;
        // 2. 만일 현재시간이 제거시간을 초과하면
        if (currentTime > destroyTime)
        {
            // 2-1. 제거한다
            Destroy(this.gameObject);
        }
    }
}
