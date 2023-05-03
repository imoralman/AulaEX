using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador : MonoBehaviour {

    // GameObject --> tipo de variavel da unity

    [SerializeField] GameObject _cube;
    [SerializeField] GameObject _sphere;
    [SerializeField] GameObject _capsule;
    [SerializeField] GameObject _cylinder;

    [SerializeField] bool _checkCube;
    [SerializeField] bool _checkSphere;
    [SerializeField] bool _checkCapsule;
    [SerializeField] bool _checkCylinder;

    // Start is called before the first frame update
    void Start(){

    /*
        if (_checkCube == false) {
            _cube.SetActive(false);
        }
    */

    }

    // Update is called once per frame
    void Update(){

        if (_checkCube == false) { 
            _cube.SetActive(false);
        } else {
            _cube.SetActive(true);
        }
        //**************
        if(_checkSphere == false) {
            _sphere.SetActive(false);
        }
        else {
            _sphere.SetActive(true);
        }
        //**************
        if (_checkCapsule == false) {
            _capsule.SetActive(false);
        }
        else {
            _capsule.SetActive(true);
        }
        //***************
        if (_checkCylinder == false) {
            _cylinder.SetActive(false);
        }
        else {
            _cylinder.SetActive(true);
        }
        //****************


    }
}
