using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMap : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
	public float scale = 0.1f;

    public Transform targetTransform;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        targetTransform = this.gameObject.transform;
        targetTransform.position = player.transform.position;
        //targetTransform.rotation = player.transform.rotation;
        //this.gameObject.transform.rotation = player.transform.rotation;
        this.gameObject.transform.localPosition = targetTransform.position;

    }
}