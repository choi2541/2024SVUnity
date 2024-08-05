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
        originPos = transform.position;//����������: �ڱ���ġ ����
    }

    // Update is called once per frame
    void Update()
    {
        // forward �Ķ��� z�� back �Ķ��� -z;, left x��
        transform.position = transform.position + transform.forward * speed * Time.deltaTime;
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    Debug.Log($"�浹�� ����� �̸� : {other.name}");
    //    // �÷��̾ ������Ʈ�� �浹������ ���ӿ���
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
    // Ʈ���Ŵ� �������� �浹�� �߻����� �ʴ´�. Collision ������ �浹�� �߻��ϰ� �̺�Ʈ�� �߻��Ѵ�.



}
