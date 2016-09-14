using UnityEngine;
using System.Collections;

public class CoolElementScript : MonoBehaviour {

    public Rigidbody2D rb;
    public BoxCollider2D cl;

    private float SizeX;
    private float SizeY;

    //Camera.main.ScreenToWorldPoint(Input.mousePosition)


    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        cl = GetComponent<BoxCollider2D>();
        rb.constraints = RigidbodyConstraints2D.FreezeRotation | RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
        SizeX = cl.bounds.size.x;
        SizeY = cl.bounds.size.y;
	}
	
	// Update is called once per frame

    void OnMouseDrag()
    {
        if(Camera.main.ScreenToWorldPoint(Input.mousePosition).x > transform.position.x+0.5f)
        {
            //Bevæg til højre;
            RaycastHit2D R1;
            R1 = Physics2D.Raycast(new Vector2(transform.position.x + (SizeX * 0.51f), transform.position.y + (SizeY * 0.45f)), Vector2.right, 0.45f);
            RaycastHit2D R2;
            R2 = Physics2D.Raycast(new Vector2(transform.position.x + (SizeX * 0.51f), transform.position.y - (SizeY * 0.45f)), Vector2.right, 0.45f);
            RaycastHit2D R3;
            R3 = Physics2D.Raycast(new Vector2(transform.position.x + (SizeX * 0.51f), transform.position.y), Vector2.right, 0.45f);

            if (R1.collider != null || R2.collider != null || R3.collider != null)
            {
                return;
            }
            else
            {
                transform.position = transform.position + new Vector3(0.5f, 0, 0);
            }
        }
        else if(Camera.main.ScreenToWorldPoint(Input.mousePosition).x < transform.position.x - 0.5f)
        {
            //Bevæg til venstre;
            RaycastHit2D L1;
            L1 = Physics2D.Raycast(new Vector2(transform.position.x - (SizeX * 0.51f), transform.position.y + (SizeY * 0.45f)), Vector2.left, 0.45f);
            RaycastHit2D L2;
            L2 = Physics2D.Raycast(new Vector2(transform.position.x - (SizeX * 0.51f), transform.position.y - (SizeY * 0.45f)), Vector2.left, 0.45f);
            RaycastHit2D L3;
            L3 = Physics2D.Raycast(new Vector2(transform.position.x - (SizeX * 0.51f), transform.position.y), Vector2.left, 0.45f);

            if (L1.collider != null || L2.collider != null || L3.collider != null)
            {
                return;
            }
            else
            {
                transform.position = transform.position - new Vector3(0.5f, 0, 0);
            }
        }
        else if(Camera.main.ScreenToWorldPoint(Input.mousePosition).y > transform.position.y + 0.5f)
        {
            //Bevæg op;
            RaycastHit2D U1;
            U1 = Physics2D.Raycast(new Vector2(transform.position.x + (SizeX * 0.45f), transform.position.y + (SizeY * 0.51f)), Vector2.up, 0.45f);
            RaycastHit2D U2;
            U2 = Physics2D.Raycast(new Vector2(transform.position.x - (SizeX * 0.45f), transform.position.y + (SizeY * 0.51f)), Vector2.up, 0.45f);
            RaycastHit2D U3;
            U3 = Physics2D.Raycast(new Vector2(transform.position.x, transform.position.y + SizeY * 0.51f), Vector2.up, 0.45f);
            if (U1.collider != null || U2.collider != null || U3.collider != null)
            {
                return;
            }
            else
            {
                transform.position = transform.position + new Vector3(0, 0.5f, 0);
            }
        }
        else if(Camera.main.ScreenToWorldPoint(Input.mousePosition).y < transform.position.y - 0.5f)
        {
            //Bevæg ned;
            RaycastHit2D D1;
            D1 = Physics2D.Raycast(new Vector2(transform.position.x + (SizeX * 0.45f), transform.position.y - (SizeY * 0.51f)), Vector2.down, 0.45f);
            RaycastHit2D D2;
            D2 = Physics2D.Raycast(new Vector2(transform.position.x - (SizeX * 0.45f), transform.position.y - (SizeY * 0.51f)), Vector2.down, 0.45f);
            RaycastHit2D D3;
            D3 = Physics2D.Raycast(new Vector2(transform.position.x, transform.position.y - SizeY * 0.51f), Vector2.down, 0.45f);

            if (D1.collider != null || D2.collider != null || D3.collider != null)
            {
                return;
            }
            else
            {
                transform.position = transform.position - new Vector3(0, 0.5f, 0);
            }
        }
        else
        {
            return;
        }
    }


    void OnMouseUp()
    {
        //rb.velocity = new Vector2(0, 0);
        //rb.constraints = RigidbodyConstraints2D.FreezeRotation | RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
    }
}
