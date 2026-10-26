using UnityEngine;
using System.Collections;

public class BlueCylinder : MonoBehaviour, ICylinder {
    Vector3 startPos;

    private void Start() {
        startPos = this.transform.position;
    }

    public void Move() {
        StartCoroutine(Movement());
    }

    private IEnumerator Movement() {
        bool forward = true;
        
        while (true) {
            yield return null;

            if (this.transform.position.y >  startPos.y + 5) {
                forward = false;
            }

            if (this.transform.position.y <  startPos.y) {
                forward = true;
            }

            if (forward) {
                this.transform.position += new Vector3(0, 0.005f, 0);
                continue;
            }
            
            this.transform.position -= new Vector3(0, 0.005f, 0);
        }
    }
}