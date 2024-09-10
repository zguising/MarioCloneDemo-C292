using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] int pointValue;

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (gameObject.tag == "Coin1")
            {
                UIManager.Instance.IncreaseScore(1);
            }
            else if (gameObject.tag == "Coin2")
            {
                UIManager.Instance.IncreaseScore(5);
            }
            else if (gameObject.tag == "Coin10")
            {
                UIManager.Instance.IncreaseScore(10);
            }
            Destroy(gameObject);
        }
    }


}
