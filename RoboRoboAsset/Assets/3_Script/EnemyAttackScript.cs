using UnityEngine;
using System.Collections;

public class EnemyAttackScript : MonoBehaviour {
	
	public EnemyScript _EnemySt;

	// Use this for initialization
	void Start () {
		
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
    void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "player")
        {
            Vector3 _Vec = (other.transform.position - transform.position).normalized;
            _Vec.y=0;
            other.transform.localPosition += _Vec * 0.5f;
			other.SendMessage("Damaged",10.0f);
        }
        
    }
}
