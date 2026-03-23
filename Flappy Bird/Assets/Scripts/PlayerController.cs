using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

   [SerializeField] float moveSpeedY = 10.0f;

   float screenHeight;

    void Start() {

    screenHeight = GameController.Instance.ScreenHeight;
    
        
    }

    // Update is called once per frame

    void Update()
    {

        float directionY = Input.GetAxisRaw("Vertical");

        float positionY = transform.position.y + 
                            (directionY * moveSpeedY * Time.deltaTime);

        positionY = Mathf.Clamp(positionY, -screenHeight, screenHeight);

        transform.position = new Vector3(transform.position.x, positionY, transform.position.z);
        
    }
    void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag.Equals("Enemy")) {
             Debug.Log("Player Collided with enemy");
        }
    }
}
