using System;
using System.Collections.Generic;
using uiwidgets;
using Unity.UIWidgets.gestures;
using Unity.UIWidgets.material;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.widgets;
using UnityEngine;

namespace HotFix_Project
{
    public class InstanceClass
    {
        private int id;

        public InstanceClass()
        {
            UnityEngine.Debug.Log("!!! InstanceClass::InstanceClass()");
            this.id = 0;
        }

        public InstanceClass(int id)
        {
            UnityEngine.Debug.Log("!!! InstanceClass::InstanceClass() id = " + id);
            this.id = id;
        }

        public int ID
        {
            get { return id; }
        }

        public static Widget GetContainer()
        {
            return new WidgetsApp(
                home: new Container(color: Colors.blue, width: 400, height: 400)
            );
        }

        public static Widget CreatePhotoHero(BuildContext context,string photo, GestureTapCallback onTap, float? width)
        {
            return new SizedBox(
              width: width,
              height: width,
              child: new Hero(
                tag: photo,
                child: new Unity.UIWidgets.material.Material(
                  color: Colors.transparent,
                  child: new InkWell(
                    onTap: onTap,
                    child: new Container(color: Colors.orange)
                  )
                )
              )
            );
        }

        public static Widget BuildWithContext(BuildContext context)
        {
             float timeDilation = 5.0f; // 1.0 means normal animation speed.
            Debug.Log("creaing context");
            return new Scaffold(
              appBar: new AppBar(
                title: new Text("Basic Hero Animation")
              ),
              body: new Center(
                child: CreatePhotoHero(
                    context,
                  photo: "images/flippers-alpha.png",
                  width: 200.0f,
                  onTap: () =>
                  {
                      Debug.Log($"this is in on tap, {context}");
                      Navigator.of(context).push(new MaterialPageRoute(
                        builder: (BuildContext contextx) =>
                        {
                            Debug.Log("this is in builder");
                            return new Scaffold(
                            appBar: new AppBar(
                              title: new Text("Flippers Page")
                            ),
                            body: new Container(
                              // The blue background emphasizes that it's a new route.
                              color: Colors.lightBlueAccent,
                              padding: EdgeInsets.all(16.0f),
                              alignment: Alignment.topLeft,
                              child: CreatePhotoHero(
                                  contextx,
                                photo: "images/flippers-alpha.png",
                                width: 100.0f,
                                onTap: () =>
                                {
                                    Debug.Log("this is in hero click");

                                    Navigator.of(contextx).pop<object>();
                                }
                              )
                            )
                          );
                        }
                      )
                          );
                  }
                )
              )
            );
        }

        // static method
        public static void StaticFunTest()
        {
            UnityEngine.Debug.Log("!!! InstanceClass.StaticFunTest()");
        }

        public static void StaticFunTest2(int a)
        {
            UnityEngine.Debug.Log("!!! InstanceClass.StaticFunTest2(), a=" + a);
        }

        public static void GenericMethod<T>(T a)
        {
            UnityEngine.Debug.Log("!!! InstanceClass.GenericMethod(), a=" + a);
        }

        public void RefOutMethod(int addition, out List<int> lst, ref int val)
        {
            val = val + addition + id;
            lst = new List<int>();
            lst.Add(id);
        }
    }


}
