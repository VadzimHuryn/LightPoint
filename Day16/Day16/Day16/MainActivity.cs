using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections;
using System.Collections.Generic;

namespace Day16
{
    [Activity(Label = "Day16", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 0;
        public IList<string> items = new List<string>();
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
            ListView list = FindViewById<ListView>(Resource.Id.listView1);
            Button buttonAdd = FindViewById<Button>(Resource.Id.button1);
            Button buttonDel = FindViewById<Button>(Resource.Id.button2);
            buttonAdd.Click += delegate
            {
                items.Add("Button " + count++);
                list.Adapter = new MyAdapter(this, items);
            };
            buttonDel.Click += delegate
            {
                if(items.Count >0 )
                {
                    items.RemoveAt(items.Count - 1);
                    list.Adapter = new MyAdapter(this, items);
                }
            };
        }
        protected override void OnSaveInstanceState(Bundle bundle)
        {
            bundle.PutStringArrayList("items", items);
            bundle.PutInt("count", count);
        }

        protected override void OnRestoreInstanceState(Bundle bundle)
        {
            this.items = bundle.GetStringArrayList("items");
            this.count = bundle.GetInt("count");
            ListView list = FindViewById<ListView>(Resource.Id.listView1);
            list.Adapter = new MyAdapter(this, items);
        }

    }
}

