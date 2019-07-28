using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using DG.Tweening;
using TMPro;

public class TestDotween : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string str = "New Text <sprite=12_t index=0>.";
         str = "New Text <sprite name=\"Smiling face with smiling eyes\"> .";
        TextMeshProUGUI textMeshProUGUI =  GetComponent<TextMeshProUGUI>();
        textMeshProUGUI.text = "";
        textMeshProUGUI.DOText(str, 2).OnComplete(()=> {
            Debug.Log("完成");

            textMeshProUGUI.text = "";
            textMeshProUGUI.ForceMeshUpdate();
            string str1 = "New Text <sprite index=0> .";
            textMeshProUGUI.DOText(str, 2).OnComplete(() => { Debug.Log("完成"); });
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
