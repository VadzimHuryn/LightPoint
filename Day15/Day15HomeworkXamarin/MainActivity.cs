using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections;
using System.Collections.Generic;

namespace Day15HomeworkXamarin
{
    [Activity(Label = "Day15HomeworkXamarin", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;
        public List<View> controls = new List<View>();

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
       

            SetContentView(Resource.Layout.Main);

            LinearLayout linear = FindViewById<LinearLayout>(Resource.Id.linear);
            LinearLayout layout1 = FindViewById<LinearLayout>(Resource.Id.layout1);


            Button buttonAdd = FindViewById<Button>(Resource.Id.button2);
            Button buttonDelete = FindViewById<Button>(Resource.Id.button1);




            Button button1 = FindViewById<Button>(Resource.Id.MyButton);

            button1.Click += delegate { button1.Text = string.Format("{0} clicks!", count++); };
            buttonAdd.Click += delegate
            {
                Button newbtn = new Button(this)
                {
                    Text = "Button" + count,
                    Id = count
                };
                layout1.AddView(newbtn);
                controls.Add(newbtn);
                count++;
            };

            buttonDelete.Click += delegate
            {
                if (controls.Count > 0)
                {
                    layout1.RemoveView(controls[controls.Count - 1]);
                    controls.RemoveAt(controls.Count - 1);
                }
            };
        }

        protected override void OnSaveInstanceState(Bundle bundle)
        {
            StackControl.controls = controls;
            StackControl.count = count;
        }

        protected override void OnRestoreInstanceState(Bundle bundle)
        {
            controls = StackControl.controls;
            count = StackControl.count;
            LinearLayout layout1 = FindViewById<LinearLayout>(Resource.Id.layout1);
            foreach (var element in controls)
            {
                ((LinearLayout)element.Parent).RemoveView(element);
                layout1.AddView(element);
            }
        }
    }
}

