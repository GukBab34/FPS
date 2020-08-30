using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    // 회전속도 변수
    public float rotSpeed = 500f;
    // 회전값 변수
    float mx = 0;

    private void Update()
    {
        // 1. 사용자의 마우스 입력을 받는다
        float mouse_X = Input.GetAxis("Mouse X");

        // 2. 회전값 변수에 마우스 입력값만큼 미리 누적시킨다
        mx += mouse_X * rotSpeed * Time.deltaTime;

        // 3. 물체를 회전방향대로 회전시킨다
        this.transform.eulerAngles = new Vector3(0, mx, 0);
    }
}
