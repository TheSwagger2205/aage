using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public Text ScoreText;
    public float speed = 5f;
    public int score;
    public Transform RespawnPoint;

    private PlayerMovement2 playerMovement2;
    private Rigidbody _PBody;
    private Vector3 _inputs = Vector3.zero;
   

    void Start()
    {
        _PBody = GetComponent<Rigidbody>();
        playerMovement2 = new PlayerMovement2();
        score = 0;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
            _PBody.AddForce(Vector3.left * speed);
        if (Input.GetKey(KeyCode.D))
            _PBody.AddForce(Vector3.right * speed);
        if (Input.GetKey(KeyCode.W))
            _PBody.AddForce(Vector3.forward * speed);
        if (Input.GetKey(KeyCode.S))
            _PBody.AddForce(Vector3.back * speed);

        if (transform.position.y < -15.0f) 
        {
            playerMovement2.score++;
            ScoreText.text = "Player 2 Score: " + playerMovement2.score;

            transform.position = RespawnPoint.transform.position;
            _PBody.velocity = Vector3.zero;
        }
    }
}

