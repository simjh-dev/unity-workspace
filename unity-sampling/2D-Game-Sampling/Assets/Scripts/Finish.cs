using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Finish : MonoBehaviour
{

    private AudioSource finishSound;
    private bool isCompleted = false;

    // Start is called before the first frame update
    void Start()
    {
        finishSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.name == "Player" && !isCompleted) {
            isCompleted = true;
            finishSound.Play();
            Invoke("CompleteLevel", 2f);
            // CompleteLevel();
        }
    }

    private void CompleteLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
