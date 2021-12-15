using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMoving : MonoBehaviour
{
    float playerSpeed=0.01f;
    int speedMultiplier=2;
    public GameObject mainCamera;
    public GameObject road;
    // Start is called before the first frame update
    void Start(){}
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f,0f,playerSpeed);
        mainCamera.transform.Translate(0f,0f,playerSpeed);
        if(Input.GetKeyDown("space")){
            speedUp();
        }
        Moving();
    }

    void speedUp()
    {
        playerSpeed=playerSpeed*speedMultiplier;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "RoadNext")
        {
            GameObject current = GameObject.Find ("RoadCurrent");
            GameObject next = GameObject.Find ("RoadNext");
            GameObject nextP = GameObject.Find ("RoadNext+");
            if (current){
                Destroy (current.gameObject);
            }
            next.name="RoadCurrent";
            nextP.name="RoadNext";
            Vector3 position=new Vector3(0,0,nextP.transform.position.z+50);
            Debug.Log(position);
            GameObject newRoad;
            newRoad=Instantiate(road, position, Quaternion.identity); 
            newRoad.name="RoadNext+";
        }
        if (collision.gameObject.name == "Left")
        {
            Debug.Log("left");
        }
    }

    void Moving()
    {
        if(Input.GetKey(KeyCode.LeftArrow)){
            if(transform.position.x>-2){
              transform.Translate(-0.015f,0f,0f);
            }
        }

        if(Input.GetKey(KeyCode.RightArrow)){
            if(transform.position.x<2){
              transform.Translate(0.015f,0f,0f);
            }
        }
    }
}
