using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

    public float speed = 0.1f;

    Transform player;

    // Use this for initialization
    void Start () {
        player = GameObject.Find("player").GetComponent<Transform>();
    }
    
    // Update is called once per frame
    void Update () {


    }

    private void FixedUpdate()
    {
        Vector3 movement = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            movement += (Vector3.up * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            movement += Vector3.left * speed/1.2f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            movement += Vector3.down * speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            movement += Vector3.right * speed/1.2f;
        }

        player.position += movement;


        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.rotation = Quaternion.LookRotation(Vector3.forward, mousePos - transform.position);
        //transform.rotation = Quaternion.Euler(0, 0, 90);
    }
}
