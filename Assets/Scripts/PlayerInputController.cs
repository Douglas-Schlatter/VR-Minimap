using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    public float moveSpeed = 10;
    public GameObject targetObjectToMove;

    public void moveFoward() 
    {
        Vector3 movement = new Vector3(1, 0, 1);
        this.gameObject.transform.Translate(movement * moveSpeed * Time.deltaTime);
    }
    public void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(x, 0, z);
        targetObjectToMove.gameObject.transform.Translate(movement * moveSpeed * Time.deltaTime);
    }
}
