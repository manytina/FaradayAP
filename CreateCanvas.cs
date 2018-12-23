using UnityEngine;
using System.Collections;

public class CreateCanvas : MonoBehaviour {

	public Transform canvas;

	// Use this for initialization
	void Start () {
		Instantiate(canvas, new Vector3(0, 0, 0), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
