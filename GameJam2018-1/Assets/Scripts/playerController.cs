using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

    public float speed = 0.1f;
    public Vector3 newPos;

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
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.rotation = Quaternion.LookRotation(Vector3.forward, mousePos - transform.position);

        Vector3 movement = Vector3.zero;
        Vector3 teleport = Vector3.zero;

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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            teleport = Vector3.up * speed * 30;
            player.Translate(teleport);
        }

        player.position += movement;
        
        //transform.rotation = Quaternion.Euler(0, 0, 90);
    }
}
