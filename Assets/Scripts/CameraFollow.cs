using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public GameObject follow;
    public Vector2 minCamPos, maxCamPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float posx = follow.transform.position.x;
        float posy = follow.transform.position.y;

        transform.position = new Vector3(
            Mathf.Clamp(posx, minCamPos.x, maxCamPos.x), 
            Mathf.Clamp(posy, minCamPos.y, maxCamPos.y), 
            transform.position.z);

    }
}
