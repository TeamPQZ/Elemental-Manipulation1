using UnityEngine;
using System.Collections;

public class CoolElementScript : MonoBehaviour {

    public Rigidbody2D rb;
    private float dt;

    public float Speed;

    private Vector2 MoveDirection;
    

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        rb.constraints = RigidbodyConstraints2D.FreezeRotation | RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
	}
	
	// Update is called once per frame

    void OnMouseDrag()
    {
        Debug.Log(dt);
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
        if (Input.GetAxis("Left Click") > 0 && Input.GetAxis("Right Click") <= 0)
        {
            rb.velocity = new Vector2(Input.GetAxis("Mouse X") * Time.deltaTime * Speed, 0);
        }
        else if (Input.GetAxis("Right Click") > 0)
        {
            rb.velocity = new Vector2(0, Input.GetAxis("Mouse Y") * Time.deltaTime * Speed);
        }
        else
        {
            return;
        }
    }


    void OnMouseUp()
    {
        rb.velocity = new Vector2(0, 0);
        rb.constraints = RigidbodyConstraints2D.FreezeRotation | RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
    }
}
