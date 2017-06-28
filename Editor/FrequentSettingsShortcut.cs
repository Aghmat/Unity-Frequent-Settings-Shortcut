using UnityEditor;

/** Author: Aghmat Abrahams
 *  Unity Version: 5.6.1
 *  IDE: Visual Studio Community 2017
 *  Date: June 2017
 *  Instructions: This script will either display project settings under 
 *                a new Project Settings menu item. 
 *                Comment out the "Split settings" region for a single menu item.
 *                Comment out "Unified Settings" region for grouped items.
 *                
 **/

public class FrequentSettingsShortcut : EditorWindow
{
    #region Unified Settings
    [MenuItem("Project Settings/Input")]
    private static void Input()
    {
        EditorApplication.ExecuteMenuItem("Edit/Project Settings/Input");
    }

    [MenuItem("Project Settings/Tags and Layers")]
    private static void TaL()
    {
        EditorApplication.ExecuteMenuItem("Edit/Project Settings/Tags and Layers");
    }

    [MenuItem("Project Settings/Audio")]
    private static void Audio()
    {
        EditorApplication.ExecuteMenuItem("Edit/Project Settings/Audio");
    }

    [MenuItem("Project Settings/Time")]
    private static void Time()
    {
        EditorApplication.ExecuteMenuItem("Edit/Project Settings/Time");
    }

    [MenuItem("Project Settings/Player")]
    private static void Player()
    {
        EditorApplication.ExecuteMenuItem("Edit/Project Settings/Player");
    }

    [MenuItem("Project Settings/Physics")]
    private static void Physics()
    {
        EditorApplication.ExecuteMenuItem("Edit/Project Settings/Physics");
    }

    [MenuItem("Project Settings/Physics 2D")]
    private static void Physics2D()
    {
        EditorApplication.ExecuteMenuItem("Edit/Project Settings/Physics 2D");
    }

    [MenuItem("Project Settings/Quality")]
    private static void Quality()
    {
        EditorApplication.ExecuteMenuItem("Edit/Project Settings/Quality");
    }

    [MenuItem("Project Settings/Graphics")]
    private static void Graphics()
    {
        EditorApplication.ExecuteMenuItem("Edit/Project Settings/Graphics");
    }

    [MenuItem("Project Settings/Network")]
    private static void Network()
    {
        EditorApplication.ExecuteMenuItem("Edit/Project Settings/Network");
    }

    [MenuItem("Project Settings/Editor")]
    private static void Editor()
    {
        EditorApplication.ExecuteMenuItem("Edit/Project Settings/Editor");
    }

    [MenuItem("Project Settings/Script Execution Order")]
    private static void SeO()
    {
        EditorApplication.ExecuteMenuItem("Edit/Project Settings/Script Execution Order");
    }
    #endregion
}
