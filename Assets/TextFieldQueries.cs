using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class TextFieldQueries : test0
{
    public override void DrawEditor()
    {
        for (int i = 0; i < 1; i++)
        {
            #region VisualElement
            VisualElement visualElement = new VisualElement();
            visualElement.name = "inline-csharp-visual-element";
            visualElement.style.marginTop = 6;
            visualElement.style.marginBottom = 3;
            visualElement.style.marginLeft = 6;
            visualElement.style.marginRight = 6;
            visualElement.style.flexDirection = FlexDirection.Row;
            visualElement.style.backgroundColor = Color.white;
            visualElement.style.color = Color.gray;
            #endregion

            #region TextField
            TextField textField = new TextField();
            textField.value = "Textfield value";
            textField.style.backgroundColor = Color.cyan;
            textField.style.fontSize = 15;
            textField.style.marginLeft = 3;
            textField.style.marginTop = 3;
            textField.style.marginBottom = 3;
            textField.style.marginRight = 3;
            textField.style.height = 25;
            textField.style.flexGrow = 1;
            visualElement.Add(textField);
            #endregion

            root.Add(visualElement);

            visualElement.Q<TextField>().value = "it should resize when typing and have mono color bg";
            var textFields = root.Query<TextField>();
            var textFieldList = textFields.ToList();

            //foreach (var field in textFieldList)
            //    field.RegisterCallback<ChangeEvent<string>>(
            //        e => AnalyzeInput((e.target as TextField).value));

            foreach (var field in textFieldList)
                field.RegisterCallback<ChangeEvent<string>>(
                    e => (e.target as TextField).style.width = 100);
        }
    }

    private void AnalyzeInput(string value)
    {
        Debug.Log(value);
    }

    [MenuItem("UIElements examples/TextFieldQueries")]
    public static void OpenWindow()
    {
        EditorWindow window = GetWindow<TextFieldQueries>("TextFieldQueries example");
        window.minSize = new Vector2(500, 250);
    }
}
