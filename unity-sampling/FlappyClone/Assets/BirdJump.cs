using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdJump : MonoBehaviour
{

    public float jumpPower;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // left button click
        if (Input.GetMouseButtonDown(0)) {
            GetComponent<AudioSource>().Play();
            rb.velocity = Vector2.up * jumpPower; // (0, 3)


        }
    }

    private void OnCollisionEnter2D(Collision2D other) {

        if(Score.score > Score.bestScore) {
            Score.bestScore = Score.score;
        }

        SceneManager.LoadScene("GameOverScene");
    }

}
