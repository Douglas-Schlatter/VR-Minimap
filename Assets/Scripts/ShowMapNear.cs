using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMapNear : MonoBehaviour
{
	public GameObject player;
	public float distance = 1f;
	public Transform cube;
	
	private Transform[] thisObject;
	private Vector3 playerPos;
	private float objDist;
	private float cubeSize;
	
    // Start is called before the first frame update
    void Start()
    {
        thisObject = GetComponentsInChildren<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        playerPos = player.transform.position;
        cubeSize = cube.localScale.x;
		
		foreach (Transform child in thisObject) {
			objDist = Vector3.Distance(child.position,playerPos);
			
			if (objDist >= distance*cubeSize) {
				if (child != this.gameObject.transform)
					child.gameObject.SetActive(false);
			} else {
				child.gameObject.SetActive(true);
			}
		}
    }
}
