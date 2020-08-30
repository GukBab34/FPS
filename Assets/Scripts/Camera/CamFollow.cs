using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    // 타겟 게임오브젝트
    public GameObject target;

    private void Update()
    {
        // 1. 카메라의 위치를 타겟의 위치에 대입시킨다
        this.transform.position = target.transform.position;
    }
}
