using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 1. 중괄호는 쌍을 이루어야 한다.
// 2. 중괄호 내부에 기능을 정의할 겁니다.

public class SimpleMove : MonoBehaviour
{
    // 플레이어의 입력을 받는다. 
    // 조건을 걸어서 실행한다.

    // 변수의 선언
    [SerializeField]
    private float speed = 9.2f;


    // Start is called before the first frame update
    void Start() // 스타트 함수 : 게임이 시작되고 한번 실행된다.
    {
        Debug.Log("스타트 함수에서 작성한 내용입니다.");
    }

    // Update is called once per frame
    void Update() // 업데이트 함수 : 계속해서 변경되는 사항이 적용이 된다.
    {
        // x,y,z (y 점프) x,z 이동
        // z (정면), x(오른쪽)
        // -z(후면), -x(왼쪽)

        // -1 ~ 1
        // Input.GetAxis("Horizontal") -> 수평적으로 입력값을 받을 때 -1, 1
        // Input.GetAxis("Vertical") -> z방향 1, -z방향 -1
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 moveVector = new Vector3(horizontalInput, 0, verticalInput);

        transform.position = transform.position + moveVector * speed * Time.deltaTime; // Time.deltaTime . Frame 역수
    }
}