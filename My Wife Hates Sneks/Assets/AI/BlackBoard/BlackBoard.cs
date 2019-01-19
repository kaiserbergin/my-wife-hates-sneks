using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackBoard : MonoBehaviour
{
    public static BlackBoard instance = null;

    private void Awake()
    {
        if (instance == null) instance = this;
        else if (instance != null) Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }

    // Single Items
    public Dictionary<string, object> Objects = new Dictionary<string, object>();
    public Dictionary<string, GameObject> GameObjects = new Dictionary<string, GameObject>();    
    public Dictionary<string, Transform> Transforms = new Dictionary<string, Transform>();
    public Dictionary<string, Vector3> Vectors = new Dictionary<string, Vector3>();
    public Dictionary<string, ScriptableObject> ScriptableObjects = new Dictionary<string, ScriptableObject>();

    public Dictionary<string, string> Strings = new Dictionary<string, string>();
    public Dictionary<string, float> Floats = new Dictionary<string, float>();
    public Dictionary<string, int> Ints = new Dictionary<string, int>();
    public Dictionary<string, bool> Bools = new Dictionary<string, bool>();

    // Item Lists
    public Dictionary<string, List<object>> ObjectLists = new Dictionary<string, List<object>>();
    public Dictionary<string, List<GameObject>> GameObjectLists = new Dictionary<string, List<GameObject>>();
    public Dictionary<string, List<Transform>> TransformLists = new Dictionary<string, List<Transform>>();
    public Dictionary<string, List<Vector3>> VectorLists = new Dictionary<string, List<Vector3>>();
    public Dictionary<string, List<ScriptableObject>> ScriptableObjectLists = new Dictionary<string, List<ScriptableObject>>();

    public Dictionary<string, List<string>> StringLists = new Dictionary<string, List<string>>();
    public Dictionary<string, List<float>> FloatLists = new Dictionary<string, List<float>>();
    public Dictionary<string, List<int>> IntLists = new Dictionary<string, List<int>>();
    public Dictionary<string, List<bool>> BoolLists = new Dictionary<string, List<bool>>();
}
