using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

namespace QuickMenu
{
    public class MenuItem_SceneDiscardChanges : MenuItem
    {
        public override int priority => 1;

        public override string category => "Scene";

        public override string title => "Discard Changes";

        public override bool Validation(Context context)
        {
            return context.scene.name is not null;
        }

        public override bool Command(Context context)
        {
            if (SceneManager.sceneCount == 1)
            {
                EditorSceneManager.OpenScene(context.scene.path);
                return true;
            }

            var path = context.scene.path;
            EditorSceneManager.CloseScene(context.scene, true);
            EditorSceneManager.OpenScene(path, OpenSceneMode.Additive);
            return true;
        }
    }
}