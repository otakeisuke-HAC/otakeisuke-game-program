using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateController : MonoBehaviour
{

    Animator m_Animator;
    public bool m_GateFlag = false; //ドアのフラグ

    // Start is called before the first frame update
    void Start()
    {
        //Animatorの参照を取得
        m_Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        m_Animator.SetBool("GateBool", m_GateFlag);
    }
}
