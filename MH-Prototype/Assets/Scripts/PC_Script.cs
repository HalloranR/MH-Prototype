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
<<<<<<< Updated upstream
=======
    public Rigidbody2D allyRB;

    //bools for help
>>>>>>> Stashed changes
    public bool bound = false;
    public bool push = false;
    [SerializeField] private float speed = 10f;
<<<<<<< Updated upstream
=======
    [SerializeField] float pullSpeed = 7f;
    [SerializeField] Vector2 pullVelocity = new Vector2(7f, 7f);
>>>>>>> Stashed changes

    void Awake()
    {
        print("first");
        playerInput = new PlayerInputActions();
        rb = GetComponent<Rigidbody2D>();
        allyRB = ally.GetComponent<Rigidbody2D>();
    }

    void start()
    {
        line.SetWidth(0.05F, 0.05F);
        line.SetVertexCount(2);
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
        rb.velocity = moveInput * speed;

        if (bound == true && push == false)
        {
            line.SetPosition(0, transform.position);
            line.SetPosition(1, ally.transform.position);
<<<<<<< Updated upstream
            print("here");
            float step = 5f * Time.deltaTime;
            ally.transform.position = Vector3.MoveTowards(ally.transform.position, transform.position, step);
=======

            float step = pullSpeed * Time.deltaTime;
            
            //Get the difference then move it
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
>>>>>>> Stashed changes
        }
        if (bound == false && push == true)
        {
            line.SetPosition(0, transform.position);
            line.SetPosition(1, ally.transform.position);
<<<<<<< Updated upstream
            print("here");
            float step = 5f * Time.deltaTime;
            ally.transform.position = Vector3.MoveTowards(ally.transform.position, 
                new Vector3(-100 * transform.position.x, -100 * transform.position.y, transform.position.z), step);
=======

            float step = pullSpeed * Time.deltaTime;

            Vector2 difference = (Vector2)ally.transform.position - (Vector2)transform.position;
            allyRB.MovePosition((Vector2)ally.transform.position + difference * step);
>>>>>>> Stashed changes
        }
    }

    private void DoFire(InputAction.CallbackContext obj)
    {
        if (bound == false)
        {
            bound = true;
            print("dome");
        }
        else if (bound == true)
        {
            print("Happened?");
            line.SetPosition(0, new Vector2(0,0));
            line.SetPosition(1, new Vector2(0, 0));
            bound = false;
<<<<<<< Updated upstream
=======
            bust = false;
            allyRB.velocity = new Vector2(0f, 0f);
>>>>>>> Stashed changes
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