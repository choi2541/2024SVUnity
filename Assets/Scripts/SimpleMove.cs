using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 1. �߰�ȣ�� ���� �̷��� �Ѵ�.
// 2. �߰�ȣ ���ο� ����� ������ �̴ϴ�.

public class SimpleMove : MonoBehaviour
{
    // �÷��̾��� �Է��� �޴´�. 
    // ������ �ɾ �����Ѵ�.

    // ������ ����
    [SerializeField]
    private float speed = 9.2f;


    // Start is called before the first frame update
    void Start() // ��ŸƮ �Լ� : ������ ���۵ǰ� �ѹ� ����ȴ�.
    {
        Debug.Log("��ŸƮ �Լ����� �ۼ��� �����Դϴ�.");
    }

    // Update is called once per frame
    void Update() // ������Ʈ �Լ� : ����ؼ� ����Ǵ� ������ ������ �ȴ�.
    {
        // x,y,z (y ����) x,z �̵�
        // z (����), x(������)
        // -z(�ĸ�), -x(����)

        // -1 ~ 1
        // Input.GetAxis("Horizontal") -> ���������� �Է°��� ���� �� -1, 1
        // Input.GetAxis("Vertical") -> z���� 1, -z���� -1
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 moveVector = new Vector3(horizontalInput, 0, verticalInput);

        transform.position = transform.position + moveVector * speed * Time.deltaTime; // Time.deltaTime . Frame ����
    }
}