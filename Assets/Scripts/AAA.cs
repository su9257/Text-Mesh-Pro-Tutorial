using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AAA : MonoBehaviour
{

    private const float lowPassFilterFactor = 0.2f;
    protected void Start()
    {
        //设置设备陀螺仪的开启/关闭状态，使用陀螺仪功能必须设置为 true
        Input.gyro.enabled = true;
        //获取设备重力加速度向量
        Vector3 deviceGravity = Input.gyro.gravity;
        //设备的旋转速度，返回结果为x，y，z轴的旋转速度，单位为（弧度/秒）
        Vector3 rotationVelocity = Input.gyro.rotationRate;
        //获取更加精确的旋转
        Vector3 rotationVelocity2 = Input.gyro.rotationRateUnbiased;
        //设置陀螺仪的更新检索时间，即隔 0.1秒更新一次
        Input.gyro.updateInterval = 0.1f;
        //获取移除重力加速度后设备的加速度
        Vector3 acceleration = Input.gyro.userAcceleration;
    }

    protected void Update()
    {
        //Input.gyro.attitude 返回值为 Quaternion类型，即设备旋转欧拉角
        transform.rotation = Quaternion.Slerp(transform.rotation, Input.gyro.attitude, lowPassFilterFactor);
    }

    void OnGUI()
    {
        GUI.Label(new Rect(50, 100, 500, 20), "Label : " + Input.gyro.attitude.x + "       " + Input.gyro.attitude.y + "         " + Input.gyro.attitude.z);
    }

}
