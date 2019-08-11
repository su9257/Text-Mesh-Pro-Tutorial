using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamGyro : MonoBehaviour
{
    GameObject camParent;

    public float speed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        camParent = new GameObject("CamParent");
        camParent.transform.position = transform.position;
        transform.parent = camParent.transform;
        Input.gyro.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void LateUpdate()
    {
        //camParent.transform.Rotate(0, -Input.gyro.rotationRateUnbiased.y * speed, 0);
        //transform.Rotate(-Input.gyro.rotationRateUnbiased.x * speed, 0, 0);

        //camParent.transform.Rotate(0, -Input.gyro.rotationRate.y * speed, 0);
        //transform.Rotate(-Input.gyro.rotationRate.x * speed, 0, 0);

        //camParent.transform.Rotate(0, -Input.gyro.rotationRate.y * speed, 0);
        transform.Rotate(-Input.gyro.rotationRate.x * speed, -Input.gyro.rotationRate.y * speed, 0);
    }
}
