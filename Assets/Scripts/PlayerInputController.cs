using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    public float moveSpeed = 3;
    public GameObject targetObjectToMove;
    public GameObject mapObject;
    public bool matchRotation = true;

    public void MoveFoward() 
    {
        Vector3 movement = new Vector3(1, 0, 1);
        this.gameObject.transform.Translate(movement * moveSpeed * Time.deltaTime);
    }
    public void Update()
    {
        /*
        float x = Input.GetAxis("Vertical");
        float z = Input.GetAxis("Horizontal");

        Vector3 movement = this.gameObject.transform.forward * x + this.gameObject.transform.right * z;
		movement.y = 0;
		movement = Vector3.Normalize(movement);
        targetObjectToMove.gameObject.transform.Translate(movement * moveSpeed * Time.deltaTime);
        */
        // old mapObject.transform.localRotation = Quaternion.Euler(-this.gameObject.transform.rotation.eulerAngles);
        if (matchRotation)
        {
            mapObject.transform.localRotation = Quaternion.Euler(new Vector3(0, -this.gameObject.transform.rotation.eulerAngles.y, 0));
        }
    }

    public void ToggleMap()
    {
        mapObject.SetActive(!mapObject.activeSelf);
    }

    public void ToggleMatchRotation()
    {
        matchRotation = !matchRotation;
    }
}
