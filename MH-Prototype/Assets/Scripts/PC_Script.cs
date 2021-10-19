using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PC_Script : MonoBehaviour
{
    //bools for help
    public bool bound = false;
    public bool bust = false;

    //variables for speed
    [SerializeField] private float walkSpeed = 10f;
    [SerializeField] float pullSpeed = 7f;

    //objects to create and then get defined later
    private PlayerInputActions playerInput;
    private Rigidbody2D rb;
    public LineRenderer line;
    public GameObject ally;
    public Rigidbody2D allyRB;

    void Awake()
    {
        //set up inputs
        playerInput = new PlayerInputActions();

        //get the neccessary components
        rb = GetComponent<Rigidbody2D>();
        allyRB = ally.GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        //enables for inputs
        playerInput.Enable();

        playerInput.Fire.Fire.performed += DoFire;
        playerInput.Fire.Fire.Enable();
    }

    private void OnDisable(){ playerInput.Disable(); }

    void FixedUpdate()
    {
        //movement for the player
        Vector2 moveInput = playerInput.Movement.Move.ReadValue<Vector2>();
        rb.velocity = moveInput * walkSpeed;

        //pull the ally if true
        if (bound == true && bust == false) { Pull(); }
    }

    private void DoFire(InputAction.CallbackContext obj)
    {
        //use and if else so that that it mimics holding the button for the action
        if (bound == false)
        {
            bound = true;
        }
        else if (bound == true)
        {
            //delete the line and reset vars
            line.SetPosition(0, new Vector2(0,0));
            line.SetPosition(1, new Vector2(0, 0));
            bound = false;
            bust = false;
            allyRB.velocity = new Vector2(0f, 0f);
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
}