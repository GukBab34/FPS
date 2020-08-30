using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    // 발사위치
    public GameObject firePosition;
    // 투척무기 오브젝트
    public GameObject BombFactory;
    // 투척파워
    public float throwPower = 15f;

    void Update()
    {
        // 1. 마우스 오른쪽 버튼을 입력받으면
        if (Input.GetButtonDown("Fire1"))
        {
            // 1-1. 폭탄을 생성해 발사위치에 위치시킨다
            GameObject bomb = Instantiate(BombFactory);
            bomb.transform.position = firePosition.transform.position;

            // 1-2. 폭탄 오브젝트의 리지드바디 컴포넌트 가져오기
            Rigidbody rb = bomb.GetComponent<Rigidbody>();

            // 1-3. 카메라의 정면 방향으로 폭탄에 물리적인 힘을 가한다
            rb.AddForce(Camera.main.transform.forward * throwPower, ForceMode.Impulse);
        }
    }
}
