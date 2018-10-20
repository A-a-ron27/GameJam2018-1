using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour {

    public Transform target;
    public Vector3 offset = new Vector3(0f, 0f, -10f);
    public Vector3 velocity = Vector3.zero;

	// Use this for initialization
	void Start () {
        target = GameObject.Find("player").GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        // Define a target position above and behind the target transform
        Vector3 targetPosition = target.position + offset;

        // Smoothly move the camera towards that target position
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, .2f);
    }
}
