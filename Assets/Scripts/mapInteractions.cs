using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.XR.Interaction.Toolkit;


public class mapInteractions : MonoBehaviour
{
	public Transform cam;
	public Transform controle;
	public Transform mapa;

	public void debugLog() {
		Debug.Log("a");
	}

	public void parentChange() {
		mapa.parent = cam;
	}
}