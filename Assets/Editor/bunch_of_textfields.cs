using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor.UIElements;
using System;

public class bunch_of_textfields : EditorWindow
{
    [MenuItem("UIElements/bunch_of_textfields")]
    public static void ShowExample()
    {
        bunch_of_textfields wnd = GetWindow<bunch_of_textfields>();
        wnd.titleContent = new GUIContent("bunch_of_textfields");
    }

    public void OnEnable()
    {
        // Each editor window contains a root VisualElement object
        VisualElement root = rootVisualElement;

        // Import UXML
        var visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/Editor/bunch_of_textfields.uxml");
        var styleSheet = AssetDatabase.LoadAssetAtPath<StyleSheet>("Assets/Editor/bunch_of_textfields.uss");
        VisualElement labelFromUXML = visualTree.CloneTree();
        labelFromUXML.styleSheets.Add(styleSheet);
        root.Add(labelFromUXML);

        // adding queries

        // this only changes the first one
        labelFromUXML.Q<TextField>().value = "write hello world! here";
        var textFields = root.Query<TextField>();
        var textFieldList = textFields.ToList();

        foreach (var field in textFieldList)
            field.RegisterCallback<ChangeEvent<string>>(
                e => AnalyzeInput((e.target as TextField).value));
    }

    private void AnalyzeInput(string input)
    {
        if (input.Contains("hello world!")) Debug.Log("string match!");
    }
}