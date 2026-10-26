using UnityEngine;
using System.Collections;

public class BlueCube : MonoBehaviour, ICube {
    public void Spin() {
        StartCoroutine(Movement());
    }

    private IEnumerator Movement() {
        float z = Random.Range(-0.5f, 0.5f);

        while (true) {
            this.transform.Rotate(0, 0, z);

            yield return null;
        }
    }
}
