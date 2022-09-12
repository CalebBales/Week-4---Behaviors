using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour 
// MonoBehaviour is the parent class
// Any class that is gonna be a component is gonna be a child of MonoBehaviour
// MonoBehaviour is the parent class of all Unity components
{
    // serialized means that you can change the values in the Unity Editor, instead
    // of having to go back to the script
    [SerializeField] float moveSpeed;
    [SerializeField] Vector3 moveDirection;

    [SerializeField] GameObject StationarySphere;

    float totalMoveDistance;
    Vector3 startingLocation;   

    // Start is called before the first frame update
    void Start()
    {
        totalMoveDistance = 10f;
        startingLocation = gameObject.transform.position;
    }

    
    // Update is called once per frame
    void Update()
    {
        float distanceTraveled = GetDistanceTraveled();

        if (distanceTraveled > totalMoveDistance)
        {
            FlipMoveDirection();
        }

        //MoveObject thisMoveObject = GetComponent<MoveObject>();
        gameObject.transform.Translate(moveDirection * moveSpeed);
    }

    void FlipMoveDirection()
    {
        moveDirection = -moveDirection;
    }

    float GetDistanceTraveled()
    {
        return Vector3.Distance(gameObject.transform.position, startingLocation);
    }
}
