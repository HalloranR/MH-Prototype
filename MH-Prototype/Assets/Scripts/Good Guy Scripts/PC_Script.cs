using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PC_Script : MonoBehaviour
{
    //bools for help
    public bool bound = false;
    public bool bust = false;
    public bool a = false;
    public bool b = false;

    //variables for speed
    [SerializeField] private float walkSpeed = 10f;
    [SerializeField] float pullSpeed = 7f;

    //objects to create and then get defined later
    private PlayerInputActions playerInput;
    private Rigidbody2D rb;
    public LineRenderer line;

    //manage allies here
    public GameObject ally;
    public Rigidbody2D allyRB;
    public GameObject ally1;
    public Rigidbody2D allyRB1;
    public GameObject ally2;
    public Rigidbody2D allyRB2;

    void Awake()
    {
        //set up inputs
        playerInput = new PlayerInputActions();

        //get the neccessary components
        rb = GetComponent<Rigidbody2D>();
        allyRB1 = ally1.GetComponent<Rigidbody2D>();
        allyRB2 = ally2.GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        //enables for inputs
        playerInput.Enable();

        playerInput.Fire.Fire.performed += DoFire;
        playerInput.Fire.Fire.Enable();

        playerInput.A.A.performed += DoA;
        playerInput.A.A.Enable();

        playerInput.B.B.performed += DoB;
        playerInput.B.B.Enable();
    }

    private void OnDisable(){ playerInput.Disable(); }

    void FixedUpdate()
    {
        //movement for the player
        Vector2 moveInput = playerInput.Movement.Move.ReadValue<Vector2>();
        rb.velocity = moveInput * walkSpeed;

        //pull the ally if true
        if (bound == true && bust == false && ally != null) { Pull(); }
    }

    private void DoFire(InputAction.CallbackContext obj)
    {
        //make sure you dont get a null reference
        if (ally != null)
        {
            //use and if else so that that it mimics holding the button for the action
            if (!bound)
            {
                if (FireLaser()) { bound = true; }

            }
            else if (bound)
            {
                //delete the line and reset vars
                line.SetPosition(0, new Vector2(0, 0));
                line.SetPosition(1, new Vector2(0, 0));
                bound = false;
                bust = false;
                allyRB.velocity = new Vector2(0f, 0f);
            }
        }
        else
        {
            print("null pointer");
            bound = false;
        }
    }

    public void Pull()
    {
        //set up the line render
        line.SetPosition(0, transform.position);
        line.SetPosition(1, ally.transform.position);

        //pull the ally in steps using the difference and the pullspeed
        float step = pullSpeed * Time.deltaTime;
        Vector2 difference = (Vector2)transform.position - (Vector2)ally.transform.position;

        //move the ally
        allyRB.MovePosition((Vector2)ally.transform.position + difference * step);

        //stop movement if too close and destroy the line
        if ((Mathf.Abs(ally.transform.position.x - transform.position.x) < 1) &&
            (Mathf.Abs(ally.transform.position.y - transform.position.y) < 1))
        {
            bust = true;

            line.SetPosition(0, new Vector2(0, 0));
            line.SetPosition(1, new Vector2(0, 0));
        }
    }

    public bool FireLaser()
    {
        Vector3 dir = ally.transform.position - transform.position;

        int mask = 1 << LayerMask.NameToLayer("Pillar");

        RaycastHit2D hit = Physics2D.Raycast(transform.position, dir, dir.magnitude, mask);

        if (hit)
        {
            print("Here");

            Debug.DrawRay(transform.position, ally.transform.position - transform.position, Color.green);

            if(hit.collider.gameObject.tag == "Pillar")
            {
                Vector3 endpos = transform.position;
                line.SetPosition(0, transform.position);
                line.SetPosition(1, transform.position);

                while (false) //endpos != hit.collider.gameObject.transform.position)
                {
                    endpos = endpos + dir;
                    line.SetPosition(1, endpos);

                }
                line.SetPosition(1, transform.position);
                return false;
            }
        }

        return true;
    }

    private void DoA(InputAction.CallbackContext obj)
    {
        if(ally1 != null)
        {
            if (a)
            {
                ally = null;
                allyRB = null;
                a = false;
                line.SetPosition(0, new Vector2(0, 0));
                line.SetPosition(1, new Vector2(0, 0));
            }
            else
            {
                ally = ally1;
                allyRB = allyRB1;
                a = true;
            }
        }
    }

    private void DoB(InputAction.CallbackContext obj)
    {
        if(ally2 != null)
        {
            if (b)
            {
                ally = null;
                allyRB = null;
                b = false;
                line.SetPosition(0, new Vector2(0, 0));
                line.SetPosition(1, new Vector2(0, 0));
            }
            else
            {
                ally = ally2;
                allyRB = allyRB2;
                b = true;
            }
        }
    }
}