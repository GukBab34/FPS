using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // 캐릭터 컨트롤러 변수
    CharacterController cc;
    // 이동속도 변수
    public float moveSpeed = 7f;
    // 중력 변수
    float gravity = -9.81f;
    // 수직 속력 변수
    float yVelocity = 0;
    // 점프력 변수
    public float jumpPower = 5f;
    // 점프 상태 변수
    bool isJumping = false;


    private void Awake()
    {
        // 1. 캐릭터 컨트롤러 받아오기
        cc = GetComponent<CharacterController>();
    }

    void Update()
    {
        // 1. 사용자의 입력을 받는다
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // 2. 방향을 만든다
        Vector3 dir = new Vector3(h, 0, v);
        dir = dir.normalized;

        // 3. 메인카메라를 기준으로 방향을 변환한다
        dir = Camera.main.transform.TransformDirection(dir);

        // 4. 바닥에 닿은상태라면
        if( cc.collisionFlags == CollisionFlags.Below)
        {
            // 4-1. 점프중이 아닌 상태로 변경한다
            isJumping = false;
            // 4-2. 캐릭터 수직속도를 0으로 한다
            yVelocity = 0;
        }

        // 5. 만약 스페이스바를 눌렀고 점프중이 아닌 상태라면
        if (Input.GetButtonDown("Jump") && isJumping == false)
        {
            // 5-1. 점프한다
            yVelocity = jumpPower;
            // 5-2. 점프상태로 변경한다
            isJumping = true;
        }

        // 6. 캐릭터 수직 속도에 중력값을 적용한다
        yVelocity += gravity * Time.deltaTime;
        dir.y = yVelocity;

        // 7. 이동속도에 맞춰 이동한다
        cc.Move(dir * moveSpeed * Time.deltaTime);
    }
}
