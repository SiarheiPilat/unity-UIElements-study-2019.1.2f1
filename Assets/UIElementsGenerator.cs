using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using System;
using System.Text;

public class UIElementsGenerator : EditorWindow
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

    int howManyButtons;

    [MenuItem("UIElements/UI Generator")]
	public static void Init()
	{
	    GetWindow<UIElementsGenerator>().Show();
	}
	
	public void OnGUI()
	{
        howManyButtons = EditorGUILayout.IntField(howManyButtons);

        inputFileName = EditorGUILayout.TextField(inputFileName);

		if(GUILayout.Button("Generate UI for " + inputFileName))
		{
			GenerateFromTemplate(inputFileName);
		}
		
	}

	void GenerateFromTemplate(string newName)
	{

        destination1 = "Assets/Editor/Generated/" + newName + ".cs";
        destination2 = "Assets/Editor/Generated/" + newName + ".uss";
        destination3 = "Assets/Editor/Generated/" + newName + ".uxml";

        visualContent = "";
        for (int i = 0; i < howManyButtons; i++)
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

        // Create a new file     
        using (StreamWriter sw = File.CreateText(destination3))
        {
            sw.Write(uxmlContent);
        }
        AssetDatabase.Refresh();

        //File.Copy(template3, destination3);
        //File.WriteAllText(destination3, File.ReadAllText(destination3).Replace(@"<engine:Label text=""Hello World!From UXML"" />", visualContent));
    }
	
	
	
}
