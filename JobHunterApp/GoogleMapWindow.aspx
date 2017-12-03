<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GoogleMapWindow.aspx.cs" Inherits="JobHunterApp.GoogleMapWindow" %>



<!DOCTYPE html>
<h2>Google Map Location</h2>
<html>
  <head>
    <title>Job Location</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0, user-scalable=no">
    <meta charset="utf-8">
    <style>
      /* Always set the map height explicitly to define the size of the div
       * element that contains the map. */
      #map {
        height: 100%;
      }
      /* Optional: Makes the sample page fill the window. */
      html, body {
        height: 100%; /*was 100%*/
        margin-left: 50px; /*margin: 0;*/
        margin-right: 50px;
        margin-top: 0px;
        margin-bottom: 80px;
        padding: 0;
      }
    </style>


  </head>

    
  <body>
      <!---TextBox Part------>
      <form runat ="server">
          Enter Latitude, Longitude:
          <asp:TextBox id="txt1" runat="server" />
          <asp:Button OnClick="Unnamed_Click1" Text="Submit" runat="server" />
          <p><asp:Label id="lbl1" runat="server" /></p>
<br /><br />

          </form>
  <script>
                    function getCoords(t1) {
                        var fullCoordinates = t1;
                        return fullCoordinates;
                    }
      </script>
      
    <div id="map"></div>
    <script>
        //Up there before script:
        //<div id ="map"></div>
        //EDIT 2:01 PM - parseFloat WORKS!
        //Declaring local map variables to be used
        var map;
        //var myLatlng = new google.maps.LatLng(parseFloat(co[0]), parseFloat(co[1]));

        //EDIT 3:32 PM - localStorage WORKS!
        //var locat = localStorage.getItem('zorg');

        


        //var locat = parseFloat(34.9956098333);
        //var locat;
        //var halfLocat = parseFloat(-81.9699969856);
        
        //locat = localStorage.getItem('zorg');

        //Array Creation
        var locations;

        var locatArray = [];

        //locations.push(localStorage.getItem('zorg'));

        //sessionStorage.setItem(locations, 'zorg');

        locations = sessionStorage.getItem('zorg');
        locatArray.push(locations);


        var xanax = getCoords;
        //THIS FINALLY WORKS - EDIT: 2:00 AM

        var loc = locatArray[0].split(",");
        //var lat = parseFloat(loc[0]);
        //var lng = parseFloat(-81.9699969856);
        //var lng = parseFloat(loc[1]);

        var lat = parseFloat(sessionStorage.getItem('latitude'));
        var lng = parseFloat(sessionStorage.getItem('longitude'));

        //var modLat = parseFloat(locations);
        //var modLng = parseFloat(-81.9699969856)

        var firsLoc;
        var secLat;

        //var dbLocat = parseFloat(locat);
        //sessionStorage.setItem(fullLocat, koop)
        //sessionStorage.setItem(locat, 34.9956098333)
        //sessionStorage.setItem(half, -81.9699969856)
        //var longit = new google.maps.LatLng(locat, halfLocat);
        //fullLocat = locat + "," + longit;

        function initMap() {
            map = new google.maps.Map(document.getElementById('map'), {
                zoom: 16,
                //34.9956098333, -81.9699969856)
                //new google.maps.Latlng(34.9956098333 , -81.9699969856)
                center: new google.maps.LatLng(lat,lng),
                mapTypeId: 'roadmap'
            });

            var iconBase = 'https://maps.google.com/mapfiles/kml/shapes/';
            var pushBase = 'http://maps.google.com/mapfiles/kml/pushpin/'
            var icons = {
                parking: {
                    icon: iconBase + 'parking_lot_maps.png'
                },
                library: {
                    icon: iconBase + 'library_maps.png'
                },
                info: {
                    icon: iconBase + 'info-i_maps.png'
                },
                actualLocal: {
                    icon: pushBase + 'pink-pushpin.png'
                }
            };

            var features = [
                {
                    position: new google.maps.LatLng(-33.91721, 151.22630),
                    type: 'info'
                }, {
                    position: new google.maps.LatLng(-33.91539, 151.22820),
                    type: 'info'
                }, {
                    position: new google.maps.LatLng(-33.91747, 151.22912),
                    type: 'info'
                }, {
                    position: new google.maps.LatLng(-33.91910, 151.22907),
                    type: 'info'
                }, {
                    position: new google.maps.LatLng(-33.91725, 151.23011),
                    type: 'info'
                }, {
                    position: new google.maps.LatLng(-33.91872, 151.23089),
                    type: 'info'
                }, {
                    position: new google.maps.LatLng(-33.91784, 151.23094),
                    type: 'info'
                }, {
                    position: new google.maps.LatLng(-33.91682, 151.23149),
                    type: 'info'
                }, {
                    position: new google.maps.LatLng(-33.91790, 151.23463),
                    type: 'info'
                }, {
                    position: new google.maps.LatLng(-33.91666, 151.23468),
                    type: 'info'
                }, {
                    position: new google.maps.LatLng(-33.916988, 151.233640),
                    type: 'info'
                }, {
                    position: new google.maps.LatLng(-33.91662347903106, 151.22879464019775),
                    type: 'parking'
                }, {
                    position: new google.maps.LatLng(-33.916365282092855, 151.22937399734496),
                    type: 'parking'
                }, {
                    position: new google.maps.LatLng(-33.91665018901448, 151.2282474695587),
                    type: 'parking'
                }, {
                    position: new google.maps.LatLng(-33.919543720969806, 151.23112279762267),
                    type: 'parking'
                }, {
                    position: new google.maps.LatLng(-33.91608037421864, 151.23288232673644),
                    type: 'parking'
                }, {
                    position: new google.maps.LatLng(-33.91851096391805, 151.2344058214569),
                    type: 'parking'
                }, {
                    position: new google.maps.LatLng(-33.91818154739766, 151.2346203981781),
                    type: 'parking'
                }, {
                    position: new google.maps.LatLng(-33.91727341958453, 151.23348314155578),
                    type: 'library'
                },
                {
                    //34.995,-81.969
                    position: new google.maps.LatLng(lat, lng),
                    type: 'actualLocal'
                }
            ];

            // Create markers.
            features.forEach(function (feature) {
                var marker = new google.maps.Marker({
                    position: feature.position,
                    icon: icons[feature.type].icon,
                    map: map
                });
            });
        }
        
    </script>
    <script async defer
    src="https://maps.googleapis.com/maps/api/js?key=AIzaSyAEZN5TwwiKsWxSdZ_idyIprTxtAcY_JSk
&callback=initMap">
    </script>
  </body>

</html>
<h3>
    <script type="text/javascript">
        document.write(lat)
      </script>
</h3>

