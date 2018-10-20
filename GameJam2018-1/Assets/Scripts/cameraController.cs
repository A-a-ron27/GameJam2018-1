using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour {

    public Transform target;
    public Vector3 offset = new Vector3(0f, 0f, -10f);

	// Use this for initialization
	void Start () {
        target = GameObject.Find("player").GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = target.position + offset;
	}
}
