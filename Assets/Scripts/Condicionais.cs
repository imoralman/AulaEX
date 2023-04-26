using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condicionais : MonoBehaviour
{

    [SerializeField] float _f1, _f2;
    [SerializeField] int _i1, _i2;
    [SerializeField] string _t1, _t2;
    [SerializeField] bool _b1, _b2;



    // Start is called before the first frame update
    void Start()
    {


        if (_i1 == _i2) {
            Debug.Log("sao iguais");
        }else {
            Debug.Log("sao diferente");
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
