using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextGroup : MonoBehaviour
{
    public List<TextMeshProUGUI> textMeshProUGUIs = new List<TextMeshProUGUI>();
    private static TextGroup instance = null;
    public static TextGroup Instance
    {
        get
        {
            return instance;
        }
    }

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            textMeshProUGUIs.Add(transform.GetChild(i).GetComponent<TextMeshProUGUI>());
        }
    }

    public void OpenObject(string Name)
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            if (textMeshProUGUIs[i].name == Name)
            {
                textMeshProUGUIs[i].gameObject.SetActive(true);
            }
            else
            {
                textMeshProUGUIs[i].gameObject.SetActive(false);
            }
        }
    }
}
