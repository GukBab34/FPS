using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombAction : MonoBehaviour
{
    // 폭발 이펙트 변수
    public GameObject bombEffect;
    
    private void OnCollisionEnter(Collision collision) // 충돌했을때의 처리
    {
        // 1. 이펙트 프리팹을 생성하고 위치시킨다
        GameObject effect = Instantiate(bombEffect);
        effect.transform.position = this.transform.position;
        // 2. 자기 자신을 제거한다
        Destroy(this.gameObject);
    }
}
