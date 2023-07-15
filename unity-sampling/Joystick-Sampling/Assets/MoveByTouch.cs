using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveByTouch : MonoBehaviour
{

    public Joystick joystick;
    public float speed = 1f;
    private Vector2 screenBounds;
    private float playerWidth;
    private float playerHeight;

    private void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3 (Screen.width, Screen.height, Camera.main.transform.position.z));
        playerWidth = GetComponent<SpriteRenderer>().bounds.size.x;
        playerHeight = GetComponent<SpriteRenderer>().bounds.size.y;
    }


    void FixedUpdate()
    {
        float x = joystick.Horizontal;
        float y = joystick.Vertical;
        if(x == 0 && y == 0) return;
        Vector3 move = new Vector3(x, y, 0) * speed * Time.fixedDeltaTime;
        Vector3 result = transform.position + move;
        if(result.x - (playerWidth / 2) < -screenBounds.x) result.x = -screenBounds.x + (playerWidth / 2);
        if(result.y - (playerHeight / 2) < -screenBounds.y) result.y = -screenBounds.y + (playerHeight / 2);
        if(result.x + (playerWidth / 2) > screenBounds.x) result.x = screenBounds.x - (playerWidth / 2);
        if(result.y + (playerHeight / 2) > screenBounds.y) result.y = screenBounds.y - (playerHeight / 2);
        transform.position = result;
    }
}
