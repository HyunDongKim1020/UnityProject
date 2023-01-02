using UnityEngine;
using System.Collections;

public class HP_Bar : MonoBehaviour {
	
	public GameObject _target;
	private TextMesh _HpVal;
	private TextMesh _name;
	private GameObject _HpBar;

	// Use this for initialization
	void Start () {
		
		if(_target!=null)
		{
			_HpVal = transform.Find("3_HpVal").GetComponent<TextMesh>();
			_name = transform.Find("2_Name").GetComponent<TextMesh>();
			_HpBar = transform.Find("1_HpBarParent").gameObject;
			
			if(_target.tag == "player")
			{
				_target.GetComponent<PlayerScript>()._HpVal = _HpVal;
				_target.GetComponent<PlayerScript>()._hpBar = _HpBar;
				if(_name!=null)
				{
					_name.text = "PLAYER";
					_name.color = Color.blue;
				}
			}
			else if(_target.tag == "enemy")
			{
				
				_target.GetComponent<EnemyScript>()._HpVal = _HpVal;
				_target.GetComponent<EnemyScript>()._hpBar = _HpBar;
				if(_name!=null)
				{
					_name.text = "ENEMY";
					_name.color = Color.red;
				}
			}
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.position = new Vector3 (_target.transform.position.x, transform.position.y, _target.transform.position.z);
	
	}
}
