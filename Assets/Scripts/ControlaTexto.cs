using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaTexto : MonoBehaviour
{

    [SerializeField] GameObject _cube;
    [SerializeField] GameObject _sphere;
    [SerializeField] GameObject _capsule;
    [SerializeField] GameObject _cylinder;

    [SerializeField] string _texto;

    // Start is called before the first frame update
    void Start() {
        


    }

    // Update is called once per frame
    void Update() {

        if (_texto == "cubo") {
             _cube.SetActive(true);
                } else if (_texto == "esfera"){
                    _sphere.SetActive(true);
                         }else if(_texto == "capsula") {
                              _capsule.SetActive(true);
                                }else if(_texto == "cilindro") {
                                    _cylinder.SetActive(true);
        }
        else {
            _cube.SetActive(false);
            _sphere.SetActive(false);
            _capsule.SetActive(false);
            _cylinder.SetActive(false);
        }
        
        
        }
}
