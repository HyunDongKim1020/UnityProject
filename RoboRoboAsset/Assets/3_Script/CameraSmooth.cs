using UnityEngine;
using System.Collections;

public class CameraSmooth : MonoBehaviour
{

    public GameObject _target;
    public Vector3 _iniPos;
    public Vector3 _nowPos;

    // Use this for initialization
    void Start()
    {

        _iniPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = _iniPos + _target.transform.position;

    }
}
