using UnityEngine;
using System.IO;

public class WorldSpawner {
    [RuntimeInitializeOnLoadMethod]
    static void OnRuntimeMethodLoad() {
        // 1. Create a Camera so we can see
        GameObject camObj = new GameObject("Main Camera");
        Camera cam = camObj.AddComponent<Camera>();
        camObj.transform.position = new Vector3(0, 5, -10);
        camObj.transform.LookAt(Vector3.zero);
        camObj.tag = "MainCamera";

        // 2. Create a Light so it's not pitch black
        GameObject lightObj = new GameObject("Sun");
        Light light = lightObj.AddComponent<Light>();
        light.type = LightType.Directional;
        lightObj.transform.rotation = Quaternion.Euler(50, -30, 0);

        // 3. Load your Room
        // Note: Loading a GLB at runtime usually requires a package (like glTFast).
        // Since we can't install packages easily, we'll spawn a "Placeholder" 
        // to prove the build works, then I'll show you how to link the GLB.
        GameObject floor = GameObject.CreatePrimitive(PrimitiveType.Plane);
        floor.transform.localScale = new Vector3(5, 1, 5);
        
        Debug.Log("World Spawned Successfully!");
    }
}

