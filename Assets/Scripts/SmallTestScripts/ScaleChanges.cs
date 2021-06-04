using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleChanges : MonoBehaviour {

	public float xScale;
	public float yScale;
	public float zScale;

	float time = 3.0f;

	void Update () {
		time -= Time.deltaTime;
		transform.localScale += new Vector3(xScale, yScale, zScale);
	}



}
	