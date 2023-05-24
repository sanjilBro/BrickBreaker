using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour
{
  [SerializeField] public new Rigidbody2D rigidbody ;
 public Vector2 direction;
public float speed = 20f;
[SerializeField] private float offset;

public static float screenSizeX{get;private set;}
public static float screenSizeY{get; private set;}
private void Awake()
    {
        this.rigidbody = GetComponent<Rigidbody2D>();
        screenSizeY = Camera.main.orthographicSize;
        screenSizeX = Camera.main.aspect * screenSizeY;
    }





 private void Update()
    {
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            this.direction = Vector2.left;
        }
         else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            this.direction = Vector2.right;
        }
        
        else 
        {
            this.direction = Vector2.zero;
        }
        if(transform.position.x >= screenSizeX - offset)transform.position = new Vector2(screenSizeX - offset,transform.position.y);
        else if(transform.position.x<=-screenSizeX + offset)transform.position = new Vector2(-screenSizeX +offset,transform.position.y);
    }

    private void FixedUpdate()
    {

        if(this.direction!= Vector2.zero)
        {
            this.rigidbody.transform.Translate(this.direction*this.speed * Time.deltaTime);
        }
    }
}
