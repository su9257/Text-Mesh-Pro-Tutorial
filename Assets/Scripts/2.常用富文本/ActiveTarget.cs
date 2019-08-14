using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ActiveTarget : MonoBehaviour
{

    public GameObject targetObject = null;

    void Start()
    {
       GetComponent<Button>().onClick.AddListener(()=> 
        {
            GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("Player");
            for (int i = 0; i < gameObjects.Length; i++)
            {
                if (targetObject.name == gameObjects[i].name)
                {
                    gameObjects[i].SetActive(true);
                }
                else
                {
                    gameObjects[i].SetActive(false);
                }
            }
        });
    }


}
