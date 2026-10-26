using UnityEngine;

public class ShapeSpawner : MonoBehaviour {
    [SerializeField] private GreenFactory greenFactory;
    [SerializeField] private RedFactory redFactory;
    [SerializeField] private BlueFactory blueFactory;

    private IFactory currentFactory;

    private void OnGUI() {
        if (GUILayout.Button("Red Factory")) {
            currentFactory = redFactory;
        }
        if (GUILayout.Button("Blue Factory")) {
            currentFactory = blueFactory;
        }
        if (GUILayout.Button("Green Factory")) {
            currentFactory = greenFactory;
        }

        
        if (GUILayout.Button("Spawn")) {
            if (currentFactory == null) {
                return;
            }

            GameObject sphere = currentFactory.SpawnSphere();
            GameObject cube = currentFactory.SpawnCube();
            GameObject cylinder = currentFactory.SpawnCylinder();

            sphere.transform.parent = this.transform;
            cube.transform.parent = this.transform;
            cylinder.transform.parent = this.transform;

            sphere.transform.position = GetRandomPos();
            cube.transform.position = GetRandomPos();
            cylinder.transform.position = GetRandomPos();

            sphere.GetComponent<ISphere>().Expand();
            cube.GetComponent<ICube>().Spin();
            cylinder.GetComponent<ICylinder>().Move();

            Debug.Log("Spawning object from " + currentFactory);
        }

        if (GUILayout.Button("Reset")) {
            for (int i = transform.childCount - 1; i >= 0; i--) {
                Destroy(transform.GetChild(i).gameObject);
            }
        }
    }

    private Vector3 GetRandomPos() {
        int unit = Random.Range(0, 3);
        float x = Random.Range(-20, 20);
        float z = Random.Range(-20, 20);

        Vector3 position = new Vector3(x, 0, z);

        return position;
    }
}
