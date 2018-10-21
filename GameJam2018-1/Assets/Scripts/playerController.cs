using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

    public float speed = 0.1f;
<<<<<<< HEAD
    public Vector3 newPos;

=======
    public float teleportDist = 0.5f;
>>>>>>> 756b861e884a0228aad39266e6aa874e2cc2fbef
    Transform player;
    public int coolDown = 0;
    // Use this for initialization
    void Start () {
        player = GameObject.Find("player").GetComponent<Transform>();
    }
    
    // Update is called once per frame
    void Update () {
        if (coolDown > 0)
            coolDown--;

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
            movement += Vector3.left * speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            movement += Vector3.down * speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            movement += Vector3.right * speed;
        }
<<<<<<< HEAD
        if (Input.GetKeyDown(KeyCode.Space))
        {
            teleport = Vector3.up * speed * 30;
            player.Translate(teleport);
        }

        player.position += movement;
        
=======
        

        player.Translate(movement, Space.World);

        movement = Vector3.zero;
        if (Input.GetKey(KeyCode.Space) && coolDown == 0)
        {
            movement += (Vector3.up * teleportDist);
            coolDown += 200;
        }
        player.Translate(movement);
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.rotation = Quaternion.LookRotation(Vector3.forward, mousePos - transform.position);
>>>>>>> 756b861e884a0228aad39266e6aa874e2cc2fbef
        //transform.rotation = Quaternion.Euler(0, 0, 90);
    }
}
