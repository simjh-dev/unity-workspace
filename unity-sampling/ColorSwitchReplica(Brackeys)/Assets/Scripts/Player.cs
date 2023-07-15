using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public float jumpForce = 3f;
    public Rigidbody2D rb;
    public SpriteRenderer sr;

    public Color colorCyan;
    public Color colorYellow;
    public Color colorMagenta;
    public Color colorPink;

    private string currentColor;

    private void Start() {
        SetRandomColor();
    }

    public void ButtonOnClick() {
        rb.velocity = Vector2.up * jumpForce;
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {

        if(other.tag == "ColorChanger") {
            SetRandomColor();
            Destroy(other.gameObject);
            return;
        }   

        if(other.tag != currentColor) {
            Debug.Log("Game Over!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }   

    }
    
    private void SetRandomColor() {
        // 0 <= idx < 4 
        int ranIdx = Random.Range(0, 4);

        switch(ranIdx) 
        {
            case 0:
                currentColor = "Cyan";
                sr.color = colorCyan;
                break;
            case 1:
                currentColor = "Yellow";
                sr.color = colorYellow;
                break;
            case 2:
                currentColor = "Magenta";
                sr.color = colorMagenta;
                break;
            case 3:
                currentColor = "Pink";
                sr.color = colorPink;
                break;
        }


    }
}
