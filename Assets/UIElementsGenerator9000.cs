using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using System;
using System.Text;

public class UIElementsGenerator9000 : EditorWindow
{
    string template1 = "Assets/Editor/Templates/template.cs";
    string template2 = "Assets/Editor/Templates/template.uss";
    string template3 = "Assets/Editor/Templates/template.uxml";
    string destination1 = "Assets/Editor/Generated/newgenerated.cs";
    string destination2 = "Assets/Editor/Generated/newgenerated.uss";
    string destination3 = "Assets/Editor/Generated/newgenerated.uxml";

    string uxmlContent;
    string visualElement = @"<engine:Button name=""button"" text=""Button"" />";
    string visualContent;

    string inputFileName = "Enter file name";

    [MenuItem("UIElements/UI Generator 9000 Buttons")]
    public static void Init()
    {
        GetWindow<UIElementsGenerator9000>().Show();
    }

    public void OnGUI()
    {
        inputFileName = EditorGUILayout.TextField(inputFileName);
        if (GUILayout.Button("Generate 9000 buttons UI lol"))
        {
            GenerateFromTemplate(inputFileName);
        }
        EditorGUILayout.LabelField("It make take a few seconds");
    }

    void GenerateFromTemplate(string newName)
    {

        destination1 = "Assets/Editor/Generated/" + newName + ".cs";
        destination2 = "Assets/Editor/Generated/" + newName + ".uss";
        destination3 = "Assets/Editor/Generated/" + newName + ".uxml";

        visualContent = "";
        for (int i = 0; i < 9000; i++)
        {
            visualContent += visualElement + "\n";
        }

        File.Copy(template1, destination1);
        File.WriteAllText(destination1, File.ReadAllText(destination1).Replace("template : EditorWindow", newName + " : EditorWindow").Replace(@"[MenuItem(""Window/UIElements/template"")]", @"[MenuItem(""UIElements/" + newName + @""")]").Replace(@"template wnd = GetWindow<template>();", newName + @" wnd = GetWindow<" + newName + @"> ();").Replace("Templates/template.uxml", "Generated/" + newName + ".uxml").Replace(@"wnd.titleContent = new GUIContent(""template"");", @"wnd.titleContent = new GUIContent(""" + newName + @""");"));

        File.Copy(template2, destination2);

        uxmlContent = File.ReadAllText(template3);
        uxmlContent = uxmlContent.Replace(@"<engine:Label text=""Hello World! From UXML"" />",
            @"<engine:ScrollView>" +
            visualContent + @"</engine:ScrollView>");

        using (StreamWriter sw = File.CreateText(destination3))
        {
            sw.Write(uxmlContent);
        }
        AssetDatabase.Refresh();
    }
}
