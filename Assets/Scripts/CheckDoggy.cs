using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckDoggy : MonoBehaviour
{

public static bool isNear;
public static int perritosCollected=0;
private void OnTriggerEnter2D(Collider2D collision)
{
    if (collision.CompareTag("Player"))
    {
       // collision.GetComponent<PlayerRespawn>().ReachedCheckPoint(transform.position.x, transform.position.y);
        GetComponent<Animator>().enabled = true;
        Debug.Log("Salvame");
        isNear = true;
        Debug.Log(isNear);
        perritosCollected++;
        Debug.Log(perritosCollected);
    }
}

private void OnTriggerExit2D(Collider2D collision)
{
        if (collision.CompareTag("Player"))
    {
        Debug.Log("No te vayas!!!!!!!");
        isNear = false;
        Debug.Log(isNear);
    }
}

}
