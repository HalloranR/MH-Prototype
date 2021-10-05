using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PC_Script : MonoBehaviour
{
    private PlayerInputActions playerInput;
    private Rigidbody2D rb;
    public LineRenderer line;
    public GameObject ally;
    public Rigidbody2D allyRB;

    //bools for help
    public bool bound = false;
    public bool push = false;
    public bool bust = false;
    [SerializeField] private float walkSpeed = 10f;
    [SerializeField] float pullSpeed = 7f;

    void Awake()
    {
        print("first");
        playerInput = new PlayerInputActions();
        rb = GetComponent<Rigidbody2D>();
        allyRB = ally.GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        playerInput.Enable();

        playerInput.Fire.Fire.performed += DoFire;
        playerInput.Fire.Fire.Enable();

        playerInput.Push.Push.performed += DoPush;
        playerInput.Push.Push.Enable();
    }

    private void OnDisable(){ playerInput.Disable(); }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 moveInput = playerInput.Movement.Move.ReadValue<Vector2>();
        rb.velocity = moveInput * walkSpeed;

        if (bound == true && bust == false)
        {
            line.SetPosition(0, transform.position);
            line.SetPosition(1, ally.transform.position);

            float step = pullSpeed * Time.deltaTime;
            Vector2 difference = (Vector2)transform.position - (Vector2)ally.transform.position;

            allyRB.MovePosition((Vector2)ally.transform.position + difference * step);

            //stop movement if too close
            if((Mathf.Abs(ally.transform.position.x - transform.position.x) < 1) &&
                (Mathf.Abs(ally.transform.position.y - transform.position.y) < 1))
            { 
                bust = true;

                line.SetPosition(0, new Vector2(0, 0));
                line.SetPosition(1, new Vector2(0, 0));
            }
        }
        if (push == true)
        {
            line.SetPosition(0, transform.position);
            line.SetPosition(1, ally.transform.position);

            float step = pullSpeed * Time.deltaTime;
            Vector2 difference = (Vector2)ally.transform.position - (Vector2)transform.position;

            allyRB.MovePosition((Vector2)ally.transform.position + difference * step);
        }
    }

    private void DoFire(InputAction.CallbackContext obj)
    {
        if (bound == false)
        {
            bound = true;
        }
        else if (bound == true)
        {
            line.SetPosition(0, new Vector2(0,0));
            line.SetPosition(1, new Vector2(0, 0));
            bound = false;
            bust = false;
            allyRB.velocity = new Vector2(0f, 0f);
        }
    }

    private void DoPush(InputAction.CallbackContext obj)
    {
        if (push == false)
        {
            push = true;
        }
        else if (push == true)
        {
            push = false;
            line.SetPosition(0, new Vector2(0, 0));
            line.SetPosition(1, new Vector2(0, 0));
            allyRB.velocity = new Vector2(0f, 0f);
        }
    }
}