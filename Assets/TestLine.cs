using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class TestLine : MonoBehaviour
{
    public TextMeshProUGUI textMeshProUGUI = null;
    public LayoutElement layoutElement = null;
    public Vector2 vector2 = Vector3.zero;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            vector2 = textMeshProUGUI.GetPreferredValues(textMeshProUGUI.text, 500, Mathf.Infinity);
            layoutElement.preferredHeight = vector2.y;
            Debug.Log(vector2);
        }
    }
}
