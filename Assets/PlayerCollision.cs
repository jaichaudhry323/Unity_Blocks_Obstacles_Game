using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hit Hit Hit");
        Debug.Log(collision.collider.name);

        // Searching for name and doing stuff is not recommended at all
        // as many objects can have same name but different properties 
        // also its time consuming
        //if(collision.collider.name == "Obstacle"){
        //    Debug.Log("We hit an Obstacle | name");
        //}


        // So better way is to use 'tag' which is like assigning a class to an object
        // 'tag' is used to group objects together
        if (collision.collider.tag == "Obstacle"){
            Debug.Log("We hit an Obstacle | tag");
            movement.enabled = false;
        }


    }

}
/*
 * E05
 Dont forget to add rigidbody component if you want to modify mass and gravity
 type of properties of the object

Creating tags

Disabling players movement when player hits obstacle

Adding reference to playermovement script
 */