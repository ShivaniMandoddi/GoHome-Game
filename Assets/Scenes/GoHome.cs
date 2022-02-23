using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoHome : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector2 startPosition;
    [SerializeField]
    private Vector2 homePosition;
    private Vector2 distance;
    void Start()
    {
        print("Hey! Welcome to my game Go Home");
        print("Instructions how to play game");
        print("Press up-arrow to move forward\nPress down-arrow to move backward\n " +
            "Press left arrow to move left \n press right arrow to move right\n");
        
        print("My start position is " + startPosition + "\n My home position is " + homePosition);
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

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            startPosition = startPosition + new Vector2(0,1);
            distance = homePosition - startPosition;
            print("distance to home is " + distance);
            float finalDistance = distance.magnitude;
            if (distance.y > 0)
                print("Move Forward");
            else if (distance.y < 0)
                print("Move Backward");
            else if (distance.x > 0)
                print("Move Right");
            else if (distance.x < 0)
                print("Move Left");
            else if (finalDistance == 0)
                print("You reached destination\n");
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            startPosition = startPosition + new Vector2(0,-1);
            distance = homePosition - startPosition;
            print("distance to home is " + distance);
            float finalDistance = distance.magnitude;
            if (distance.y > 0)
                print("Move Forward");
            else if (distance.y < 0)
                print("Move Backward");
            else if (distance.x > 0)
                print("Move Right");
            else if (distance.x < 0)
                print("Move Left");
            else if (finalDistance == 0)
                print("You reached destination\n");

        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            startPosition = startPosition + new Vector2(-1, 0);
            distance = homePosition - startPosition;
            print("distance to home is " + distance);
            float finalDistance = distance.magnitude;
            if (distance.y > 0)
                print("Move Forward");
            else if (distance.y < 0)
                print("Move Backward");
            else if (distance.x > 0)
                print("Move Right");
            else if (distance.x < 0)
                print("Move Left");
            else if (finalDistance == 0)
                print("You reached destination\n");
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            startPosition = startPosition + new Vector2(1, 0);
            distance = homePosition - startPosition;
            print("distance to home is " + distance);
            float finalDistance = distance.magnitude;
            if (distance.y > 0)
                print("Move Forward");
            else if (distance.y < 0)
                print("Move Backward");
            else if (distance.x > 0)
                print("Move Right");
            else if (distance.x < 0)
                print("Move Left");
            else if (finalDistance == 0)
                print("You reached destination\n");
        }
    }
   }
