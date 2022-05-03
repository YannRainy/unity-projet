using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.Physics2DModule;





public class jeanmove : MonoBehaviour
{
    public Vector2 jeanmichelsaut;
    private Vector2 right = new Vector2(20, 0f);
    private Vector2 left = new Vector2(-20, 0f);
    public GameObject foo;
    private Vector2 up = new Vector2(0, 65f);
    private Vector2 down = new Vector2(0, -30f);
    private bool moving = false;
    private Vector2 movingdirection = new Vector2(0, 0);
    private Vector2 nul = new Vector2(0, 0f);
    private bool grounded = true;
    private bool dead = false;
    public bool activated = true;
    void Start()
    {
        
    }


    void OnCollisionEnter2D(Collision2D col)
    {
        var decor = col.gameObject.GetComponent<jeandecor>();
        if(decor != null )
        {
            if (decor.plancher)
            {
                grounded = true;           
            }
            
        }
        var deathdecor = col.gameObject.GetComponent<deathdecor>();
        if(deathdecor != null)
        {
            if (deathdecor.death)
            {
                dead = true;
            }


        }

       
        
        
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            if (activated == false)
            {
                activated = true;
            }
            else
            {
                activated = false;
            }
            
        }
        if (activated == true)
        {

            var v = GetComponent<Rigidbody2D>();

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                movingdirection = left;
                moving = true;
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                movingdirection = right;
                moving = true;
            }

            if (Input.GetKeyUp(KeyCode.LeftArrow))
            {
                moving = false;
            }


            if (Input.GetKeyUp(KeyCode.RightArrow))
            {
                moving = false;
            }



            if (moving == true)
            {
                v.velocity = new Vector2(movingdirection.x, v.velocity.y);
            }


            if (grounded == true)
            {
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    v.velocity = up;
                    grounded = false;
                }

                if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    v.velocity = down;
                }
            }

            if (dead == true)
            {
                right = nul;
                left = nul;
                up = nul;
                down = nul;
                SceneManager.LoadScene(1);
            }









            var cam = foo.GetComponent<Camera>();


            var v3 = new Vector3(transform.position.x, transform.position.y, -10);

            if ((v3 - cam.transform.position).magnitude > 10)
            {





                cam.transform.position = cam.transform.position * 0.990f + v3 * 0.01f;

            }
        }
    }
}
