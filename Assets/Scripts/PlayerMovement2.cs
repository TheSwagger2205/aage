using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement2 : MonoBehaviour
{
    public Text ScoreText;
    public float speed = 5f;
    public int score;
    public Transform RespawnPoint;
    public Rigidbody PBody;

    private PlayerMovement playerMovement;
    private Vector3 _inputs = Vector3.zero;

    void Start()
    {
        PBody = GetComponent<Rigidbody>();
        playerMovement = new PlayerMovement();
        score = 0;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
            PBody.AddForce(Vector3.left * speed);
        if (Input.GetKey(KeyCode.RightArrow))
            PBody.AddForce(Vector3.right * speed);
        if (Input.GetKey(KeyCode.UpArrow))
            PBody.AddForce(Vector3.forward * speed);
        if (Input.GetKey(KeyCode.DownArrow))
            PBody.AddForce(Vector3.back * speed);

        if (transform.position.y < -15.0f)
        {
            playerMovement.score++;
            ScoreText.text = "Player 1 Score: " + playerMovement.score;

            transform.position = new Vector3(128.8f, 32.3f, 58f);
            PBody.velocity = Vector3.zero;
        }
    }
}