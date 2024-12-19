using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR;

public class PlayerInputController : MonoBehaviour
{
    public float moveSpeed = 3;
    public GameObject targetObjectToMove;
    public GameObject mapObject;
    public GameObject mapHolder;
    public bool matchRotation = true;
    public XRController rController;
    public Transform controle;
    //Input Related
    public InputActionReference inputToggleMap;

    public InputActionReference inputToggleMatchRotation;

    public InputActionReference inputMapFullReset;

    public void Awake()
    {
        inputToggleMap.action.Enable();
        inputToggleMap.action.performed += ToggleMap;

        inputToggleMatchRotation.action.Enable();
        inputToggleMatchRotation.action.performed += ToggleMatchRotation;

        inputMapFullReset.action.Enable();
        inputMapFullReset.action.performed += MapFullReset;
    }
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

    public void ToggleMap(InputAction.CallbackContext context)
    {
        mapObject.SetActive(!mapObject.activeSelf);
    }

    public void ToggleMatchRotation(InputAction.CallbackContext context)
    {
        matchRotation = !matchRotation;
    }

    public void MapFullReset(InputAction.CallbackContext context)
    {
        mapHolder.transform.parent = controle;
        mapHolder.transform.localPosition = Vector3.zero;
        mapHolder.transform.localEulerAngles = Vector3.zero;
        mapHolder.transform.localScale = Vector3.one;
    }
    public void OnDeviceChange(InputDevice device, InputDeviceChange change)
    {
        switch (change)
        {

            case InputDeviceChange.Disconnected:
                inputToggleMap.action.Disable();
                inputToggleMap.action.performed -= ToggleMap;


                inputToggleMatchRotation.action.Disable();
                inputToggleMatchRotation.action.performed -= ToggleMatchRotation;

                inputMapFullReset.action.Disable();
                inputMapFullReset.action.performed -= MapFullReset;
                break;
            case InputDeviceChange.Reconnected:
                inputToggleMap.action.Enable();
                inputToggleMap.action.performed += ToggleMap;


                inputToggleMatchRotation.action.Enable();
                inputToggleMatchRotation.action.performed += ToggleMatchRotation;


                inputMapFullReset.action.Enable();
                inputMapFullReset.action.performed += MapFullReset;
                break;
            default:
                break;
        }

    }
}
