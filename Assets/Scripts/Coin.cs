using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private bool hitted = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player"&& hitted==false)
        {
            SoundManager.instance.PlayCoin();
            hitted = true;
            UIManager.instance.UpdateScore(1);
            Destroy(gameObject);
            
        }
    }
}
