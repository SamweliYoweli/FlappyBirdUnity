using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour {
    // Start is called before the first frame update

    [SerializeField] int scoreValue = -1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate(){
        
        if(transform.position.x <
         (-GameController.Instance.ScreenWidth - GameController.Instance.ScreenOffset)) {
            GameController.Instance.UpdateScore(scoreValue);
                Destroy(gameObject);
            }
        
    }
}
