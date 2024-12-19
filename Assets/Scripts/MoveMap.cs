using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMap : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
	public float scale = 0.05f;
    public Transform targetTransform;
	
	private Vector3 initialPos;
	private Vector3 currentPos;
	
    void Start()
    {
		initialPos = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        targetTransform = this.gameObject.transform;
		currentPos = initialPos + (player.transform.position - initialPos);
        targetTransform.position = currentPos * -scale;
        this.gameObject.transform.localPosition = targetTransform.position;
    }
}