using UnityEngine;
public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(player.position);

        transform.position = player.position + offset;
    }
}

/*
 E04 
Transform component is responsible for position rotation and scale
so we create a reference of type Transform for Camera object
 */