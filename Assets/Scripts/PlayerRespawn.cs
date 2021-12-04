using System.Runtime.ExceptionServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRespawn : MonoBehaviour
{

private float checkPointPositionX,checkPointPositionY;
public Animator animator;
public GameObject[] hearts;
private int life;


    void Start()
    {
life = hearts.Length;

        if(PlayerPrefs.GetFloat("checkPointPositionX")!=0) {
            transform.position = (new Vector2(PlayerPrefs.GetFloat("checkPointPositionX"), PlayerPrefs.GetFloat("checkPointPositionY")));
        }
    }

    private void checkLife() {
        if (life < 1)
        {
            Destroy(hearts[0].gameObject);
                    animator.Play("hit");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        CheckDoggy.perritosCollected=0;
        }else if (life < 2)
        {
            Destroy(hearts[1].gameObject);
                    animator.Play("hit");
        }else if (life <3)
        {
            Destroy(hearts[2].gameObject);
                    animator.Play("hit");
        }
    }

    public void ReachedCheckPoint (float x, float y) {
        PlayerPrefs.SetFloat("checkPointPositionX", x);
        PlayerPrefs.SetFloat("checkPointPositionY", y);
    }

    public void PlayerDamaged () {
life--;
checkLife();
    }

}
