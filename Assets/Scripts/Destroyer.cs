using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{  
    public GameObject Player;
    public GameObject PlatformPrefab;
    public GameObject SpringPrefab;
    private GameObject _myPlat;

    private void OnTriggerEnter2D(Collider2D collision) 
    {

        if (Random.Range(1,6) > 1)
        {
        _myPlat = (GameObject)Instantiate(PlatformPrefab,new Vector2(Random.Range(-3,3),Player.transform.position.y + (14+Random.Range(0.5f,1f))), Quaternion.identity);
        }
        
        else
        {
        _myPlat = (GameObject)Instantiate(SpringPrefab,new Vector2(Random.Range(-3,3),Player.transform.position.y + (14+Random.Range(0.5f,1f))), Quaternion.identity);
        }
        
        Destroy(collision.gameObject);
    }

}
