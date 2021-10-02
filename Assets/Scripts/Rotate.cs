using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Direction {UP, DOWN, LEFT, RIGHT}

public class Rotate : MonoBehaviour
{
    public Direction dirToRotate;
    public Quaternion rotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player")
        {
            objRotate(other.gameObject);
        }
    }

    void objRotate(GameObject obj)
    {
        Debug.Log("Rotation: " + dirToRotate.ToString());
        switch (dirToRotate)
        {
            case Direction.UP:
                rotation = new Quaternion(0, 100, 0, 0);
                break;

            case Direction.DOWN:
                rotation = new Quaternion(0, -100, 0, 0);
                break;

            case Direction.LEFT:
                rotation = new Quaternion(-100, 0, 0, 0);
                break;

            case Direction.RIGHT:
                rotation = new Quaternion(100, 0, 0, 0);
            break;
        }
        obj.transform.rotation = rotation;
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the player game object or the level
        
    }
}
