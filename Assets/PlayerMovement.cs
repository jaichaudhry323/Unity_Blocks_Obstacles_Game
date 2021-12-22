using UnityEngine;

public class PlayerMovement : MonoBehaviour{
    
    // public type_of_reference name_of_variable;
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 2000f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Working from Start Function");
        //rb.useGravity = false;
        //rb.AddForce(0, 20, 50);
    }

    // Update is called once per frame
    void Update()
    {
        //rb.AddForce(0, 0 , 500*Time.deltaTime);
    }

    private void FixedUpdate()
    {
        // Time.deltaTime is the time between two frames      
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if(Input.GetKey("d")){
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}


/*
 Input is updated in the Update method 
so all jumping etc user based actions should be handled inside the update function
and not the fixedUpdate function
search net for better understanding
 */

/*
 E04
Nesting objects like nesting game camera to the player object
just drag and drop camera on player
but this makes the camera to spin when the object spins so we unparent 
and make the camera snap to the position of the player object
 */

