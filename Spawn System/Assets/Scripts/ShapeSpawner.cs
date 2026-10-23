using UnityEngine;

public class ShapeSpawner : MonoBehaviour {
    [SerializeField] private MonoBehaviour cubeFactory;
    [SerializeField] private MonoBehaviour sphereFactory;

    private IFactory currentFactory;

    private void OnGUI() {
        if (GUILayout.Button("ChangeFactory")) {
            if (currentFactory == cubeFactory as IFactory) {
                currentFactory = sphereFactory as IFactory;
                
                Debug.Log("Swapping to " + currentFactory);
                return;
            }

            currentFactory = cubeFactory as IFactory;

            Debug.Log("Swapping to " + currentFactory);
        }

        if (currentFactory == null) {
            return;
        }
        
        if (GUILayout.Button("Spawn")) {
            int unit = Random.Range(0, 3);
            float x = Random.Range(-20, 20);
            float z = Random.Range(-20, 20);

            Vector3 position = new Vector3(x, 0, z);

            currentFactory.Spawn(unit, position);

            Debug.Log("Spawning object from " + currentFactory);
        }
    }
}
