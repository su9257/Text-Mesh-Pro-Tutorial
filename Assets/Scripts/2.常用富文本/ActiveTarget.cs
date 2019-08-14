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
            if (targetObject != null)
            {
                TextGroup.Instance.OpenObject(targetObject.name);
            }
        });
    }


}
