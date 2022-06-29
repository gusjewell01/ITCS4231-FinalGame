using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DRotation : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject rotater;
    public bool rotateChecker;
    public GameObject player;
    void Start()
    {
        rotateChecker = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other) {
        

        Debug.Log("Rotation");
        if (rotateChecker) {
            if (RotaterPosition.position == 1) {
                if (other.gameObject.tag =="2") {
                    player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y+ 3f, 0);
                rotater.transform.Rotate(72, 0, 0);
                RotaterPosition.position = 2;
                rotateChecker = false;
                StartCoroutine(cooldown());
                }
                if (other.gameObject.tag =="5") {
            player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y+3f, 0);
                rotater.transform.Rotate(-72f, 0, 0);
                RotaterPosition.position = 5;
                rotateChecker = false;
                StartCoroutine(cooldown());
                }
            }
            if (RotaterPosition.position == 2) {
                if (other.gameObject.tag =="3") {
                    player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y+3f, 0);
                rotater.transform.Rotate(72f, 0, 0);
                RotaterPosition.position = 3;
                rotateChecker = false;
                StartCoroutine(cooldown());
                }
                if (other.gameObject.tag =="1") {
                    player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y+3f, 0);
                rotater.transform.Rotate(-72f, 0, 0);
                RotaterPosition.position = 1;
                rotateChecker = false;
                StartCoroutine(cooldown());
                }
            }
            if (RotaterPosition.position == 3) {
                if (other.gameObject.tag =="4") {
                player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y+3f, 0);
                rotater.transform.Rotate(72f, 0, 0);
                RotaterPosition.position = 4;
                rotateChecker = false;
                StartCoroutine(cooldown());
                }
                if (other.gameObject.tag =="2") {
                    player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y+3f, 0);
                rotater.transform.Rotate(-72f, 0, 0);
                RotaterPosition.position = 2;
                rotateChecker = false;
                StartCoroutine(cooldown());
                }
            }
            if (RotaterPosition.position == 4) {
                if (other.gameObject.tag =="5") {
                player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y+3f, 0);
                rotater.transform.Rotate(72f, 0, 0);
                RotaterPosition.position = 5;
                rotateChecker = false;
                StartCoroutine(cooldown());
                }
                if (other.gameObject.tag =="3") {
                    player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y+3f, 0);
                rotater.transform.Rotate(-72f, 0, 0);
                RotaterPosition.position = 3;
                rotateChecker = false;
                StartCoroutine(cooldown());
                }
            }

            if (RotaterPosition.position == 5) {
                if (other.gameObject.tag =="1") {
                player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y+3f, 0);
                rotater.transform.Rotate(72f, 0, 0);
                RotaterPosition.position = 1;
                rotateChecker = false;
                StartCoroutine(cooldown());
                }
                if (other.gameObject.tag =="4") {
                    player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y+3f, 0);
                rotater.transform.Rotate(-72f, 0, 0);
                RotaterPosition.position = 4;
                rotateChecker = false;
                StartCoroutine(cooldown());
                }
            }
            
        }
    }

    IEnumerator cooldown() {
        yield return new WaitForSeconds(.2f);
        rotateChecker = true;
    }
    
}
    

