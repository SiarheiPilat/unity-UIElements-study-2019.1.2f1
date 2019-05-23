using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor.UIElements;
using System.IO;

public class random_buttons : EditorWindow
{
    static int random;
    static string path = "Assets/Editor/random_buttons.uxml";

    [MenuItem("UIElements/random_buttons")]
    public static void ShowExample()
    {
        random = Random.Range(0, 15);
        Change();
        random_buttons wnd = GetWindow<random_buttons>();
        wnd.titleContent = new GUIContent("random_buttons");
    }

    static void Change()
    {
        string text = File.ReadAllText(path);
        Debug.Log(text);
        text = text.Replace(@"<engine:Label text=""No buttons"" />", @"<engine:Label text=""Privet buttons"" />");
        File.WriteAllText(path, text);
    }

    public void OnEnable()
    {
        // Each editor window contains a root VisualElement object
        VisualElement root = rootVisualElement;

        // Import UXML
        var visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/Editor/random_buttons.uxml");
        var styleSheet = AssetDatabase.LoadAssetAtPath<StyleSheet>("Assets/Editor/random_buttons.uss");
        VisualElement labelFromUXML = visualTree.CloneTree();
        root.Add(labelFromUXML);
    }
}