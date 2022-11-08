using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Joystick joystick;
    public Rigidbody2D rb;
    public Slider HealthBar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 Input = new Vector2(joystick.Horizontal , 0);
        rb.MovePosition((Vector2)transform.position + Input * 10 * Time.deltaTime);

        if(Input.x > 0)
        {
            HealthBar.SetDirection(Slider.Direction.RightToLeft , true);
            transform.rotation = Quaternion.Euler(0,180,0);
        }
        if(Input.x < 0)
        {
            HealthBar.SetDirection(Slider.Direction.LeftToRight , true);
            transform.rotation = Quaternion.Euler(0,0,0);
        }
    }
}
