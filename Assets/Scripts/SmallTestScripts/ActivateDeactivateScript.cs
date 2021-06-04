using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateDeactivateScript : MonoBehaviour {

	public GameObject cam1;

	void Update ()
	{
		if (Input.GetKey (KeyCode.UpArrow)) {
			cam1.GetComponent<ShaderEffectScanner> ().enabled = true;
		} else {
			cam1.GetComponent<ShaderEffectScanner> ().enabled = false;
		}
	}
}