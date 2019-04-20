using UnityEditor;
using System.IO;

public class ExportAssetBundles
{
    static string getDirectory()
    {
        string assetBundleDirectory = EditorUtility.SaveFolderPanel("Choose a folder to export asset bundles", "", "");
        if (!Directory.Exists(assetBundleDirectory))
        {
            Directory.CreateDirectory(assetBundleDirectory);
        }
        return assetBundleDirectory;
    }

    [MenuItem("**Build AssetBundles**/Build ...")]
    static void BuildAllAssetBundlesWin()
    {
        BuildPipeline.BuildAssetBundles(getDirectory(), BuildAssetBundleOptions.None, EditorUserBuildSettings.activeBuildTarget);
    }
}