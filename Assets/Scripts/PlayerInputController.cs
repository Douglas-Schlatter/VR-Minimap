using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    public float moveSpeed = 10;
    public GameObject targetObjectToMove;
    [SerializeField] float mouseSens = 100f;
    float xRotation = 0f;
    public void moveFoward() 
    {
        Vector3 movement = new Vector3(1, 0, 1);
        this.gameObject.transform.Translate(movement * moveSpeed * Time.deltaTime);
    }
    public void Update()
    {
        //float mouseX = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime;
        //float mouseY = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime;

        //xRotation -= mouseY; //incluir a rotação no eixo y

        //xRotation = Mathf.Clamp(xRotation, -90f, 90f); // dar um maximo de rotação em Y com clamp

        //targetObjectToMove.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);

        //targetObjectToMove.transform.Rotate(Vector3.up * mouseX); //Rotacionar o objeto que a camera esta fixado

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        //targetObjectToMove.transform.rotation = this.gameObject.transform.rotation;
        Vector3 movement = new Vector3(x, 0, z);
        targetObjectToMove.gameObject.transform.Translate(movement * moveSpeed * Time.deltaTime);
    }
}
