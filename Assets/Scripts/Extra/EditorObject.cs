using UnityEditor;
using UnityEngine;
using Utils;

public class EditorObject : EditorWindow
{
    private GameObject obj;
    [SerializeField] private GameObject parent;

    [MenuItem("Tools/EditorObject")]
    public static void StartWindow()
    {
        EditorObject e = GetWindow<EditorObject>();
        e.minSize = new Vector2(400, 200);
        e.Show();
    }

    private void OnGUI()
    {
        EditorGUILayout.Space(10);
        EditorGUILayout.LabelField("Editor Object:", EditorStyles.boldLabel);
        EditorGUILayout.Space(5);

        if (GUILayout.Button("Hello World Button")) { Debug.Log(ExtraUtils.HelloWorld()); }
        
        EditorGUILayout.Space(10);
        EditorGUILayout.LabelField("Spawn object:", EditorStyles.boldLabel);
        obj = (GameObject)EditorGUILayout.ObjectField(obj, typeof(GameObject), false);
        if (GUILayout.Button("Create Object in Scene")) { Instantiate(obj, Vector3.zero, Quaternion.identity); }
    }
}