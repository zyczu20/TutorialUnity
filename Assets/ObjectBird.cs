using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBird : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    protected float flapStrenght = 25;
    public LogicScript logic;
    protected bool birdIsAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidbody.velocity = Vector2.up * flapStrenght;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;

    }
}
