using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMap : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
	public float scale = 0.05f;
	public GameObject playerMarker;
	
	Vector3 initialPos;
	
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.localPosition = new Vector3(player.transform.position.x, 0, player.transform.position.z) * -scale;
		playerMarker.transform.localPosition = new Vector3(player.transform.position.x, 0, player.transform.position.z) * 1/2;
		Vector3 playerRotation =  -player.transform.rotation.eulerAngles;
		playerRotation.x = 0;
		this.gameObject.transform.localRotation = Quaternion.Euler(playerRotation);

    }
}