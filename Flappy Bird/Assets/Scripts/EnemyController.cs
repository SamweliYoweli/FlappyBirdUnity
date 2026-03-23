using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour

{
    Vector3 moveDirection = Vector3.zero;

    [SerializeField] float minMoveSppedX = 2.5f;
    [SerializeField] float maxMoveSpeedX = 7.5f;
    // Start is called before the first frame update
    [SerializeField] int scoreValue = 3;
    [SerializeField] GameObject effect;
    void Start()
    {
        float randomMoveSpeedX =
             Random.Range(minMoveSppedX, maxMoveSpeedX);
        moveDirection =
            new Vector3(randomMoveSpeedX, 0.0f, 0.0f);

    }

    // Update is called once per frame
    void Update()
    {
         transform.Translate(-moveDirection * Time.deltaTime);
        
    }

    void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag.Equals("Player")) {

    Instantiate(effect, 
                transform.position,
                Quaternion.identity);

        GameController.Instance.UpdateScore(scoreValue);
        // Remove from the hierachy the 
        // game object this script is attached to
        Destroy(gameObject);
        }
    }
    
}
