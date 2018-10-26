using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerOneController : MonoBehaviour
{
    public Transform respawnPoint;
    public Text pointText;

    private static Player playerOne;
    private static Rigidbody rigidbody;
    private static Transform transform;
    private PlayerTwoController playerTwo;
    

    void Start ()
    {
        playerOne = new Player()
        {
            Score = 0,
            Speed = 10,
            Respawnpoint = respawnPoint,
            FallLimit = -30f
        };

        rigidbody = GetComponent<Rigidbody>();
        transform = GetComponent<Transform>();
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.A))
            rigidbody.AddForce(Vector3.left * playerOne.Speed);
        if (Input.GetKey(KeyCode.D))
            rigidbody.AddForce(Vector3.right * playerOne.Speed);
        if (Input.GetKey(KeyCode.W))
            rigidbody.AddForce(Vector3.forward * playerOne.Speed);
        if (Input.GetKey(KeyCode.S))
            rigidbody.AddForce(Vector3.back * playerOne.Speed);

        if (transform.position.y < playerOne.FallLimit)
        {
            Addpoint();
            pointText.text = "Player 1 Score: " + playerOne.Score;
            Respawn();
        }
    }

    public static void Addpoint()
    {
        playerOne.Score++;
    }
    public static void Respawn()
    {
        transform.position = playerOne.Respawnpoint.transform.position;
        rigidbody.velocity = Vector3.zero;
    }
}
