using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBird : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrenght;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            myRigidbody.velocity = Vector2.up * flapStrenght;
        }
    }
}


//https://www.youtube.com/watch?v=XtQMytORBmM&ab_channel=GameMaker%27sToolkit
//16:09