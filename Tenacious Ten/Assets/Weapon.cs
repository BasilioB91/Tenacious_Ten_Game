using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public Animator animator;
    public Transform firePoint;
    public GameObject lemonBulletPreFab;

	// Update is called once per frame
	void Update () {
        //animator.SetBool("IsShooting", false);
        if (Input.GetButtonDown("Fire1")){
            StartCoroutine(Shoot());
            //animator.SetBool("IsShooting", true);
        }
    }

    public IEnumerator Shoot () {
        //shoot logic
        animator.SetBool("IsShooting", true);
        Instantiate(lemonBulletPreFab, firePoint.position, firePoint.rotation);
        yield return new WaitForSeconds(.6f);
        animator.SetBool("IsShooting", false);
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Debug.Log(hitInfo.name);
    }
}
