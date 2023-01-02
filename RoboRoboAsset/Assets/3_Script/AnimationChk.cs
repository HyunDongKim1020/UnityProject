using UnityEngine;
using System.Collections;

public class AnimationChk : MonoBehaviour {

    public Animator _playerAnim;
    public AudioSource _publicAudio;
    public AudioClip _attackSnd;
    public AudioClip _damageSnd;

	// Use this for initialization
	void Start () {

        _playerAnim = gameObject.GetComponent<Animator>();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void AttackDone()
    {
        if (_playerAnim != null) _playerAnim.SetBool("attackChk", false);
        else Debug.Log("Need Animator File");
        if (_attackSnd != null && _publicAudio != null) _publicAudio.PlayOneShot(_attackSnd);
        else Debug.Log("Need AudioSource File or Attack Audio Clip");
    }

    void DamageDone()
    {
        if (_playerAnim != null) _playerAnim.SetBool("damageChk", false);
        else Debug.Log("Need Animator File");
        if (_damageSnd != null && _publicAudio != null) _publicAudio.PlayOneShot(_damageSnd);
        else Debug.Log("Need AudioSource File or Damage Audio Clip");
        
    }
}
