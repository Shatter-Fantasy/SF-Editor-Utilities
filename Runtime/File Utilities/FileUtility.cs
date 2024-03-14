using System.IO;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

namespace SF.UICreator
{
    public static class FileUtility
    {
        private static string DataPath => Application.dataPath;

#if UNITY_EDITOR
        /// <summary>
        /// Creates a folder and any needed sub folders using the Assets directory as the root to place the folders in.
        /// </summary>
        /// <param name="folderPath"></param>
        public static void CreateFolderPath(string folderPath)
        {
            if(folderPath.StartsWith("/"))
                folderPath.Remove(0, 1);

            Directory.CreateDirectory(DataPath + "/" + folderPath);
            AssetDatabase.Refresh();
        }
#endif

        public static bool IsFolderPathValid(string folderPath)
        {
           return Directory.Exists(DataPath + "/" + folderPath);
        }

    }
}
