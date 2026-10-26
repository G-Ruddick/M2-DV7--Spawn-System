using UnityEngine;
using System.Collections;

public class BlueSphere : MonoBehaviour, ISphere {
    public void Expand() {
        StartCoroutine(Movement());
    }

    private IEnumerator Movement() {
        bool expand = true;
        
        while (true) {
            yield return null;

            if (expand) {
                this.transform.localScale += new Vector3(0, 0.005f, 0);
                
                if (this.transform.localScale.y < 5) {
                    continue;
                }

                expand = false;
            }
            
            this.transform.localScale -= new Vector3(0, 0.005f, 0);
                
            if (this.transform.localScale.y > 0.5f) {
                continue;
            }

            expand = true;
        }
    }
}
