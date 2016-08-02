using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Gms.Maps;
using Android.Gms.Maps.Model;
using Android.Locations;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Android.Graphics.Drawables;

namespace Day16Maps
{
    [Activity(Label = "Day16Maps", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity,  IOnMapReadyCallback
    {
        private GoogleMap mMap;
        int count = 1;
        bool addmarker = false;
        Button AddMarker;
        TextView longitude;
        TextView latitude;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
            SetUpMap();
            AddMarker = FindViewById<Button>(Resource.Id.button1);
            longitude = FindViewById<TextView>(Resource.Id.textView1);
            latitude = FindViewById<TextView>(Resource.Id.textView2);
            AddMarker.Click += delegate
            {
                addmarker = true;
                AddMarker.Enabled = false;
            };
        }

        public void OnMapReady(GoogleMap googleMap)
        {
            
            mMap = googleMap;
            mMap.MyLocationEnabled = true;
            mMap.MyLocationChange += (s, e) =>
            {
                var MyLocation = e.Location;
                LatLng latlng = new LatLng(MyLocation.Latitude, MyLocation.Longitude);
                CameraUpdate camera = CameraUpdateFactory.NewLatLngZoom(latlng, 15);
                mMap.MoveCamera(camera);
                MarkerOptions options = new MarkerOptions()
                    .SetPosition(latlng)
                    .SetTitle("MyHome")
                    .Draggable(true);
             
                mMap.AddMarker(options);
            };
            mMap.MapClick += MMap_MapClick;
        }

        private void MMap_MapClick(object sender, GoogleMap.MapClickEventArgs e)
        {
            if(addmarker)
            {
                LatLng latlng = new LatLng(e.Point.Latitude, e.Point.Longitude);
                MarkerOptions options = new MarkerOptions()
                    .SetPosition(latlng)
                    .SetTitle("Marker" + count)
                    .Draggable(true);
                mMap.AddMarker(options);
                latitude.Text = e.Point.Latitude.ToString();
                longitude.Text = e.Point.Longitude.ToString();
                count++;
                addmarker = false;
                AddMarker.Enabled = true;
            }  
        }

        public void SetUpMap()
        {
            if(mMap==null)
            {
                FragmentManager.FindFragmentById<MapFragment>(Resource.Id.map).GetMapAsync(this);
            }
        }

        //public void InitocationManager()
        //{
        //    locationManager = (LocationManager)(Application.Context.ApplicationContext).GetSystemService(LocationService);
        //    Criteria criteria = new Criteria { Accuracy = Accuracy.Fine };
        //    IList<string> acceptableLocationProviders = locationManager.GetProviders(criteria, true);
        //    if(acceptableLocationProviders.Any())
        //    {
        //        locationProvider = acceptableLocationProviders.First();
        //    }
        //    else
        //    {
        //        locationProvider = string.Empty;
        //    }
        //    OnLocationChanged(locationManager.GetLastKnownLocation(locationProvider));
        //}

        //public void OnLocationChanged(Location location)
        //{
        //    currentLocation = location;
        //}

        //public void OnProviderDisabled(string provider)
        //{
        //    throw new NotImplementedException();
        //}

        //public void OnProviderEnabled(string provider)
        //{
        //    throw new NotImplementedException();
        //}

        //public void OnStatusChanged(string provider, [GeneratedEnum] Availability status, Bundle extras)
        //{
        //    throw new NotImplementedException();
        //}
    }
}

