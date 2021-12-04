using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
public class PerritoManager : MonoBehaviour
{


public static bool allDogs=false;
        public Text levelClearedDogs;
    public Text totalDogs;
    public Text dogsCollected;
    private int totalDogsInLevel;
     public GameObject endPanel;
    // Start is called before the first frame update
    void Start()
    {
        totalDogsInLevel = transform.childCount;
    }

    // Update is called once per frame
    private void Update()
{
    AllDogsCollected();
 totalDogs.text = totalDogsInLevel.ToString();
 dogsCollected.text = CheckDoggy.perritosCollected.ToString();
}

public void AllDogsCollected(){
    if (CheckDoggy.perritosCollected == totalDogsInLevel)
    {
         levelClearedDogs.gameObject.SetActive(true);
         allDogs=true;
          if (CocoaManager.allFruits==true && allDogs==true)
        {
             Time.timeScale=0;
    endPanel.SetActive(true);
        }

    }
}
}
