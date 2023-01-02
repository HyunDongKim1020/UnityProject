using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonClicked : MonoBehaviour {

    //private GUITexture _thisObjBtn;
    private Button _thisObjBtn;
    public GameObject _target;
    public string _functionName = "Regame";

	// Use this for initialization
	void Start () {

        _thisObjBtn = gameObject.GetComponentInChildren<Button>();

    }
	
	// Update is called once per frame
    void Update()
    {

        //if( Input.GetMouseButtonDown(0))
        //{
        //    if(_thisObjBtn.HitTest(Input.mousePosition))
        //    {

        //        if (_target != null)
        //        {
        //            _target.SendMessage(_functionName, SendMessageOptions.DontRequireReceiver);
        //        }
        //    }
        //}
    }
}
