using UnityEngine;
using System.Collections;

public class PlayerAttackScript : MonoBehaviour {
	

	public PlayerScript _PlayerSt;

	// Use this for initialization
	void Start () {
		
		_PlayerSt = GameObject.FindWithTag("player").GetComponent<PlayerScript>();
		_PlayerSt._attackChkCol = gameObject.GetComponent<BoxCollider>();

		gameObject.GetComponent<BoxCollider>().enabled = false;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "enemy")
        {
            Vector3 _Vec = (other.transform.position - transform.position).normalized;
            _Vec.y=0;
            other.transform.localPosition += _Vec * 0.5f;
			other.SendMessage("Damaged",10.0f);
        }
        
    }
}
