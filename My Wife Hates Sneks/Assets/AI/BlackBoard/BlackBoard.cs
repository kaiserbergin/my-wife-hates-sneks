using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.AI.Blackboard
{
    public class BlackBoard
    {
        private static readonly Lazy<BlackBoard> lazy = new Lazy<BlackBoard>(() => new BlackBoard());

        public static BlackBoard Instance { get { return lazy.Value; } }

        private BlackBoard()
        {
            Objects = new Dictionary<string, object>();
            GameObjects = new Dictionary<string, GameObject>();
            Transforms = new Dictionary<string, Transform>();
            Vectors = new Dictionary<string, Vector3>();
            ScriptableObjects = new Dictionary<string, ScriptableObject>();

            Strings = new Dictionary<string, string>();
            Floats = new Dictionary<string, float>();
            Ints = new Dictionary<string, int>();
            Bools = new Dictionary<string, bool>();

            ObjectLists = new Dictionary<string, List<object>>();
            GameObjectLists = new Dictionary<string, List<GameObject>>();
            TransformLists = new Dictionary<string, List<Transform>>();
            VectorLists = new Dictionary<string, List<Vector3>>();
            ScriptableObjectLists = new Dictionary<string, List<ScriptableObject>>();

            StringLists = new Dictionary<string, List<string>>();
            FloatLists = new Dictionary<string, List<float>>();
            IntLists = new Dictionary<string, List<int>>();
            BoolLists = new Dictionary<string, List<bool>>();
        }

        public void ClearBlackBoard()
        {
            Objects.Clear();
            GameObjects.Clear();
            Transforms.Clear();
            Vectors.Clear();
            ScriptableObjects.Clear();

            Strings.Clear();
            Floats.Clear();
            Ints.Clear();
            Bools.Clear();

            ObjectLists.Clear();
            GameObjectLists.Clear();
            TransformLists.Clear();
            VectorLists.Clear();
            ScriptableObjectLists.Clear();

            StringLists.Clear();
            FloatLists.Clear();
            IntLists.Clear();
            BoolLists.Clear();
        }

        // Single Items
        public Dictionary<string, object> Objects;
        public Dictionary<string, GameObject> GameObjects;
        public Dictionary<string, Transform> Transforms;
        public Dictionary<string, Vector3> Vectors;
        public Dictionary<string, ScriptableObject> ScriptableObjects;

        public Dictionary<string, string> Strings;
        public Dictionary<string, float> Floats;
        public Dictionary<string, int> Ints;
        public Dictionary<string, bool> Bools;

        // Item Lists
        public Dictionary<string, List<object>> ObjectLists;
        public Dictionary<string, List<GameObject>> GameObjectLists;
        public Dictionary<string, List<Transform>> TransformLists;
        public Dictionary<string, List<Vector3>> VectorLists;
        public Dictionary<string, List<ScriptableObject>> ScriptableObjectLists;

        public Dictionary<string, List<string>> StringLists;
        public Dictionary<string, List<float>> FloatLists;
        public Dictionary<string, List<int>> IntLists;
        public Dictionary<string, List<bool>> BoolLists;

        
    }
}
