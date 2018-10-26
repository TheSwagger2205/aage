using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTwoController : MonoBehaviour
{
    public Transform respawnPoint;
    public Text pointText;

    private static Player playerTwo;
    private static Rigidbody rigidbody;
    private static Transform transform;
    
    void Start ()
    {
        playerTwo = new Player()
        {
            Score = 0,
            Speed = 10,
            Respawnpoint = respawnPoint,
            FallLimit = -30f
        };

        rigidbody = GetComponent<Rigidbody>();
        transform = GetComponent<Transform>();
    }
	
	void Update ()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
            rigidbody.AddForce(Vector3.left * playerTwo.Speed);
        if (Input.GetKey(KeyCode.RightArrow))
            rigidbody.AddForce(Vector3.right * playerTwo.Speed);
        if (Input.GetKey(KeyCode.UpArrow))
            rigidbody.AddForce(Vector3.forward * playerTwo.Speed);
        if (Input.GetKey(KeyCode.DownArrow))
            rigidbody.AddForce(Vector3.back * playerTwo.Speed,.);

        if (transform.position.y < playerTwo.FallLimit)
        {
            Addpoint();
            pointText.text = "Player 2 Score: " + playerTwo.Score;
            Respawn();
        }
    }

    public static void Addpoint()
    {
        playerTwo.Score++;
    }
    public static void Respawn()
    {
        transform.position = playerTwo.Respawnpoint.transform.position;
        rigidbody.velocity = Vector3.zero;
    }
}
