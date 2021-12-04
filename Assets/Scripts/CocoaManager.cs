using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CocoaManager : MonoBehaviour
{

    public Text levelCleared;
    public Text totalFruits;
    public Text fruitsCollected;
    private int totalFruitsInLevel;
    public static bool allFruits=false;
    public GameObject endPanel;



void Start()
{
  totalFruitsInLevel = transform.childCount;
}

private void Update()
{
    AllFruitsCollected();
 totalFruits.text = totalFruitsInLevel.ToString();
 fruitsCollected.text = (totalFruitsInLevel - transform.childCount).ToString();
}

public void AllFruitsCollected () {

    
    
    if (transform.childCount==0)
    {

        Debug.Log("No quedan frutas, victoria!");
        levelCleared.gameObject.SetActive(true);
        allFruits=true;

        if (allFruits==true && PerritoManager.allDogs==true)
        {
             Time.timeScale=0;
    endPanel.SetActive(true);
        }
    }

}
}
