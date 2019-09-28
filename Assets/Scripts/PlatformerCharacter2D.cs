using UnityEngine;
using UnityEngine.UI;

public class PlatformerCharacter2D : MonoBehaviour
{
    public GameObject HUD;

    [SerializeField] public float maxSpeed = 12f;    // The fastest the player can travel in the x axis.
    [SerializeField] private LayerMask whatIsGround; // A mask determining what is ground to the character

    private Transform groundCheck;        // A position marking where to check if the player is grounded.
    private float groundedRadius = .2f;   // Radius of the overlap circle to determine if grounded
    private bool grounded = false;        // Whether or not the player is grounded.
    private Animator anim;                // Reference to the player's animator component.  
    private Touch touch; 


    private void Awake()
    {
        // Setting up references.
        groundCheck = transform.Find("GroundCheck");
        anim = GetComponent<Animator>();
    }


    private void FixedUpdate()
    {
        // The player is grounded if a circlecast to the groundcheck position hits anything designated as ground
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundedRadius, whatIsGround);
        anim.SetBool("Grounded", grounded);
    
        // Set the vertical animation
        anim.SetFloat("vSpeed", GetComponent<Rigidbody2D>().velocity.y);

        GetComponent<Rigidbody2D>().velocity = new Vector2(maxSpeed, GetComponent<Rigidbody2D>().velocity.y);
        maxSpeed += 0.007f;
        anim.SetFloat("Speed", maxSpeed / 12);
    }

    void Update()
    {
        touch = Input.GetTouch(0);
        if (grounded && Input.touchCount!=0 && touch.phase == TouchPhase.Began)
        {
            anim.SetBool("Grounded", false);                                    // For altering animator parameter.
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 2000f));        // Add force to player.
            Invoke("Jump2", 0.05f);
        }
        HUD.GetComponentInChildren<Text>().text = ((int)(transform.position.x*3)).ToString() + "m";
    }

    void Jump2()
    {
        if (Input.touchCount != 0)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 1200f));
            Invoke("Jump3", 0.03f);
        }
    }

    void Jump3()
    {
        if (Input.touchCount != 0)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 1100f));
            Invoke("Jump4", 0.02f);
        }
    }

    void Jump4()
    {
        if (Input.touchCount != 0)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 900f));
        }
    }

}