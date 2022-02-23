using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoHomeManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 startPosition;
    [SerializeField]
    private Vector3 homePosition;
    private Vector3 distance;
    void Start()
    {
        print("Hey! Welcome to my game Go Home");
        print("Instructions how to play game");
        print("Press up-arrow to move forward\nPress down-arrow to move backward\n " +
            "Press left arrow to move left \n press right arrow to move right\n");
        print("Press N for up \n Press M for down\n");
        print("My start position is "+startPosition+ "\n My home position is "+homePosition);
        distance = homePosition - startPosition;
        print("The Distance to cover is " + distance.magnitude);
        float finalDistance = distance.magnitude;
        if (finalDistance > 0)
            print("Move Forward\n");
        else if (finalDistance < 0)
            print("Move Backward\n");
        else if (finalDistance == 0)
            print("You reached destination\n");
    }

    // Update is called once per frame
    void Update()
    {
        // print("I am in update function");

        CheckPlayerMovement(KeyCode.UpArrow,new Vector3(0,0,1));
        CheckPlayerMovement(KeyCode.DownArrow, new Vector3(0, 0, -1));
        CheckPlayerMovement(KeyCode.LeftArrow, new Vector3(-1, 0, 0));
        CheckPlayerMovement(KeyCode.RightArrow, new Vector3(1, 0, 0));
        CheckPlayerMovement(KeyCode.N, new Vector3(0, 1, 0));
        CheckPlayerMovement(KeyCode.M, new Vector3(0, -1, 0));

        /*
        distance = homePosition - startPosition;
        print("distance to home is " + distance);
        float finalDistance = distance.magnitude;
        if (distance.z > 0)
            print("Move Forward");
        else if (distance.z < 0)
            print("Move Backward");
        else if (distance.x > 0)
            print("Move Right");
        else if (distance.x < 0)
            print("Move Left");
        else if (distance.y > 0)
            print("Move up");
        else if (distance.y < 0)
            print("Move down");
        else if (finalDistance == 0)
            print("You reached destination\n");*/

        //print("Up Arrow Pressed\n");

        //startPosition = startPosition - 1;

    }

    private void CheckPlayerMovement(KeyCode arrow,Vector3 value)
    {
        if (Input.GetKeyDown(arrow))
        {
            startPosition = startPosition + value;
            distance = homePosition - startPosition;
            print("distance to home is " + distance);
            float finalDistance = distance.magnitude;
            if (distance.z > 0)
                print("Move Forward");
            else if (distance.z < 0)
                print("Move Backward");
            else if (distance.x > 0)
                print("Move Right");
            else if (distance.x < 0)
                print("Move Left");
            else if (distance.y > 0)
                print("Move up");
            else if (distance.y < 0)
                print("Move down");
            else if (finalDistance == 0)
                print("You reached destination\n");
        }
        /*if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            startPosition = startPosition + new Vector3(0, 0, 1);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            startPosition = startPosition + new Vector3(0, 0, -1);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            startPosition = startPosition + new Vector3(-1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            startPosition = startPosition + new Vector3(1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            startPosition = startPosition + new Vector3(0, 1, 0);
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            startPosition = startPosition + new Vector3(0, -1, 0);
        }*/
    }
}
