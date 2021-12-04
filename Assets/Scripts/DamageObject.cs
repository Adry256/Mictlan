using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageObject : MonoBehaviour
{

  //  public GameObject transition;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.CompareTag("Player")) {
            Debug.Log("AUCH");
            collision.transform.GetComponent<PlayerRespawn>().PlayerDamaged();
            //transition.SetActive(true);
            // Destroy(collision.gameObject);
        }
    }
}
