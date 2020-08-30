using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRoatate : MonoBehaviour
{
    // 회전속도 변수
    public float rotSpeed = 500f;

    // 회전값 변수
    float mx = 0;
    float my = 0;

    private void Update()
    {
        // 1. 사용자의 마우스 입력을 받는다
        float mouse_X = Input.GetAxis("Mouse X");
        float mouse_Y = Input.GetAxis("Mouse Y");

        // 2. 회전값 변수에 마우스 입력 값만큼 미리 누적시킨다
        mx += mouse_X * rotSpeed * Time.deltaTime;
        my += mouse_Y * rotSpeed * Time.deltaTime;

        // 3. 마우스 상하회전의 각도를 제한한다
        my = Mathf.Clamp(my, -90f, 90f);

        // 4. 물체를 회전 방향으로 회전시킨다
        this.transform.eulerAngles = new Vector3(-my, mx, 0);

    }
}
