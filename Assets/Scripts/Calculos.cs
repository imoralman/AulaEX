using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculos : MonoBehaviour {

    [SerializeField]float _n1, _n2;



    // Start is called before the first frame update
    void Start() {

        

        _n1 = _n1 / _n2;
        Debug.Log("divisao" + _n1);

        _n1 = _n1 * _n2;
        Debug.Log("mutiplicacao " + _n1);

        _n1++; //_n1 += n1     ---->   _n1 = _n1 + 1

    }

    // Update is called once per frame
    void Update() {
        
    }
}
