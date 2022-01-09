using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enum1 : MonoBehaviour


{

    public enum TestEnum { TestA, TestB, TestC }

    public class Test : MonoBehaviour
    {
        TestEnum myEnum;


        void Update()
        {
            if (myEnum == TestEnum.TestA)
            {
                Debug.Log("Test A");
            }
            else if (myEnum == TestEnum.TestB)
            {
                Debug.Log("Test B");
            }
            else if (myEnum == TestEnum.TestC)
            {
                Debug.Log("Test C");
            }
        }
    }
}
