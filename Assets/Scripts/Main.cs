using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public Material mat;
    public Transform m_targetObj;



    // Update is called once per frame
    void Update()
    {
        mat.SetVector("Vector3_B45F07CF", m_targetObj.position);
    }
}
