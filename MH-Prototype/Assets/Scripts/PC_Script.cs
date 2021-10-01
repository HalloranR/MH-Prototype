using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PC_Script : MonoBehaviour
{
    private PlayerInputActions playerInput;
    private Rigidbody2D rb;
    public LineRenderer line;

    //Set up ally
    public GameObject ally;
    public Rigidbody allyRB;

    //bools for help
    public bool bound = false;
    public bool push = false;
    public bool bust = false;

    //movement speed and hook speed
    [SerializeField] private float speed = 10f;
    [SerializeField] float pullSpeed = 7f;

    void Awake()
    {
        playerInput = new PlayerInputActions();
        rb = GetComponent<Rigidbody2D>();
    }

    void start()
    {
        line.SetWidth(0.05F, 0.05F);
        line.SetVertexCount(2);
        allyRB = ally.GetComponent<RigidBody>();
    }

    private void OnEnable()
    {
        //do enables
        playerInput.Enable();
        playerInput.Fire.Fire.performed += DoFire;
        playerInput.Fire.Fire.Enable();

        playerInput.Push.Push.performed += DoPush;
        playerInput.Push.Push.Enable();
    }

    private void OnDisable()
    {
        playerInput.Disable();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 moveInput = playerInput.Movement.Move.ReadValue<Vector2>();
        rb.velocity = moveInput * speed;

        if (bound == true && bust == false)
        {
            line.SetPosition(0, transform.position);
            line.SetPosition(1, ally.transform.position);

            float step = pullSpeed * Time.deltaTime;
            //ally.transform.translate(Vector3.MoveTowards(ally.transform.position, transform.position, step);

            allyRB.velocity = new Vector3(0, 10, 0);

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
            ally.transform.position = Vector3.MoveTowards(ally.transform.position, 
                new Vector3(-100 * transform.position.x, -100 * transform.position.y, transform.position.z), step);
            
            
        }
    }

    private void DoFire(InputAction.CallbackContext obj)
    {
        if (bound == false) { bound = true; }
        else if (bound == true)
        {
            line.SetPosition(0, new Vector2(0,0));
            line.SetPosition(1, new Vector2(0, 0));
            bound = false;
            bust = false;
        }
    }

    private void DoPush(InputAction.CallbackContext obj)
    {
        if (push == false) { push = true; }
        else if (push == true)
        {
            push = false;
            line.SetPosition(0, new Vector2(0, 0));
            line.SetPosition(1, new Vector2(0, 0));
        }
    }
}