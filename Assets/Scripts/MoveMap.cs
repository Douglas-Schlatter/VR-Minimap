using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMap : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
	public float scale = 0.05f;
    public Transform targetTransform;
	
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        targetTransform = this.gameObject.transform;
        targetTransform.position = new Vector3(player.transform.position.x, 0, player.transform.position.z) * -scale;
        this.gameObject.transform.localPosition = targetTransform.position;

    }
}