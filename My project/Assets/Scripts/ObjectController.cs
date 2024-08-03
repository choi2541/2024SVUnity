using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    public float speed;
        // Start is called before the first frame update
    void Start()
    {
        speed = 10f;
        originPos = transform.position;//오리진포스: 자기위치 저장
    }

    // Update is called once per frame
    void Update()
    {
        // forward 파란색 z축 back 파란색 -z;, left x축
        transform.position = transform.position + transform.forward * speed * Time.deltaTime;
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    Debug.Log($"충돌한 대상의 이름 : {other.name}");
    //    // 플레이어가 오브젝트에 충돌했을때 게임오버
    //}

    private Vector3 originPos;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player")) 
        {
            Destroy(collision.gameObject);
        }
        if (collision.collider.CompareTag("Wall"))
        {
            transform.position = originPos;
        }
    }
    // 트리거는 물리적인 충돌이 발생하지 않는다. Collision 물리적 충돌이 발생하고 이벤트도 발생한다.



}
