using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DetectRedBall : MonoBehaviour
{
    public GameObject secondLevel;
    public GameObject player;
    public GameObject secondLevelSpawn;
    public GameObject thirdlevelspawn;
    public Canvas canvas;
    public GameObject SecretWall;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.name == "RedButton")
            {
                if (Input.GetMouseButtonDown(0))
                {
                    Debug.Log("Clicked Red Button");
                    secondLevel.SetActive(true);
                    secondLevelSpawn.SetActive(false);
                }
            }
            if (hit.transform.name == "RedButton2")
            {
                if (Input.GetMouseButtonDown(0))
                {
                    Debug.Log("Clicked Red Button");
                    secondLevel.SetActive(true);
                    thirdlevelspawn.SetActive(false);
                }
            }
            if (hit.transform.name == "RedButton3")
            {
                if (Input.GetMouseButtonDown(0))
                {
                    Debug.Log("Clicked Red Button");
                    SecretWall.SetActive(false);

                }
            }
            if (hit.transform.name == "RedButton4")
            {
                if (Input.GetMouseButtonDown(0))
                {
                    Debug.Log("Clicked Red Button");
                    canvas.gameObject.SetActive(true);
                }
            }
        }


    }
}
