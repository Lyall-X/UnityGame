using UnityEngine;
using Client.ObjectPool;
using Client.Utility;
using DG.Tweening;
using System;
using Client.UI;
using LuaInterface;

namespace Client.Manager 
{
    public class GameManager : BaseManager 
    {
        [NoToLua]
        public override void Initialize()
        {
            QualitySettings.vSyncCount = 2;

            //Screen.SetResolution(640, 1136, false);
            DOTween.Init(true, true, LogBehaviour.Default);
            Screen.sleepTimeout = SleepTimeout.NeverSleep;
            Util.SetDebugState(AppConst.LogMode);           //设置日志
            Application.targetFrameRate = AppConst.GameFrameRate;
            LoadingUI.Instance().Open(ResInitialize);      //创建LoadingUI
        }

        /// <summary>
        /// 释放资源
        /// </summary>
        public void ResInitialize() 
        {
            if (AppConst.DebugMode) 
            {
                LoadingUI.Instance().Close();
                OnResInitOK();
                return;
            }
            if (extractMgr.IsResNeedExtract()) 
            {
                //启动释放协成 
                StartCoroutine(extractMgr.OnResExtract(delegate
                {
                    StartCoroutine(updateMgr.OnResUpdate(OnResInitOK));
                }));    
            }
            else    
            {
                StartCoroutine(updateMgr.OnResUpdate(OnResInitOK));
            }
        }

        /// <summary>
        /// 资源初始化结束
        /// </summary>
        void OnResInitOK() 
        {
            LoadingUI.Instance().Close();
            resMgr.Initialize();
            resMgr.InitResManifest(AppConst.ResIndexFile, delegate() 
            {
                Debug.Log("Initialize OK!!!");
                this.OnInitializeOK();
            });
        }

        void OnInitializeOK() 
        {
            // 初始化网络,绑定c#和lua recive函数
            networkMgr.Initialize();
            //LUA管理器, Main.lua
            luaMgr.Initialize();

            //Tables文件夹, NpcTable与ObjectPoolTable 配置表
            tableMgr.Initialize();
            // Datas 文件夹
            configMgr.Initialize();
            // Fonts 文件夹
            fontMgr.LoadFonts();
            // Shaders 文件夹
            shaderMgr.LoadShaders();

            // Prefabs/Object 预制体
            objMgr.Initialize();
            // Prefabs/Bullet 预制体
            bulletMgr.Initialize();
            // Prefabs/Effect 预制体
            effectMgr.Initialize(); 

            // 定时器
            timerMgr.Initialize(); 
            //战斗事件与管理类添加
            battleViewMgr.Initialize();

            Util.CallLuaMethod("Initialize", (Action)delegate ()
            {
                TestObjectPool();   //测试对象池
                Util.CallLuaMethod("OnInitOK");  //初始化完成
            });
        }

        void TestObjectPool() 
        {
            //类对象池测试
            var classObjPool = objMgr.CreatePool<TestObjectClass>(OnPoolGetElement, OnPoolPushElement);
            //方法1
            //objPool.Release(new TestObjectClass("abcd", 100, 200f));
            //var testObj1 = objPool.Get();

            //方法2
            objMgr.Release<TestObjectClass>(new TestObjectClass("abcd", 100, 200f));
            var testObj1 = objMgr.Get<TestObjectClass>();

            Debug.Log("TestObjectClass--->>>" + testObj1.ToString());

            //游戏对象池测试
            var prefab = Resources.Load("Prefabs/TestGameObjectPrefab", typeof(GameObject)) as GameObject;
            var gameObjPool = objMgr.CreatePool("TestGameObject", 5, 10, prefab);

            var gameObj = Instantiate(prefab) as GameObject;
            gameObj.name = "TestGameObject_01";
            gameObj.transform.localScale = Vector3.one;
            gameObj.transform.localPosition = Vector3.zero;

            objMgr.Release(gameObj);
            var backObj = objMgr.Get("TestGameObject");
            backObj.transform.SetParent(null);

            Debug.Log("TestGameObject--->>>" + backObj);
        }

        /// <summary>
        /// 当从池子里面获取时
        /// </summary>
        /// <param name="obj"></param>
        void OnPoolGetElement(TestObjectClass obj) 
        {
            Debug.Log("OnPoolGetElement--->>>" + obj);
        }

        /// <summary>
        /// 当放回池子里面时
        /// </summary>
        /// <param name="obj"></param>
        void OnPoolPushElement(TestObjectClass obj) 
        {
            Debug.Log("OnPoolPushElement--->>>" + obj);
        }

        [NoToLua]
        public override void OnUpdate(float deltaTime)
        {
        }

        [NoToLua]
        public override void OnDispose()
        {
            if (networkMgr != null) {
                networkMgr.OnDispose();
            }
            if (luaMgr != null) {
                luaMgr.Close();
            }
            Debug.Log("~GameManager was destroyed");
        }
    }
}