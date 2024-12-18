using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMapNear : MonoBehaviour
{
	public GameObject player;
	public float distance = 1f;
	
	private Transform[] thisObject;
	private Vector3 playerPos;
	private float objDist;
	
    // Start is called before the first frame update
    void Start()
    {
        thisObject = GetComponentsInChildren<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        playerPos = player.transform.position;
		
		foreach (Transform child in thisObject) {
			objDist = Vector3.Distance(child.position,playerPos);
			
			if (objDist >= distance) {
				if (child != this.gameObject.transform)
					child.gameObject.SetActive(false);
			} else {
				child.gameObject.SetActive(true);
			}
		}
    }
}
