using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public CharacterController characterController;
    public float speed = 10f;

    private void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        PlayerMove();
        //PlayercamerMove();
    }
    private void PlayerMove()
    {
        // �÷��̾��� �Է��� �ް� �ʹ�.
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Debug.Log($"horizontalInput : {horizontalInput}, verticlaInput : {verticalInput}");

        Vector3 moveVector = new Vector3(horizontalInput, 0, verticalInput);

        // Time.deltaTime������ ���������� ó���Ǿ� �ֱ� ������ �߰������൵ �ȴ�.
        characterController.SimpleMove(moveVector * speed); // ����� �ӵ� speed Vector
    }

    // ������ �����̰� �ʹ�.
    private void PlayerCameraMove()
    {
        // �÷��̾��� �Է�. Mouse �Է����޾ƾ߰���
        float MouseX = Input.GetAxis("Mouse X");

        Debug.Log($"MouseX {MouseX}");
        float MouseY = Input.GetAxis("Mouse Y");

        // transform ����. Y���� MouseX����ŭ �������ָ� �ȴ�.

        transform.rotation = Quaternion.Euler(MouseX, MouseY, 0);

    }
    private void OnTriggerEnter(Collider other)

    {
        if (other.CompareTag("Goal"))
        {
            Destroy(other.gameObject);

        }
    }
}
