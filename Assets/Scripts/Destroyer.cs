using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{  
    public GameObject player;
    public GameObject platformPrefab;
    private GameObject myPlat;
    public GameObject springPrefab;

    private void OnTriggerEnter2D(Collider2D collision) 
    {

        if (Random.Range(1,6) > 1)
        {
        myPlat = (GameObject)Instantiate(platformPrefab,new Vector2(Random.Range(-3,3),player.transform.position.y + (14+Random.Range(0.5f,1f))), Quaternion.identity);
        }
        
        else
        {
        myPlat = (GameObject)Instantiate(springPrefab,new Vector2(Random.Range(-3,3),player.transform.position.y + (14+Random.Range(0.5f,1f))), Quaternion.identity);
        }
        
        Destroy(collision.gameObject);
    }

}
